using System.Security.Cryptography;
using System.Text;

namespace TextCrypt
{
    internal class Crypt
    {
        private byte[] keyBytes;
        private byte[] ivBytes;
        private Aes aes;

        public Crypt()
        {
            if (!File.Exists("C:\\" + Environment.UserName + "\\Dokumente\\KeyChain.xml"))
            {
                aes = Aes.Create();
                aes.GenerateKey();
                aes.GenerateIV();
                keyBytes = aes.Key;
                ivBytes = aes.IV;
                //Key und IV Bytes in XML Datei speichern
            }
            else
            { 
                //lade Schlüssel aus Datei
            }
        }

        public byte[] EncryptText(string input)
        {
            byte[] encryptedText;
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(ms, aes.CreateEncryptor(keyBytes, ivBytes), CryptoStreamMode.Write))
                {
                    using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                    {
                        streamWriter.Write(input);
                        streamWriter.Flush();
                    }
                    encryptedText = ms.ToArray();
                }
            }
            return encryptedText;
        }

        public byte[] DecryptText(string input)
        {
            byte[] plainText = { };
            using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(input)))
            {
                using (CryptoStream cryptoStream = new CryptoStream(ms, aes.CreateDecryptor(keyBytes, ivBytes), CryptoStreamMode.Read))
                {
                    using (StreamReader streamReader = new StreamReader(cryptoStream))
                    {
                        string temp = streamReader.ReadToEnd();
                        plainText = Encoding.Unicode.GetBytes(temp);
                    }
                }
            }
            return plainText;
        }

        public void CreateCryptKeys()
        {
            string fileContent = String.Empty;
            try
            {
                using (FileStream fileStream = new FileStream("C:\\temp.txt", FileMode.OpenOrCreate))
                {
                    using (Aes aes = Aes.Create())
                    {
                        byte[] key =
                        {
                            0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                            0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
                        };
                        aes.Key = key;

                        byte[] iv = aes.IV;
                        fileStream.Write(iv, 0, iv.Length);

                        using (CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            using (StreamWriter encryptWriter = new StreamWriter(cryptoStream))
                            {
                                encryptWriter.WriteLine("This is a Test!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
