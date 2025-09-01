namespace DVDL_Persentation.License_Information
{
    partial class ManageLocalDrivingLicenseApplicationForm
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
            TheLocalDrivingLicenseTypeData = new DataGridView();
            OperationOnLocalDrivingLicense = new ContextMenuStrip(components);
            showApplicationDeToolStripMenuItem = new ToolStripMenuItem();
            deleteApplicationToolStripMenuItem = new ToolStripMenuItem();
            cancelApplicationToolStripMenuItem = new ToolStripMenuItem();
            schedualToolStripMenuItem = new ToolStripMenuItem();
            visnToolStripMenuItem = new ToolStripMenuItem();
            writinToolStripMenuItem = new ToolStripMenuItem();
            streetTestToolStripMenuItem = new ToolStripMenuItem();
            issueDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            sToolStripMenuItem = new ToolStripMenuItem();
            CancelButton = new Button();
            TheRecordesLabel = new Label();
            label2 = new Label();
            TheTitleLabel = new Label();
            LocalDrivingLicenseImage = new PictureBox();
            TheFiltersCommboBox = new ComboBox();
            label1 = new Label();
            AddLocalDrivingApplicationButton = new Button();
            StatusComboBox = new ComboBox();
            TheFilterInformationTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)TheLocalDrivingLicenseTypeData).BeginInit();
            OperationOnLocalDrivingLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LocalDrivingLicenseImage).BeginInit();
            SuspendLayout();
            // 
            // TheLocalDrivingLicenseTypeData
            // 
            TheLocalDrivingLicenseTypeData.AllowUserToAddRows = false;
            TheLocalDrivingLicenseTypeData.AllowUserToDeleteRows = false;
            TheLocalDrivingLicenseTypeData.BackgroundColor = SystemColors.ActiveCaption;
            TheLocalDrivingLicenseTypeData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TheLocalDrivingLicenseTypeData.ContextMenuStrip = OperationOnLocalDrivingLicense;
            TheLocalDrivingLicenseTypeData.Location = new Point(4, 271);
            TheLocalDrivingLicenseTypeData.Margin = new Padding(4, 3, 4, 3);
            TheLocalDrivingLicenseTypeData.Name = "TheLocalDrivingLicenseTypeData";
            TheLocalDrivingLicenseTypeData.ReadOnly = true;
            TheLocalDrivingLicenseTypeData.Size = new Size(927, 325);
            TheLocalDrivingLicenseTypeData.TabIndex = 12;
            // 
            // OperationOnLocalDrivingLicense
            // 
            OperationOnLocalDrivingLicense.Font = new Font("Segoe UI", 11F);
            OperationOnLocalDrivingLicense.Items.AddRange(new ToolStripItem[] { showApplicationDeToolStripMenuItem, deleteApplicationToolStripMenuItem, cancelApplicationToolStripMenuItem, schedualToolStripMenuItem, issueDrivingLicenseToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem, sToolStripMenuItem });
            OperationOnLocalDrivingLicense.Name = "contextMenuStrip1";
            OperationOnLocalDrivingLicense.Size = new Size(265, 172);
            OperationOnLocalDrivingLicense.Opening += OperationOnLocalDrivingLicense_Opening;
            // 
            // showApplicationDeToolStripMenuItem
            // 
            showApplicationDeToolStripMenuItem.Name = "showApplicationDeToolStripMenuItem";
            showApplicationDeToolStripMenuItem.Size = new Size(264, 24);
            showApplicationDeToolStripMenuItem.Text = "Show Application Details";
            showApplicationDeToolStripMenuItem.Click += showApplicationDeToolStripMenuItem_Click;
            // 
            // deleteApplicationToolStripMenuItem
            // 
            deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            deleteApplicationToolStripMenuItem.Size = new Size(264, 24);
            deleteApplicationToolStripMenuItem.Text = "Delete Application";
            deleteApplicationToolStripMenuItem.Click += deleteApplicationToolStripMenuItem_Click;
            // 
            // cancelApplicationToolStripMenuItem
            // 
            cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            cancelApplicationToolStripMenuItem.Size = new Size(264, 24);
            cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            cancelApplicationToolStripMenuItem.Click += cancelApplicationToolStripMenuItem_Click;
            // 
            // schedualToolStripMenuItem
            // 
            schedualToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visnToolStripMenuItem, writinToolStripMenuItem, streetTestToolStripMenuItem });
            schedualToolStripMenuItem.Name = "schedualToolStripMenuItem";
            schedualToolStripMenuItem.Size = new Size(264, 24);
            schedualToolStripMenuItem.Text = "Schedule Test";
            // 
            // visnToolStripMenuItem
            // 
            visnToolStripMenuItem.Name = "visnToolStripMenuItem";
            visnToolStripMenuItem.Size = new Size(157, 24);
            visnToolStripMenuItem.Text = "Vision Test";
            visnToolStripMenuItem.Click += visnToolStripMenuItem_Click;
            // 
            // writinToolStripMenuItem
            // 
            writinToolStripMenuItem.Enabled = false;
            writinToolStripMenuItem.Name = "writinToolStripMenuItem";
            writinToolStripMenuItem.Size = new Size(157, 24);
            writinToolStripMenuItem.Text = "Written Test";
            writinToolStripMenuItem.Click += writinToolStripMenuItem_Click;
            // 
            // streetTestToolStripMenuItem
            // 
            streetTestToolStripMenuItem.Enabled = false;
            streetTestToolStripMenuItem.Name = "streetTestToolStripMenuItem";
            streetTestToolStripMenuItem.Size = new Size(157, 24);
            streetTestToolStripMenuItem.Text = "Street test";
            streetTestToolStripMenuItem.Click += streetTestToolStripMenuItem_Click;
            // 
            // issueDrivingLicenseToolStripMenuItem
            // 
            issueDrivingLicenseToolStripMenuItem.Enabled = false;
            issueDrivingLicenseToolStripMenuItem.Name = "issueDrivingLicenseToolStripMenuItem";
            issueDrivingLicenseToolStripMenuItem.Size = new Size(264, 24);
            issueDrivingLicenseToolStripMenuItem.Text = "Issue Driving License";
            issueDrivingLicenseToolStripMenuItem.Click += issueDrivingLicenseToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(264, 24);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // sToolStripMenuItem
            // 
            sToolStripMenuItem.Enabled = false;
            sToolStripMenuItem.Name = "sToolStripMenuItem";
            sToolStripMenuItem.Size = new Size(264, 24);
            sToolStripMenuItem.Text = "Show License";
            sToolStripMenuItem.Click += sToolStripMenuItem_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(832, 602);
            CancelButton.Margin = new Padding(4, 3, 4, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(88, 27);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // TheRecordesLabel
            // 
            TheRecordesLabel.AutoSize = true;
            TheRecordesLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TheRecordesLabel.Location = new Point(134, 603);
            TheRecordesLabel.Margin = new Padding(4, 0, 4, 0);
            TheRecordesLabel.Name = "TheRecordesLabel";
            TheRecordesLabel.Size = new Size(44, 17);
            TheRecordesLabel.TabIndex = 15;
            TheRecordesLabel.Text = "????";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 603);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 14;
            label2.Text = "Recordes : ";
            // 
            // TheTitleLabel
            // 
            TheTitleLabel.AutoSize = true;
            TheTitleLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TheTitleLabel.ForeColor = Color.Red;
            TheTitleLabel.Location = new Point(208, 178);
            TheTitleLabel.Margin = new Padding(4, 0, 4, 0);
            TheTitleLabel.Name = "TheTitleLabel";
            TheTitleLabel.Size = new Size(445, 31);
            TheTitleLabel.TabIndex = 13;
            TheTitleLabel.Text = "Local Driving License Application";
            // 
            // LocalDrivingLicenseImage
            // 
            LocalDrivingLicenseImage.BackgroundImage = Properties.Resource.Applications;
            LocalDrivingLicenseImage.BackgroundImageLayout = ImageLayout.Stretch;
            LocalDrivingLicenseImage.Location = new Point(346, 0);
            LocalDrivingLicenseImage.Margin = new Padding(4, 3, 4, 3);
            LocalDrivingLicenseImage.Name = "LocalDrivingLicenseImage";
            LocalDrivingLicenseImage.Size = new Size(237, 174);
            LocalDrivingLicenseImage.TabIndex = 17;
            LocalDrivingLicenseImage.TabStop = false;
            // 
            // TheFiltersCommboBox
            // 
            TheFiltersCommboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TheFiltersCommboBox.FormattingEnabled = true;
            TheFiltersCommboBox.Location = new Point(106, 232);
            TheFiltersCommboBox.Margin = new Padding(4, 3, 4, 3);
            TheFiltersCommboBox.Name = "TheFiltersCommboBox";
            TheFiltersCommboBox.Size = new Size(140, 23);
            TheFiltersCommboBox.TabIndex = 19;
            TheFiltersCommboBox.SelectedIndexChanged += TheFiltersCommboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.World, 0);
            label1.Location = new Point(14, 235);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 13);
            label1.TabIndex = 18;
            label1.Text = "Filter By : ";
            // 
            // AddLocalDrivingApplicationButton
            // 
            AddLocalDrivingApplicationButton.BackColor = Color.White;
            AddLocalDrivingApplicationButton.BackgroundImageLayout = ImageLayout.Stretch;
            AddLocalDrivingApplicationButton.FlatStyle = FlatStyle.Flat;
            AddLocalDrivingApplicationButton.Font = new Font("Segoe UI", 15F);
            AddLocalDrivingApplicationButton.Location = new Point(844, 214);
            AddLocalDrivingApplicationButton.Margin = new Padding(4, 3, 4, 3);
            AddLocalDrivingApplicationButton.Name = "AddLocalDrivingApplicationButton";
            AddLocalDrivingApplicationButton.Size = new Size(72, 54);
            AddLocalDrivingApplicationButton.TabIndex = 21;
            AddLocalDrivingApplicationButton.Text = "Add";
            AddLocalDrivingApplicationButton.UseVisualStyleBackColor = false;
            AddLocalDrivingApplicationButton.Click += AddLocalDrivingApplicationButton_Click;
            // 
            // StatusComboBox
            // 
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBox.Enabled = false;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Items.AddRange(new object[] { "New", "Completed", "Cancelled" });
            StatusComboBox.Location = new Point(261, 231);
            StatusComboBox.Margin = new Padding(4, 3, 4, 3);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(140, 23);
            StatusComboBox.TabIndex = 22;
            StatusComboBox.Visible = false;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // TheFilterInformationTextBox
            // 
            TheFilterInformationTextBox.Location = new Point(261, 231);
            TheFilterInformationTextBox.Name = "TheFilterInformationTextBox";
            TheFilterInformationTextBox.Size = new Size(140, 23);
            TheFilterInformationTextBox.TabIndex = 23;
            TheFilterInformationTextBox.TextChanged += TheFilterInformationTextBox_TextChanged_1;
            TheFilterInformationTextBox.KeyPress += TheFilterInformationTextBox_KeyPress;
            // 
            // ManageLocalDrivingLicenseApplicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(933, 644);
            Controls.Add(TheFilterInformationTextBox);
            Controls.Add(StatusComboBox);
            Controls.Add(AddLocalDrivingApplicationButton);
            Controls.Add(TheFiltersCommboBox);
            Controls.Add(label1);
            Controls.Add(TheLocalDrivingLicenseTypeData);
            Controls.Add(LocalDrivingLicenseImage);
            Controls.Add(CancelButton);
            Controls.Add(TheRecordesLabel);
            Controls.Add(label2);
            Controls.Add(TheTitleLabel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManageLocalDrivingLicenseApplicationForm";
            Text = "LocalDrivingLicenseApplicationForm";
            Load += ManageLocalDrivingLicenseApplicationForm_Load;
            ((System.ComponentModel.ISupportInitialize)TheLocalDrivingLicenseTypeData).EndInit();
            OperationOnLocalDrivingLicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LocalDrivingLicenseImage).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TheLocalDrivingLicenseTypeData;
        private System.Windows.Forms.ContextMenuStrip OperationOnLocalDrivingLicense;
        private System.Windows.Forms.PictureBox LocalDrivingLicenseImage;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label TheRecordesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TheTitleLabel;
        private System.Windows.Forms.ComboBox TheFiltersCommboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddLocalDrivingApplicationButton;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streetTestToolStripMenuItem;
        private TextBox TheFilterInformationTextBox;
    }
}