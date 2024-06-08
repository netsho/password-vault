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
            lbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTitle.Location = new Point(66, 38);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(320, 51);
            lbTitle.TabIndex = 21;
            lbTitle.Text = "Edit \"\" password";
            // 
            // btnGenerate
            // 
            btnGenerate.FlatStyle = FlatStyle.System;
            btnGenerate.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            btnGenerate.Location = new Point(166, 622);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(309, 87);
            btnGenerate.TabIndex = 20;
            btnGenerate.Text = "GENERATE RANDOM PASSWORD";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += BtnGenerate_Click;
            // 
            // txtBoxPwd
            // 
            txtBoxPwd.Location = new Point(142, 573);
            txtBoxPwd.Name = "txtBoxPwd";
            txtBoxPwd.Size = new Size(415, 39);
            txtBoxPwd.TabIndex = 19;
            txtBoxPwd.UseSystemPasswordChar = true;
            txtBoxPwd.TextChanged += TxtBoxPwd_TextChanged;
            // 
            // txtBoxUser
            // 
            txtBoxUser.Location = new Point(142, 438);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(368, 39);
            txtBoxUser.TabIndex = 18;
            // 
            // comBoxCat
            // 
            comBoxCat.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxCat.FlatStyle = FlatStyle.System;
            comBoxCat.FormattingEnabled = true;
            comBoxCat.Location = new Point(142, 301);
            comBoxCat.Name = "comBoxCat";
            comBoxCat.Size = new Size(368, 40);
            comBoxCat.TabIndex = 17;
            // 
            // txtBoxApp
            // 
            txtBoxApp.Location = new Point(142, 178);
            txtBoxApp.Name = "txtBoxApp";
            txtBoxApp.Size = new Size(368, 39);
            txtBoxApp.TabIndex = 16;
            // 
            // btnEdit
            // 
            btnEdit.DialogResult = DialogResult.OK;
            btnEdit.FlatStyle = FlatStyle.System;
            btnEdit.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            btnEdit.Location = new Point(209, 794);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(211, 44);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "SAVE";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            // 
            // lbPwd
            // 
            lbPwd.AutoSize = true;
            lbPwd.FlatStyle = FlatStyle.System;
            lbPwd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbPwd.Location = new Point(142, 527);
            lbPwd.Name = "lbPwd";
            lbPwd.Size = new Size(157, 45);
            lbPwd.TabIndex = 14;
            lbPwd.Text = "Password";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.FlatStyle = FlatStyle.System;
            lbUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbUser.Location = new Point(142, 394);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(276, 45);
            lbUser.TabIndex = 13;
            lbUser.Text = "Username / Email";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.FlatStyle = FlatStyle.System;
            lbCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbCategory.Location = new Point(142, 256);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(153, 45);
            lbCategory.TabIndex = 12;
            lbCategory.Text = "Category";
            // 
            // lbApp
            // 
            lbApp.AutoSize = true;
            lbApp.FlatStyle = FlatStyle.System;
            lbApp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbApp.Location = new Point(142, 133);
            lbApp.Name = "lbApp";
            lbApp.Size = new Size(185, 45);
            lbApp.TabIndex = 11;
            lbApp.Text = "Application";
            // 
            // btnEye
            // 
            btnEye.BackColor = Color.Transparent;
            btnEye.BackgroundImage = Properties.Resources.eye;
            btnEye.BackgroundImageLayout = ImageLayout.Stretch;
            btnEye.Location = new Point(517, 573);
            btnEye.Name = "btnEye";
            btnEye.Size = new Size(40, 41);
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
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(621, 855);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            MinimizeBox = false;
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