namespace TheSereens
{
    partial class ManageUsersForm
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
            this.components = new System.ComponentModel.Container();
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
            this.DataOfAllUsersDataGradeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataOfAllUsersDataGradeView.ContextMenuStrip = this.UsersProcess;
            this.DataOfAllUsersDataGradeView.Location = new System.Drawing.Point(209, 205);
            this.DataOfAllUsersDataGradeView.Name = "DataOfAllUsersDataGradeView";
            this.DataOfAllUsersDataGradeView.Size = new System.Drawing.Size(548, 111);
            this.DataOfAllUsersDataGradeView.TabIndex = 13;
            // 
            // UsersProcess
            // 
            this.UsersProcess.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updaateInformationToolStripMenuItem,
            this.deletaThePersonToolStripMenuItem,
            this.theInformationToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.UsersProcess.Name = "contextMenuStrip1";
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
            this.deletaThePersonToolStripMenuItem.Text = "Deleta the User";
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
            this.changePasswordToolStripMenuItem.Text = "Change password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TitleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TitleLabel.Location = new System.Drawing.Point(441, 150);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(231, 36);
            this.TitleLabel.TabIndex = 12;
            this.TitleLabel.Text = "Manage users";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TheFilterInformaion
            // 
            this.TheFilterInformaion.Location = new System.Drawing.Point(299, 160);
            this.TheFilterInformaion.Name = "TheFilterInformaion";
            this.TheFilterInformaion.Size = new System.Drawing.Size(122, 20);
            this.TheFilterInformaion.TabIndex = 20;
            this.TheFilterInformaion.TextChanged += new System.EventHandler(this.TheFilterInformationTextBox_TextChanged);
            // 
            // TheRecordesNumberLable
            // 
            this.TheRecordesNumberLable.Location = new System.Drawing.Point(78, 424);
            this.TheRecordesNumberLable.Name = "TheRecordesNumberLable";
            this.TheRecordesNumberLable.Size = new System.Drawing.Size(82, 23);
            this.TheRecordesNumberLable.TabIndex = 19;
            // 
            // TheFiltersCommboBox
            // 
            this.TheFiltersCommboBox.FormattingEnabled = true;
            this.TheFiltersCommboBox.Location = new System.Drawing.Point(167, 159);
            this.TheFiltersCommboBox.Name = "TheFiltersCommboBox";
            this.TheFiltersCommboBox.Size = new System.Drawing.Size(121, 21);
            this.TheFiltersCommboBox.TabIndex = 18;
            this.TheFiltersCommboBox.SelectedIndexChanged += new System.EventHandler(this.TheFiltersOfCommboBox_SelectedIndexChanged);
            // 
            // TheNumberOfRecordesButton
            // 
            this.TheNumberOfRecordesButton.Location = new System.Drawing.Point(78, 409);
            this.TheNumberOfRecordesButton.Name = "TheNumberOfRecordesButton";
            this.TheNumberOfRecordesButton.Size = new System.Drawing.Size(82, 23);
            this.TheNumberOfRecordesButton.TabIndex = 17;
            this.TheNumberOfRecordesButton.Text = "# Recordes : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Filter By : ";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(739, 409);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(62, 43);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.BackgroundImage = global::TheSereens.Properties.Resources._9731573;
            this.AddUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserButton.Location = new System.Drawing.Point(739, 122);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(62, 47);
            this.AddUserButton.TabIndex = 14;
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // ManageUsersMenuImage
            // 
            this.ManageUsersMenuImage.BackgroundImage = global::TheSereens.Properties.Resources.finger_pressing_red_icon;
            this.ManageUsersMenuImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManageUsersMenuImage.Location = new System.Drawing.Point(441, 12);
            this.ManageUsersMenuImage.Name = "ManageUsersMenuImage";
            this.ManageUsersMenuImage.Size = new System.Drawing.Size(231, 135);
            this.ManageUsersMenuImage.TabIndex = 11;
            this.ManageUsersMenuImage.TabStop = false;
            // 
            // IsActiveCompoBox
            // 
            this.IsActiveCompoBox.Enabled = false;
            this.IsActiveCompoBox.FormattingEnabled = true;
            this.IsActiveCompoBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.IsActiveCompoBox.Location = new System.Drawing.Point(299, 160);
            this.IsActiveCompoBox.Name = "IsActiveCompoBox";
            this.IsActiveCompoBox.Size = new System.Drawing.Size(121, 21);
            this.IsActiveCompoBox.TabIndex = 21;
            this.IsActiveCompoBox.Visible = false;
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
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
            this.Name = "ManageUsersForm";
            this.Text = "ManageUsers";
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
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}