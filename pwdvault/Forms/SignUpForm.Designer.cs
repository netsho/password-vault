namespace pwdvault.Forms
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            lbTitle = new Label();
            btnGenerate = new Button();
            txtBoxPwd = new TextBox();
            txtBoxUser = new TextBox();
            btnSign = new Button();
            lbPwd = new Label();
            lbUsername = new Label();
            toolTip1 = new ToolTip(components);
            errorProvider = new ErrorProvider(components);
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(94, 31);
            lbTitle.Margin = new Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(274, 38);
            lbTitle.TabIndex = 21;
            lbTitle.Text = "Create new account";
            // 
            // btnGenerate
            // 
            btnGenerate.FlatStyle = FlatStyle.System;
            btnGenerate.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerate.Location = new Point(126, 308);
            btnGenerate.Margin = new Padding(2);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(246, 68);
            btnGenerate.TabIndex = 20;
            btnGenerate.Text = "GENERATE RANDOM PASSWORD";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += BtnGenerate_Click;
            // 
            // txtBoxPwd
            // 
            errorProvider.SetIconPadding(txtBoxPwd, 5);
            txtBoxPwd.Location = new Point(108, 269);
            txtBoxPwd.Margin = new Padding(2);
            txtBoxPwd.Name = "txtBoxPwd";
            txtBoxPwd.Size = new Size(284, 31);
            txtBoxPwd.TabIndex = 19;
            txtBoxPwd.TextChanged += TxtBoxPwd_TextChanged;
            // 
            // txtBoxUser
            // 
            txtBoxUser.Location = new Point(108, 172);
            txtBoxUser.Margin = new Padding(2);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(284, 31);
            txtBoxUser.TabIndex = 16;
            // 
            // btnSign
            // 
            btnSign.FlatStyle = FlatStyle.System;
            btnSign.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSign.Location = new Point(108, 442);
            btnSign.Margin = new Padding(2);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(131, 34);
            btnSign.TabIndex = 15;
            btnSign.Text = "SIGN UP";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += BtnSign_Click;
            // 
            // lbPwd
            // 
            lbPwd.AutoSize = true;
            lbPwd.FlatStyle = FlatStyle.System;
            lbPwd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPwd.Location = new Point(108, 234);
            lbPwd.Margin = new Padding(2, 0, 2, 0);
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
            lbUsername.Margin = new Padding(2, 0, 2, 0);
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
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.System;
            btnCancel.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(261, 442);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 34);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // SignUpForm
            // 
            AcceptButton = btnSign;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 511);
            Controls.Add(btnCancel);
            Controls.Add(lbTitle);
            Controls.Add(btnGenerate);
            Controls.Add(txtBoxPwd);
            Controls.Add(txtBoxUser);
            Controls.Add(btnSign);
            Controls.Add(lbPwd);
            Controls.Add(lbUsername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignUpForm";
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
        private Button btnCancel;
    }
}