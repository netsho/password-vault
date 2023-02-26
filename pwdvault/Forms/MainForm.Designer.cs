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
            groupBox1 = new GroupBox();
            btnCopyPwd = new Button();
            btnCopyUser = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            lbPwd = new Label();
            lbUser = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnFilter = new Button();
            textBox1 = new TextBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
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
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Window;
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1717, 777);
            splitContainer1.SplitterDistance = 417;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCopyPwd);
            groupBox1.Controls.Add(btnCopyUser);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
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
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.eye;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(1045, 87);
            button1.Name = "button1";
            button1.Size = new Size(34, 34);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(751, 57);
            label3.Name = "label3";
            label3.Size = new Size(268, 28);
            label3.TabIndex = 5;
            label3.Text = "testtesttesttestetstrtbfdfgytyt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(175, 58);
            label2.Name = "label2";
            label2.Size = new Size(252, 28);
            label2.TabIndex = 3;
            label2.Text = "oussamabricha@gmail.com";
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
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(16, 113);
            label1.Name = "label1";
            label1.Size = new Size(1036, 2);
            label1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnFilter);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1296, 113);
            panel1.TabIndex = 0;
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
            // textBox1
            // 
            textBox1.Location = new Point(396, 40);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Filter";
            textBox1.Size = new Size(479, 31);
            textBox1.TabIndex = 1;
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
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Button btnAdd;
        private Button btnFilter;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label lbPwd;
        private Label lbUser;
        private Button btnCopyPwd;
        private Button btnCopyUser;
        private Button button1;
    }
}