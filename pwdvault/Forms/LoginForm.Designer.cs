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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btConnect
            // 
            btConnect.FlatStyle = FlatStyle.System;
            btConnect.Location = new Point(362, 414);
            btConnect.Name = "btConnect";
            btConnect.Size = new Size(163, 34);
            btConnect.TabIndex = 0;
            btConnect.Text = "Se connecter";
            btConnect.UseVisualStyleBackColor = true;
            // 
            // txtBoxUser
            // 
            txtBoxUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxUser.Location = new Point(280, 172);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(330, 31);
            txtBoxUser.TabIndex = 1;
            // 
            // txtBoxPwd
            // 
            txtBoxPwd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPwd.Location = new Point(280, 313);
            txtBoxPwd.Name = "txtBoxPwd";
            txtBoxPwd.PasswordChar = '*';
            txtBoxPwd.Size = new Size(330, 31);
            txtBoxPwd.TabIndex = 2;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.FlatStyle = FlatStyle.System;
            lbUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUser.ForeColor = SystemColors.MenuText;
            lbUser.Location = new Point(280, 126);
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
            lbPwd.Location = new Point(280, 264);
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
            lbTitle.Location = new Point(335, 37);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(215, 38);
            lbTitle.TabIndex = 5;
            lbTitle.Text = "Password Vault";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.ed8a3323_2e23_4d7d_b292_f9d2bafb5d92;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(897, 511);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 511);
            Controls.Add(lbTitle);
            Controls.Add(lbPwd);
            Controls.Add(lbUser);
            Controls.Add(txtBoxPwd);
            Controls.Add(txtBoxUser);
            Controls.Add(btConnect);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connexion - Password Vault";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btConnect;
        private TextBox txtBoxUser;
        private TextBox txtBoxPwd;
        private Label lbUser;
        private Label lbPwd;
        private Label lbTitle;
        private PictureBox pictureBox1;
    }
}