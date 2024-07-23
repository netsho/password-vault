namespace pwdvault.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnEye = new Button();
            txtBoxPwd = new TextBox();
            lbPwd = new Label();
            lbUser = new Label();
            txtBoxUser = new TextBox();
            PanelBanner = new Panel();
            splitCollapsing = new SplitContainer();
            checkBoxInfo = new CheckBox();
            btnFileDialogKey = new Button();
            txtBoxKey = new TextBox();
            lbDbKey = new Label();
            btnFileDialogCert = new Button();
            txtBoxCertificate = new TextBox();
            lbDbCertificate = new Label();
            btnFileDialogCA = new Button();
            txtBoxSecretId = new TextBox();
            lbSecretId = new Label();
            txtBoxCA = new TextBox();
            lbDbCA = new Label();
            BtnLogin = new Button();
            LinkLbSignUp = new LinkLabel();
            LbSignUp = new Label();
            BtnLoginData = new Button();
            ((System.ComponentModel.ISupportInitialize)splitCollapsing).BeginInit();
            splitCollapsing.Panel1.SuspendLayout();
            splitCollapsing.Panel2.SuspendLayout();
            splitCollapsing.SuspendLayout();
            SuspendLayout();
            // 
            // btnEye
            // 
            btnEye.BackgroundImage = Properties.Resources.eye;
            btnEye.BackgroundImageLayout = ImageLayout.Stretch;
            btnEye.Location = new Point(731, 235);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(41, 40);
            btnEye.TabIndex = 15;
            btnEye.UseVisualStyleBackColor = true;
            btnEye.MouseDown += BtnEye_MouseDown;
            btnEye.MouseUp += BtnEye_MouseUp;
            // 
            // txtBoxPwd
            // 
            txtBoxPwd.Font = new Font("Segoe UI", 9F);
            txtBoxPwd.Location = new Point(294, 235);
            txtBoxPwd.Name = "txtBoxPwd";
            txtBoxPwd.Size = new Size(428, 39);
            txtBoxPwd.TabIndex = 11;
            txtBoxPwd.UseSystemPasswordChar = true;
            // 
            // lbPwd
            // 
            lbPwd.AutoSize = true;
            lbPwd.FlatStyle = FlatStyle.System;
            lbPwd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbPwd.Location = new Point(119, 238);
            lbPwd.Name = "lbPwd";
            lbPwd.Size = new Size(147, 41);
            lbPwd.TabIndex = 13;
            lbPwd.Text = "Password";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.FlatStyle = FlatStyle.System;
            lbUser.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbUser.ForeColor = SystemColors.MenuText;
            lbUser.Location = new Point(119, 150);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(156, 41);
            lbUser.TabIndex = 12;
            lbUser.Text = "Username";
            // 
            // txtBoxUser
            // 
            txtBoxUser.BackColor = SystemColors.Window;
            txtBoxUser.Font = new Font("Segoe UI", 9F);
            txtBoxUser.Location = new Point(294, 147);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(428, 39);
            txtBoxUser.TabIndex = 10;
            // 
            // PanelBanner
            // 
            PanelBanner.Location = new Point(0, 0);
            PanelBanner.Margin = new Padding(5);
            PanelBanner.Name = "PanelBanner";
            PanelBanner.Size = new Size(882, 106);
            PanelBanner.TabIndex = 17;
            PanelBanner.Paint += PanelBanner_Paint;
            // 
            // splitCollapsing
            // 
            splitCollapsing.Location = new Point(20, 384);
            splitCollapsing.Margin = new Padding(5);
            splitCollapsing.Name = "splitCollapsing";
            splitCollapsing.Orientation = Orientation.Horizontal;
            // 
            // splitCollapsing.Panel1
            // 
            splitCollapsing.Panel1.Controls.Add(checkBoxInfo);
            splitCollapsing.Panel1.Controls.Add(btnFileDialogKey);
            splitCollapsing.Panel1.Controls.Add(txtBoxKey);
            splitCollapsing.Panel1.Controls.Add(lbDbKey);
            splitCollapsing.Panel1.Controls.Add(btnFileDialogCert);
            splitCollapsing.Panel1.Controls.Add(txtBoxCertificate);
            splitCollapsing.Panel1.Controls.Add(lbDbCertificate);
            splitCollapsing.Panel1.Controls.Add(btnFileDialogCA);
            splitCollapsing.Panel1.Controls.Add(txtBoxSecretId);
            splitCollapsing.Panel1.Controls.Add(lbSecretId);
            splitCollapsing.Panel1.Controls.Add(txtBoxCA);
            splitCollapsing.Panel1.Controls.Add(lbDbCA);
            // 
            // splitCollapsing.Panel2
            // 
            splitCollapsing.Panel2.Controls.Add(BtnLogin);
            splitCollapsing.Panel2.Controls.Add(LinkLbSignUp);
            splitCollapsing.Panel2.Controls.Add(LbSignUp);
            splitCollapsing.Size = new Size(842, 677);
            splitCollapsing.SplitterDistance = 552;
            splitCollapsing.SplitterWidth = 6;
            splitCollapsing.TabIndex = 18;
            // 
            // checkBoxInfo
            // 
            checkBoxInfo.AutoSize = true;
            checkBoxInfo.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            checkBoxInfo.Location = new Point(49, 507);
            checkBoxInfo.Margin = new Padding(5);
            checkBoxInfo.Name = "checkBoxInfo";
            checkBoxInfo.Size = new Size(270, 33);
            checkBoxInfo.TabIndex = 40;
            checkBoxInfo.Text = "Remember the fields";
            checkBoxInfo.UseVisualStyleBackColor = true;
            checkBoxInfo.CheckedChanged += CheckBoxInfo_CheckedChanged;
            // 
            // btnFileDialogKey
            // 
            btnFileDialogKey.BackgroundImage = Properties.Resources.icons8_folder_48;
            btnFileDialogKey.Location = new Point(741, 310);
            btnFileDialogKey.Margin = new Padding(5);
            btnFileDialogKey.Name = "btnFileDialogKey";
            btnFileDialogKey.Size = new Size(52, 45);
            btnFileDialogKey.TabIndex = 39;
            btnFileDialogKey.UseVisualStyleBackColor = true;
            btnFileDialogKey.Click += BtnFileDialogKey_Click;
            // 
            // txtBoxKey
            // 
            txtBoxKey.Location = new Point(49, 310);
            txtBoxKey.Name = "txtBoxKey";
            txtBoxKey.Size = new Size(682, 39);
            txtBoxKey.TabIndex = 38;
            // 
            // lbDbKey
            // 
            lbDbKey.AutoSize = true;
            lbDbKey.FlatStyle = FlatStyle.System;
            lbDbKey.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbDbKey.Location = new Point(49, 266);
            lbDbKey.Name = "lbDbKey";
            lbDbKey.Size = new Size(203, 41);
            lbDbKey.TabIndex = 37;
            lbDbKey.Text = "Database Key";
            // 
            // btnFileDialogCert
            // 
            btnFileDialogCert.BackgroundImage = Properties.Resources.icons8_folder_48;
            btnFileDialogCert.Location = new Point(741, 184);
            btnFileDialogCert.Margin = new Padding(5);
            btnFileDialogCert.Name = "btnFileDialogCert";
            btnFileDialogCert.Size = new Size(52, 46);
            btnFileDialogCert.TabIndex = 36;
            btnFileDialogCert.UseVisualStyleBackColor = true;
            btnFileDialogCert.Click += BtnFileDialogCert_Click;
            // 
            // txtBoxCertificate
            // 
            txtBoxCertificate.Location = new Point(49, 184);
            txtBoxCertificate.Name = "txtBoxCertificate";
            txtBoxCertificate.Size = new Size(682, 39);
            txtBoxCertificate.TabIndex = 35;
            // 
            // lbDbCertificate
            // 
            lbDbCertificate.AutoSize = true;
            lbDbCertificate.FlatStyle = FlatStyle.System;
            lbDbCertificate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbDbCertificate.Location = new Point(49, 139);
            lbDbCertificate.Name = "lbDbCertificate";
            lbDbCertificate.Size = new Size(295, 41);
            lbDbCertificate.TabIndex = 34;
            lbDbCertificate.Text = "Database Certificate";
            // 
            // btnFileDialogCA
            // 
            btnFileDialogCA.BackgroundImage = Properties.Resources.icons8_folder_48;
            btnFileDialogCA.Location = new Point(741, 56);
            btnFileDialogCA.Margin = new Padding(5);
            btnFileDialogCA.Name = "btnFileDialogCA";
            btnFileDialogCA.Size = new Size(52, 46);
            btnFileDialogCA.TabIndex = 33;
            btnFileDialogCA.UseVisualStyleBackColor = true;
            btnFileDialogCA.Click += BtnFileDialogCA_Click;
            // 
            // txtBoxSecretId
            // 
            txtBoxSecretId.Location = new Point(49, 434);
            txtBoxSecretId.Name = "txtBoxSecretId";
            txtBoxSecretId.Size = new Size(682, 39);
            txtBoxSecretId.TabIndex = 32;
            // 
            // lbSecretId
            // 
            lbSecretId.AutoSize = true;
            lbSecretId.FlatStyle = FlatStyle.System;
            lbSecretId.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbSecretId.Location = new Point(49, 389);
            lbSecretId.Name = "lbSecretId";
            lbSecretId.Size = new Size(219, 41);
            lbSecretId.TabIndex = 31;
            lbSecretId.Text = "Vault Secret ID";
            // 
            // txtBoxCA
            // 
            txtBoxCA.Location = new Point(49, 59);
            txtBoxCA.Name = "txtBoxCA";
            txtBoxCA.Size = new Size(682, 39);
            txtBoxCA.TabIndex = 30;
            // 
            // lbDbCA
            // 
            lbDbCA.AutoSize = true;
            lbDbCA.FlatStyle = FlatStyle.System;
            lbDbCA.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbDbCA.Location = new Point(49, 11);
            lbDbCA.Name = "lbDbCA";
            lbDbCA.Size = new Size(193, 41);
            lbDbCA.TabIndex = 29;
            lbDbCA.Text = "Database CA";
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = SystemColors.ButtonFace;
            BtnLogin.BackgroundImage = Properties.Resources.Summer;
            BtnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLogin.Font = new Font("Bahnschrift SemiBold", 9F);
            BtnLogin.Location = new Point(99, 19);
            BtnLogin.Margin = new Padding(5);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(606, 48);
            BtnLogin.TabIndex = 20;
            BtnLogin.Text = "LOGIN";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // LinkLbSignUp
            // 
            LinkLbSignUp.ActiveLinkColor = Color.FromArgb(43, 88, 118);
            LinkLbSignUp.AutoSize = true;
            LinkLbSignUp.BackColor = SystemColors.Window;
            LinkLbSignUp.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            LinkLbSignUp.ForeColor = SystemColors.ActiveCaptionText;
            LinkLbSignUp.LinkColor = Color.FromArgb(43, 88, 118);
            LinkLbSignUp.Location = new Point(600, 72);
            LinkLbSignUp.Margin = new Padding(5, 0, 5, 0);
            LinkLbSignUp.Name = "LinkLbSignUp";
            LinkLbSignUp.Size = new Size(105, 29);
            LinkLbSignUp.TabIndex = 18;
            LinkLbSignUp.TabStop = true;
            LinkLbSignUp.Text = "SIGN UP";
            LinkLbSignUp.LinkClicked += LinkLbSignUp_LinkClicked;
            // 
            // LbSignUp
            // 
            LbSignUp.AutoSize = true;
            LbSignUp.Font = new Font("Segoe UI", 9F);
            LbSignUp.Location = new Point(325, 69);
            LbSignUp.Margin = new Padding(5, 0, 5, 0);
            LbSignUp.Name = "LbSignUp";
            LbSignUp.Size = new Size(266, 32);
            LbSignUp.TabIndex = 17;
            LbSignUp.Text = "Don't have an account?";
            // 
            // BtnLoginData
            // 
            BtnLoginData.BackColor = SystemColors.ButtonFace;
            BtnLoginData.BackgroundImage = Properties.Resources.Summer;
            BtnLoginData.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLoginData.Font = new Font("Bahnschrift SemiBold", 9F);
            BtnLoginData.ForeColor = SystemColors.ActiveCaptionText;
            BtnLoginData.Location = new Point(68, 320);
            BtnLoginData.Margin = new Padding(5);
            BtnLoginData.Name = "BtnLoginData";
            BtnLoginData.Size = new Size(744, 54);
            BtnLoginData.TabIndex = 19;
            BtnLoginData.Text = "ADDITIONAL LOGIN INFORMATION";
            BtnLoginData.UseVisualStyleBackColor = false;
            BtnLoginData.Click += BtnLoginData_Click;
            // 
            // LoginForm
            // 
            AcceptButton = BtnLogin;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(881, 1061);
            Controls.Add(BtnLoginData);
            Controls.Add(splitCollapsing);
            Controls.Add(PanelBanner);
            Controls.Add(btnEye);
            Controls.Add(txtBoxPwd);
            Controls.Add(lbPwd);
            Controls.Add(lbUser);
            Controls.Add(txtBoxUser);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Password Vault";
            splitCollapsing.Panel1.ResumeLayout(false);
            splitCollapsing.Panel1.PerformLayout();
            splitCollapsing.Panel2.ResumeLayout(false);
            splitCollapsing.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitCollapsing).EndInit();
            splitCollapsing.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEye;
        private TextBox txtBoxPwd;
        private Label lbPwd;
        private Label lbUser;
        private TextBox txtBoxUser;
        private Panel PanelBanner;
        private SplitContainer splitCollapsing;
        private CheckBox checkBoxInfo;
        private Button btnFileDialogKey;
        private TextBox txtBoxKey;
        private Label lbDbKey;
        private Button btnFileDialogCert;
        private TextBox txtBoxCertificate;
        private Label lbDbCertificate;
        private Button btnFileDialogCA;
        private TextBox txtBoxSecretId;
        private Label lbSecretId;
        private TextBox txtBoxCA;
        private Label lbDbCA;
        private Label LbSignUp;
        private LinkLabel LinkLbSignUp;
        private Button BtnLoginData;
        private Button BtnLogin;
    }
}