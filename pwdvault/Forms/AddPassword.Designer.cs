﻿namespace pwdvault.Forms
{
    partial class AddPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPassword));
            lbApp = new Label();
            lbCategory = new Label();
            lbUser = new Label();
            lbPwd = new Label();
            btnAdd = new Button();
            txtBoxApp = new TextBox();
            comBoxCat = new ComboBox();
            txtBoxUser = new TextBox();
            txtBoxPwd = new TextBox();
            btnGenerate = new Button();
            lbTitle = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lbApp
            // 
            lbApp.AutoSize = true;
            lbApp.FlatStyle = FlatStyle.System;
            lbApp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbApp.Location = new Point(100, 104);
            lbApp.Margin = new Padding(2, 0, 2, 0);
            lbApp.Name = "lbApp";
            lbApp.Size = new Size(137, 32);
            lbApp.TabIndex = 0;
            lbApp.Text = "Application";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.FlatStyle = FlatStyle.System;
            lbCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCategory.Location = new Point(100, 200);
            lbCategory.Margin = new Padding(2, 0, 2, 0);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(114, 32);
            lbCategory.TabIndex = 1;
            lbCategory.Text = "Category";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.FlatStyle = FlatStyle.System;
            lbUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUser.Location = new Point(100, 308);
            lbUser.Margin = new Padding(2, 0, 2, 0);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(206, 32);
            lbUser.TabIndex = 2;
            lbUser.Text = "Username / Email";
            // 
            // lbPwd
            // 
            lbPwd.AutoSize = true;
            lbPwd.FlatStyle = FlatStyle.System;
            lbPwd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPwd.Location = new Point(100, 412);
            lbPwd.Margin = new Padding(2, 0, 2, 0);
            lbPwd.Name = "lbPwd";
            lbPwd.Size = new Size(115, 32);
            lbPwd.TabIndex = 3;
            lbPwd.Text = "Password";
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.System;
            btnAdd.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(159, 621);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 34);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // txtBoxApp
            // 
            txtBoxApp.Location = new Point(100, 139);
            txtBoxApp.Margin = new Padding(2);
            txtBoxApp.Name = "txtBoxApp";
            txtBoxApp.Size = new Size(284, 31);
            txtBoxApp.TabIndex = 5;
            // 
            // comBoxCat
            // 
            comBoxCat.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxCat.FlatStyle = FlatStyle.System;
            comBoxCat.FormattingEnabled = true;
            comBoxCat.Location = new Point(100, 235);
            comBoxCat.Margin = new Padding(2);
            comBoxCat.Name = "comBoxCat";
            comBoxCat.Size = new Size(284, 33);
            comBoxCat.TabIndex = 6;
            // 
            // txtBoxUser
            // 
            txtBoxUser.Location = new Point(100, 342);
            txtBoxUser.Margin = new Padding(2);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(284, 31);
            txtBoxUser.TabIndex = 7;
            // 
            // txtBoxPwd
            // 
            errorProvider.SetIconPadding(txtBoxPwd, 5);
            txtBoxPwd.Location = new Point(100, 448);
            txtBoxPwd.Margin = new Padding(2);
            txtBoxPwd.Name = "txtBoxPwd";
            txtBoxPwd.Size = new Size(284, 31);
            txtBoxPwd.TabIndex = 8;
            txtBoxPwd.TextChanged += TxtBoxPwd_TextChanged;
            // 
            // btnGenerate
            // 
            btnGenerate.FlatStyle = FlatStyle.System;
            btnGenerate.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerate.Location = new Point(111, 498);
            btnGenerate.Margin = new Padding(2);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(260, 66);
            btnGenerate.TabIndex = 9;
            btnGenerate.Text = "GENERATE RANDOM PASSWORD";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += BtnGenerate_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(32, 25);
            lbTitle.Margin = new Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(264, 38);
            lbTitle.TabIndex = 10;
            lbTitle.Text = "Add new password";
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // AddPassword
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(478, 694);
            Controls.Add(lbTitle);
            Controls.Add(btnGenerate);
            Controls.Add(txtBoxPwd);
            Controls.Add(txtBoxUser);
            Controls.Add(comBoxCat);
            Controls.Add(txtBoxApp);
            Controls.Add(btnAdd);
            Controls.Add(lbPwd);
            Controls.Add(lbUser);
            Controls.Add(lbCategory);
            Controls.Add(lbApp);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New password";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbApp;
        private Label lbCategory;
        private Label lbUser;
        private Label lbPwd;
        private Button btnAdd;
        private TextBox txtBoxApp;
        private ComboBox comBoxCat;
        private TextBox txtBoxUser;
        private TextBox txtBoxPwd;
        private Button btnGenerate;
        private Label lbTitle;
        private ErrorProvider errorProvider;
    }
}