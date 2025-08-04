namespace TheSereens
{
    partial class ManageApplicationTypesForm
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
            this.TheInternationallicenseData = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.perosnInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TheTitleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TheRecordesLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ManageApplicationTypeImage = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TheInternationallicenseData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManageApplicationTypeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TheInternationallicenseData
            // 
            this.TheInternationallicenseData.AllowUserToAddRows = false;
            this.TheInternationallicenseData.AllowUserToDeleteRows = false;
            this.TheInternationallicenseData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.TheInternationallicenseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TheInternationallicenseData.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TheInternationallicenseData.DefaultCellStyle = dataGridViewCellStyle1;
            this.TheInternationallicenseData.GridColor = System.Drawing.Color.Gray;
            this.TheInternationallicenseData.Location = new System.Drawing.Point(23, 327);
            this.TheInternationallicenseData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TheInternationallicenseData.Name = "TheInternationallicenseData";
            this.TheInternationallicenseData.ReadOnly = true;
            this.TheInternationallicenseData.Size = new System.Drawing.Size(887, 327);
            this.TheInternationallicenseData.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.contextMenuStrip1.ForeColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perosnInformationToolStripMenuItem,
            this.licenseInformationToolStripMenuItem,
            this.personHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 70);
            // 
            // perosnInformationToolStripMenuItem
            // 
            this.perosnInformationToolStripMenuItem.Name = "perosnInformationToolStripMenuItem";
            this.perosnInformationToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.perosnInformationToolStripMenuItem.Text = "Person Information";
            this.perosnInformationToolStripMenuItem.Click += new System.EventHandler(this.perosnInformationToolStripMenuItem_Click);
            // 
            // licenseInformationToolStripMenuItem
            // 
            this.licenseInformationToolStripMenuItem.Name = "licenseInformationToolStripMenuItem";
            this.licenseInformationToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.licenseInformationToolStripMenuItem.Text = "License Information";
            this.licenseInformationToolStripMenuItem.Click += new System.EventHandler(this.licenseInformationToolStripMenuItem_Click);
            // 
            // personHistoryToolStripMenuItem
            // 
            this.personHistoryToolStripMenuItem.Name = "personHistoryToolStripMenuItem";
            this.personHistoryToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.personHistoryToolStripMenuItem.Text = "Person History";
            this.personHistoryToolStripMenuItem.Click += new System.EventHandler(this.personHistoryToolStripMenuItem_Click);
            // 
            // TheTitleLabel
            // 
            this.TheTitleLabel.AutoSize = true;
            this.TheTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.TheTitleLabel.ForeColor = System.Drawing.Color.Teal;
            this.TheTitleLabel.Location = new System.Drawing.Point(266, 262);
            this.TheTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TheTitleLabel.Name = "TheTitleLabel";
            this.TheTitleLabel.Size = new System.Drawing.Size(400, 32);
            this.TheTitleLabel.TabIndex = 10;
            this.TheTitleLabel.Text = "Manage The International License";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(23, 680);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Records:";
            // 
            // TheRecordesLabel
            // 
            this.TheRecordesLabel.AutoSize = true;
            this.TheRecordesLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TheRecordesLabel.Location = new System.Drawing.Point(117, 680);
            this.TheRecordesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TheRecordesLabel.Name = "TheRecordesLabel";
            this.TheRecordesLabel.Size = new System.Drawing.Size(17, 19);
            this.TheRecordesLabel.TabIndex = 8;
            this.TheRecordesLabel.Text = "0";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.DarkRed;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(817, 673);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(93, 46);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // ManageApplicationTypeImage
            // 
            this.ManageApplicationTypeImage.BackgroundImage = global::TheSereens.Properties.Resources.international_driver_s_license_card_identification_data_information_concept;
            this.ManageApplicationTypeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManageApplicationTypeImage.Location = new System.Drawing.Point(350, 26);
            this.ManageApplicationTypeImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ManageApplicationTypeImage.Name = "ManageApplicationTypeImage";
            this.ManageApplicationTypeImage.Size = new System.Drawing.Size(233, 209);
            this.ManageApplicationTypeImage.TabIndex = 7;
            this.ManageApplicationTypeImage.TabStop = false;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Teal;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(817, 248);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(93, 65);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ManageApplicationTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(933, 745);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ManageApplicationTypeImage);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.TheRecordesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TheTitleLabel);
            this.Controls.Add(this.TheInternationallicenseData);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ManageApplicationTypesForm";
            this.Text = "Manage Application Types";
            this.Load += new System.EventHandler(this.ManageApplicationTypesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TheInternationallicenseData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManageApplicationTypeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TheInternationallicenseData;
        private System.Windows.Forms.Label TheTitleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TheRecordesLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox ManageApplicationTypeImage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem perosnInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personHistoryToolStripMenuItem;
        private System.Windows.Forms.Button Add;
    }
}
