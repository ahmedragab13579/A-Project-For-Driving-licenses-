namespace DVDL_Persentation.Manage_Screens
{
    partial class ManageInternationalLicense
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
            TheInternationalData = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            personInfoToolStripMenuItem = new ToolStripMenuItem();
            licenseInfoToolStripMenuItem = new ToolStripMenuItem();
            personHistoryToolStripMenuItem = new ToolStripMenuItem();
            ManageApplicationTypeImage = new PictureBox();
            CancelButton = new Button();
            TheRecordesLabel = new Label();
            label2 = new Label();
            TheTitleLabel = new Label();
            Add = new Button();
            panel1 = new Panel();
            IsActive = new ComboBox();
            FilterData = new TextBox();
            label1 = new Label();
            Filters = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)TheInternationalData).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ManageApplicationTypeImage).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TheInternationalData
            // 
            TheInternationalData.AllowUserToAddRows = false;
            TheInternationalData.AllowUserToDeleteRows = false;
            TheInternationalData.BackgroundColor = Color.SteelBlue;
            TheInternationalData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TheInternationalData.ContextMenuStrip = contextMenuStrip1;
            TheInternationalData.Location = new Point(4, 310);
            TheInternationalData.Margin = new Padding(4, 3, 4, 3);
            TheInternationalData.Name = "TheInternationalData";
            TheInternationalData.ReadOnly = true;
            TheInternationalData.Size = new Size(927, 325);
            TheInternationalData.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { personInfoToolStripMenuItem, licenseInfoToolStripMenuItem, personHistoryToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(152, 70);
            // 
            // personInfoToolStripMenuItem
            // 
            personInfoToolStripMenuItem.Name = "personInfoToolStripMenuItem";
            personInfoToolStripMenuItem.Size = new Size(151, 22);
            personInfoToolStripMenuItem.Text = "Person Info";
            personInfoToolStripMenuItem.Click += personInfoToolStripMenuItem_Click;
            // 
            // licenseInfoToolStripMenuItem
            // 
            licenseInfoToolStripMenuItem.Name = "licenseInfoToolStripMenuItem";
            licenseInfoToolStripMenuItem.Size = new Size(151, 22);
            licenseInfoToolStripMenuItem.Text = "License info";
            licenseInfoToolStripMenuItem.Click += licenseInfoToolStripMenuItem_Click;
            // 
            // personHistoryToolStripMenuItem
            // 
            personHistoryToolStripMenuItem.Name = "personHistoryToolStripMenuItem";
            personHistoryToolStripMenuItem.Size = new Size(151, 22);
            personHistoryToolStripMenuItem.Text = "Person History";
            personHistoryToolStripMenuItem.Click += personHistoryToolStripMenuItem_Click;
            // 
            // ManageApplicationTypeImage
            // 
            ManageApplicationTypeImage.BackgroundImage = Properties.Resource.LicenseView_4001;
            ManageApplicationTypeImage.BackgroundImageLayout = ImageLayout.Stretch;
            ManageApplicationTypeImage.Location = new Point(345, 3);
            ManageApplicationTypeImage.Margin = new Padding(4, 3, 4, 3);
            ManageApplicationTypeImage.Name = "ManageApplicationTypeImage";
            ManageApplicationTypeImage.Size = new Size(237, 197);
            ManageApplicationTypeImage.TabIndex = 11;
            ManageApplicationTypeImage.TabStop = false;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(832, 648);
            CancelButton.Margin = new Padding(4, 3, 4, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(88, 27);
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // TheRecordesLabel
            // 
            TheRecordesLabel.AutoSize = true;
            TheRecordesLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TheRecordesLabel.Location = new Point(122, 653);
            TheRecordesLabel.Margin = new Padding(4, 0, 4, 0);
            TheRecordesLabel.Name = "TheRecordesLabel";
            TheRecordesLabel.Size = new Size(44, 17);
            TheRecordesLabel.TabIndex = 9;
            TheRecordesLabel.Text = "????";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 648);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 8;
            label2.Text = "Recordes : ";
            // 
            // TheTitleLabel
            // 
            TheTitleLabel.AutoSize = true;
            TheTitleLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TheTitleLabel.ForeColor = Color.Red;
            TheTitleLabel.Location = new Point(226, 219);
            TheTitleLabel.Margin = new Padding(4, 0, 4, 0);
            TheTitleLabel.Name = "TheTitleLabel";
            TheTitleLabel.Size = new Size(470, 31);
            TheTitleLabel.TabIndex = 7;
            TheTitleLabel.Text = "Manage The International Licenses";
            // 
            // Add
            // 
            Add.Location = new Point(832, 240);
            Add.Margin = new Padding(4, 3, 4, 3);
            Add.Name = "Add";
            Add.Size = new Size(88, 54);
            Add.TabIndex = 12;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(IsActive);
            panel1.Controls.Add(FilterData);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Filters);
            panel1.Location = new Point(12, 260);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 44);
            panel1.TabIndex = 13;
            // 
            // IsActive
            // 
            IsActive.DropDownStyle = ComboBoxStyle.DropDownList;
            IsActive.Enabled = false;
            IsActive.FormattingEnabled = true;
            IsActive.Items.AddRange(new object[] { "Yes", "No" });
            IsActive.Location = new Point(268, 18);
            IsActive.Name = "IsActive";
            IsActive.Size = new Size(143, 23);
            IsActive.TabIndex = 10;
            IsActive.Visible = false;
            IsActive.SelectedIndexChanged += IsActive_SelectedIndexChanged;
            // 
            // FilterData
            // 
            FilterData.Location = new Point(268, 18);
            FilterData.Margin = new Padding(4, 3, 4, 3);
            FilterData.Name = "FilterData";
            FilterData.Size = new Size(143, 23);
            FilterData.TabIndex = 9;
            FilterData.TextChanged += FilterData_TextChanged;
            FilterData.KeyPress += FilterData_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(4, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 8;
            label1.Text = "Filters : ";
            // 
            // Filters
            // 
            Filters.DropDownStyle = ComboBoxStyle.DropDownList;
            Filters.FormattingEnabled = true;
            Filters.Items.AddRange(new object[] { "None" });
            Filters.Location = new Point(90, 16);
            Filters.Margin = new Padding(4, 3, 4, 3);
            Filters.Name = "Filters";
            Filters.Size = new Size(140, 23);
            Filters.TabIndex = 0;
            Filters.SelectedIndexChanged += Filters_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(16, 193);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 23);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.Visible = false;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // ManageInternationalLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(933, 691);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel1);
            Controls.Add(Add);
            Controls.Add(TheInternationalData);
            Controls.Add(ManageApplicationTypeImage);
            Controls.Add(CancelButton);
            Controls.Add(TheRecordesLabel);
            Controls.Add(label2);
            Controls.Add(TheTitleLabel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManageInternationalLicense";
            Text = "ManageInternationalLicense";
            Load += ManageInternationalLicense_Load;
            ((System.ComponentModel.ISupportInitialize)TheInternationalData).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ManageApplicationTypeImage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TheInternationalData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox ManageApplicationTypeImage;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label TheRecordesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TheTitleLabel;
        private System.Windows.Forms.ToolStripMenuItem personInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personHistoryToolStripMenuItem;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FilterData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Filters;
        private ComboBox IsActive;
        private DateTimePicker dateTimePicker1;
    }
}