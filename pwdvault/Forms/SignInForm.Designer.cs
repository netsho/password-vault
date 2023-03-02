namespace pwdvault.Forms
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            lbTitle = new Label();
            btnGenerate = new Button();
            txtBoxPwd = new TextBox();
            txtBoxUser = new TextBox();
            btnSign = new Button();
            lbPwd = new Label();
            lbUsername = new Label();
            toolTip1 = new ToolTip(components);
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(113, 33);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(274, 38);
            lbTitle.TabIndex = 21;
            lbTitle.Text = "Create new account";
            // 
            // btnGenerate
            // 
            btnGenerate.FlatStyle = FlatStyle.System;
            btnGenerate.Location = new Point(131, 319);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(237, 62);
            btnGenerate.TabIndex = 20;
            btnGenerate.Text = "Generate random password";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtBoxPwd
            // 
            errorProvider.SetIconPadding(txtBoxPwd, 5);
            txtBoxPwd.Location = new Point(108, 269);
            txtBoxPwd.Name = "txtBoxPwd";
            txtBoxPwd.Size = new Size(284, 31);
            txtBoxPwd.TabIndex = 19;
            txtBoxPwd.TextChanged += txtBoxPwd_TextChanged;
            // 
            // txtBoxUser
            // 
            txtBoxUser.Location = new Point(108, 173);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(284, 31);
            txtBoxUser.TabIndex = 16;
            // 
            // btnSign
            // 
            btnSign.FlatStyle = FlatStyle.System;
            btnSign.Location = new Point(194, 483);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(112, 34);
            btnSign.TabIndex = 15;
            btnSign.Text = "Sign in";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // lbPwd
            // 
            lbPwd.AutoSize = true;
            lbPwd.FlatStyle = FlatStyle.System;
            lbPwd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPwd.Location = new Point(108, 234);
            lbPwd.Name = "lbPwd";
            lbPwd.Size = new Size(115, 32);
            lbPwd.TabIndex = 14;
            lbPwd.Text = "Password";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.FlatStyle = FlatStyle.System;
            lbUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUsername.Location = new Point(108, 138);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(124, 32);
            lbUsername.TabIndex = 11;
            lbUsername.Text = "Username";
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 544);
            Controls.Add(lbTitle);
            Controls.Add(btnGenerate);
            Controls.Add(txtBoxPwd);
            Controls.Add(txtBoxUser);
            Controls.Add(btnSign);
            Controls.Add(lbPwd);
            Controls.Add(lbUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign in";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Button btnGenerate;
        private TextBox txtBoxPwd;
        private TextBox txtBoxUser;
        private Button btnSign;
        private Label lbPwd;
        private Label lbUsername;
        private ToolTip toolTip1;
        private ErrorProvider errorProvider;
    }
}