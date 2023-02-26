namespace pwdvault.Forms
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
            SuspendLayout();
            // 
            // lbApp
            // 
            lbApp.AutoSize = true;
            lbApp.FlatStyle = FlatStyle.System;
            lbApp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbApp.Location = new Point(100, 104);
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
            lbPwd.Location = new Point(100, 413);
            lbPwd.Name = "lbPwd";
            lbPwd.Size = new Size(115, 32);
            lbPwd.TabIndex = 3;
            lbPwd.Text = "Password";
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.System;
            btnAdd.Location = new Point(185, 613);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtBoxApp
            // 
            txtBoxApp.Location = new Point(100, 139);
            txtBoxApp.Name = "txtBoxApp";
            txtBoxApp.Size = new Size(284, 31);
            txtBoxApp.TabIndex = 5;
            // 
            // comBoxCat
            // 
            comBoxCat.FlatStyle = FlatStyle.System;
            comBoxCat.FormattingEnabled = true;
            comBoxCat.Location = new Point(100, 235);
            comBoxCat.Name = "comBoxCat";
            comBoxCat.Size = new Size(284, 33);
            comBoxCat.TabIndex = 6;
            // 
            // txtBoxUser
            // 
            txtBoxUser.Location = new Point(100, 343);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(284, 31);
            txtBoxUser.TabIndex = 7;
            // 
            // txtBoxPwd
            // 
            txtBoxPwd.Location = new Point(100, 448);
            txtBoxPwd.Name = "txtBoxPwd";
            txtBoxPwd.Size = new Size(284, 31);
            txtBoxPwd.TabIndex = 8;
            // 
            // btnGenerate
            // 
            btnGenerate.FlatStyle = FlatStyle.System;
            btnGenerate.Location = new Point(124, 496);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(237, 62);
            btnGenerate.TabIndex = 9;
            btnGenerate.Text = "Generate random password";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(33, 25);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(264, 38);
            lbTitle.TabIndex = 10;
            lbTitle.Text = "Add new password";
            // 
            // AddPassword
            // 
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AddPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New password";
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
    }
}