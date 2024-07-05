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
            btnEye.Location = new Point(450, 147);
            btnEye.Margin = new Padding(2);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(25, 25);
            btnEye.TabIndex = 15;
            btnEye.UseVisualStyleBackColor = true;
            btnEye.MouseDown += BtnEye_MouseDown;
            btnEye.MouseUp += BtnEye_MouseUp;
            // 
            // txtBoxPwd
            // 
            txtBoxPwd.Font = new Font("Segoe UI", 9F);
            txtBoxPwd.Location = new Point(181, 147);
            txtBoxPwd.Margin = new Padding(2);
            txtBoxPwd.Name = "txtBoxPwd";
            txtBoxPwd.Size = new Size(265, 27);
            txtBoxPwd.TabIndex = 11;
            txtBoxPwd.UseSystemPasswordChar = true;
            // 
            // lbPwd
            // 
            lbPwd.AutoSize = true;
            lbPwd.FlatStyle = FlatStyle.System;
            lbPwd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbPwd.Location = new Point(73, 149);
            lbPwd.Margin = new Padding(2, 0, 2, 0);
            lbPwd.Name = "lbPwd";
            lbPwd.Size = new Size(91, 25);
            lbPwd.TabIndex = 13;
            lbPwd.Text = "Password";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.FlatStyle = FlatStyle.System;
            lbUser.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbUser.ForeColor = SystemColors.MenuText;
            lbUser.Location = new Point(73, 94);
            lbUser.Margin = new Padding(2, 0, 2, 0);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(98, 25);
            lbUser.TabIndex = 12;
            lbUser.Text = "Username";
            // 
            // txtBoxUser
            // 
            txtBoxUser.BackColor = SystemColors.Window;
            txtBoxUser.Font = new Font("Segoe UI", 9F);
            txtBoxUser.Location = new Point(181, 92);
            txtBoxUser.Margin = new Padding(2);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(265, 27);
            txtBoxUser.TabIndex = 10;
            // 
            // PanelBanner
            // 
            PanelBanner.Location = new Point(0, 0);
            PanelBanner.Name = "PanelBanner";
            PanelBanner.Size = new Size(543, 66);
            PanelBanner.TabIndex = 17;
            PanelBanner.Paint += PanelBanner_Paint;
            // 
            // splitCollapsing
            // 
            splitCollapsing.Location = new Point(12, 240);
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
            splitCollapsing.Size = new Size(518, 423);
            splitCollapsing.SplitterDistance = 345;
            splitCollapsing.TabIndex = 18;
            // 
            // checkBoxInfo
            // 
            checkBoxInfo.AutoSize = true;
            checkBoxInfo.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            checkBoxInfo.Location = new Point(30, 317);
            checkBoxInfo.Name = "checkBoxInfo";
            checkBoxInfo.Size = new Size(170, 22);
            checkBoxInfo.TabIndex = 40;
            checkBoxInfo.Text = "Remember the fields";
            checkBoxInfo.UseVisualStyleBackColor = true;
            checkBoxInfo.CheckedChanged += CheckBoxInfo_CheckedChanged;
            // 
            // btnFileDialogKey
            // 
            btnFileDialogKey.BackgroundImage = Properties.Resources.icons8_folder_48;
            btnFileDialogKey.Location = new Point(456, 194);
            btnFileDialogKey.Name = "btnFileDialogKey";
            btnFileDialogKey.Size = new Size(32, 28);
            btnFileDialogKey.TabIndex = 39;
            btnFileDialogKey.UseVisualStyleBackColor = true;
            btnFileDialogKey.Click += BtnFileDialogKey_Click;
            // 
            // txtBoxKey
            // 
            txtBoxKey.Location = new Point(30, 194);
            txtBoxKey.Margin = new Padding(2);
            txtBoxKey.Name = "txtBoxKey";
            txtBoxKey.Size = new Size(421, 27);
            txtBoxKey.TabIndex = 38;
            // 
            // lbDbKey
            // 
            lbDbKey.AutoSize = true;
            lbDbKey.FlatStyle = FlatStyle.System;
            lbDbKey.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbDbKey.Location = new Point(30, 166);
            lbDbKey.Margin = new Padding(2, 0, 2, 0);
            lbDbKey.Name = "lbDbKey";
            lbDbKey.Size = new Size(129, 25);
            lbDbKey.TabIndex = 37;
            lbDbKey.Text = "Database Key";
            // 
            // btnFileDialogCert
            // 
            btnFileDialogCert.BackgroundImage = Properties.Resources.icons8_folder_48;
            btnFileDialogCert.Location = new Point(456, 115);
            btnFileDialogCert.Name = "btnFileDialogCert";
            btnFileDialogCert.Size = new Size(32, 29);
            btnFileDialogCert.TabIndex = 36;
            btnFileDialogCert.UseVisualStyleBackColor = true;
            btnFileDialogCert.Click += BtnFileDialogCert_Click;
            // 
            // txtBoxCertificate
            // 
            txtBoxCertificate.Location = new Point(30, 115);
            txtBoxCertificate.Margin = new Padding(2);
            txtBoxCertificate.Name = "txtBoxCertificate";
            txtBoxCertificate.Size = new Size(421, 27);
            txtBoxCertificate.TabIndex = 35;
            // 
            // lbDbCertificate
            // 
            lbDbCertificate.AutoSize = true;
            lbDbCertificate.FlatStyle = FlatStyle.System;
            lbDbCertificate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbDbCertificate.Location = new Point(30, 87);
            lbDbCertificate.Margin = new Padding(2, 0, 2, 0);
            lbDbCertificate.Name = "lbDbCertificate";
            lbDbCertificate.Size = new Size(187, 25);
            lbDbCertificate.TabIndex = 34;
            lbDbCertificate.Text = "Database Certificate";
            // 
            // btnFileDialogCA
            // 
            btnFileDialogCA.BackgroundImage = Properties.Resources.icons8_folder_48;
            btnFileDialogCA.Location = new Point(456, 35);
            btnFileDialogCA.Name = "btnFileDialogCA";
            btnFileDialogCA.Size = new Size(32, 29);
            btnFileDialogCA.TabIndex = 33;
            btnFileDialogCA.UseVisualStyleBackColor = true;
            btnFileDialogCA.Click += BtnFileDialogCA_Click;
            // 
            // txtBoxSecretId
            // 
            txtBoxSecretId.Location = new Point(30, 271);
            txtBoxSecretId.Margin = new Padding(2);
            txtBoxSecretId.Name = "txtBoxSecretId";
            txtBoxSecretId.Size = new Size(421, 27);
            txtBoxSecretId.TabIndex = 32;
            // 
            // lbSecretId
            // 
            lbSecretId.AutoSize = true;
            lbSecretId.FlatStyle = FlatStyle.System;
            lbSecretId.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbSecretId.Location = new Point(30, 243);
            lbSecretId.Margin = new Padding(2, 0, 2, 0);
            lbSecretId.Name = "lbSecretId";
            lbSecretId.Size = new Size(139, 25);
            lbSecretId.TabIndex = 31;
            lbSecretId.Text = "Vault Secret ID";
            // 
            // txtBoxCA
            // 
            txtBoxCA.Location = new Point(30, 37);
            txtBoxCA.Margin = new Padding(2);
            txtBoxCA.Name = "txtBoxCA";
            txtBoxCA.Size = new Size(421, 27);
            txtBoxCA.TabIndex = 30;
            // 
            // lbDbCA
            // 
            lbDbCA.AutoSize = true;
            lbDbCA.FlatStyle = FlatStyle.System;
            lbDbCA.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbDbCA.Location = new Point(30, 7);
            lbDbCA.Margin = new Padding(2, 0, 2, 0);
            lbDbCA.Name = "lbDbCA";
            lbDbCA.Size = new Size(122, 25);
            lbDbCA.TabIndex = 29;
            lbDbCA.Text = "Database CA";
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = SystemColors.ButtonFace;
            BtnLogin.BackgroundImage = Properties.Resources.Summer;
            BtnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLogin.Font = new Font("Bahnschrift SemiBold", 9F);
            BtnLogin.Location = new Point(61, 12);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(373, 30);
            BtnLogin.TabIndex = 20;
            BtnLogin.Text = "LOGIN";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // LinkLbSignUp
            // 
            LinkLbSignUp.ActiveLinkColor = Color.FromArgb(43, 88, 118);
            LinkLbSignUp.AutoSize = true;
            LinkLbSignUp.BackColor = SystemColors.ButtonFace;
            LinkLbSignUp.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            LinkLbSignUp.ForeColor = SystemColors.ActiveCaptionText;
            LinkLbSignUp.LinkColor = Color.FromArgb(43, 88, 118);
            LinkLbSignUp.Location = new Point(369, 45);
            LinkLbSignUp.Name = "LinkLbSignUp";
            LinkLbSignUp.Size = new Size(65, 18);
            LinkLbSignUp.TabIndex = 18;
            LinkLbSignUp.TabStop = true;
            LinkLbSignUp.Text = "SIGN UP";
            LinkLbSignUp.LinkClicked += LinkLbSignUp_LinkClicked;
            // 
            // LbSignUp
            // 
            LbSignUp.AutoSize = true;
            LbSignUp.Font = new Font("Segoe UI", 9F);
            LbSignUp.Location = new Point(200, 44);
            LbSignUp.Name = "LbSignUp";
            LbSignUp.Size = new Size(163, 20);
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
            BtnLoginData.Location = new Point(42, 200);
            BtnLoginData.Name = "BtnLoginData";
            BtnLoginData.Size = new Size(458, 34);
            BtnLoginData.TabIndex = 19;
            BtnLoginData.Text = "ADDITIONAL LOGIN INFORMATION";
            BtnLoginData.UseVisualStyleBackColor = false;
            BtnLoginData.Click += BtnLoginData_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(542, 663);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Password Vault";
            WindowState = FormWindowState.Minimized;
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