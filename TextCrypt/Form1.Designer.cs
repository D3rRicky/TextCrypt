namespace TextCrypt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnEncryptInput = new System.Windows.Forms.Button();
            this.BtnDecryptInput = new System.Windows.Forms.Button();
            this.TxtKeyChainFilePath = new System.Windows.Forms.TextBox();
            this.BtnSaveAs = new System.Windows.Forms.Button();
            this.LblKeyChane = new System.Windows.Forms.Label();
            this.RtbInput = new System.Windows.Forms.TextBox();
            this.RtbOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnEncryptInput
            // 
            this.BtnEncryptInput.Location = new System.Drawing.Point(12, 189);
            this.BtnEncryptInput.Name = "BtnEncryptInput";
            this.BtnEncryptInput.Size = new System.Drawing.Size(116, 23);
            this.BtnEncryptInput.TabIndex = 1;
            this.BtnEncryptInput.Text = "Verschlüsseln";
            this.BtnEncryptInput.UseVisualStyleBackColor = true;
            this.BtnEncryptInput.Click += new System.EventHandler(this.BtnEncryptInput_Click);
            // 
            // BtnDecryptInput
            // 
            this.BtnDecryptInput.Location = new System.Drawing.Point(685, 189);
            this.BtnDecryptInput.Name = "BtnDecryptInput";
            this.BtnDecryptInput.Size = new System.Drawing.Size(103, 23);
            this.BtnDecryptInput.TabIndex = 2;
            this.BtnDecryptInput.Text = "Entschlüsseln";
            this.BtnDecryptInput.UseVisualStyleBackColor = true;
            this.BtnDecryptInput.Click += new System.EventHandler(this.BtnDecryptInput_Click);
            // 
            // TxtKeyChainFilePath
            // 
            this.TxtKeyChainFilePath.Location = new System.Drawing.Point(121, 413);
            this.TxtKeyChainFilePath.Name = "TxtKeyChainFilePath";
            this.TxtKeyChainFilePath.ReadOnly = true;
            this.TxtKeyChainFilePath.Size = new System.Drawing.Size(558, 23);
            this.TxtKeyChainFilePath.TabIndex = 4;
            // 
            // BtnSaveAs
            // 
            this.BtnSaveAs.Location = new System.Drawing.Point(685, 413);
            this.BtnSaveAs.Name = "BtnSaveAs";
            this.BtnSaveAs.Size = new System.Drawing.Size(101, 23);
            this.BtnSaveAs.TabIndex = 5;
            this.BtnSaveAs.Text = "Speichern unter";
            this.BtnSaveAs.UseVisualStyleBackColor = true;
            this.BtnSaveAs.Click += new System.EventHandler(this.BtnSaveAs_Click);
            // 
            // LblKeyChane
            // 
            this.LblKeyChane.AutoSize = true;
            this.LblKeyChane.Location = new System.Drawing.Point(12, 416);
            this.LblKeyChane.Name = "LblKeyChane";
            this.LblKeyChane.Size = new System.Drawing.Size(103, 15);
            this.LblKeyChane.TabIndex = 6;
            this.LblKeyChane.Text = "Output Speichern:";
            // 
            // RtbInput
            // 
            this.RtbInput.Location = new System.Drawing.Point(11, 11);
            this.RtbInput.Multiline = true;
            this.RtbInput.Name = "RtbInput";
            this.RtbInput.Size = new System.Drawing.Size(777, 172);
            this.RtbInput.TabIndex = 7;
            // 
            // RtbOutput
            // 
            this.RtbOutput.Location = new System.Drawing.Point(12, 218);
            this.RtbOutput.Multiline = true;
            this.RtbOutput.Name = "RtbOutput";
            this.RtbOutput.Size = new System.Drawing.Size(776, 189);
            this.RtbOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RtbOutput);
            this.Controls.Add(this.RtbInput);
            this.Controls.Add(this.LblKeyChane);
            this.Controls.Add(this.BtnSaveAs);
            this.Controls.Add(this.TxtKeyChainFilePath);
            this.Controls.Add(this.BtnDecryptInput);
            this.Controls.Add(this.BtnEncryptInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BtnEncryptInput;
        private Button BtnDecryptInput;
        private TextBox TxtKeyChainFilePath;
        private Button BtnSaveAs;
        private Label LblKeyChane;
        private TextBox RtbInput;
        private TextBox RtbOutput;
    }
}