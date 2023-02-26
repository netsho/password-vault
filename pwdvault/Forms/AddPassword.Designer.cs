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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnGenerate = new Button();
            SuspendLayout();
            // 
            // lbApp
            // 
            lbApp.AutoSize = true;
            lbApp.FlatStyle = FlatStyle.System;
            lbApp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbApp.Location = new Point(105, 54);
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
            lbCategory.Location = new Point(105, 170);
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
            lbUser.Location = new Point(105, 294);
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
            lbPwd.Location = new Point(105, 416);
            lbPwd.Name = "lbPwd";
            lbPwd.Size = new Size(115, 32);
            lbPwd.TabIndex = 3;
            lbPwd.Text = "Password";
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.System;
            btnAdd.Location = new Point(190, 623);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 31);
            textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(105, 205);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(284, 33);
            comboBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 329);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(105, 451);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(284, 31);
            textBox3.TabIndex = 8;
            // 
            // btnGenerate
            // 
            btnGenerate.FlatStyle = FlatStyle.System;
            btnGenerate.Location = new Point(129, 499);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(237, 62);
            btnGenerate.TabIndex = 9;
            btnGenerate.Text = "Generate random password";
            btnGenerate.UseVisualStyleBackColor = true;
            // 
            // AddPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(478, 694);
            Controls.Add(btnGenerate);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnGenerate;
    }
}