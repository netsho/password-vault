namespace pwdvault.Forms
{
    partial class LoginDataForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginDataForm));
            btnLogin = new Button();
            btnCancel = new Button();
            txtBoxCA = new TextBox();
            lbDbCA = new Label();
            txtBoxSecretId = new TextBox();
            lbSecretId = new Label();
            btnFileDialogCA = new Button();
            btnFileDialogCert = new Button();
            txtBoxCertificate = new TextBox();
            lbDbCertificate = new Label();
            btnFileDialogKey = new Button();
            txtBoxKey = new TextBox();
            lbDbKey = new Label();
            toolTipFolder = new ToolTip(components);
            checkBoxInfo = new CheckBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(168, 396);
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
            btnCancel.Location = new Point(328, 396);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 27);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // txtBoxCA
            // 
            txtBoxCA.Location = new Point(75, 62);
            txtBoxCA.Margin = new Padding(2);
            txtBoxCA.Name = "txtBoxCA";
            txtBoxCA.Size = new Size(456, 27);
            txtBoxCA.TabIndex = 18;
            // 
            // lbDbCA
            // 
            lbDbCA.AutoSize = true;
            lbDbCA.FlatStyle = FlatStyle.System;
            lbDbCA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDbCA.Location = new Point(75, 34);
            lbDbCA.Margin = new Padding(2, 0, 2, 0);
            lbDbCA.Name = "lbDbCA";
            lbDbCA.Size = new Size(126, 28);
            lbDbCA.TabIndex = 17;
            lbDbCA.Text = "Database CA";
            // 
            // txtBoxSecretId
            // 
            txtBoxSecretId.Location = new Point(75, 296);
            txtBoxSecretId.Margin = new Padding(2);
            txtBoxSecretId.Name = "txtBoxSecretId";
            txtBoxSecretId.Size = new Size(456, 27);
            txtBoxSecretId.TabIndex = 20;
            // 
            // lbSecretId
            // 
            lbSecretId.AutoSize = true;
            lbSecretId.FlatStyle = FlatStyle.System;
            lbSecretId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSecretId.Location = new Point(75, 268);
            lbSecretId.Margin = new Padding(2, 0, 2, 0);
            lbSecretId.Name = "lbSecretId";
            lbSecretId.Size = new Size(146, 28);
            lbSecretId.TabIndex = 19;
            lbSecretId.Text = "Vault Secret ID";
            // 
            // btnFileDialogCA
            // 
            btnFileDialogCA.BackgroundImage = Properties.Resources.icons8_folder_48;
            btnFileDialogCA.Location = new Point(536, 62);
            btnFileDialogCA.Name = "btnFileDialogCA";
            btnFileDialogCA.Size = new Size(32, 29);
            btnFileDialogCA.TabIndex = 21;
            toolTipFolder.SetToolTip(btnFileDialogCA, "Browse");
            btnFileDialogCA.UseVisualStyleBackColor = true;
            btnFileDialogCA.Click += BtnFileDialogCA_Click;
            // 
            // btnFileDialogCert
            // 
            btnFileDialogCert.BackgroundImage = Properties.Resources.icons8_folder_48;
            btnFileDialogCert.Location = new Point(536, 140);
            btnFileDialogCert.Name = "btnFileDialogCert";
            btnFileDialogCert.Size = new Size(32, 29);
            btnFileDialogCert.TabIndex = 24;
            toolTipFolder.SetToolTip(btnFileDialogCert, "Browse");
            btnFileDialogCert.UseVisualStyleBackColor = true;
            btnFileDialogCert.Click += BtnFileDialogCert_Click;
            // 
            // txtBoxCertificate
            // 
            txtBoxCertificate.Location = new Point(75, 140);
            txtBoxCertificate.Margin = new Padding(2);
            txtBoxCertificate.Name = "txtBoxCertificate";
            txtBoxCertificate.Size = new Size(456, 27);
            txtBoxCertificate.TabIndex = 23;
            // 
            // lbDbCertificate
            // 
            lbDbCertificate.AutoSize = true;
            lbDbCertificate.FlatStyle = FlatStyle.System;
            lbDbCertificate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDbCertificate.Location = new Point(75, 112);
            lbDbCertificate.Margin = new Padding(2, 0, 2, 0);
            lbDbCertificate.Name = "lbDbCertificate";
            lbDbCertificate.Size = new Size(193, 28);
            lbDbCertificate.TabIndex = 22;
            lbDbCertificate.Text = "Database Certificate";
            // 
            // btnFileDialogKey
            // 
            btnFileDialogKey.BackgroundImage = Properties.Resources.icons8_folder_48;
            btnFileDialogKey.Location = new Point(536, 219);
            btnFileDialogKey.Name = "btnFileDialogKey";
            btnFileDialogKey.Size = new Size(32, 27);
            btnFileDialogKey.TabIndex = 27;
            toolTipFolder.SetToolTip(btnFileDialogKey, "Browse");
            btnFileDialogKey.UseVisualStyleBackColor = true;
            btnFileDialogKey.Click += BtnFileDialogKey_Click;
            // 
            // txtBoxKey
            // 
            txtBoxKey.Location = new Point(75, 219);
            txtBoxKey.Margin = new Padding(2);
            txtBoxKey.Name = "txtBoxKey";
            txtBoxKey.Size = new Size(456, 27);
            txtBoxKey.TabIndex = 26;
            // 
            // lbDbKey
            // 
            lbDbKey.AutoSize = true;
            lbDbKey.FlatStyle = FlatStyle.System;
            lbDbKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDbKey.Location = new Point(75, 191);
            lbDbKey.Margin = new Padding(2, 0, 2, 0);
            lbDbKey.Name = "lbDbKey";
            lbDbKey.Size = new Size(134, 28);
            lbDbKey.TabIndex = 25;
            lbDbKey.Text = "Database Key";
            // 
            // checkBoxInfo
            // 
            checkBoxInfo.AutoSize = true;
            checkBoxInfo.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxInfo.Location = new Point(75, 342);
            checkBoxInfo.Name = "checkBoxInfo";
            checkBoxInfo.Size = new Size(170, 22);
            checkBoxInfo.TabIndex = 28;
            checkBoxInfo.Text = "Remember the fields";
            checkBoxInfo.UseVisualStyleBackColor = true;
            checkBoxInfo.CheckedChanged += CheckBoxInfo_CheckedChanged;
            // 
            // LoginDataForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(620, 435);
            Controls.Add(checkBoxInfo);
            Controls.Add(btnFileDialogKey);
            Controls.Add(txtBoxKey);
            Controls.Add(lbDbKey);
            Controls.Add(btnFileDialogCert);
            Controls.Add(txtBoxCertificate);
            Controls.Add(lbDbCertificate);
            Controls.Add(btnFileDialogCA);
            Controls.Add(txtBoxSecretId);
            Controls.Add(lbSecretId);
            Controls.Add(txtBoxCA);
            Controls.Add(lbDbCA);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginDataForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Additional login information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancel;
        private TextBox txtBoxCA;
        private Label lbDbCA;
        private TextBox txtBoxSecretId;
        private Label lbSecretId;
        private Button btnLogin;
        private Button btnFileDialogCA;
        private Button btnFileDialogCert;
        private TextBox txtBoxCertificate;
        private Label lbDbCertificate;
        private Button btnFileDialogKey;
        private TextBox txtBoxKey;
        private Label lbDbKey;
        private ToolTip toolTipFolder;
        private CheckBox checkBoxInfo;
    }
}