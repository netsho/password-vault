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
            lbAdmini = new Label();
            lbCatTitle = new Label();
            lbCoding = new Label();
            lbGames = new Label();
            lbFinance = new Label();
            lbRetail = new Label();
            lbSocial = new Label();
            lbStudy = new Label();
            lbWork = new Label();
            lbAll = new Label();
            pictureBox1 = new PictureBox();
            lbTitleVault = new Label();
            lbTitlePwd = new Label();
            picBoxBackgroundCat = new PictureBox();
            listPwdPanel = new Panel();
            separator = new Label();
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
            splitContainer1.Panel1.Controls.Add(lbAdmini);
            splitContainer1.Panel1.Controls.Add(lbCatTitle);
            splitContainer1.Panel1.Controls.Add(lbCoding);
            splitContainer1.Panel1.Controls.Add(lbGames);
            splitContainer1.Panel1.Controls.Add(lbFinance);
            splitContainer1.Panel1.Controls.Add(lbRetail);
            splitContainer1.Panel1.Controls.Add(lbSocial);
            splitContainer1.Panel1.Controls.Add(lbStudy);
            splitContainer1.Panel1.Controls.Add(lbWork);
            splitContainer1.Panel1.Controls.Add(lbAll);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(lbTitleVault);
            splitContainer1.Panel1.Controls.Add(lbTitlePwd);
            splitContainer1.Panel1.Controls.Add(picBoxBackgroundCat);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(listPwdPanel);
            splitContainer1.Panel2.Controls.Add(separator);
            splitContainer1.Panel2.Controls.Add(panelTop);
            splitContainer1.Panel2.MouseDown += splitContainer1_Panel2_MouseDown;
            splitContainer1.Panel2.MouseMove += splitContainer1_Panel2_MouseMove;
            splitContainer1.Panel2.MouseUp += splitContainer1_Panel2_MouseUp;
            splitContainer1.Size = new Size(1717, 777);
            splitContainer1.SplitterDistance = 417;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            // 
            // lbAdmini
            // 
            lbAdmini.BackColor = Color.FromArgb(103, 138, 178);
            lbAdmini.Cursor = Cursors.Hand;
            lbAdmini.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbAdmini.ForeColor = Color.Black;
            lbAdmini.Image = Properties.Resources.institution;
            lbAdmini.ImageAlign = ContentAlignment.MiddleLeft;
            lbAdmini.Location = new Point(82, 280);
            lbAdmini.Name = "lbAdmini";
            lbAdmini.Size = new Size(244, 40);
            lbAdmini.TabIndex = 9;
            lbAdmini.Text = "Administrative";
            lbAdmini.TextAlign = ContentAlignment.MiddleRight;
            lbAdmini.Click += lbAdmini_Click;
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
            // lbCoding
            // 
            lbCoding.BackColor = Color.FromArgb(103, 138, 178);
            lbCoding.Cursor = Cursors.Hand;
            lbCoding.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCoding.Image = Properties.Resources.coding;
            lbCoding.ImageAlign = ContentAlignment.MiddleLeft;
            lbCoding.Location = new Point(82, 625);
            lbCoding.Name = "lbCoding";
            lbCoding.Size = new Size(156, 40);
            lbCoding.TabIndex = 15;
            lbCoding.Text = "Coding";
            lbCoding.TextAlign = ContentAlignment.MiddleRight;
            lbCoding.Click += lbCoding_Click;
            // 
            // lbGames
            // 
            lbGames.BackColor = Color.FromArgb(103, 138, 178);
            lbGames.Cursor = Cursors.Hand;
            lbGames.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbGames.Image = Properties.Resources.console;
            lbGames.ImageAlign = ContentAlignment.MiddleLeft;
            lbGames.Location = new Point(82, 575);
            lbGames.Name = "lbGames";
            lbGames.Size = new Size(158, 40);
            lbGames.TabIndex = 14;
            lbGames.Text = "Games";
            lbGames.TextAlign = ContentAlignment.MiddleRight;
            lbGames.Click += lbGames_Click;
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
            lbFinance.Size = new Size(167, 40);
            lbFinance.TabIndex = 12;
            lbFinance.Text = "Finance";
            lbFinance.TextAlign = ContentAlignment.MiddleRight;
            lbFinance.Click += lbFinance_Click;
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
            lbRetail.Size = new Size(146, 40);
            lbRetail.TabIndex = 11;
            lbRetail.Text = "Retail";
            lbRetail.TextAlign = ContentAlignment.MiddleRight;
            lbRetail.Click += lbRetail_Click;
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
            lbSocial.Size = new Size(161, 40);
            lbSocial.TabIndex = 10;
            lbSocial.Text = "Socials";
            lbSocial.TextAlign = ContentAlignment.MiddleRight;
            lbSocial.Click += lbSocial_Click;
            // 
            // lbStudy
            // 
            lbStudy.BackColor = Color.FromArgb(103, 138, 178);
            lbStudy.Cursor = Cursors.Hand;
            lbStudy.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbStudy.Image = Properties.Resources.graduation_cap;
            lbStudy.ImageAlign = ContentAlignment.MiddleLeft;
            lbStudy.Location = new Point(82, 380);
            lbStudy.Name = "lbStudy";
            lbStudy.Size = new Size(146, 40);
            lbStudy.TabIndex = 9;
            lbStudy.Text = "Study";
            lbStudy.TextAlign = ContentAlignment.MiddleRight;
            lbStudy.Click += lbStudy_Click;
            // 
            // lbWork
            // 
            lbWork.BackColor = Color.FromArgb(103, 138, 178);
            lbWork.Cursor = Cursors.Hand;
            lbWork.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbWork.ForeColor = Color.Black;
            lbWork.Image = Properties.Resources.portfolio;
            lbWork.ImageAlign = ContentAlignment.MiddleLeft;
            lbWork.Location = new Point(81, 330);
            lbWork.Name = "lbWork";
            lbWork.Size = new Size(143, 40);
            lbWork.TabIndex = 8;
            lbWork.Text = "Work";
            lbWork.TextAlign = ContentAlignment.MiddleRight;
            lbWork.Click += lbWork_Click;
            // 
            // lbAll
            // 
            lbAll.BackColor = Color.FromArgb(103, 138, 178);
            lbAll.Cursor = Cursors.Hand;
            lbAll.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbAll.ForeColor = Color.Black;
            lbAll.Image = Properties.Resources.app1;
            lbAll.ImageAlign = ContentAlignment.MiddleLeft;
            lbAll.Location = new Point(81, 155);
            lbAll.Name = "lbAll";
            lbAll.Size = new Size(124, 49);
            lbAll.TabIndex = 6;
            lbAll.Text = "All";
            lbAll.TextAlign = ContentAlignment.MiddleRight;
            lbAll.Click += lbAll_Click;
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
            // listPwdPanel
            // 
            listPwdPanel.AutoScroll = true;
            listPwdPanel.Location = new Point(0, 119);
            listPwdPanel.Name = "listPwdPanel";
            listPwdPanel.Size = new Size(1299, 658);
            listPwdPanel.TabIndex = 4;
            listPwdPanel.MouseDown += MainForm_MouseDown;
            listPwdPanel.MouseMove += MainForm_MouseMove;
            listPwdPanel.MouseUp += MainForm_MouseUp;
            // 
            // separator
            // 
            separator.BorderStyle = BorderStyle.Fixed3D;
            separator.Location = new Point(15, 111);
            separator.Name = "separator";
            separator.Size = new Size(1272, 2);
            separator.TabIndex = 3;
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
            // 
            // txtBoxFilter
            // 
            txtBoxFilter.Location = new Point(396, 40);
            txtBoxFilter.Name = "txtBoxFilter";
            txtBoxFilter.PlaceholderText = "Filter by application or website name";
            txtBoxFilter.Size = new Size(479, 31);
            txtBoxFilter.TabIndex = 1;
            txtBoxFilter.TextChanged += txtBoxFilter_TextChanged;
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
        private PictureBox picBoxBackgroundCat;
        private Label lbTitleVault;
        private Label lbTitlePwd;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Label lbSocial;
        private Label lbStudy;
        private Label lbWork;
        private Label lbAll;
        private Label lbCatTitle;
        private Label lbCoding;
        private Label lbGames;
        private Label lbFinance;
        private Label lbRetail;
        private SaveFileDialog saveFileDialog1;
        private Label separator;
        private Label lbAdmini;
        private Panel listPwdPanel;
    }
}