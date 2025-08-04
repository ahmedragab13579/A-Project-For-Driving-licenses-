namespace TheSereens.License_Information
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
            this.components = new System.ComponentModel.Container();
            this.TheLocalDrivingLicenseTypeData = new System.Windows.Forms.DataGridView();
            this.OperationOnLocalDrivingLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTheApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TheRecordesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TheTitleLabel = new System.Windows.Forms.Label();
            this.LocalDrivingLicenseImage = new System.Windows.Forms.PictureBox();
            this.TheFilterInformationTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TheFiltersCommboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddLocalDrivingApplicationButton = new System.Windows.Forms.Button();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TheLocalDrivingLicenseTypeData)).BeginInit();
            this.OperationOnLocalDrivingLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalDrivingLicenseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TheLocalDrivingLicenseTypeData
            // 
            this.TheLocalDrivingLicenseTypeData.AllowUserToAddRows = false;
            this.TheLocalDrivingLicenseTypeData.AllowUserToDeleteRows = false;
            this.TheLocalDrivingLicenseTypeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TheLocalDrivingLicenseTypeData.ContextMenuStrip = this.OperationOnLocalDrivingLicense;
            this.TheLocalDrivingLicenseTypeData.Location = new System.Drawing.Point(3, 235);
            this.TheLocalDrivingLicenseTypeData.Name = "TheLocalDrivingLicenseTypeData";
            this.TheLocalDrivingLicenseTypeData.ReadOnly = true;
            this.TheLocalDrivingLicenseTypeData.Size = new System.Drawing.Size(795, 282);
            this.TheLocalDrivingLicenseTypeData.TabIndex = 12;
            // 
            // OperationOnLocalDrivingLicense
            // 
            this.OperationOnLocalDrivingLicense.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.OperationOnLocalDrivingLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDeToolStripMenuItem,
            this.editTheApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.schedualToolStripMenuItem,
            this.issueDrivingLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.sToolStripMenuItem});
            this.OperationOnLocalDrivingLicense.Name = "contextMenuStrip1";
            this.OperationOnLocalDrivingLicense.Size = new System.Drawing.Size(265, 218);
            this.OperationOnLocalDrivingLicense.Opening += new System.ComponentModel.CancelEventHandler(this.OperationOnLocalDrivingLicense_Opening);
            // 
            // showApplicationDeToolStripMenuItem
            // 
            this.showApplicationDeToolStripMenuItem.Name = "showApplicationDeToolStripMenuItem";
            this.showApplicationDeToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.showApplicationDeToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDeToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDeToolStripMenuItem_Click);
            // 
            // editTheApplicationToolStripMenuItem
            // 
            this.editTheApplicationToolStripMenuItem.Name = "editTheApplicationToolStripMenuItem";
            this.editTheApplicationToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.editTheApplicationToolStripMenuItem.Text = "Edit The Test";
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // schedualToolStripMenuItem
            // 
            this.schedualToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visnToolStripMenuItem,
            this.writinToolStripMenuItem,
            this.streetTestToolStripMenuItem});
            this.schedualToolStripMenuItem.Name = "schedualToolStripMenuItem";
            this.schedualToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.schedualToolStripMenuItem.Text = "Schedule Test";
            // 
            // visnToolStripMenuItem
            // 
            this.visnToolStripMenuItem.Name = "visnToolStripMenuItem";
            this.visnToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.visnToolStripMenuItem.Text = "Vision Test";
            this.visnToolStripMenuItem.Click += new System.EventHandler(this.visnToolStripMenuItem_Click);
            // 
            // writinToolStripMenuItem
            // 
            this.writinToolStripMenuItem.Enabled = false;
            this.writinToolStripMenuItem.Name = "writinToolStripMenuItem";
            this.writinToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.writinToolStripMenuItem.Text = "Written Test";
            this.writinToolStripMenuItem.Click += new System.EventHandler(this.writinToolStripMenuItem_Click);
            // 
            // streetTestToolStripMenuItem
            // 
            this.streetTestToolStripMenuItem.Enabled = false;
            this.streetTestToolStripMenuItem.Name = "streetTestToolStripMenuItem";
            this.streetTestToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.streetTestToolStripMenuItem.Text = "Street test";
            this.streetTestToolStripMenuItem.Click += new System.EventHandler(this.streetTestToolStripMenuItem_Click);
            // 
            // issueDrivingLicenseToolStripMenuItem
            // 
            this.issueDrivingLicenseToolStripMenuItem.Enabled = false;
            this.issueDrivingLicenseToolStripMenuItem.Name = "issueDrivingLicenseToolStripMenuItem";
            this.issueDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.issueDrivingLicenseToolStripMenuItem.Text = "Issue Driving License";
            this.issueDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Enabled = false;
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.sToolStripMenuItem.Text = "Show License";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(723, 523);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TheRecordesLabel
            // 
            this.TheRecordesLabel.AutoSize = true;
            this.TheRecordesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheRecordesLabel.Location = new System.Drawing.Point(115, 523);
            this.TheRecordesLabel.Name = "TheRecordesLabel";
            this.TheRecordesLabel.Size = new System.Drawing.Size(44, 17);
            this.TheRecordesLabel.TabIndex = 15;
            this.TheRecordesLabel.Text = "????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Recordes : ";
            // 
            // TheTitleLabel
            // 
            this.TheTitleLabel.AutoSize = true;
            this.TheTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheTitleLabel.ForeColor = System.Drawing.Color.Red;
            this.TheTitleLabel.Location = new System.Drawing.Point(178, 154);
            this.TheTitleLabel.Name = "TheTitleLabel";
            this.TheTitleLabel.Size = new System.Drawing.Size(445, 31);
            this.TheTitleLabel.TabIndex = 13;
            this.TheTitleLabel.Text = "Local Driving License Application";
            // 
            // LocalDrivingLicenseImage
            // 
            this.LocalDrivingLicenseImage.BackgroundImage = global::TheSereens.Properties.Resources.standard_quality_control_concept_m;
            this.LocalDrivingLicenseImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LocalDrivingLicenseImage.Location = new System.Drawing.Point(297, 0);
            this.LocalDrivingLicenseImage.Name = "LocalDrivingLicenseImage";
            this.LocalDrivingLicenseImage.Size = new System.Drawing.Size(203, 151);
            this.LocalDrivingLicenseImage.TabIndex = 17;
            this.LocalDrivingLicenseImage.TabStop = false;
            // 
            // TheFilterInformationTextBox
            // 
            this.TheFilterInformationTextBox.Location = new System.Drawing.Point(235, 201);
            this.TheFilterInformationTextBox.Name = "TheFilterInformationTextBox";
            this.TheFilterInformationTextBox.Size = new System.Drawing.Size(122, 20);
            this.TheFilterInformationTextBox.TabIndex = 20;
            this.TheFilterInformationTextBox.TextChanged += new System.EventHandler(this.TheFilterInformationTextBox_TextChanged);
            // 
            // TheFiltersCommboBox
            // 
            this.TheFiltersCommboBox.FormattingEnabled = true;
            this.TheFiltersCommboBox.Location = new System.Drawing.Point(91, 201);
            this.TheFiltersCommboBox.Name = "TheFiltersCommboBox";
            this.TheFiltersCommboBox.Size = new System.Drawing.Size(121, 21);
            this.TheFiltersCommboBox.TabIndex = 19;
            this.TheFiltersCommboBox.SelectedIndexChanged += new System.EventHandler(this.TheFiltersCommboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Filter By : ";
            // 
            // AddLocalDrivingApplicationButton
            // 
            this.AddLocalDrivingApplicationButton.BackgroundImage = global::TheSereens.Properties.Resources._9731573;
            this.AddLocalDrivingApplicationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddLocalDrivingApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLocalDrivingApplicationButton.Location = new System.Drawing.Point(736, 182);
            this.AddLocalDrivingApplicationButton.Name = "AddLocalDrivingApplicationButton";
            this.AddLocalDrivingApplicationButton.Size = new System.Drawing.Size(62, 47);
            this.AddLocalDrivingApplicationButton.TabIndex = 21;
            this.AddLocalDrivingApplicationButton.UseVisualStyleBackColor = true;
            this.AddLocalDrivingApplicationButton.Click += new System.EventHandler(this.AddLocalDrivingApplicationButton_Click);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Enabled = false;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "New",
            "Completed",
            "Cancelled"});
            this.StatusComboBox.Location = new System.Drawing.Point(235, 200);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.StatusComboBox.TabIndex = 22;
            this.StatusComboBox.Visible = false;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // ManageLocalDrivingLicenseApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.AddLocalDrivingApplicationButton);
            this.Controls.Add(this.TheFilterInformationTextBox);
            this.Controls.Add(this.TheFiltersCommboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TheLocalDrivingLicenseTypeData);
            this.Controls.Add(this.LocalDrivingLicenseImage);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.TheRecordesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TheTitleLabel);
            this.Name = "ManageLocalDrivingLicenseApplicationForm";
            this.Text = "LocalDrivingLicenseApplicationForm";
            this.Load += new System.EventHandler(this.ManageLocalDrivingLicenseApplicationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TheLocalDrivingLicenseTypeData)).EndInit();
            this.OperationOnLocalDrivingLicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LocalDrivingLicenseImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TheLocalDrivingLicenseTypeData;
        private System.Windows.Forms.ContextMenuStrip OperationOnLocalDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem editTheApplicationToolStripMenuItem;
        private System.Windows.Forms.PictureBox LocalDrivingLicenseImage;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label TheRecordesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TheTitleLabel;
        private System.Windows.Forms.MaskedTextBox TheFilterInformationTextBox;
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
    }
}