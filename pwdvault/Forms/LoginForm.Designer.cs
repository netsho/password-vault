﻿namespace pwdvault.Forms
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
            btnLogin = new Button();
            txtBoxUser = new TextBox();
            txtBoxPwd = new TextBox();
            lbUser = new Label();
            lbPwd = new Label();
            lbTitle = new Label();
            splitContainer1 = new SplitContainer();
            btnSignUp = new Button();
            btnEye = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.System;
            btnLogin.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            btnLogin.Location = new Point(370, 608);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(211, 44);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // txtBoxUser
            // 
            txtBoxUser.Font = new Font("Segoe UI", 9F);
            txtBoxUser.Location = new Point(151, 289);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(428, 39);
            txtBoxUser.TabIndex = 1;
            // 
            // txtBoxPwd
            // 
            txtBoxPwd.Font = new Font("Segoe UI", 9F);
            txtBoxPwd.Location = new Point(151, 471);
            txtBoxPwd.Name = "txtBoxPwd";
            txtBoxPwd.Size = new Size(428, 39);
            txtBoxPwd.TabIndex = 2;
            txtBoxPwd.UseSystemPasswordChar = true;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.FlatStyle = FlatStyle.System;
            lbUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbUser.ForeColor = SystemColors.MenuText;
            lbUser.Location = new Point(151, 230);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(167, 45);
            lbUser.TabIndex = 3;
            lbUser.Text = "Username";
            // 
            // lbPwd
            // 
            lbPwd.AutoSize = true;
            lbPwd.FlatStyle = FlatStyle.System;
            lbPwd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbPwd.Location = new Point(151, 407);
            lbPwd.Name = "lbPwd";
            lbPwd.Size = new Size(157, 45);
            lbPwd.TabIndex = 4;
            lbPwd.Text = "Password";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.FlatStyle = FlatStyle.System;
            lbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTitle.Location = new Point(222, 116);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(291, 51);
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
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(btnSignUp);
            splitContainer1.Panel1.Controls.Add(btnEye);
            splitContainer1.Panel1.Controls.Add(lbTitle);
            splitContainer1.Panel1.Controls.Add(txtBoxPwd);
            splitContainer1.Panel1.Controls.Add(lbPwd);
            splitContainer1.Panel1.Controls.Add(btnLogin);
            splitContainer1.Panel1.Controls.Add(lbUser);
            splitContainer1.Panel1.Controls.Add(txtBoxUser);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Size = new Size(1429, 716);
            splitContainer1.SplitterDistance = 721;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 6;
            // 
            // btnSignUp
            // 
            btnSignUp.FlatStyle = FlatStyle.System;
            btnSignUp.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            btnSignUp.Location = new Point(151, 608);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(211, 44);
            btnSignUp.TabIndex = 8;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += BtnSignUp_Click;
            // 
            // btnEye
            // 
            btnEye.BackgroundImage = Properties.Resources.eye;
            btnEye.BackgroundImageLayout = ImageLayout.Stretch;
            btnEye.Location = new Point(588, 471);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(40, 40);
            btnEye.TabIndex = 7;
            btnEye.UseVisualStyleBackColor = true;
            btnEye.MouseDown += BtnEye_MouseDown;
            btnEye.MouseUp += BtnEye_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.digital_secure_background_lock_circle_icons_dark_blue_6837396;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(703, 716);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 716);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Password Vault";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private TextBox txtBoxUser;
        private TextBox txtBoxPwd;
        private Label lbUser;
        private Label lbPwd;
        private Label lbTitle;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Button btnEye;
        private Button btnSignUp;
    }
}