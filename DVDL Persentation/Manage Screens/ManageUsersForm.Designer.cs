namespace DVDL_Persentation
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataOfAllUsersDataGradeView = new DataGridView();
            UsersProcess = new ContextMenuStrip(components);
            updaateInformationToolStripMenuItem = new ToolStripMenuItem();
            deletaThePersonToolStripMenuItem = new ToolStripMenuItem();
            theInformationToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            TitleLabel = new Label();
            TheRecordesNumberLable = new Label();
            TheFiltersCommboBox = new ComboBox();
            TheNumberOfRecordesButton = new Label();
            label2 = new Label();
            CancelButton = new Button();
            AddUserButton = new Button();
            ManageUsersMenuImage = new PictureBox();
            IsActiveCompoBox = new ComboBox();
            TheFilterInformaion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataOfAllUsersDataGradeView).BeginInit();
            UsersProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ManageUsersMenuImage).BeginInit();
            SuspendLayout();
            // 
            // DataOfAllUsersDataGradeView
            // 
            DataOfAllUsersDataGradeView.AllowUserToAddRows = false;
            DataOfAllUsersDataGradeView.AllowUserToDeleteRows = false;
            DataOfAllUsersDataGradeView.BackgroundColor = Color.FromArgb(45, 45, 48);
            DataOfAllUsersDataGradeView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataOfAllUsersDataGradeView.ContextMenuStrip = UsersProcess;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DataOfAllUsersDataGradeView.DefaultCellStyle = dataGridViewCellStyle1;
            DataOfAllUsersDataGradeView.GridColor = Color.DimGray;
            DataOfAllUsersDataGradeView.Location = new Point(18, 275);
            DataOfAllUsersDataGradeView.Margin = new Padding(4, 3, 4, 3);
            DataOfAllUsersDataGradeView.Name = "DataOfAllUsersDataGradeView";
            DataOfAllUsersDataGradeView.ReadOnly = true;
            DataOfAllUsersDataGradeView.Size = new Size(700, 208);
            DataOfAllUsersDataGradeView.TabIndex = 13;
            // 
            // UsersProcess
            // 
            UsersProcess.Items.AddRange(new ToolStripItem[] { updaateInformationToolStripMenuItem, deletaThePersonToolStripMenuItem, theInformationToolStripMenuItem, changePasswordToolStripMenuItem });
            UsersProcess.Name = "UsersProcess";
            UsersProcess.Size = new Size(179, 92);
            // 
            // updaateInformationToolStripMenuItem
            // 
            updaateInformationToolStripMenuItem.Name = "updaateInformationToolStripMenuItem";
            updaateInformationToolStripMenuItem.Size = new Size(178, 22);
            updaateInformationToolStripMenuItem.Text = "Update Information";
            updaateInformationToolStripMenuItem.Click += UpdateInformationToolStripMenuItem_Click;
            // 
            // deletaThePersonToolStripMenuItem
            // 
            deletaThePersonToolStripMenuItem.Name = "deletaThePersonToolStripMenuItem";
            deletaThePersonToolStripMenuItem.Size = new Size(178, 22);
            deletaThePersonToolStripMenuItem.Text = "Delete the User";
            deletaThePersonToolStripMenuItem.Click += DeleteTheUserToolStripMenuItem_Click;
            // 
            // theInformationToolStripMenuItem
            // 
            theInformationToolStripMenuItem.Name = "theInformationToolStripMenuItem";
            theInformationToolStripMenuItem.Size = new Size(178, 22);
            theInformationToolStripMenuItem.Text = "Details";
            theInformationToolStripMenuItem.Click += TheInformationToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(178, 22);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += ChangePasswordToolStripMenuItem_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TitleLabel.ForeColor = Color.DeepSkyBlue;
            TitleLabel.Location = new Point(213, 185);
            TitleLabel.Margin = new Padding(4, 0, 4, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(327, 42);
            TitleLabel.TabIndex = 14;
            TitleLabel.Text = "Manage Users";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TheRecordesNumberLable
            // 
            TheRecordesNumberLable.Location = new Point(91, 489);
            TheRecordesNumberLable.Margin = new Padding(4, 0, 4, 0);
            TheRecordesNumberLable.Name = "TheRecordesNumberLable";
            TheRecordesNumberLable.Size = new Size(117, 27);
            TheRecordesNumberLable.TabIndex = 16;
            // 
            // TheFiltersCommboBox
            // 
            TheFiltersCommboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TheFiltersCommboBox.Location = new Point(114, 232);
            TheFiltersCommboBox.Margin = new Padding(4, 3, 4, 3);
            TheFiltersCommboBox.Name = "TheFiltersCommboBox";
            TheFiltersCommboBox.Size = new Size(139, 23);
            TheFiltersCommboBox.TabIndex = 17;
            TheFiltersCommboBox.SelectedIndexChanged += TheFiltersOfCommboBox_SelectedIndexChanged;
            // 
            // TheNumberOfRecordesButton
            // 
            TheNumberOfRecordesButton.Location = new Point(4, 507);
            TheNumberOfRecordesButton.Margin = new Padding(4, 0, 4, 0);
            TheNumberOfRecordesButton.Name = "TheNumberOfRecordesButton";
            TheNumberOfRecordesButton.Size = new Size(117, 27);
            TheNumberOfRecordesButton.TabIndex = 18;
            TheNumberOfRecordesButton.Text = "# Records:";
            // 
            // label2
            // 
            label2.Location = new Point(9, 234);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 19;
            label2.Text = "Filter By:";
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(645, 489);
            CancelButton.Margin = new Padding(4, 3, 4, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(72, 50);
            CancelButton.TabIndex = 20;
            CancelButton.Text = "Cancel";
            CancelButton.Click += CancelButton_Click;
            // 
            // AddUserButton
            // 
            AddUserButton.BackgroundImageLayout = ImageLayout.Stretch;
            AddUserButton.FlatStyle = FlatStyle.Flat;
            AddUserButton.Location = new Point(645, 173);
            AddUserButton.Margin = new Padding(4, 3, 4, 3);
            AddUserButton.Name = "AddUserButton";
            AddUserButton.Size = new Size(72, 54);
            AddUserButton.TabIndex = 21;
            AddUserButton.Click += AddUserButton_Click;
            // 
            // ManageUsersMenuImage
            // 
            ManageUsersMenuImage.BackgroundImage = Properties.Resource.Users_2_400;
            ManageUsersMenuImage.BackgroundImageLayout = ImageLayout.Stretch;
            ManageUsersMenuImage.Location = new Point(243, 6);
            ManageUsersMenuImage.Margin = new Padding(4, 3, 4, 3);
            ManageUsersMenuImage.Name = "ManageUsersMenuImage";
            ManageUsersMenuImage.Size = new Size(270, 166);
            ManageUsersMenuImage.TabIndex = 22;
            ManageUsersMenuImage.TabStop = false;
            // 
            // IsActiveCompoBox
            // 
            IsActiveCompoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IsActiveCompoBox.Enabled = false;
            IsActiveCompoBox.Items.AddRange(new object[] { "Yes", "No" });
            IsActiveCompoBox.Location = new Point(297, 232);
            IsActiveCompoBox.Margin = new Padding(4, 3, 4, 3);
            IsActiveCompoBox.Name = "IsActiveCompoBox";
            IsActiveCompoBox.Size = new Size(140, 23);
            IsActiveCompoBox.TabIndex = 1;
            IsActiveCompoBox.Visible = false;
            IsActiveCompoBox.SelectedIndexChanged += IsActiveCompoBox_SelectedIndexChanged;
            // 
            // TheFilterInformaion
            // 
            TheFilterInformaion.Location = new Point(286, 232);
            TheFilterInformaion.Name = "TheFilterInformaion";
            TheFilterInformaion.Size = new Size(164, 23);
            TheFilterInformaion.TabIndex = 23;
            TheFilterInformaion.TextChanged += TheFilterInformaion_TextChanged;
            TheFilterInformaion.KeyPress += TheFilterInformaion_KeyPress;
            // 
            // ManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(757, 554);
            Controls.Add(TheFilterInformaion);
            Controls.Add(IsActiveCompoBox);
            Controls.Add(DataOfAllUsersDataGradeView);
            Controls.Add(TitleLabel);
            Controls.Add(TheRecordesNumberLable);
            Controls.Add(TheFiltersCommboBox);
            Controls.Add(TheNumberOfRecordesButton);
            Controls.Add(label2);
            Controls.Add(CancelButton);
            Controls.Add(AddUserButton);
            Controls.Add(ManageUsersMenuImage);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "ManageUsersForm";
            Text = "Manage Users";
            Load += ManageUsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataOfAllUsersDataGradeView).EndInit();
            UsersProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ManageUsersMenuImage).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataOfAllUsersDataGradeView;
        private System.Windows.Forms.ContextMenuStrip UsersProcess;
        private System.Windows.Forms.ToolStripMenuItem updaateInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletaThePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TheRecordesNumberLable;
        private System.Windows.Forms.ComboBox TheFiltersCommboBox;
        private System.Windows.Forms.Label TheNumberOfRecordesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.PictureBox ManageUsersMenuImage;
        private System.Windows.Forms.ComboBox IsActiveCompoBox;
        private TextBox TheFilterInformaion;
    }
}
