namespace pwdvault.Forms
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            lbTitle = new Label();
            txtBoxPwd = new TextBox();
            txtBoxUser = new TextBox();
            btnSign = new Button();
            lbPwd = new Label();
            lbUsername = new Label();
            toolTip1 = new ToolTip(components);
            errorProvider = new ErrorProvider(components);
            btnCancel = new Button();
            PanelBanner = new Panel();
            btnFileDialogKey = new Button();
            txtBoxKey = new TextBox();
            lbDbKey = new Label();
            btnFileDialogCert = new Button();
            txtBoxCertificate = new TextBox();
            lbDbCertificate = new Label();
            btnFileDialogCA = new Button();
            txtBoxCA = new TextBox();
            lbDbCA = new Label();
            BtnLoginData = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(130, 76);
            lbTitle.Margin = new Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(243, 27);
            lbTitle.TabIndex = 21;
            lbTitle.Text = "Create new account";
            // 
            // txtBoxPwd
            // 
            errorProvider.SetIconPadding(txtBoxPwd, 5);
            txtBoxPwd.Location = new Point(32, 212);
            txtBoxPwd.Margin = new Padding(2);
            txtBoxPwd.Name = "txtBoxPwd";
            txtBoxPwd.Size = new Size(421, 27);
            txtBoxPwd.TabIndex = 19;
            txtBoxPwd.TextChanged += TxtBoxPwd_TextChanged;
            // 
            // txtBoxUser
            // 
            txtBoxUser.Location = new Point(32, 142);
            txtBoxUser.Margin = new Padding(2);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(421, 27);
            txtBoxUser.TabIndex = 16;
            // 
            // btnSign
            // 
            btnSign.DialogResult = DialogResult.OK;
            btnSign.FlatStyle = FlatStyle.System;
            btnSign.Font = new Font("Bahnschrift SemiBold", 9F);
            btnSign.Location = new Point(57, 536);
            btnSign.Margin = new Padding(2);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(187, 28);
            btnSign.TabIndex = 15;
            btnSign.Text = "SIGN UP";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += BtnSign_Click;
            // 
            // lbPwd
            // 
            lbPwd.AutoSize = true;
            lbPwd.FlatStyle = FlatStyle.System;
            lbPwd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbPwd.Location = new Point(32, 182);
            lbPwd.Margin = new Padding(2, 0, 2, 0);
            lbPwd.Name = "lbPwd";
            lbPwd.Size = new Size(97, 28);
            lbPwd.TabIndex = 14;
            lbPwd.Text = "Password";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.FlatStyle = FlatStyle.System;
            lbUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbUsername.Location = new Point(32, 112);
            lbUsername.Margin = new Padding(2, 0, 2, 0);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(104, 28);
            lbUsername.TabIndex = 11;
            lbUsername.Text = "Username";
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatStyle = FlatStyle.System;
            btnCancel.Font = new Font("Bahnschrift SemiBold", 9F);
            btnCancel.Location = new Point(248, 536);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 28);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // PanelBanner
            // 
            PanelBanner.Location = new Point(0, 0);
            PanelBanner.Name = "PanelBanner";
            PanelBanner.Size = new Size(501, 60);
            PanelBanner.TabIndex = 23;
            PanelBanner.Paint += PanelBanner_Paint;
            // 
            // btnFileDialogKey
            // 
            btnFileDialogKey.BackgroundImage = Properties.Resources.icons8_folder_48;
            btnFileDialogKey.Location = new Point(458, 489);
            btnFileDialogKey.Name = "btnFileDialogKey";
            btnFileDialogKey.Size = new Size(32, 28);
            btnFileDialogKey.TabIndex = 48;
            btnFileDialogKey.UseVisualStyleBackColor = true;
            btnFileDialogKey.Click += BtnFileDialogKey_Click;
            // 
            // txtBoxKey
            // 
            txtBoxKey.Location = new Point(32, 489);
            txtBoxKey.Margin = new Padding(2);
            txtBoxKey.Name = "txtBoxKey";
            txtBoxKey.Size = new Size(421, 27);
            txtBoxKey.TabIndex = 47;
            // 
            // lbDbKey
            // 
            lbDbKey.AutoSize = true;
            lbDbKey.FlatStyle = FlatStyle.System;
            lbDbKey.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbDbKey.Location = new Point(32, 462);
            lbDbKey.Margin = new Padding(2, 0, 2, 0);
            lbDbKey.Name = "lbDbKey";
            lbDbKey.Size = new Size(129, 25);
            lbDbKey.TabIndex = 46;
            lbDbKey.Text = "Database Key";
            // 
            // btnFileDialogCert
            // 
            btnFileDialogCert.BackgroundImage = Properties.Resources.icons8_folder_48;
            btnFileDialogCert.Location = new Point(457, 422);
            btnFileDialogCert.Name = "btnFileDialogCert";
            btnFileDialogCert.Size = new Size(32, 29);
            btnFileDialogCert.TabIndex = 45;
            btnFileDialogCert.UseVisualStyleBackColor = true;
            btnFileDialogCert.Click += BtnFileDialogCert_Click;
            // 
            // txtBoxCertificate
            // 
            txtBoxCertificate.Location = new Point(32, 422);
            txtBoxCertificate.Margin = new Padding(2);
            txtBoxCertificate.Name = "txtBoxCertificate";
            txtBoxCertificate.Size = new Size(421, 27);
            txtBoxCertificate.TabIndex = 44;
            // 
            // lbDbCertificate
            // 
            lbDbCertificate.AutoSize = true;
            lbDbCertificate.FlatStyle = FlatStyle.System;
            lbDbCertificate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbDbCertificate.Location = new Point(32, 395);
            lbDbCertificate.Margin = new Padding(2, 0, 2, 0);
            lbDbCertificate.Name = "lbDbCertificate";
            lbDbCertificate.Size = new Size(187, 25);
            lbDbCertificate.TabIndex = 43;
            lbDbCertificate.Text = "Database Certificate";
            // 
            // btnFileDialogCA
            // 
            btnFileDialogCA.BackgroundImage = Properties.Resources.icons8_folder_48;
            btnFileDialogCA.Location = new Point(457, 355);
            btnFileDialogCA.Name = "btnFileDialogCA";
            btnFileDialogCA.Size = new Size(32, 29);
            btnFileDialogCA.TabIndex = 42;
            btnFileDialogCA.UseVisualStyleBackColor = true;
            btnFileDialogCA.Click += BtnFileDialogCA_Click;
            // 
            // txtBoxCA
            // 
            txtBoxCA.Location = new Point(32, 355);
            txtBoxCA.Margin = new Padding(2);
            txtBoxCA.Name = "txtBoxCA";
            txtBoxCA.Size = new Size(421, 27);
            txtBoxCA.TabIndex = 41;
            // 
            // lbDbCA
            // 
            lbDbCA.AutoSize = true;
            lbDbCA.FlatStyle = FlatStyle.System;
            lbDbCA.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbDbCA.Location = new Point(32, 328);
            lbDbCA.Margin = new Padding(2, 0, 2, 0);
            lbDbCA.Name = "lbDbCA";
            lbDbCA.Size = new Size(122, 25);
            lbDbCA.TabIndex = 40;
            lbDbCA.Text = "Database CA";
            // 
            // BtnLoginData
            // 
            BtnLoginData.BackColor = SystemColors.ButtonFace;
            BtnLoginData.BackgroundImage = Properties.Resources.Summer;
            BtnLoginData.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLoginData.Font = new Font("Bahnschrift SemiBold", 9F);
            BtnLoginData.ForeColor = SystemColors.ActiveCaptionText;
            BtnLoginData.Location = new Point(57, 254);
            BtnLoginData.Name = "BtnLoginData";
            BtnLoginData.Size = new Size(361, 62);
            BtnLoginData.TabIndex = 49;
            BtnLoginData.Text = "GENERATE RANDOM PASSWORD";
            BtnLoginData.UseVisualStyleBackColor = false;
            BtnLoginData.Click += BtnGenerate_Click;
            // 
            // SignUpForm
            // 
            AcceptButton = btnSign;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(501, 580);
            Controls.Add(BtnLoginData);
            Controls.Add(btnFileDialogKey);
            Controls.Add(txtBoxKey);
            Controls.Add(lbDbKey);
            Controls.Add(btnFileDialogCert);
            Controls.Add(txtBoxCertificate);
            Controls.Add(lbDbCertificate);
            Controls.Add(btnFileDialogCA);
            Controls.Add(txtBoxCA);
            Controls.Add(lbDbCA);
            Controls.Add(PanelBanner);
            Controls.Add(btnCancel);
            Controls.Add(lbTitle);
            Controls.Add(txtBoxPwd);
            Controls.Add(txtBoxUser);
            Controls.Add(btnSign);
            Controls.Add(lbPwd);
            Controls.Add(lbUsername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign in";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private TextBox txtBoxPwd;
        private TextBox txtBoxUser;
        private Button btnSign;
        private Label lbPwd;
        private Label lbUsername;
        private ToolTip toolTip1;
        private ErrorProvider errorProvider;
        private Button btnCancel;
        private Panel PanelBanner;
        private Button btnFileDialogKey;
        private TextBox txtBoxKey;
        private Label lbDbKey;
        private Button btnFileDialogCert;
        private TextBox txtBoxCertificate;
        private Label lbDbCertificate;
        private Button btnFileDialogCA;
        private TextBox txtBoxCA;
        private Label lbDbCA;
        private Button BtnLoginData;
    }
}