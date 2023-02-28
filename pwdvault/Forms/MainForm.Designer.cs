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
            label2 = new Label();
            lbCatTitle = new Label();
            lbEntert = new Label();
            lbGames = new Label();
            lbFinance = new Label();
            lbRetail = new Label();
            lbSocial = new Label();
            lbStudy = new Label();
            lbWork = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lbTitleVault = new Label();
            lbTitlePwd = new Label();
            picBoxBackgroundCat = new PictureBox();
            separator = new Label();
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
            btnExit = new Button();
            saveFileDialog1 = new SaveFileDialog();
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
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(lbCatTitle);
            splitContainer1.Panel1.Controls.Add(lbEntert);
            splitContainer1.Panel1.Controls.Add(lbGames);
            splitContainer1.Panel1.Controls.Add(lbFinance);
            splitContainer1.Panel1.Controls.Add(lbRetail);
            splitContainer1.Panel1.Controls.Add(lbSocial);
            splitContainer1.Panel1.Controls.Add(lbStudy);
            splitContainer1.Panel1.Controls.Add(lbWork);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(lbTitleVault);
            splitContainer1.Panel1.Controls.Add(lbTitlePwd);
            splitContainer1.Panel1.Controls.Add(picBoxBackgroundCat);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(separator);
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
            // label2
            // 
            label2.BackColor = Color.FromArgb(103, 138, 178);
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Image = Properties.Resources.institution;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(82, 285);
            label2.Name = "label2";
            label2.Size = new Size(244, 34);
            label2.TabIndex = 9;
            label2.Text = "Administrative";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbCatTitle
            // 
            lbCatTitle.AutoSize = true;
            lbCatTitle.BackColor = Color.FromArgb(103, 138, 178);
            lbCatTitle.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbCatTitle.ForeColor = Color.White;
            lbCatTitle.Location = new Point(34, 211);
            lbCatTitle.Name = "lbCatTitle";
            lbCatTitle.Size = new Size(192, 43);
            lbCatTitle.TabIndex = 17;
            lbCatTitle.Text = "Categories";
            // 
            // lbEntert
            // 
            lbEntert.BackColor = Color.FromArgb(103, 138, 178);
            lbEntert.Cursor = Cursors.Hand;
            lbEntert.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbEntert.Image = Properties.Resources.coding;
            lbEntert.ImageAlign = ContentAlignment.MiddleLeft;
            lbEntert.Location = new Point(82, 635);
            lbEntert.Name = "lbEntert";
            lbEntert.Size = new Size(156, 32);
            lbEntert.TabIndex = 15;
            lbEntert.Text = "Coding";
            lbEntert.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbGames
            // 
            lbGames.BackColor = Color.FromArgb(103, 138, 178);
            lbGames.Cursor = Cursors.Hand;
            lbGames.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbGames.Image = Properties.Resources.console;
            lbGames.ImageAlign = ContentAlignment.MiddleLeft;
            lbGames.Location = new Point(82, 585);
            lbGames.Name = "lbGames";
            lbGames.Size = new Size(158, 32);
            lbGames.TabIndex = 14;
            lbGames.Text = "Games";
            lbGames.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbFinance
            // 
            lbFinance.BackColor = Color.FromArgb(103, 138, 178);
            lbFinance.Cursor = Cursors.Hand;
            lbFinance.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbFinance.Image = Properties.Resources.euro;
            lbFinance.ImageAlign = ContentAlignment.MiddleLeft;
            lbFinance.Location = new Point(82, 525);
            lbFinance.Name = "lbFinance";
            lbFinance.Size = new Size(167, 50);
            lbFinance.TabIndex = 12;
            lbFinance.Text = "Finance";
            lbFinance.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbRetail
            // 
            lbRetail.BackColor = Color.FromArgb(103, 138, 178);
            lbRetail.Cursor = Cursors.Hand;
            lbRetail.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbRetail.Image = Properties.Resources.shopping_bag;
            lbRetail.ImageAlign = ContentAlignment.MiddleLeft;
            lbRetail.Location = new Point(82, 475);
            lbRetail.Name = "lbRetail";
            lbRetail.Size = new Size(146, 50);
            lbRetail.TabIndex = 11;
            lbRetail.Text = "Retail";
            lbRetail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbSocial
            // 
            lbSocial.BackColor = Color.FromArgb(103, 138, 178);
            lbSocial.Cursor = Cursors.Hand;
            lbSocial.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSocial.Image = Properties.Resources.internet;
            lbSocial.ImageAlign = ContentAlignment.MiddleLeft;
            lbSocial.Location = new Point(82, 425);
            lbSocial.Name = "lbSocial";
            lbSocial.Size = new Size(161, 50);
            lbSocial.TabIndex = 10;
            lbSocial.Text = "Socials";
            lbSocial.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbStudy
            // 
            lbStudy.BackColor = Color.FromArgb(103, 138, 178);
            lbStudy.Cursor = Cursors.Hand;
            lbStudy.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbStudy.Image = Properties.Resources.graduation_cap;
            lbStudy.ImageAlign = ContentAlignment.MiddleLeft;
            lbStudy.Location = new Point(82, 385);
            lbStudy.Name = "lbStudy";
            lbStudy.Size = new Size(146, 32);
            lbStudy.TabIndex = 9;
            lbStudy.Text = "Study";
            lbStudy.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbWork
            // 
            lbWork.BackColor = Color.FromArgb(103, 138, 178);
            lbWork.Cursor = Cursors.Hand;
            lbWork.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbWork.ForeColor = Color.Black;
            lbWork.Image = Properties.Resources.portfolio;
            lbWork.ImageAlign = ContentAlignment.MiddleLeft;
            lbWork.Location = new Point(81, 335);
            lbWork.Name = "lbWork";
            lbWork.Size = new Size(143, 34);
            lbWork.TabIndex = 8;
            lbWork.Text = "Work";
            lbWork.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(103, 138, 178);
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Image = Properties.Resources.app1;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(81, 155);
            label1.Name = "label1";
            label1.Size = new Size(124, 49);
            label1.TabIndex = 6;
            label1.Text = "All";
            label1.TextAlign = ContentAlignment.MiddleRight;
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
            lbTitleVault.BackColor = Color.FromArgb(103, 138, 178);
            lbTitleVault.Font = new Font("Bahnschrift SemiLight", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitleVault.ForeColor = Color.White;
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
            lbTitlePwd.BackColor = Color.FromArgb(103, 138, 178);
            lbTitlePwd.Font = new Font("Bahnschrift SemiBold SemiConden", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitlePwd.ForeColor = Color.White;
            lbTitlePwd.Location = new Point(129, 29);
            lbTitlePwd.Name = "lbTitlePwd";
            lbTitlePwd.Size = new Size(158, 39);
            lbTitlePwd.TabIndex = 2;
            lbTitlePwd.Text = "PASSWORD";
            lbTitlePwd.TextAlign = ContentAlignment.TopCenter;
            // 
            // picBoxBackgroundCat
            // 
            picBoxBackgroundCat.BackColor = Color.FromArgb(103, 138, 178);
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
            // separator
            // 
            separator.BorderStyle = BorderStyle.Fixed3D;
            separator.Location = new Point(15, 111);
            separator.Name = "separator";
            separator.Size = new Size(1272, 2);
            separator.TabIndex = 3;
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
        private Label label1;
        private Label lbCatTitle;
        private Label lbEntert;
        private Label lbGames;
        private Label lbFinance;
        private Label lbRetail;
        private SaveFileDialog saveFileDialog1;
        private Label separator;
        private Label label2;
    }
}