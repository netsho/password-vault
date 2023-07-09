namespace pwdvault.Forms
{
    partial class InfoConnectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoConnectionForm));
            btnLogin = new Button();
            btnCancel = new Button();
            txtBoxCertificate = new TextBox();
            lbDbCertificate = new Label();
            txtBoxSecretId = new TextBox();
            lbSecretId = new Label();
            ofdCertificate = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(179, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 27);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(339, 200);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 27);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // txtBoxCertificate
            // 
            txtBoxCertificate.Location = new Point(75, 62);
            txtBoxCertificate.Margin = new Padding(2);
            txtBoxCertificate.Name = "txtBoxCertificate";
            txtBoxCertificate.Size = new Size(477, 27);
            txtBoxCertificate.TabIndex = 18;
            // 
            // lbDbCertificate
            // 
            lbDbCertificate.AutoSize = true;
            lbDbCertificate.FlatStyle = FlatStyle.System;
            lbDbCertificate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDbCertificate.Location = new Point(75, 34);
            lbDbCertificate.Margin = new Padding(2, 0, 2, 0);
            lbDbCertificate.Name = "lbDbCertificate";
            lbDbCertificate.Size = new Size(231, 28);
            lbDbCertificate.TabIndex = 17;
            lbDbCertificate.Text = "Database TLS Certificate";
            // 
            // txtBoxSecretId
            // 
            txtBoxSecretId.Location = new Point(75, 134);
            txtBoxSecretId.Margin = new Padding(2);
            txtBoxSecretId.Name = "txtBoxSecretId";
            txtBoxSecretId.Size = new Size(477, 27);
            txtBoxSecretId.TabIndex = 20;
            // 
            // lbSecretId
            // 
            lbSecretId.AutoSize = true;
            lbSecretId.FlatStyle = FlatStyle.System;
            lbSecretId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSecretId.Location = new Point(75, 106);
            lbSecretId.Margin = new Padding(2, 0, 2, 0);
            lbSecretId.Name = "lbSecretId";
            lbSecretId.Size = new Size(146, 28);
            lbSecretId.TabIndex = 19;
            lbSecretId.Text = "Vault Secret ID";
            // 
            // ofdCertificate
            // 
            ofdCertificate.FileName = "openFileDialogCertificate";
            // 
            // InfoConnectionForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(620, 239);
            Controls.Add(txtBoxSecretId);
            Controls.Add(lbSecretId);
            Controls.Add(txtBoxCertificate);
            Controls.Add(lbDbCertificate);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InfoConnectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Additional login information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancel;
        private TextBox txtBoxCertificate;
        private Label lbDbCertificate;
        private TextBox txtBoxSecretId;
        private Label lbSecretId;
        private OpenFileDialog ofdCertificate;
        private Button btnLogin;
    }
}