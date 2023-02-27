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
            label12 = new Label();
            lbEntert = new Label();
            lbGames = new Label();
            lbEmail = new Label();
            lbFinance = new Label();
            lbRetail = new Label();
            lbSocial = new Label();
            lbStudy = new Label();
            lbWork = new Label();
            lbAdmin = new Label();
            label1 = new Label();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            lbTitleVault = new Label();
            lbTitlePwd = new Label();
            picBoxBackgroundCat = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBackgroundCat).BeginInit();
            groupBox1.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.GradientActiveCaption;
            splitContainer1.Panel1.Controls.Add(label12);
            splitContainer1.Panel1.Controls.Add(lbEntert);
            splitContainer1.Panel1.Controls.Add(lbGames);
            splitContainer1.Panel1.Controls.Add(lbEmail);
            splitContainer1.Panel1.Controls.Add(lbFinance);
            splitContainer1.Panel1.Controls.Add(lbRetail);
            splitContainer1.Panel1.Controls.Add(lbSocial);
            splitContainer1.Panel1.Controls.Add(lbStudy);
            splitContainer1.Panel1.Controls.Add(lbWork);
            splitContainer1.Panel1.Controls.Add(lbAdmin);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(lbTitleVault);
            splitContainer1.Panel1.Controls.Add(lbTitlePwd);
            splitContainer1.Panel1.Controls.Add(picBoxBackgroundCat);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Window;
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2.Controls.Add(panelTop);
            splitContainer1.Panel2.MouseDown += splitContainer1_Panel2_MouseDown;
            splitContainer1.Panel2.MouseMove += splitContainer1_Panel2_MouseMove;
            splitContainer1.Panel2.MouseUp += splitContainer1_Panel2_MouseUp;
            splitContainer1.Size = new Size(1717, 777);
            splitContainer1.SplitterDistance = 417;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(45, 223);
            label12.Name = "label12";
            label12.Size = new Size(129, 29);
            label12.TabIndex = 17;
            label12.Text = "Catégories";
            // 
            // lbEntert
            // 
            lbEntert.AutoSize = true;
            lbEntert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbEntert.Location = new Point(129, 675);
            lbEntert.Name = "lbEntert";
            lbEntert.Size = new Size(91, 32);
            lbEntert.TabIndex = 15;
            lbEntert.Text = "Coding";
            // 
            // lbGames
            // 
            lbGames.AutoSize = true;
            lbGames.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbGames.Location = new Point(129, 625);
            lbGames.Name = "lbGames";
            lbGames.Size = new Size(86, 32);
            lbGames.TabIndex = 14;
            lbGames.Text = "Games";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmail.Location = new Point(129, 575);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(122, 32);
            lbEmail.TabIndex = 13;
            lbEmail.Text = "Institution";
            // 
            // lbFinance
            // 
            lbFinance.AutoSize = true;
            lbFinance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbFinance.Location = new Point(129, 525);
            lbFinance.Name = "lbFinance";
            lbFinance.Size = new Size(96, 32);
            lbFinance.TabIndex = 12;
            lbFinance.Text = "Finance";
            // 
            // lbRetail
            // 
            lbRetail.AutoSize = true;
            lbRetail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbRetail.Location = new Point(129, 475);
            lbRetail.Name = "lbRetail";
            lbRetail.Size = new Size(72, 32);
            lbRetail.TabIndex = 11;
            lbRetail.Text = "Retail";
            // 
            // lbSocial
            // 
            lbSocial.AutoSize = true;
            lbSocial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbSocial.Location = new Point(129, 425);
            lbSocial.Name = "lbSocial";
            lbSocial.Size = new Size(86, 32);
            lbSocial.TabIndex = 10;
            lbSocial.Text = "Socials";
            // 
            // lbStudy
            // 
            lbStudy.AutoSize = true;
            lbStudy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbStudy.Location = new Point(129, 375);
            lbStudy.Name = "lbStudy";
            lbStudy.Size = new Size(74, 32);
            lbStudy.TabIndex = 9;
            lbStudy.Text = "Study";
            // 
            // lbWork
            // 
            lbWork.AutoSize = true;
            lbWork.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbWork.Location = new Point(129, 325);
            lbWork.Name = "lbWork";
            lbWork.Size = new Size(69, 32);
            lbWork.TabIndex = 8;
            lbWork.Text = "Work";
            // 
            // lbAdmin
            // 
            lbAdmin.AutoSize = true;
            lbAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbAdmin.Location = new Point(129, 275);
            lbAdmin.Name = "lbAdmin";
            lbAdmin.Size = new Size(167, 32);
            lbAdmin.TabIndex = 7;
            lbAdmin.Text = "Administrative";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(129, 154);
            label1.Name = "label1";
            label1.Size = new Size(41, 32);
            label1.TabIndex = 6;
            label1.Text = "All";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1187, 38);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(81, 36);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lock_main;
            pictureBox1.Location = new Point(45, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lbTitleVault
            // 
            lbTitleVault.AutoSize = true;
            lbTitleVault.Font = new Font("Bahnschrift SemiLight", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitleVault.Location = new Point(153, 68);
            lbTitleVault.Name = "lbTitleVault";
            lbTitleVault.Size = new Size(108, 39);
            lbTitleVault.TabIndex = 3;
            lbTitleVault.Text = "VAULT";
            lbTitleVault.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbTitlePwd
            // 
            lbTitlePwd.AutoSize = true;
            lbTitlePwd.Font = new Font("Bahnschrift SemiBold SemiConden", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitlePwd.Location = new Point(129, 29);
            lbTitlePwd.Name = "lbTitlePwd";
            lbTitlePwd.Size = new Size(158, 39);
            lbTitlePwd.TabIndex = 2;
            lbTitlePwd.Text = "PASSWORD";
            lbTitlePwd.TextAlign = ContentAlignment.TopCenter;
            // 
            // picBoxBackgroundCat
            // 
            picBoxBackgroundCat.BackgroundImage = Properties.Resources.background_categories;
            picBoxBackgroundCat.Dock = DockStyle.Fill;
            picBoxBackgroundCat.Location = new Point(0, 0);
            picBoxBackgroundCat.Name = "picBoxBackgroundCat";
            picBoxBackgroundCat.Size = new Size(417, 777);
            picBoxBackgroundCat.TabIndex = 1;
            picBoxBackgroundCat.TabStop = false;
            picBoxBackgroundCat.MouseDown += pictureBox1_MouseDown;
            picBoxBackgroundCat.MouseMove += pictureBox1_MouseMove;
            picBoxBackgroundCat.MouseUp += pictureBox1_MouseUp;
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
            panelTop.Controls.Add(btnExit);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1299, 113);
            panelTop.TabIndex = 0;
            panelTop.MouseDown += panelTop_MouseDown;
            panelTop.MouseMove += panelTop_MouseMove;
            panelTop.MouseUp += panelTop_MouseUp;
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
            btnAdd.Click += btnAdd_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1717, 777);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Vault";
            MouseDown += MainForm_MouseDown;
            MouseMove += MainForm_MouseMove;
            MouseUp += MainForm_MouseUp;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBackgroundCat).EndInit();
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
        private PictureBox picBoxBackgroundCat;
        private Label lbTitleVault;
        private Label lbTitlePwd;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Label lbSocial;
        private Label lbStudy;
        private Label lbWork;
        private Label lbAdmin;
        private Label label1;
        private Label label12;
        private Label lbEntert;
        private Label lbGames;
        private Label lbEmail;
        private Label lbFinance;
        private Label lbRetail;
    }
}