namespace pwdvault.Forms
{
    partial class Password
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbApp = new Label();
            lbUser = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnCopy = new Button();
            toolTipCopy = new ToolTip(components);
            toolTipEdit = new ToolTip(components);
            toolTipDelete = new ToolTip(components);
            pictureBoxApp = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxApp).BeginInit();
            SuspendLayout();
            // 
            // lbApp
            // 
            lbApp.AutoSize = true;
            lbApp.Font = new Font("Bahnschrift SemiBold", 13F, FontStyle.Bold);
            lbApp.ForeColor = Color.Black;
            lbApp.Location = new Point(136, 10);
            lbApp.Margin = new Padding(2, 0, 2, 0);
            lbApp.Name = "lbApp";
            lbApp.Size = new Size(107, 27);
            lbApp.TabIndex = 0;
            lbApp.Text = "Facebook";
            lbApp.MouseEnter += Password_MouseEnter;
            lbApp.MouseLeave += Password_MouseLeave;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Location = new Point(138, 36);
            lbUser.Margin = new Padding(2, 0, 2, 0);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(26, 20);
            lbUser.TabIndex = 1;
            lbUser.Text = "gh";
            lbUser.MouseEnter += Password_MouseEnter;
            lbUser.MouseLeave += Password_MouseLeave;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources.icons8_delete_48;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.Location = new Point(764, 18);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(38, 38);
            btnDelete.TabIndex = 3;
            toolTipDelete.SetToolTip(btnDelete, "Delete password");
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            btnDelete.MouseEnter += Password_MouseEnter;
            btnDelete.MouseLeave += Password_MouseLeave;
            // 
            // btnEdit
            // 
            btnEdit.BackgroundImage = Properties.Resources.icons8_edit_48;
            btnEdit.BackgroundImageLayout = ImageLayout.Stretch;
            btnEdit.Location = new Point(706, 18);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(38, 38);
            btnEdit.TabIndex = 4;
            toolTipEdit.SetToolTip(btnEdit, "Edit password");
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += BtnEdit_Click;
            btnEdit.MouseEnter += Password_MouseEnter;
            btnEdit.MouseLeave += Password_MouseLeave;
            // 
            // btnCopy
            // 
            btnCopy.BackgroundImage = Properties.Resources.icons8_copy_48;
            btnCopy.BackgroundImageLayout = ImageLayout.Stretch;
            btnCopy.Location = new Point(647, 18);
            btnCopy.Margin = new Padding(2);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(38, 38);
            btnCopy.TabIndex = 7;
            toolTipCopy.SetToolTip(btnCopy, "Copy the password to the clipboard");
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += BtnCopy_Click;
            btnCopy.MouseEnter += Password_MouseEnter;
            btnCopy.MouseLeave += Password_MouseLeave;
            // 
            // pictureBoxApp
            // 
            pictureBoxApp.BackColor = Color.White;
            pictureBoxApp.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxApp.ErrorImage = Properties.Resources.icons8_noimage;
            pictureBoxApp.Image = Properties.Resources.icons8_noimage;
            pictureBoxApp.Location = new Point(73, 11);
            pictureBoxApp.Margin = new Padding(2);
            pictureBoxApp.Name = "pictureBoxApp";
            pictureBoxApp.Size = new Size(48, 48);
            pictureBoxApp.TabIndex = 8;
            pictureBoxApp.TabStop = false;
            pictureBoxApp.MouseEnter += Password_MouseEnter;
            pictureBoxApp.MouseLeave += Password_MouseLeave;
            // 
            // Password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBoxApp);
            Controls.Add(btnCopy);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(lbUser);
            Controls.Add(lbApp);
            Margin = new Padding(2);
            Name = "Password";
            Size = new Size(814, 74);
            MouseEnter += Password_MouseEnter;
            MouseLeave += Password_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)pictureBoxApp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbApp;
        private Label lbUser;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnCopy;
        private ToolTip toolTipDelete;
        private ToolTip toolTipEdit;
        private ToolTip toolTipCopy;
        private PictureBox pictureBoxApp;
    }
}
