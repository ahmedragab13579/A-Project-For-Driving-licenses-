namespace TheSereens
{
    partial class ManageUsersForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataOfAllUsersDataGradeView = new System.Windows.Forms.DataGridView();
            this.UsersProcess = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updaateInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletaThePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TheFilterInformaion = new System.Windows.Forms.MaskedTextBox();
            this.TheRecordesNumberLable = new System.Windows.Forms.Label();
            this.TheFiltersCommboBox = new System.Windows.Forms.ComboBox();
            this.TheNumberOfRecordesButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.ManageUsersMenuImage = new System.Windows.Forms.PictureBox();
            this.IsActiveCompoBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataOfAllUsersDataGradeView)).BeginInit();
            this.UsersProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManageUsersMenuImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DataOfAllUsersDataGradeView
            // 
            this.DataOfAllUsersDataGradeView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.DataOfAllUsersDataGradeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataOfAllUsersDataGradeView.ContextMenuStrip = this.UsersProcess;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataOfAllUsersDataGradeView.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataOfAllUsersDataGradeView.GridColor = System.Drawing.Color.DimGray;
            this.DataOfAllUsersDataGradeView.Location = new System.Drawing.Point(15, 238);
            this.DataOfAllUsersDataGradeView.Name = "DataOfAllUsersDataGradeView";
            this.DataOfAllUsersDataGradeView.Size = new System.Drawing.Size(600, 180);
            this.DataOfAllUsersDataGradeView.TabIndex = 13;
            // 
            // UsersProcess
            // 
            this.UsersProcess.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updaateInformationToolStripMenuItem,
            this.deletaThePersonToolStripMenuItem,
            this.theInformationToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.UsersProcess.Name = "UsersProcess";
            this.UsersProcess.Size = new System.Drawing.Size(179, 92);
            // 
            // updaateInformationToolStripMenuItem
            // 
            this.updaateInformationToolStripMenuItem.Name = "updaateInformationToolStripMenuItem";
            this.updaateInformationToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.updaateInformationToolStripMenuItem.Text = "Update Information";
            this.updaateInformationToolStripMenuItem.Click += new System.EventHandler(this.UpdateInformationToolStripMenuItem_Click);
            // 
            // deletaThePersonToolStripMenuItem
            // 
            this.deletaThePersonToolStripMenuItem.Name = "deletaThePersonToolStripMenuItem";
            this.deletaThePersonToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.deletaThePersonToolStripMenuItem.Text = "Delete the User";
            this.deletaThePersonToolStripMenuItem.Click += new System.EventHandler(this.DeleteTheUserToolStripMenuItem_Click);
            // 
            // theInformationToolStripMenuItem
            // 
            this.theInformationToolStripMenuItem.Name = "theInformationToolStripMenuItem";
            this.theInformationToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.theInformationToolStripMenuItem.Text = "Details";
            this.theInformationToolStripMenuItem.Click += new System.EventHandler(this.TheInformationToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.TitleLabel.Location = new System.Drawing.Point(184, 143);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(280, 36);
            this.TitleLabel.TabIndex = 14;
            this.TitleLabel.Text = "Manage Users";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TheFilterInformaion
            // 
            this.TheFilterInformaion.Location = new System.Drawing.Point(233, 201);
            this.TheFilterInformaion.Name = "TheFilterInformaion";
            this.TheFilterInformaion.Size = new System.Drawing.Size(120, 20);
            this.TheFilterInformaion.TabIndex = 15;
            this.TheFilterInformaion.TextChanged += new System.EventHandler(this.TheFilterInformationTextBox_TextChanged);
            // 
            // TheRecordesNumberLable
            // 
            this.TheRecordesNumberLable.Location = new System.Drawing.Point(78, 424);
            this.TheRecordesNumberLable.Name = "TheRecordesNumberLable";
            this.TheRecordesNumberLable.Size = new System.Drawing.Size(100, 23);
            this.TheRecordesNumberLable.TabIndex = 16;
            // 
            // TheFiltersCommboBox
            // 
            this.TheFiltersCommboBox.Location = new System.Drawing.Point(98, 201);
            this.TheFiltersCommboBox.Name = "TheFiltersCommboBox";
            this.TheFiltersCommboBox.Size = new System.Drawing.Size(120, 21);
            this.TheFiltersCommboBox.TabIndex = 17;
            this.TheFiltersCommboBox.SelectedIndexChanged += new System.EventHandler(this.TheFiltersOfCommboBox_SelectedIndexChanged);
            // 
            // TheNumberOfRecordesButton
            // 
            this.TheNumberOfRecordesButton.Location = new System.Drawing.Point(3, 439);
            this.TheNumberOfRecordesButton.Name = "TheNumberOfRecordesButton";
            this.TheNumberOfRecordesButton.Size = new System.Drawing.Size(100, 23);
            this.TheNumberOfRecordesButton.TabIndex = 18;
            this.TheNumberOfRecordesButton.Text = "# Records:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Filter By:";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(553, 424);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(62, 43);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.BackgroundImage = global::TheSereens.Properties.Resources._9731573;
            this.AddUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserButton.Location = new System.Drawing.Point(553, 150);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(62, 47);
            this.AddUserButton.TabIndex = 21;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // ManageUsersMenuImage
            // 
            this.ManageUsersMenuImage.BackgroundImage = global::TheSereens.Properties.Resources.finger_pressing_red_icon;
            this.ManageUsersMenuImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManageUsersMenuImage.Location = new System.Drawing.Point(208, 5);
            this.ManageUsersMenuImage.Name = "ManageUsersMenuImage";
            this.ManageUsersMenuImage.Size = new System.Drawing.Size(231, 135);
            this.ManageUsersMenuImage.TabIndex = 22;
            this.ManageUsersMenuImage.TabStop = false;
            // 
            // IsActiveCompoBox
            // 
            this.IsActiveCompoBox.Enabled = false;
            this.IsActiveCompoBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.IsActiveCompoBox.Location = new System.Drawing.Point(233, 201);
            this.IsActiveCompoBox.Name = "IsActiveCompoBox";
            this.IsActiveCompoBox.Size = new System.Drawing.Size(121, 21);
            this.IsActiveCompoBox.TabIndex = 1;
            this.IsActiveCompoBox.Visible = false;
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(649, 480);
            this.Controls.Add(this.IsActiveCompoBox);
            this.Controls.Add(this.DataOfAllUsersDataGradeView);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.TheFilterInformaion);
            this.Controls.Add(this.TheRecordesNumberLable);
            this.Controls.Add(this.TheFiltersCommboBox);
            this.Controls.Add(this.TheNumberOfRecordesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.ManageUsersMenuImage);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManageUsersForm";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataOfAllUsersDataGradeView)).EndInit();
            this.UsersProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManageUsersMenuImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataOfAllUsersDataGradeView;
        private System.Windows.Forms.ContextMenuStrip UsersProcess;
        private System.Windows.Forms.ToolStripMenuItem updaateInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletaThePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.MaskedTextBox TheFilterInformaion;
        private System.Windows.Forms.Label TheRecordesNumberLable;
        private System.Windows.Forms.ComboBox TheFiltersCommboBox;
        private System.Windows.Forms.Label TheNumberOfRecordesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.PictureBox ManageUsersMenuImage;
        private System.Windows.Forms.ComboBox IsActiveCompoBox;
    }
}
