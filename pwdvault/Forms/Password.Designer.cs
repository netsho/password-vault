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
            lbApp = new Label();
            lbUser = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnCopy = new Button();
            lbUserTitle = new Label();
            SuspendLayout();
            // 
            // lbApp
            // 
            lbApp.AutoSize = true;
            lbApp.Font = new Font("Bahnschrift SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbApp.Location = new Point(33, 3);
            lbApp.Name = "lbApp";
            lbApp.Size = new Size(143, 36);
            lbApp.TabIndex = 0;
            lbApp.Text = "Facebook";
            lbApp.MouseEnter += Password_MouseEnter;
            lbApp.MouseLeave += Password_MouseLeave;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Location = new Point(191, 39);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(33, 25);
            lbUser.TabIndex = 1;
            lbUser.Text = "gh";
            lbUser.MouseEnter += Password_MouseEnter;
            lbUser.MouseLeave += Password_MouseLeave;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources.delete;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.Location = new Point(1200, 34);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(35, 34);
            btnDelete.TabIndex = 3;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += Password_MouseEnter;
            btnDelete.MouseLeave += Password_MouseLeave;
            // 
            // btnEdit
            // 
            btnEdit.BackgroundImage = Properties.Resources.edit;
            btnEdit.BackgroundImageLayout = ImageLayout.Stretch;
            btnEdit.Location = new Point(1140, 34);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(35, 34);
            btnEdit.TabIndex = 4;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            btnEdit.MouseEnter += Password_MouseEnter;
            btnEdit.MouseLeave += Password_MouseLeave;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(857, 34);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(258, 34);
            btnCopy.TabIndex = 5;
            btnCopy.Text = "Copy password to clipboard";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            btnCopy.MouseEnter += Password_MouseEnter;
            btnCopy.MouseLeave += Password_MouseLeave;
            // 
            // lbUserTitle
            // 
            lbUserTitle.AutoSize = true;
            lbUserTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserTitle.Location = new Point(75, 39);
            lbUserTitle.Name = "lbUserTitle";
            lbUserTitle.Size = new Size(101, 25);
            lbUserTitle.TabIndex = 6;
            lbUserTitle.Text = "Username ";
            lbUserTitle.MouseEnter += Password_MouseEnter;
            lbUserTitle.MouseLeave += Password_MouseLeave;
            // 
            // Password
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbUserTitle);
            Controls.Add(btnCopy);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(lbUser);
            Controls.Add(lbApp);
            Name = "Password";
            Size = new Size(1298, 80);
            MouseEnter += Password_MouseEnter;
            MouseLeave += Password_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbApp;
        private Label lbUser;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnCopy;
        private Label lbUserTitle;
    }
}
