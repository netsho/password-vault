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
            btConnect = new Button();
            txtBoxUser = new TextBox();
            txtBoxPwd = new TextBox();
            lbUser = new Label();
            lbPwd = new Label();
            lbTitle = new Label();
            splitContainer1 = new SplitContainer();
            btnEye = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btConnect
            // 
            btConnect.FlatStyle = FlatStyle.System;
            btConnect.Location = new Point(198, 468);
            btConnect.Name = "btConnect";
            btConnect.Size = new Size(163, 34);
            btConnect.TabIndex = 0;
            btConnect.Text = "Se connecter";
            btConnect.UseVisualStyleBackColor = true;
            btConnect.Click += btConnect_Click;
            // 
            // txtBoxUser
            // 
            txtBoxUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxUser.Location = new Point(116, 226);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(330, 31);
            txtBoxUser.TabIndex = 1;
            // 
            // txtBoxPwd
            // 
            txtBoxPwd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPwd.Location = new Point(116, 367);
            txtBoxPwd.Name = "txtBoxPwd";
            txtBoxPwd.Size = new Size(330, 31);
            txtBoxPwd.TabIndex = 2;
            txtBoxPwd.UseSystemPasswordChar = true;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.FlatStyle = FlatStyle.System;
            lbUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUser.ForeColor = SystemColors.MenuText;
            lbUser.Location = new Point(116, 180);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(74, 32);
            lbUser.TabIndex = 3;
            lbUser.Text = "Login";
            // 
            // lbPwd
            // 
            lbPwd.AutoSize = true;
            lbPwd.FlatStyle = FlatStyle.System;
            lbPwd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPwd.Location = new Point(116, 318);
            lbPwd.Name = "lbPwd";
            lbPwd.Size = new Size(160, 32);
            lbPwd.TabIndex = 4;
            lbPwd.Text = "Mot de passe";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.FlatStyle = FlatStyle.System;
            lbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(171, 91);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(215, 38);
            lbTitle.TabIndex = 5;
            lbTitle.Text = "Password Vault";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnEye);
            splitContainer1.Panel1.Controls.Add(lbTitle);
            splitContainer1.Panel1.Controls.Add(txtBoxPwd);
            splitContainer1.Panel1.Controls.Add(lbPwd);
            splitContainer1.Panel1.Controls.Add(btConnect);
            splitContainer1.Panel1.Controls.Add(lbUser);
            splitContainer1.Panel1.Controls.Add(txtBoxUser);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Size = new Size(1117, 602);
            splitContainer1.SplitterDistance = 554;
            splitContainer1.TabIndex = 6;
            // 
            // btnEye
            // 
            btnEye.BackgroundImage = Properties.Resources.eye;
            btnEye.BackgroundImageLayout = ImageLayout.Stretch;
            btnEye.Location = new Point(452, 368);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(31, 31);
            btnEye.TabIndex = 7;
            btnEye.UseVisualStyleBackColor = true;
            btnEye.MouseDown += btnEye_MouseDown;
            btnEye.MouseUp += btnEye_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.digital_secure_background_lock_circle_icons_dark_blue_6837396;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(559, 602);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 602);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connexion - Password Vault";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btConnect;
        private TextBox txtBoxUser;
        private TextBox txtBoxPwd;
        private Label lbUser;
        private Label lbPwd;
        private Label lbTitle;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Button btnEye;
    }
}