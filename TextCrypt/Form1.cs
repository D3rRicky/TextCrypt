using System.Text;

namespace TextCrypt
{
    public partial class Form1 : Form
    {
        Crypt crypt;
        public Form1()
        {
            InitializeComponent();
            crypt = new Crypt();
        }

        private void BtnEncryptInput_Click(object sender, EventArgs e)
        {
            string input = RtbInput.Text;
            if (input != String.Empty)
            {
                byte[] byteArray = crypt.EncryptText(input);
                RtbOutput.Text = Convert.ToBase64String(byteArray, 0, byteArray.Length);
            }
            else
            {
                MessageBox.Show("You need to type in something to encrypt!", "Warning");
            }
        }

        private void BtnDecryptInput_Click(object sender, EventArgs e)
        {
            string input = RtbInput.Text;
            if (input != String.Empty)
            {
                RtbOutput.Text = crypt.DecryptText(Convert.FromBase64String(input));
            }
            else
            { 
                MessageBox.Show("You need to type something encrypted to decrypt it!", "Warning");
            }
        }

        private void BtnSaveAs_Click(object sender, EventArgs e)
        {
            if (RtbOutput.Text != String.Empty)
            {
                using (SaveFileDialog ofd = new SaveFileDialog())
                {
                    ofd.InitialDirectory = "C:\\Benutzer\\" + Environment.UserName + "\\Dokumente\\";
                    ofd.Filter = "Text Files (*.txt)| *.txt";
                    ofd.FilterIndex = 0;
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        TxtKeyChainFilePath.Text = ofd.FileName;
                        //Save Output to choosen Filelocation
                    }
                }
            }
            else
            {
                MessageBox.Show("Really wanna save an empty file?", "Information");
            }
        }
    }
}