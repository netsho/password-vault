namespace pwdvault.Forms
{
    partial class EditPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPassword));
            lbTitle = new Label();
            btnGenerate = new Button();
            txtBoxPwd = new TextBox();
            txtBoxUser = new TextBox();
            comBoxCat = new ComboBox();
            txtBoxApp = new TextBox();
            btnEdit = new Button();
            lbPwd = new Label();
            lbUser = new Label();
            lbCategory = new Label();
            lbApp = new Label();
            btnEye = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(41, 24);
            lbTitle.Margin = new Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(205, 32);
            lbTitle.TabIndex = 21;
            lbTitle.Text = "Edit \"\" password";
            // 
            // btnGenerate
            // 
            btnGenerate.FlatStyle = FlatStyle.System;
            btnGenerate.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerate.Location = new Point(102, 389);
            btnGenerate.Margin = new Padding(2);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(190, 54);
            btnGenerate.TabIndex = 20;
            btnGenerate.Text = "GENERATE RANDOM PASSWORD";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += BtnGenerate_Click;
            // 
            // txtBoxPwd
            // 
            txtBoxPwd.Location = new Point(87, 358);
            txtBoxPwd.Margin = new Padding(2);
            txtBoxPwd.Name = "txtBoxPwd";
            txtBoxPwd.Size = new Size(257, 27);
            txtBoxPwd.TabIndex = 19;
            txtBoxPwd.UseSystemPasswordChar = true;
            txtBoxPwd.TextChanged += TxtBoxPwd_TextChanged;
            // 
            // txtBoxUser
            // 
            txtBoxUser.Location = new Point(87, 274);
            txtBoxUser.Margin = new Padding(2);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(228, 27);
            txtBoxUser.TabIndex = 18;
            // 
            // comBoxCat
            // 
            comBoxCat.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxCat.FlatStyle = FlatStyle.System;
            comBoxCat.FormattingEnabled = true;
            comBoxCat.Location = new Point(87, 188);
            comBoxCat.Margin = new Padding(2);
            comBoxCat.Name = "comBoxCat";
            comBoxCat.Size = new Size(228, 28);
            comBoxCat.TabIndex = 17;
            // 
            // txtBoxApp
            // 
            txtBoxApp.Location = new Point(87, 111);
            txtBoxApp.Margin = new Padding(2);
            txtBoxApp.Name = "txtBoxApp";
            txtBoxApp.Size = new Size(228, 27);
            txtBoxApp.TabIndex = 16;
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.System;
            btnEdit.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(129, 496);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(130, 27);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "SAVE";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // lbPwd
            // 
            lbPwd.AutoSize = true;
            lbPwd.FlatStyle = FlatStyle.System;
            lbPwd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPwd.Location = new Point(87, 330);
            lbPwd.Margin = new Padding(2, 0, 2, 0);
            lbPwd.Name = "lbPwd";
            lbPwd.Size = new Size(97, 28);
            lbPwd.TabIndex = 14;
            lbPwd.Text = "Password";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.FlatStyle = FlatStyle.System;
            lbUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUser.Location = new Point(87, 246);
            lbUser.Margin = new Padding(2, 0, 2, 0);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(172, 28);
            lbUser.TabIndex = 13;
            lbUser.Text = "Username / Email";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.FlatStyle = FlatStyle.System;
            lbCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCategory.Location = new Point(87, 160);
            lbCategory.Margin = new Padding(2, 0, 2, 0);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(94, 28);
            lbCategory.TabIndex = 12;
            lbCategory.Text = "Category";
            // 
            // lbApp
            // 
            lbApp.AutoSize = true;
            lbApp.FlatStyle = FlatStyle.System;
            lbApp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbApp.Location = new Point(87, 83);
            lbApp.Margin = new Padding(2, 0, 2, 0);
            lbApp.Name = "lbApp";
            lbApp.Size = new Size(114, 28);
            lbApp.TabIndex = 11;
            lbApp.Text = "Application";
            // 
            // btnEye
            // 
            btnEye.BackColor = Color.Transparent;
            btnEye.BackgroundImage = Properties.Resources.eye;
            btnEye.BackgroundImageLayout = ImageLayout.Stretch;
            btnEye.Location = new Point(318, 358);
            btnEye.Margin = new Padding(2);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(25, 26);
            btnEye.TabIndex = 23;
            btnEye.UseVisualStyleBackColor = false;
            btnEye.MouseDown += BtnEye_MouseDown;
            btnEye.MouseUp += BtnEye_MouseUp;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // EditPassword
            // 
            AcceptButton = btnEdit;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(382, 534);
            Controls.Add(btnEye);
            Controls.Add(lbTitle);
            Controls.Add(btnGenerate);
            Controls.Add(txtBoxPwd);
            Controls.Add(txtBoxUser);
            Controls.Add(comBoxCat);
            Controls.Add(txtBoxApp);
            Controls.Add(btnEdit);
            Controls.Add(lbPwd);
            Controls.Add(lbUser);
            Controls.Add(lbCategory);
            Controls.Add(lbApp);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit password";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Button btnGenerate;
        private TextBox txtBoxPwd;
        private TextBox txtBoxUser;
        private ComboBox comBoxCat;
        private TextBox txtBoxApp;
        private Button btnEdit;
        private Label lbPwd;
        private Label lbUser;
        private Label lbCategory;
        private Label lbApp;
        private Button btnEye;
        private ErrorProvider errorProvider;
    }
}