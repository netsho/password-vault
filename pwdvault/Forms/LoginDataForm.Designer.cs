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
            btnLogin.Location = new Point(210, 495);
            btnLogin.Margin = new Padding(4, 4, 4, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(162, 34);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(410, 495);
            btnCancel.Margin = new Padding(4, 4, 4, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(162, 34);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // txtBoxCA
            // 
            txtBoxCA.Location = new Point(94, 78);
            txtBoxCA.Margin = new Padding(2);
            txtBoxCA.Name = "txtBoxCA";
            txtBoxCA.Size = new Size(569, 31);
            txtBoxCA.TabIndex = 18;
            // 
            // lbDbCA
            // 
            lbDbCA.AutoSize = true;
            lbDbCA.FlatStyle = FlatStyle.System;
            lbDbCA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDbCA.Location = new Point(94, 42);
            lbDbCA.Margin = new Padding(2, 0, 2, 0);
            lbDbCA.Name = "lbDbCA";
            lbDbCA.Size = new Size(154, 32);
            lbDbCA.TabIndex = 17;
            lbDbCA.Text = "Database CA";
            // 
            // txtBoxSecretId
            // 
            txtBoxSecretId.Location = new Point(94, 370);
            txtBoxSecretId.Margin = new Padding(2);
            txtBoxSecretId.Name = "txtBoxSecretId";
            txtBoxSecretId.Size = new Size(569, 31);
            txtBoxSecretId.TabIndex = 20;
            // 
            // lbSecretId
            // 
            lbSecretId.AutoSize = true;
            lbSecretId.FlatStyle = FlatStyle.System;
            lbSecretId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSecretId.Location = new Point(94, 335);
            lbSecretId.Margin = new Padding(2, 0, 2, 0);
            lbSecretId.Name = "lbSecretId";
            lbSecretId.Size = new Size(175, 32);
            lbSecretId.TabIndex = 19;
            lbSecretId.Text = "Vault Secret ID";
            // 
            // btnFileDialogCA
            // 
            btnFileDialogCA.BackgroundImage = Properties.Resources.icons8_folder_48;
            btnFileDialogCA.Location = new Point(670, 78);
            btnFileDialogCA.Margin = new Padding(4, 4, 4, 4);
            btnFileDialogCA.Name = "btnFileDialogCA";
            btnFileDialogCA.Size = new Size(40, 36);
            btnFileDialogCA.TabIndex = 21;
            toolTipFolder.SetToolTip(btnFileDialogCA, "Browse");
            btnFileDialogCA.UseVisualStyleBackColor = true;
            btnFileDialogCA.Click += BtnFileDialogCA_Click;
            // 
            // btnFileDialogCert
            // 
            btnFileDialogCert.BackgroundImage = Properties.Resources.icons8_folder_48;
            btnFileDialogCert.Location = new Point(670, 175);
            btnFileDialogCert.Margin = new Padding(4, 4, 4, 4);
            btnFileDialogCert.Name = "btnFileDialogCert";
            btnFileDialogCert.Size = new Size(40, 36);
            btnFileDialogCert.TabIndex = 24;
            toolTipFolder.SetToolTip(btnFileDialogCert, "Browse");
            btnFileDialogCert.UseVisualStyleBackColor = true;
            btnFileDialogCert.Click += BtnFileDialogCert_Click;
            // 
            // txtBoxCertificate
            // 
            txtBoxCertificate.Location = new Point(94, 175);
            txtBoxCertificate.Margin = new Padding(2);
            txtBoxCertificate.Name = "txtBoxCertificate";
            txtBoxCertificate.Size = new Size(569, 31);
            txtBoxCertificate.TabIndex = 23;
            // 
            // lbDbCertificate
            // 
            lbDbCertificate.AutoSize = true;
            lbDbCertificate.FlatStyle = FlatStyle.System;
            lbDbCertificate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDbCertificate.Location = new Point(94, 140);
            lbDbCertificate.Margin = new Padding(2, 0, 2, 0);
            lbDbCertificate.Name = "lbDbCertificate";
            lbDbCertificate.Size = new Size(236, 32);
            lbDbCertificate.TabIndex = 22;
            lbDbCertificate.Text = "Database Certificate";
            // 
            // btnFileDialogKey
            // 
            btnFileDialogKey.BackgroundImage = Properties.Resources.icons8_folder_48;
            btnFileDialogKey.Location = new Point(670, 274);
            btnFileDialogKey.Margin = new Padding(4, 4, 4, 4);
            btnFileDialogKey.Name = "btnFileDialogKey";
            btnFileDialogKey.Size = new Size(40, 34);
            btnFileDialogKey.TabIndex = 27;
            toolTipFolder.SetToolTip(btnFileDialogKey, "Browse");
            btnFileDialogKey.UseVisualStyleBackColor = true;
            btnFileDialogKey.Click += BtnFileDialogKey_Click;
            // 
            // txtBoxKey
            // 
            txtBoxKey.Location = new Point(94, 274);
            txtBoxKey.Margin = new Padding(2);
            txtBoxKey.Name = "txtBoxKey";
            txtBoxKey.Size = new Size(569, 31);
            txtBoxKey.TabIndex = 26;
            // 
            // lbDbKey
            // 
            lbDbKey.AutoSize = true;
            lbDbKey.FlatStyle = FlatStyle.System;
            lbDbKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDbKey.Location = new Point(94, 239);
            lbDbKey.Margin = new Padding(2, 0, 2, 0);
            lbDbKey.Name = "lbDbKey";
            lbDbKey.Size = new Size(163, 32);
            lbDbKey.TabIndex = 25;
            lbDbKey.Text = "Database Key";
            // 
            // checkBoxInfo
            // 
            checkBoxInfo.AutoSize = true;
            checkBoxInfo.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxInfo.Location = new Point(94, 428);
            checkBoxInfo.Margin = new Padding(4, 4, 4, 4);
            checkBoxInfo.Name = "checkBoxInfo";
            checkBoxInfo.Size = new Size(207, 26);
            checkBoxInfo.TabIndex = 28;
            checkBoxInfo.Text = "Remember the fields";
            checkBoxInfo.UseVisualStyleBackColor = true;
            checkBoxInfo.CheckedChanged += CheckBoxInfo_CheckedChanged;
            // 
            // LoginDataForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(775, 544);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
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