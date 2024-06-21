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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            splitContainer1 = new SplitContainer();
            lbVersion = new Label();
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
            lbCount = new Label();
            lbTitleCount = new Label();
            btnImport = new Button();
            btnExport = new Button();
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
            splitContainer1.Panel1.Controls.Add(lbVersion);
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
            splitContainer1.Size = new Size(1805, 960);
            splitContainer1.SplitterDistance = 435;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 0;
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbVersion.Location = new Point(353, 80);
            lbVersion.Margin = new Padding(5, 0, 5, 0);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(66, 29);
            lbVersion.TabIndex = 19;
            lbVersion.Text = "V1.3.1";
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
            allTable.Location = new Point(73, 157);
            allTable.Name = "allTable";
            allTable.RowCount = 1;
            allTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            allTable.Size = new Size(328, 67);
            allTable.TabIndex = 18;
            // 
            // allPicture
            // 
            allPicture.Cursor = Cursors.Hand;
            allPicture.Dock = DockStyle.Fill;
            allPicture.Image = Properties.Resources.icons8_apps_tab_48;
            allPicture.Location = new Point(16, 0);
            allPicture.Margin = new Padding(0);
            allPicture.Name = "allPicture";
            allPicture.Size = new Size(90, 67);
            allPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            allPicture.TabIndex = 0;
            allPicture.TabStop = false;
            allPicture.Click += LbAll_Click;
            // 
            // lbAll
            // 
            lbAll.AutoSize = true;
            lbAll.BackColor = Color.FromArgb(195, 141, 158);
            lbAll.Cursor = Cursors.Hand;
            lbAll.Dock = DockStyle.Fill;
            lbAll.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold);
            lbAll.ForeColor = Color.Black;
            lbAll.ImageAlign = ContentAlignment.MiddleLeft;
            lbAll.Location = new Point(106, 0);
            lbAll.Margin = new Padding(0);
            lbAll.Name = "lbAll";
            lbAll.Size = new Size(222, 67);
            lbAll.TabIndex = 6;
            lbAll.Text = "All";
            lbAll.TextAlign = ContentAlignment.MiddleCenter;
            lbAll.Click += LbAll_Click;
            // 
            // lbSelectedAll
            // 
            lbSelectedAll.AutoSize = true;
            lbSelectedAll.Dock = DockStyle.Fill;
            lbSelectedAll.Location = new Point(3, 0);
            lbSelectedAll.Name = "lbSelectedAll";
            lbSelectedAll.Size = new Size(10, 67);
            lbSelectedAll.TabIndex = 7;
            // 
            // lbCatTitle
            // 
            lbCatTitle.AutoSize = true;
            lbCatTitle.BackColor = Color.FromArgb(195, 141, 158);
            lbCatTitle.Font = new Font("Bahnschrift", 18F, FontStyle.Bold);
            lbCatTitle.ForeColor = Color.White;
            lbCatTitle.Location = new Point(29, 243);
            lbCatTitle.Name = "lbCatTitle";
            lbCatTitle.Size = new Size(258, 58);
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
            categoriesTable.Location = new Point(73, 325);
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
            categoriesTable.Size = new Size(328, 590);
            categoriesTable.TabIndex = 0;
            // 
            // lbSocial
            // 
            lbSocial.AutoSize = true;
            lbSocial.BackColor = Color.FromArgb(195, 141, 158);
            lbSocial.Cursor = Cursors.Hand;
            lbSocial.Dock = DockStyle.Fill;
            lbSocial.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold);
            lbSocial.ImageAlign = ContentAlignment.MiddleLeft;
            lbSocial.Location = new Point(106, 219);
            lbSocial.Margin = new Padding(0);
            lbSocial.Name = "lbSocial";
            lbSocial.Size = new Size(222, 73);
            lbSocial.TabIndex = 10;
            lbSocial.Text = "Socials";
            lbSocial.TextAlign = ContentAlignment.MiddleCenter;
            lbSocial.Click += LbSocial_Click;
            // 
            // lbAdmini
            // 
            lbAdmini.AutoSize = true;
            lbAdmini.BackColor = Color.FromArgb(195, 141, 158);
            lbAdmini.Cursor = Cursors.Hand;
            lbAdmini.Dock = DockStyle.Fill;
            lbAdmini.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold);
            lbAdmini.ForeColor = Color.Black;
            lbAdmini.ImageAlign = ContentAlignment.MiddleLeft;
            lbAdmini.Location = new Point(106, 0);
            lbAdmini.Margin = new Padding(0);
            lbAdmini.Name = "lbAdmini";
            lbAdmini.Size = new Size(222, 73);
            lbAdmini.TabIndex = 9;
            lbAdmini.Text = "Administrative";
            lbAdmini.TextAlign = ContentAlignment.MiddleCenter;
            lbAdmini.Click += LbAdmini_Click;
            // 
            // lbRetail
            // 
            lbRetail.AutoSize = true;
            lbRetail.BackColor = Color.FromArgb(195, 141, 158);
            lbRetail.Cursor = Cursors.Hand;
            lbRetail.Dock = DockStyle.Fill;
            lbRetail.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold);
            lbRetail.ImageAlign = ContentAlignment.MiddleLeft;
            lbRetail.Location = new Point(106, 292);
            lbRetail.Margin = new Padding(0);
            lbRetail.Name = "lbRetail";
            lbRetail.Size = new Size(222, 73);
            lbRetail.TabIndex = 11;
            lbRetail.Text = "Retail";
            lbRetail.TextAlign = ContentAlignment.MiddleCenter;
            lbRetail.Click += LbRetail_Click;
            // 
            // lbCoding
            // 
            lbCoding.AutoSize = true;
            lbCoding.BackColor = Color.FromArgb(195, 141, 158);
            lbCoding.Cursor = Cursors.Hand;
            lbCoding.Dock = DockStyle.Fill;
            lbCoding.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold);
            lbCoding.ImageAlign = ContentAlignment.MiddleLeft;
            lbCoding.Location = new Point(106, 511);
            lbCoding.Margin = new Padding(0);
            lbCoding.Name = "lbCoding";
            lbCoding.Size = new Size(222, 79);
            lbCoding.TabIndex = 15;
            lbCoding.Text = "Coding";
            lbCoding.TextAlign = ContentAlignment.MiddleCenter;
            lbCoding.Click += LbCoding_Click;
            // 
            // pictureAdmin
            // 
            pictureAdmin.Cursor = Cursors.Hand;
            pictureAdmin.Dock = DockStyle.Fill;
            pictureAdmin.Image = Properties.Resources.icons8_stack_of_paper_48;
            pictureAdmin.Location = new Point(16, 0);
            pictureAdmin.Margin = new Padding(0);
            pictureAdmin.Name = "pictureAdmin";
            pictureAdmin.Size = new Size(90, 73);
            pictureAdmin.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureAdmin.TabIndex = 17;
            pictureAdmin.TabStop = false;
            pictureAdmin.Click += LbAdmini_Click;
            // 
            // lbFinance
            // 
            lbFinance.AutoSize = true;
            lbFinance.BackColor = Color.FromArgb(195, 141, 158);
            lbFinance.Cursor = Cursors.Hand;
            lbFinance.Dock = DockStyle.Fill;
            lbFinance.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold);
            lbFinance.ImageAlign = ContentAlignment.MiddleLeft;
            lbFinance.Location = new Point(106, 365);
            lbFinance.Margin = new Padding(0);
            lbFinance.Name = "lbFinance";
            lbFinance.Size = new Size(222, 73);
            lbFinance.TabIndex = 12;
            lbFinance.Text = "Finance";
            lbFinance.TextAlign = ContentAlignment.MiddleCenter;
            lbFinance.Click += LbFinance_Click;
            // 
            // pictureWork
            // 
            pictureWork.Cursor = Cursors.Hand;
            pictureWork.Dock = DockStyle.Fill;
            pictureWork.Image = Properties.Resources.icons8_briefcase_48;
            pictureWork.Location = new Point(16, 73);
            pictureWork.Margin = new Padding(0);
            pictureWork.Name = "pictureWork";
            pictureWork.Size = new Size(90, 73);
            pictureWork.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureWork.TabIndex = 18;
            pictureWork.TabStop = false;
            pictureWork.Click += LbWork_Click;
            // 
            // pictureStudy
            // 
            pictureStudy.Cursor = Cursors.Hand;
            pictureStudy.Dock = DockStyle.Fill;
            pictureStudy.Image = Properties.Resources.icons8_books_48;
            pictureStudy.Location = new Point(16, 146);
            pictureStudy.Margin = new Padding(0);
            pictureStudy.Name = "pictureStudy";
            pictureStudy.Size = new Size(90, 73);
            pictureStudy.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureStudy.TabIndex = 19;
            pictureStudy.TabStop = false;
            pictureStudy.Click += LbStudy_Click;
            // 
            // pictureSocials
            // 
            pictureSocials.Cursor = Cursors.Hand;
            pictureSocials.Dock = DockStyle.Fill;
            pictureSocials.Image = Properties.Resources.icons8_internet_48;
            pictureSocials.Location = new Point(16, 219);
            pictureSocials.Margin = new Padding(0);
            pictureSocials.Name = "pictureSocials";
            pictureSocials.Size = new Size(90, 73);
            pictureSocials.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureSocials.TabIndex = 20;
            pictureSocials.TabStop = false;
            pictureSocials.Click += LbSocial_Click;
            // 
            // pictureRetail
            // 
            pictureRetail.Cursor = Cursors.Hand;
            pictureRetail.Dock = DockStyle.Fill;
            pictureRetail.Image = Properties.Resources.icons8_shopping_bag_48;
            pictureRetail.Location = new Point(16, 292);
            pictureRetail.Margin = new Padding(0);
            pictureRetail.Name = "pictureRetail";
            pictureRetail.Size = new Size(90, 73);
            pictureRetail.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureRetail.TabIndex = 21;
            pictureRetail.TabStop = false;
            pictureRetail.Click += LbRetail_Click;
            // 
            // pictureFinance
            // 
            pictureFinance.Cursor = Cursors.Hand;
            pictureFinance.Dock = DockStyle.Fill;
            pictureFinance.Image = Properties.Resources.icons8_banknotes_48;
            pictureFinance.Location = new Point(16, 365);
            pictureFinance.Margin = new Padding(0);
            pictureFinance.Name = "pictureFinance";
            pictureFinance.Size = new Size(90, 73);
            pictureFinance.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureFinance.TabIndex = 16;
            pictureFinance.TabStop = false;
            pictureFinance.Click += LbFinance_Click;
            // 
            // lbStudy
            // 
            lbStudy.AutoSize = true;
            lbStudy.BackColor = Color.FromArgb(195, 141, 158);
            lbStudy.Cursor = Cursors.Hand;
            lbStudy.Dock = DockStyle.Fill;
            lbStudy.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold);
            lbStudy.ImageAlign = ContentAlignment.MiddleLeft;
            lbStudy.Location = new Point(106, 146);
            lbStudy.Margin = new Padding(0);
            lbStudy.Name = "lbStudy";
            lbStudy.Size = new Size(222, 73);
            lbStudy.TabIndex = 9;
            lbStudy.Text = "Study";
            lbStudy.TextAlign = ContentAlignment.MiddleCenter;
            lbStudy.Click += LbStudy_Click;
            // 
            // pictureGames
            // 
            pictureGames.Cursor = Cursors.Hand;
            pictureGames.Dock = DockStyle.Fill;
            pictureGames.Image = Properties.Resources.icons8_game_controller_48;
            pictureGames.Location = new Point(16, 438);
            pictureGames.Margin = new Padding(0);
            pictureGames.Name = "pictureGames";
            pictureGames.Size = new Size(90, 73);
            pictureGames.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureGames.TabIndex = 0;
            pictureGames.TabStop = false;
            pictureGames.Click += LbGames_Click;
            // 
            // lbWork
            // 
            lbWork.AutoSize = true;
            lbWork.BackColor = Color.FromArgb(195, 141, 158);
            lbWork.Cursor = Cursors.Hand;
            lbWork.Dock = DockStyle.Fill;
            lbWork.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold);
            lbWork.ForeColor = Color.Black;
            lbWork.ImageAlign = ContentAlignment.MiddleLeft;
            lbWork.Location = new Point(106, 73);
            lbWork.Margin = new Padding(0);
            lbWork.Name = "lbWork";
            lbWork.Size = new Size(222, 73);
            lbWork.TabIndex = 8;
            lbWork.Text = "Work";
            lbWork.TextAlign = ContentAlignment.MiddleCenter;
            lbWork.Click += LbWork_Click;
            // 
            // lbGames
            // 
            lbGames.AutoSize = true;
            lbGames.BackColor = Color.FromArgb(195, 141, 158);
            lbGames.Cursor = Cursors.Hand;
            lbGames.Dock = DockStyle.Fill;
            lbGames.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold);
            lbGames.ImageAlign = ContentAlignment.MiddleLeft;
            lbGames.Location = new Point(106, 438);
            lbGames.Margin = new Padding(0);
            lbGames.Name = "lbGames";
            lbGames.Size = new Size(222, 73);
            lbGames.TabIndex = 14;
            lbGames.Text = "Games";
            lbGames.TextAlign = ContentAlignment.MiddleCenter;
            lbGames.Click += LbGames_Click;
            // 
            // pictureCoding
            // 
            pictureCoding.Cursor = Cursors.Hand;
            pictureCoding.Dock = DockStyle.Fill;
            pictureCoding.Image = Properties.Resources.icons8_console_48;
            pictureCoding.Location = new Point(16, 511);
            pictureCoding.Margin = new Padding(0);
            pictureCoding.Name = "pictureCoding";
            pictureCoding.Size = new Size(90, 79);
            pictureCoding.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureCoding.TabIndex = 22;
            pictureCoding.TabStop = false;
            pictureCoding.Click += LbCoding_Click;
            // 
            // lbSelectedAdmini
            // 
            lbSelectedAdmini.AutoSize = true;
            lbSelectedAdmini.Dock = DockStyle.Fill;
            lbSelectedAdmini.Location = new Point(3, 0);
            lbSelectedAdmini.Name = "lbSelectedAdmini";
            lbSelectedAdmini.Size = new Size(10, 73);
            lbSelectedAdmini.TabIndex = 23;
            // 
            // lbSelectedWork
            // 
            lbSelectedWork.AutoSize = true;
            lbSelectedWork.Dock = DockStyle.Fill;
            lbSelectedWork.Location = new Point(3, 73);
            lbSelectedWork.Name = "lbSelectedWork";
            lbSelectedWork.Size = new Size(10, 73);
            lbSelectedWork.TabIndex = 24;
            // 
            // lbSelectedStudy
            // 
            lbSelectedStudy.AutoSize = true;
            lbSelectedStudy.Dock = DockStyle.Fill;
            lbSelectedStudy.Location = new Point(3, 146);
            lbSelectedStudy.Name = "lbSelectedStudy";
            lbSelectedStudy.Size = new Size(10, 73);
            lbSelectedStudy.TabIndex = 25;
            // 
            // lbSelectedSocials
            // 
            lbSelectedSocials.AutoSize = true;
            lbSelectedSocials.Dock = DockStyle.Fill;
            lbSelectedSocials.Location = new Point(3, 219);
            lbSelectedSocials.Name = "lbSelectedSocials";
            lbSelectedSocials.Size = new Size(10, 73);
            lbSelectedSocials.TabIndex = 26;
            // 
            // lbSelectedRetail
            // 
            lbSelectedRetail.AutoSize = true;
            lbSelectedRetail.Dock = DockStyle.Fill;
            lbSelectedRetail.Location = new Point(3, 292);
            lbSelectedRetail.Name = "lbSelectedRetail";
            lbSelectedRetail.Size = new Size(10, 73);
            lbSelectedRetail.TabIndex = 27;
            // 
            // lbSelectedFinance
            // 
            lbSelectedFinance.AutoSize = true;
            lbSelectedFinance.Dock = DockStyle.Fill;
            lbSelectedFinance.Location = new Point(3, 365);
            lbSelectedFinance.Name = "lbSelectedFinance";
            lbSelectedFinance.Size = new Size(10, 73);
            lbSelectedFinance.TabIndex = 28;
            // 
            // lbSelectedGames
            // 
            lbSelectedGames.AutoSize = true;
            lbSelectedGames.Dock = DockStyle.Fill;
            lbSelectedGames.Location = new Point(3, 438);
            lbSelectedGames.Name = "lbSelectedGames";
            lbSelectedGames.Size = new Size(10, 73);
            lbSelectedGames.TabIndex = 29;
            // 
            // lbSelectedCoding
            // 
            lbSelectedCoding.AutoSize = true;
            lbSelectedCoding.Dock = DockStyle.Fill;
            lbSelectedCoding.Location = new Point(3, 511);
            lbSelectedCoding.Name = "lbSelectedCoding";
            lbSelectedCoding.Size = new Size(10, 79);
            lbSelectedCoding.TabIndex = 30;
            // 
            // picBoxLogo
            // 
            picBoxLogo.Image = (Image)resources.GetObject("picBoxLogo.Image");
            picBoxLogo.Location = new Point(65, 11);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(101, 99);
            picBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxLogo.TabIndex = 4;
            picBoxLogo.TabStop = false;
            picBoxLogo.MouseDown += MainForm_MouseDown;
            picBoxLogo.MouseMove += MainForm_MouseMove;
            picBoxLogo.MouseUp += MainForm_MouseUp;
            // 
            // lbTitlePwd
            // 
            lbTitlePwd.AutoSize = true;
            lbTitlePwd.BackColor = Color.FromArgb(195, 141, 158);
            lbTitlePwd.Font = new Font("Bahnschrift SemiBold SemiConden", 16F, FontStyle.Bold);
            lbTitlePwd.ForeColor = Color.White;
            lbTitlePwd.Location = new Point(174, 11);
            lbTitlePwd.Name = "lbTitlePwd";
            lbTitlePwd.Size = new Size(210, 52);
            lbTitlePwd.TabIndex = 2;
            lbTitlePwd.Text = "PASSWORD";
            lbTitlePwd.TextAlign = ContentAlignment.TopCenter;
            lbTitlePwd.MouseDown += MainForm_MouseDown;
            lbTitlePwd.MouseMove += MainForm_MouseMove;
            lbTitlePwd.MouseUp += MainForm_MouseUp;
            // 
            // lbTitleVault
            // 
            lbTitleVault.AutoSize = true;
            lbTitleVault.BackColor = Color.FromArgb(195, 141, 158);
            lbTitleVault.Font = new Font("Bahnschrift SemiLight", 16F);
            lbTitleVault.ForeColor = Color.White;
            lbTitleVault.Location = new Point(205, 61);
            lbTitleVault.Name = "lbTitleVault";
            lbTitleVault.Size = new Size(144, 52);
            lbTitleVault.TabIndex = 3;
            lbTitleVault.Text = "VAULT";
            lbTitleVault.TextAlign = ContentAlignment.TopCenter;
            lbTitleVault.MouseDown += MainForm_MouseDown;
            lbTitleVault.MouseMove += MainForm_MouseMove;
            lbTitleVault.MouseUp += MainForm_MouseUp;
            // 
            // listPwdPanel
            // 
            listPwdPanel.AutoScroll = true;
            listPwdPanel.Dock = DockStyle.Fill;
            listPwdPanel.Location = new Point(0, 115);
            listPwdPanel.Name = "listPwdPanel";
            listPwdPanel.Size = new Size(1368, 845);
            listPwdPanel.TabIndex = 4;
            listPwdPanel.MouseDown += MainForm_MouseDown;
            listPwdPanel.MouseMove += MainForm_MouseMove;
            listPwdPanel.MouseUp += MainForm_MouseUp;
            // 
            // separator
            // 
            separator.BorderStyle = BorderStyle.Fixed3D;
            separator.Location = new Point(20, 114);
            separator.Name = "separator";
            separator.Size = new Size(1332, 3);
            separator.TabIndex = 3;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lbCount);
            panelTop.Controls.Add(lbTitleCount);
            panelTop.Controls.Add(btnImport);
            panelTop.Controls.Add(btnExport);
            panelTop.Controls.Add(txtBoxFilter);
            panelTop.Controls.Add(btnAdd);
            panelTop.Controls.Add(btnExit);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1368, 115);
            panelTop.TabIndex = 0;
            panelTop.MouseDown += MainForm_MouseDown;
            panelTop.MouseMove += MainForm_MouseMove;
            panelTop.MouseUp += MainForm_MouseUp;
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCount.Location = new Point(559, 82);
            lbCount.Margin = new Padding(5, 0, 5, 0);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(26, 29);
            lbCount.TabIndex = 21;
            lbCount.Text = "0";
            // 
            // lbTitleCount
            // 
            lbTitleCount.AutoSize = true;
            lbTitleCount.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitleCount.Location = new Point(486, 82);
            lbTitleCount.Margin = new Padding(5, 0, 5, 0);
            lbTitleCount.Name = "lbTitleCount";
            lbTitleCount.Size = new Size(80, 29);
            lbTitleCount.TabIndex = 20;
            lbTitleCount.Text = "Count:";
            // 
            // btnImport
            // 
            btnImport.BackgroundImage = Properties.Resources.icons8_upload_48;
            btnImport.BackgroundImageLayout = ImageLayout.Stretch;
            btnImport.Location = new Point(1155, 27);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(62, 61);
            btnImport.TabIndex = 7;
            toolTipExit.SetToolTip(btnImport, "Import the passwords");
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += BtnImport_Click;
            // 
            // btnExport
            // 
            btnExport.BackgroundImage = Properties.Resources.icons8_download_48;
            btnExport.BackgroundImageLayout = ImageLayout.Stretch;
            btnExport.Location = new Point(1081, 27);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(62, 61);
            btnExport.TabIndex = 6;
            toolTipExit.SetToolTip(btnExport, "Export all the passwords");
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += BtnExport_Click;
            // 
            // txtBoxFilter
            // 
            txtBoxFilter.Location = new Point(392, 35);
            txtBoxFilter.Name = "txtBoxFilter";
            txtBoxFilter.PlaceholderText = "Filter by application or website name";
            txtBoxFilter.Size = new Size(622, 39);
            txtBoxFilter.TabIndex = 1;
            toolTipExit.SetToolTip(txtBoxFilter, "Filter the passwords by typing the application or website name");
            txtBoxFilter.TextChanged += TxtBoxFilter_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.HotTrack;
            btnAdd.FlatStyle = FlatStyle.System;
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(107, 21);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(205, 67);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add password";
            toolTipExit.SetToolTip(btnAdd, "Add a new password");
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = Properties.Resources.icons8_logout_48;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.Location = new Point(1253, 27);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(62, 61);
            btnExit.TabIndex = 5;
            toolTipExit.SetToolTip(btnExit, "Exit the application");
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1805, 960);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 5, 5, 5);
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
        private Button btnExport;
        private Button btnImport;
        private Label lbVersion;
        private Label lbTitleCount;
        private Label lbCount;
    }
}