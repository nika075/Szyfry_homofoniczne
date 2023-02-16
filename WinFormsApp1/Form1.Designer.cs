namespace WinFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lVersion = new System.Windows.Forms.Label();
            this.cbVersion = new System.Windows.Forms.ComboBox();
            this.tbDecryptedMessage = new System.Windows.Forms.TextBox();
            this.lDecryptedMessage = new System.Windows.Forms.Label();
            this.bDecrypt = new System.Windows.Forms.Button();
            this.tbEncryptedMessage = new System.Windows.Forms.TextBox();
            this.lEncryptedMessage = new System.Windows.Forms.Label();
            this.bEncrypt = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lVersion);
            this.panel1.Controls.Add(this.cbVersion);
            this.panel1.Controls.Add(this.tbDecryptedMessage);
            this.panel1.Controls.Add(this.lDecryptedMessage);
            this.panel1.Controls.Add(this.bDecrypt);
            this.panel1.Controls.Add(this.tbEncryptedMessage);
            this.panel1.Controls.Add(this.lEncryptedMessage);
            this.panel1.Controls.Add(this.bEncrypt);
            this.panel1.Controls.Add(this.tbMessage);
            this.panel1.Controls.Add(this.lMessage);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 449);
            this.panel1.TabIndex = 0;
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.Location = new System.Drawing.Point(12, 291);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(112, 20);
            this.lVersion.TabIndex = 17;
            this.lVersion.Text = "Wybierz wersję:";
            // 
            // cbVersion
            // 
            this.cbVersion.DisplayMember = "(none)";
            this.cbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVersion.FormattingEnabled = true;
            this.cbVersion.Items.AddRange(new object[] {
            "wersja 1",
            "wersja 2"});
            this.cbVersion.Location = new System.Drawing.Point(130, 291);
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.Size = new System.Drawing.Size(151, 28);
            this.cbVersion.TabIndex = 16;
            this.cbVersion.SelectedIndexChanged += new System.EventHandler(this.cbVersion_SelectedIndexChanged);
            // 
            // tbDecryptedMessage
            // 
            this.tbDecryptedMessage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDecryptedMessage.Location = new System.Drawing.Point(130, 225);
            this.tbDecryptedMessage.Name = "tbDecryptedMessage";
            this.tbDecryptedMessage.ReadOnly = true;
            this.tbDecryptedMessage.Size = new System.Drawing.Size(620, 27);
            this.tbDecryptedMessage.TabIndex = 15;
            // 
            // lDecryptedMessage
            // 
            this.lDecryptedMessage.AutoSize = true;
            this.lDecryptedMessage.Location = new System.Drawing.Point(21, 225);
            this.lDecryptedMessage.Name = "lDecryptedMessage";
            this.lDecryptedMessage.Size = new System.Drawing.Size(106, 20);
            this.lDecryptedMessage.TabIndex = 14;
            this.lDecryptedMessage.Text = "Odszyfrowana:";
            // 
            // bDecrypt
            // 
            this.bDecrypt.Location = new System.Drawing.Point(130, 177);
            this.bDecrypt.Name = "bDecrypt";
            this.bDecrypt.Size = new System.Drawing.Size(94, 29);
            this.bDecrypt.TabIndex = 13;
            this.bDecrypt.Text = "Odszyfruj";
            this.bDecrypt.UseVisualStyleBackColor = true;
            this.bDecrypt.Click += new System.EventHandler(this.bDecrypt_Click);
            // 
            // tbEncryptedMessage
            // 
            this.tbEncryptedMessage.Location = new System.Drawing.Point(130, 132);
            this.tbEncryptedMessage.Name = "tbEncryptedMessage";
            this.tbEncryptedMessage.ReadOnly = true;
            this.tbEncryptedMessage.Size = new System.Drawing.Size(620, 27);
            this.tbEncryptedMessage.TabIndex = 12;
            // 
            // lEncryptedMessage
            // 
            this.lEncryptedMessage.AutoSize = true;
            this.lEncryptedMessage.Location = new System.Drawing.Point(21, 135);
            this.lEncryptedMessage.Name = "lEncryptedMessage";
            this.lEncryptedMessage.Size = new System.Drawing.Size(103, 20);
            this.lEncryptedMessage.TabIndex = 11;
            this.lEncryptedMessage.Text = "Zaszyfrowana:";
            // 
            // bEncrypt
            // 
            this.bEncrypt.Location = new System.Drawing.Point(130, 76);
            this.bEncrypt.Name = "bEncrypt";
            this.bEncrypt.Size = new System.Drawing.Size(94, 29);
            this.bEncrypt.TabIndex = 10;
            this.bEncrypt.Text = "Szyfruj";
            this.bEncrypt.UseVisualStyleBackColor = true;
            this.bEncrypt.Click += new System.EventHandler(this.bEncrypt_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMessage.Location = new System.Drawing.Point(130, 25);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(620, 27);
            this.tbMessage.TabIndex = 9;
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Location = new System.Drawing.Point(29, 28);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(95, 20);
            this.lMessage.TabIndex = 8;
            this.lMessage.Text = "Wiadomość: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Szyfr homofoniczny";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox tbDecryptedMessage;
        private Label lDecryptedMessage;
        private Button bDecrypt;
        private TextBox tbEncryptedMessage;
        private Label lEncryptedMessage;
        private Button bEncrypt;
        private TextBox tbMessage;
        private Label lMessage;
        private ComboBox cbVersion;
        private Label lVersion;
    }
}