﻿namespace pwdvault.Forms
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            splitContainer1 = new SplitContainer();
            allTable = new TableLayoutPanel();
            allPicture = new PictureBox();
            lbAll = new Label();
            lbSelectedAll = new Label();
            lbCatTitle = new Label();
            categoriesTable = new TableLayoutPanel();
            lbSocial = new Label();
            lbAdmini = new Label();
            lbRetail = new Label();
            lbCoding = new Label();
            pictureAdmin = new PictureBox();
            lbFinance = new Label();
            pictureWork = new PictureBox();
            pictureStudy = new PictureBox();
            pictureSocials = new PictureBox();
            pictureRetail = new PictureBox();
            pictureFinance = new PictureBox();
            lbStudy = new Label();
            pictureGames = new PictureBox();
            lbWork = new Label();
            lbGames = new Label();
            pictureCoding = new PictureBox();
            lbSelectedAdmini = new Label();
            lbSelectedWork = new Label();
            lbSelectedStudy = new Label();
            lbSelectedSocials = new Label();
            lbSelectedRetail = new Label();
            lbSelectedFinance = new Label();
            lbSelectedGames = new Label();
            lbSelectedCoding = new Label();
            picBoxLogo = new PictureBox();
            lbTitlePwd = new Label();
            lbTitleVault = new Label();
            listPwdPanel = new Panel();
            separator = new Label();
            panelTop = new Panel();
            txtBoxFilter = new TextBox();
            btnAdd = new Button();
            btnExit = new Button();
            saveFileDialog1 = new SaveFileDialog();
            toolTipExit = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            allTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allPicture).BeginInit();
            categoriesTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureWork).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureStudy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureSocials).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureRetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureFinance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureGames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureCoding).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
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
            splitContainer1.Panel1.BackColor = Color.FromArgb(195, 141, 158);
            splitContainer1.Panel1.Controls.Add(allTable);
            splitContainer1.Panel1.Controls.Add(lbCatTitle);
            splitContainer1.Panel1.Controls.Add(categoriesTable);
            splitContainer1.Panel1.Controls.Add(picBoxLogo);
            splitContainer1.Panel1.Controls.Add(lbTitlePwd);
            splitContainer1.Panel1.Controls.Add(lbTitleVault);
            splitContainer1.Panel1.MouseDown += MainForm_MouseDown;
            splitContainer1.Panel1.MouseMove += MainForm_MouseMove;
            splitContainer1.Panel1.MouseUp += MainForm_MouseUp;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(listPwdPanel);
            splitContainer1.Panel2.Controls.Add(separator);
            splitContainer1.Panel2.Controls.Add(panelTop);
            splitContainer1.Size = new Size(1389, 750);
            splitContainer1.SplitterDistance = 337;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            // 
            // allTable
            // 
            allTable.ColumnCount = 3;
            allTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            allTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
            allTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.5F));
            allTable.Controls.Add(allPicture, 1, 0);
            allTable.Controls.Add(lbAll, 2, 0);
            allTable.Controls.Add(lbSelectedAll, 0, 0);
            allTable.Location = new Point(56, 122);
            allTable.Name = "allTable";
            allTable.RowCount = 1;
            allTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            allTable.Size = new Size(252, 53);
            allTable.TabIndex = 18;
            // 
            // allPicture
            // 
            allPicture.Cursor = Cursors.Hand;
            allPicture.Dock = DockStyle.Fill;
            allPicture.Image = Properties.Resources.icons8_apps_tab_48;
            allPicture.Location = new Point(12, 0);
            allPicture.Margin = new Padding(0);
            allPicture.Name = "allPicture";
            allPicture.Size = new Size(69, 53);
            allPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            allPicture.TabIndex = 0;
            allPicture.TabStop = false;
            allPicture.Click += lbAll_Click;
            // 
            // lbAll
            // 
            lbAll.AutoSize = true;
            lbAll.BackColor = Color.FromArgb(195, 141, 158);
            lbAll.Cursor = Cursors.Hand;
            lbAll.Dock = DockStyle.Fill;
            lbAll.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbAll.ForeColor = Color.Black;
            lbAll.ImageAlign = ContentAlignment.MiddleLeft;
            lbAll.Location = new Point(81, 0);
            lbAll.Margin = new Padding(0);
            lbAll.Name = "lbAll";
            lbAll.Size = new Size(171, 53);
            lbAll.TabIndex = 6;
            lbAll.Text = "All";
            lbAll.TextAlign = ContentAlignment.MiddleCenter;
            lbAll.Click += lbAll_Click;
            // 
            // lbSelectedAll
            // 
            lbSelectedAll.AutoSize = true;
            lbSelectedAll.Dock = DockStyle.Fill;
            lbSelectedAll.Location = new Point(3, 0);
            lbSelectedAll.Name = "lbSelectedAll";
            lbSelectedAll.Size = new Size(6, 53);
            lbSelectedAll.TabIndex = 7;
            // 
            // lbCatTitle
            // 
            lbCatTitle.AutoSize = true;
            lbCatTitle.BackColor = Color.FromArgb(195, 141, 158);
            lbCatTitle.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbCatTitle.ForeColor = Color.White;
            lbCatTitle.Location = new Point(22, 190);
            lbCatTitle.Name = "lbCatTitle";
            lbCatTitle.Size = new Size(192, 43);
            lbCatTitle.TabIndex = 17;
            lbCatTitle.Text = "Categories";
            // 
            // categoriesTable
            // 
            categoriesTable.ColumnCount = 3;
            categoriesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            categoriesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
            categoriesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.5F));
            categoriesTable.Controls.Add(lbSocial, 2, 3);
            categoriesTable.Controls.Add(lbAdmini, 2, 0);
            categoriesTable.Controls.Add(lbRetail, 2, 4);
            categoriesTable.Controls.Add(lbCoding, 2, 7);
            categoriesTable.Controls.Add(pictureAdmin, 1, 0);
            categoriesTable.Controls.Add(lbFinance, 2, 5);
            categoriesTable.Controls.Add(pictureWork, 1, 1);
            categoriesTable.Controls.Add(pictureStudy, 1, 2);
            categoriesTable.Controls.Add(pictureSocials, 1, 3);
            categoriesTable.Controls.Add(pictureRetail, 1, 4);
            categoriesTable.Controls.Add(pictureFinance, 1, 5);
            categoriesTable.Controls.Add(lbStudy, 2, 2);
            categoriesTable.Controls.Add(pictureGames, 1, 6);
            categoriesTable.Controls.Add(lbWork, 2, 1);
            categoriesTable.Controls.Add(lbGames, 2, 6);
            categoriesTable.Controls.Add(pictureCoding, 1, 7);
            categoriesTable.Controls.Add(lbSelectedAdmini, 0, 0);
            categoriesTable.Controls.Add(lbSelectedWork, 0, 1);
            categoriesTable.Controls.Add(lbSelectedStudy, 0, 2);
            categoriesTable.Controls.Add(lbSelectedSocials, 0, 3);
            categoriesTable.Controls.Add(lbSelectedRetail, 0, 4);
            categoriesTable.Controls.Add(lbSelectedFinance, 0, 5);
            categoriesTable.Controls.Add(lbSelectedGames, 0, 6);
            categoriesTable.Controls.Add(lbSelectedCoding, 0, 7);
            categoriesTable.Location = new Point(56, 254);
            categoriesTable.Name = "categoriesTable";
            categoriesTable.RowCount = 8;
            categoriesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            categoriesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            categoriesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            categoriesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            categoriesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            categoriesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            categoriesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            categoriesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            categoriesTable.Size = new Size(252, 461);
            categoriesTable.TabIndex = 0;
            // 
            // lbSocial
            // 
            lbSocial.AutoSize = true;
            lbSocial.BackColor = Color.FromArgb(195, 141, 158);
            lbSocial.Cursor = Cursors.Hand;
            lbSocial.Dock = DockStyle.Fill;
            lbSocial.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSocial.ImageAlign = ContentAlignment.MiddleLeft;
            lbSocial.Location = new Point(81, 171);
            lbSocial.Margin = new Padding(0);
            lbSocial.Name = "lbSocial";
            lbSocial.Size = new Size(171, 57);
            lbSocial.TabIndex = 10;
            lbSocial.Text = "Socials";
            lbSocial.TextAlign = ContentAlignment.MiddleCenter;
            lbSocial.Click += lbSocial_Click;
            // 
            // lbAdmini
            // 
            lbAdmini.AutoSize = true;
            lbAdmini.BackColor = Color.FromArgb(195, 141, 158);
            lbAdmini.Cursor = Cursors.Hand;
            lbAdmini.Dock = DockStyle.Fill;
            lbAdmini.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbAdmini.ForeColor = Color.Black;
            lbAdmini.ImageAlign = ContentAlignment.MiddleLeft;
            lbAdmini.Location = new Point(81, 0);
            lbAdmini.Margin = new Padding(0);
            lbAdmini.Name = "lbAdmini";
            lbAdmini.Size = new Size(171, 57);
            lbAdmini.TabIndex = 9;
            lbAdmini.Text = "Administrative";
            lbAdmini.TextAlign = ContentAlignment.MiddleCenter;
            lbAdmini.Click += lbAdmini_Click;
            // 
            // lbRetail
            // 
            lbRetail.AutoSize = true;
            lbRetail.BackColor = Color.FromArgb(195, 141, 158);
            lbRetail.Cursor = Cursors.Hand;
            lbRetail.Dock = DockStyle.Fill;
            lbRetail.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbRetail.ImageAlign = ContentAlignment.MiddleLeft;
            lbRetail.Location = new Point(81, 228);
            lbRetail.Margin = new Padding(0);
            lbRetail.Name = "lbRetail";
            lbRetail.Size = new Size(171, 57);
            lbRetail.TabIndex = 11;
            lbRetail.Text = "Retail";
            lbRetail.TextAlign = ContentAlignment.MiddleCenter;
            lbRetail.Click += lbRetail_Click;
            // 
            // lbCoding
            // 
            lbCoding.AutoSize = true;
            lbCoding.BackColor = Color.FromArgb(195, 141, 158);
            lbCoding.Cursor = Cursors.Hand;
            lbCoding.Dock = DockStyle.Fill;
            lbCoding.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCoding.ImageAlign = ContentAlignment.MiddleLeft;
            lbCoding.Location = new Point(81, 399);
            lbCoding.Margin = new Padding(0);
            lbCoding.Name = "lbCoding";
            lbCoding.Size = new Size(171, 62);
            lbCoding.TabIndex = 15;
            lbCoding.Text = "Coding";
            lbCoding.TextAlign = ContentAlignment.MiddleCenter;
            lbCoding.Click += lbCoding_Click;
            // 
            // pictureAdmin
            // 
            pictureAdmin.Cursor = Cursors.Hand;
            pictureAdmin.Dock = DockStyle.Fill;
            pictureAdmin.Image = Properties.Resources.icons8_stack_of_paper_48;
            pictureAdmin.Location = new Point(12, 0);
            pictureAdmin.Margin = new Padding(0);
            pictureAdmin.Name = "pictureAdmin";
            pictureAdmin.Size = new Size(69, 57);
            pictureAdmin.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureAdmin.TabIndex = 17;
            pictureAdmin.TabStop = false;
            pictureAdmin.Click += lbAdmini_Click;
            // 
            // lbFinance
            // 
            lbFinance.AutoSize = true;
            lbFinance.BackColor = Color.FromArgb(195, 141, 158);
            lbFinance.Cursor = Cursors.Hand;
            lbFinance.Dock = DockStyle.Fill;
            lbFinance.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbFinance.ImageAlign = ContentAlignment.MiddleLeft;
            lbFinance.Location = new Point(81, 285);
            lbFinance.Margin = new Padding(0);
            lbFinance.Name = "lbFinance";
            lbFinance.Size = new Size(171, 57);
            lbFinance.TabIndex = 12;
            lbFinance.Text = "Finance";
            lbFinance.TextAlign = ContentAlignment.MiddleCenter;
            lbFinance.Click += lbFinance_Click;
            // 
            // pictureWork
            // 
            pictureWork.Cursor = Cursors.Hand;
            pictureWork.Dock = DockStyle.Fill;
            pictureWork.Image = Properties.Resources.icons8_briefcase_48;
            pictureWork.Location = new Point(12, 57);
            pictureWork.Margin = new Padding(0);
            pictureWork.Name = "pictureWork";
            pictureWork.Size = new Size(69, 57);
            pictureWork.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureWork.TabIndex = 18;
            pictureWork.TabStop = false;
            pictureWork.Click += lbWork_Click;
            // 
            // pictureStudy
            // 
            pictureStudy.Cursor = Cursors.Hand;
            pictureStudy.Dock = DockStyle.Fill;
            pictureStudy.Image = Properties.Resources.icons8_books_48;
            pictureStudy.Location = new Point(12, 114);
            pictureStudy.Margin = new Padding(0);
            pictureStudy.Name = "pictureStudy";
            pictureStudy.Size = new Size(69, 57);
            pictureStudy.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureStudy.TabIndex = 19;
            pictureStudy.TabStop = false;
            pictureStudy.Click += lbStudy_Click;
            // 
            // pictureSocials
            // 
            pictureSocials.Cursor = Cursors.Hand;
            pictureSocials.Dock = DockStyle.Fill;
            pictureSocials.Image = Properties.Resources.icons8_internet_48;
            pictureSocials.Location = new Point(12, 171);
            pictureSocials.Margin = new Padding(0);
            pictureSocials.Name = "pictureSocials";
            pictureSocials.Size = new Size(69, 57);
            pictureSocials.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureSocials.TabIndex = 20;
            pictureSocials.TabStop = false;
            pictureSocials.Click += lbSocial_Click;
            // 
            // pictureRetail
            // 
            pictureRetail.Cursor = Cursors.Hand;
            pictureRetail.Dock = DockStyle.Fill;
            pictureRetail.Image = Properties.Resources.icons8_shopping_bag_48;
            pictureRetail.Location = new Point(12, 228);
            pictureRetail.Margin = new Padding(0);
            pictureRetail.Name = "pictureRetail";
            pictureRetail.Size = new Size(69, 57);
            pictureRetail.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureRetail.TabIndex = 21;
            pictureRetail.TabStop = false;
            pictureRetail.Click += lbRetail_Click;
            // 
            // pictureFinance
            // 
            pictureFinance.Cursor = Cursors.Hand;
            pictureFinance.Dock = DockStyle.Fill;
            pictureFinance.Image = Properties.Resources.icons8_banknotes_48;
            pictureFinance.Location = new Point(12, 285);
            pictureFinance.Margin = new Padding(0);
            pictureFinance.Name = "pictureFinance";
            pictureFinance.Size = new Size(69, 57);
            pictureFinance.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureFinance.TabIndex = 16;
            pictureFinance.TabStop = false;
            pictureFinance.Click += lbFinance_Click;
            // 
            // lbStudy
            // 
            lbStudy.AutoSize = true;
            lbStudy.BackColor = Color.FromArgb(195, 141, 158);
            lbStudy.Cursor = Cursors.Hand;
            lbStudy.Dock = DockStyle.Fill;
            lbStudy.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbStudy.ImageAlign = ContentAlignment.MiddleLeft;
            lbStudy.Location = new Point(81, 114);
            lbStudy.Margin = new Padding(0);
            lbStudy.Name = "lbStudy";
            lbStudy.Size = new Size(171, 57);
            lbStudy.TabIndex = 9;
            lbStudy.Text = "Study";
            lbStudy.TextAlign = ContentAlignment.MiddleCenter;
            lbStudy.Click += lbStudy_Click;
            // 
            // pictureGames
            // 
            pictureGames.Cursor = Cursors.Hand;
            pictureGames.Dock = DockStyle.Fill;
            pictureGames.Image = Properties.Resources.icons8_game_controller_48;
            pictureGames.Location = new Point(12, 342);
            pictureGames.Margin = new Padding(0);
            pictureGames.Name = "pictureGames";
            pictureGames.Size = new Size(69, 57);
            pictureGames.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureGames.TabIndex = 0;
            pictureGames.TabStop = false;
            pictureGames.Click += lbGames_Click;
            // 
            // lbWork
            // 
            lbWork.AutoSize = true;
            lbWork.BackColor = Color.FromArgb(195, 141, 158);
            lbWork.Cursor = Cursors.Hand;
            lbWork.Dock = DockStyle.Fill;
            lbWork.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbWork.ForeColor = Color.Black;
            lbWork.ImageAlign = ContentAlignment.MiddleLeft;
            lbWork.Location = new Point(81, 57);
            lbWork.Margin = new Padding(0);
            lbWork.Name = "lbWork";
            lbWork.Size = new Size(171, 57);
            lbWork.TabIndex = 8;
            lbWork.Text = "Work";
            lbWork.TextAlign = ContentAlignment.MiddleCenter;
            lbWork.Click += lbWork_Click;
            // 
            // lbGames
            // 
            lbGames.AutoSize = true;
            lbGames.BackColor = Color.FromArgb(195, 141, 158);
            lbGames.Cursor = Cursors.Hand;
            lbGames.Dock = DockStyle.Fill;
            lbGames.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbGames.ImageAlign = ContentAlignment.MiddleLeft;
            lbGames.Location = new Point(81, 342);
            lbGames.Margin = new Padding(0);
            lbGames.Name = "lbGames";
            lbGames.Size = new Size(171, 57);
            lbGames.TabIndex = 14;
            lbGames.Text = "Games";
            lbGames.TextAlign = ContentAlignment.MiddleCenter;
            lbGames.Click += lbGames_Click;
            // 
            // pictureCoding
            // 
            pictureCoding.Cursor = Cursors.Hand;
            pictureCoding.Dock = DockStyle.Fill;
            pictureCoding.Image = Properties.Resources.icons8_console_48;
            pictureCoding.Location = new Point(12, 399);
            pictureCoding.Margin = new Padding(0);
            pictureCoding.Name = "pictureCoding";
            pictureCoding.Size = new Size(69, 62);
            pictureCoding.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureCoding.TabIndex = 22;
            pictureCoding.TabStop = false;
            pictureCoding.Click += lbCoding_Click;
            // 
            // lbSelectedAdmini
            // 
            lbSelectedAdmini.AutoSize = true;
            lbSelectedAdmini.Dock = DockStyle.Fill;
            lbSelectedAdmini.Location = new Point(3, 0);
            lbSelectedAdmini.Name = "lbSelectedAdmini";
            lbSelectedAdmini.Size = new Size(6, 57);
            lbSelectedAdmini.TabIndex = 23;
            // 
            // lbSelectedWork
            // 
            lbSelectedWork.AutoSize = true;
            lbSelectedWork.Dock = DockStyle.Fill;
            lbSelectedWork.Location = new Point(3, 57);
            lbSelectedWork.Name = "lbSelectedWork";
            lbSelectedWork.Size = new Size(6, 57);
            lbSelectedWork.TabIndex = 24;
            // 
            // lbSelectedStudy
            // 
            lbSelectedStudy.AutoSize = true;
            lbSelectedStudy.Dock = DockStyle.Fill;
            lbSelectedStudy.Location = new Point(3, 114);
            lbSelectedStudy.Name = "lbSelectedStudy";
            lbSelectedStudy.Size = new Size(6, 57);
            lbSelectedStudy.TabIndex = 25;
            // 
            // lbSelectedSocials
            // 
            lbSelectedSocials.AutoSize = true;
            lbSelectedSocials.Dock = DockStyle.Fill;
            lbSelectedSocials.Location = new Point(3, 171);
            lbSelectedSocials.Name = "lbSelectedSocials";
            lbSelectedSocials.Size = new Size(6, 57);
            lbSelectedSocials.TabIndex = 26;
            // 
            // lbSelectedRetail
            // 
            lbSelectedRetail.AutoSize = true;
            lbSelectedRetail.Dock = DockStyle.Fill;
            lbSelectedRetail.Location = new Point(3, 228);
            lbSelectedRetail.Name = "lbSelectedRetail";
            lbSelectedRetail.Size = new Size(6, 57);
            lbSelectedRetail.TabIndex = 27;
            // 
            // lbSelectedFinance
            // 
            lbSelectedFinance.AutoSize = true;
            lbSelectedFinance.Dock = DockStyle.Fill;
            lbSelectedFinance.Location = new Point(3, 285);
            lbSelectedFinance.Name = "lbSelectedFinance";
            lbSelectedFinance.Size = new Size(6, 57);
            lbSelectedFinance.TabIndex = 28;
            // 
            // lbSelectedGames
            // 
            lbSelectedGames.AutoSize = true;
            lbSelectedGames.Dock = DockStyle.Fill;
            lbSelectedGames.Location = new Point(3, 342);
            lbSelectedGames.Name = "lbSelectedGames";
            lbSelectedGames.Size = new Size(6, 57);
            lbSelectedGames.TabIndex = 29;
            // 
            // lbSelectedCoding
            // 
            lbSelectedCoding.AutoSize = true;
            lbSelectedCoding.Dock = DockStyle.Fill;
            lbSelectedCoding.Location = new Point(3, 399);
            lbSelectedCoding.Name = "lbSelectedCoding";
            lbSelectedCoding.Size = new Size(6, 62);
            lbSelectedCoding.TabIndex = 30;
            // 
            // picBoxLogo
            // 
            picBoxLogo.Image = Properties.Resources.lock_main;
            picBoxLogo.Location = new Point(50, 9);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(78, 78);
            picBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxLogo.TabIndex = 4;
            picBoxLogo.TabStop = false;
            // 
            // lbTitlePwd
            // 
            lbTitlePwd.AutoSize = true;
            lbTitlePwd.BackColor = Color.FromArgb(195, 141, 158);
            lbTitlePwd.Font = new Font("Bahnschrift SemiBold SemiConden", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitlePwd.ForeColor = Color.White;
            lbTitlePwd.Location = new Point(134, 9);
            lbTitlePwd.Name = "lbTitlePwd";
            lbTitlePwd.Size = new Size(158, 39);
            lbTitlePwd.TabIndex = 2;
            lbTitlePwd.Text = "PASSWORD";
            lbTitlePwd.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbTitleVault
            // 
            lbTitleVault.AutoSize = true;
            lbTitleVault.BackColor = Color.FromArgb(195, 141, 158);
            lbTitleVault.Font = new Font("Bahnschrift SemiLight", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitleVault.ForeColor = Color.White;
            lbTitleVault.Location = new Point(158, 48);
            lbTitleVault.Name = "lbTitleVault";
            lbTitleVault.Size = new Size(108, 39);
            lbTitleVault.TabIndex = 3;
            lbTitleVault.Text = "VAULT";
            lbTitleVault.TextAlign = ContentAlignment.TopCenter;
            // 
            // listPwdPanel
            // 
            listPwdPanel.AutoScroll = true;
            listPwdPanel.Dock = DockStyle.Fill;
            listPwdPanel.Location = new Point(0, 90);
            listPwdPanel.Name = "listPwdPanel";
            listPwdPanel.Size = new Size(1051, 660);
            listPwdPanel.TabIndex = 4;
            listPwdPanel.MouseDown += MainForm_MouseDown;
            listPwdPanel.MouseMove += MainForm_MouseMove;
            listPwdPanel.MouseUp += MainForm_MouseUp;
            // 
            // separator
            // 
            separator.BorderStyle = BorderStyle.Fixed3D;
            separator.Location = new Point(15, 89);
            separator.Name = "separator";
            separator.Size = new Size(1025, 2);
            separator.TabIndex = 3;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(txtBoxFilter);
            panelTop.Controls.Add(btnAdd);
            panelTop.Controls.Add(btnExit);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1051, 90);
            panelTop.TabIndex = 0;
            panelTop.MouseDown += MainForm_MouseDown;
            panelTop.MouseMove += MainForm_MouseMove;
            panelTop.MouseUp += MainForm_MouseUp;
            // 
            // txtBoxFilter
            // 
            txtBoxFilter.Location = new Point(349, 27);
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
            btnAdd.Location = new Point(83, 16);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 53);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add password";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = Properties.Resources.icons8_logout_48;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.Location = new Point(964, 21);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(48, 48);
            btnExit.TabIndex = 5;
            toolTipExit.SetToolTip(btnExit, "Exit the application");
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 750);
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
            allTable.ResumeLayout(false);
            allTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)allPicture).EndInit();
            categoriesTable.ResumeLayout(false);
            categoriesTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureWork).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureStudy).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureSocials).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureRetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureFinance).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureGames).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureCoding).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panelTop;
        private Button btnAdd;
        private TextBox txtBoxFilter;
        private Label lbTitleVault;
        private Label lbTitlePwd;
        private PictureBox picBoxLogo;
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
        private TableLayoutPanel categoriesTable;
        private PictureBox pictureGames;
        private PictureBox pictureAdmin;
        private PictureBox pictureWork;
        private PictureBox pictureStudy;
        private PictureBox pictureSocials;
        private PictureBox pictureRetail;
        private PictureBox pictureFinance;
        private PictureBox pictureCoding;
        private TableLayoutPanel allTable;
        private PictureBox allPicture;
        private ToolTip toolTipExit;
        private Label lbSelectedAll;
        private Label lbSelectedAdmini;
        private Label lbSelectedWork;
        private Label lbSelectedStudy;
        private Label lbSelectedSocials;
        private Label lbSelectedRetail;
        private Label lbSelectedFinance;
        private Label lbSelectedGames;
        private Label lbSelectedCoding;
    }
}