namespace pwdvault.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            lbTitle = new Label();
            groupBox1 = new GroupBox();
            btnCopyPwd = new Button();
            btnCopyUser = new Button();
            btnEyePwd = new Button();
            lbPwdFilled = new Label();
            lbUserFilled = new Label();
            lbPwd = new Label();
            lbUser = new Label();
            panelTop = new Panel();
            btnFilter = new Button();
            txtBoxFilter = new TextBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.GradientActiveCaption;
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(lbTitle);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Window;
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2.Controls.Add(panelTop);
            splitContainer1.Size = new Size(1717, 777);
            splitContainer1.SplitterDistance = 417;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(220, 324);
            label1.Name = "label1";
            label1.Size = new Size(88, 38);
            label1.TabIndex = 1;
            label1.Text = "All";
            // 
            // lbTitle
            // 
            lbTitle.Dock = DockStyle.Top;
            lbTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.ForeColor = Color.AliceBlue;
            lbTitle.Image = Properties.Resources.background_main;
            lbTitle.Location = new Point(0, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(417, 175);
            lbTitle.TabIndex = 0;
            lbTitle.TextAlign = ContentAlignment.BottomCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCopyPwd);
            groupBox1.Controls.Add(btnCopyUser);
            groupBox1.Controls.Add(btnEyePwd);
            groupBox1.Controls.Add(lbPwdFilled);
            groupBox1.Controls.Add(lbUserFilled);
            groupBox1.Controls.Add(lbPwd);
            groupBox1.Controls.Add(lbUser);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(33, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1235, 140);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Paypal";
            // 
            // btnCopyPwd
            // 
            btnCopyPwd.FlatStyle = FlatStyle.System;
            btnCopyPwd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopyPwd.Location = new Point(1085, 87);
            btnCopyPwd.Name = "btnCopyPwd";
            btnCopyPwd.Size = new Size(144, 34);
            btnCopyPwd.TabIndex = 6;
            btnCopyPwd.Text = "Copy password";
            btnCopyPwd.UseVisualStyleBackColor = true;
            // 
            // btnCopyUser
            // 
            btnCopyUser.FlatStyle = FlatStyle.System;
            btnCopyUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopyUser.Location = new Point(447, 87);
            btnCopyUser.Name = "btnCopyUser";
            btnCopyUser.Size = new Size(154, 34);
            btnCopyUser.TabIndex = 4;
            btnCopyUser.Text = "Copy username";
            btnCopyUser.UseVisualStyleBackColor = true;
            btnCopyUser.Click += btnCopyUser_Click;
            // 
            // btnEyePwd
            // 
            btnEyePwd.BackgroundImage = Properties.Resources.eye;
            btnEyePwd.BackgroundImageLayout = ImageLayout.Stretch;
            btnEyePwd.Location = new Point(1045, 87);
            btnEyePwd.Name = "btnEyePwd";
            btnEyePwd.Size = new Size(34, 34);
            btnEyePwd.TabIndex = 3;
            btnEyePwd.UseVisualStyleBackColor = true;
            // 
            // lbPwdFilled
            // 
            lbPwdFilled.AutoSize = true;
            lbPwdFilled.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbPwdFilled.Location = new Point(751, 57);
            lbPwdFilled.Name = "lbPwdFilled";
            lbPwdFilled.Size = new Size(268, 28);
            lbPwdFilled.TabIndex = 5;
            lbPwdFilled.Text = "testtesttesttestetstrtbfdfgytyt";
            // 
            // lbUserFilled
            // 
            lbUserFilled.AutoSize = true;
            lbUserFilled.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbUserFilled.Location = new Point(175, 58);
            lbUserFilled.Name = "lbUserFilled";
            lbUserFilled.Size = new Size(252, 28);
            lbUserFilled.TabIndex = 3;
            lbUserFilled.Text = "oussamabricha@gmail.com";
            // 
            // lbPwd
            // 
            lbPwd.AutoSize = true;
            lbPwd.Location = new Point(630, 54);
            lbPwd.Name = "lbPwd";
            lbPwd.Size = new Size(115, 32);
            lbPwd.TabIndex = 4;
            lbPwd.Text = "Password";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Location = new Point(45, 54);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(124, 32);
            lbUser.TabIndex = 3;
            lbUser.Text = "Username";
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnFilter);
            panelTop.Controls.Add(txtBoxFilter);
            panelTop.Controls.Add(btnAdd);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1296, 113);
            panelTop.TabIndex = 0;
            // 
            // btnFilter
            // 
            btnFilter.BackgroundImage = Properties.Resources.magnifying_glass;
            btnFilter.BackgroundImageLayout = ImageLayout.Stretch;
            btnFilter.Location = new Point(881, 40);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(35, 34);
            btnFilter.TabIndex = 2;
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // txtBoxFilter
            // 
            txtBoxFilter.Location = new Point(396, 40);
            txtBoxFilter.Name = "txtBoxFilter";
            txtBoxFilter.PlaceholderText = "Filter";
            txtBoxFilter.Size = new Size(479, 31);
            txtBoxFilter.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.HotTrack;
            btnAdd.FlatStyle = FlatStyle.System;
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(78, 29);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 53);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add password";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1717, 777);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Vault";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panelTop;
        private Button btnAdd;
        private Button btnFilter;
        private TextBox txtBoxFilter;
        private GroupBox groupBox1;
        private Label lbPwdFilled;
        private Label lbUserFilled;
        private Label lbPwd;
        private Label lbUser;
        private Button btnCopyPwd;
        private Button btnCopyUser;
        private Button btnEyePwd;
        private Label lbTitle;
        private Label label1;
    }
}