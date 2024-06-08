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
            lbApp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbApp.Location = new Point(130, 133);
            lbApp.Name = "lbApp";
            lbApp.Size = new Size(185, 45);
            lbApp.TabIndex = 0;
            lbApp.Text = "Application";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.FlatStyle = FlatStyle.System;
            lbCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbCategory.Location = new Point(130, 256);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(153, 45);
            lbCategory.TabIndex = 1;
            lbCategory.Text = "Category";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.FlatStyle = FlatStyle.System;
            lbUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbUser.Location = new Point(130, 394);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(276, 45);
            lbUser.TabIndex = 2;
            lbUser.Text = "Username / Email";
            // 
            // lbPwd
            // 
            lbPwd.AutoSize = true;
            lbPwd.FlatStyle = FlatStyle.System;
            lbPwd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbPwd.Location = new Point(130, 527);
            lbPwd.Name = "lbPwd";
            lbPwd.Size = new Size(157, 45);
            lbPwd.TabIndex = 3;
            lbPwd.Text = "Password";
            // 
            // btnAdd
            // 
            btnAdd.DialogResult = DialogResult.OK;
            btnAdd.FlatStyle = FlatStyle.System;
            btnAdd.Font = new Font("Bahnschrift SemiBold", 9F);
            btnAdd.Location = new Point(207, 795);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(211, 44);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // txtBoxApp
            // 
            txtBoxApp.Location = new Point(130, 178);
            txtBoxApp.Name = "txtBoxApp";
            txtBoxApp.Size = new Size(368, 39);
            txtBoxApp.TabIndex = 5;
            // 
            // comBoxCat
            // 
            comBoxCat.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxCat.FlatStyle = FlatStyle.System;
            comBoxCat.FormattingEnabled = true;
            comBoxCat.Location = new Point(130, 301);
            comBoxCat.Name = "comBoxCat";
            comBoxCat.Size = new Size(368, 40);
            comBoxCat.TabIndex = 6;
            // 
            // txtBoxUser
            // 
            txtBoxUser.Location = new Point(130, 438);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(368, 39);
            txtBoxUser.TabIndex = 7;
            // 
            // txtBoxPwd
            // 
            errorProvider.SetIconPadding(txtBoxPwd, 5);
            txtBoxPwd.Location = new Point(130, 573);
            txtBoxPwd.Name = "txtBoxPwd";
            txtBoxPwd.Size = new Size(368, 39);
            txtBoxPwd.TabIndex = 8;
            txtBoxPwd.TextChanged += TxtBoxPwd_TextChanged;
            // 
            // btnGenerate
            // 
            btnGenerate.FlatStyle = FlatStyle.System;
            btnGenerate.Font = new Font("Bahnschrift SemiBold", 9F);
            btnGenerate.Location = new Point(144, 637);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(338, 84);
            btnGenerate.TabIndex = 9;
            btnGenerate.Text = "GENERATE RANDOM PASSWORD";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += BtnGenerate_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTitle.Location = new Point(42, 32);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(361, 51);
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
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(621, 888);
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
            Margin = new Padding(5, 5, 5, 5);
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