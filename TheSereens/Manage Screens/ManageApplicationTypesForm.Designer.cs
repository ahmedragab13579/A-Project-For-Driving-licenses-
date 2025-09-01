namespace TheSereens
{
    partial class ManageApplicationTypesForm
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
            this.TheInternationallicenseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TheInternationallicenseData.ContextMenuStrip = this.contextMenuStrip1;
            this.TheInternationallicenseData.Location = new System.Drawing.Point(3, 269);
            this.TheInternationallicenseData.Name = "TheInternationallicenseData";
            this.TheInternationallicenseData.ReadOnly = true;
            this.TheInternationallicenseData.Size = new System.Drawing.Size(795, 282);
            this.TheInternationallicenseData.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perosnInformationToolStripMenuItem,
            this.licenseInformationToolStripMenuItem,
            this.personHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // perosnInformationToolStripMenuItem
            // 
            this.perosnInformationToolStripMenuItem.Name = "perosnInformationToolStripMenuItem";
            this.perosnInformationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.perosnInformationToolStripMenuItem.Text = "Perosn Information";
            this.perosnInformationToolStripMenuItem.Click += new System.EventHandler(this.perosnInformationToolStripMenuItem_Click);
            // 
            // licenseInformationToolStripMenuItem
            // 
            this.licenseInformationToolStripMenuItem.Name = "licenseInformationToolStripMenuItem";
            this.licenseInformationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.licenseInformationToolStripMenuItem.Text = "License Information";
            this.licenseInformationToolStripMenuItem.Click += new System.EventHandler(this.licenseInformationToolStripMenuItem_Click);
            // 
            // personHistoryToolStripMenuItem
            // 
            this.personHistoryToolStripMenuItem.Name = "personHistoryToolStripMenuItem";
            this.personHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personHistoryToolStripMenuItem.Text = "Person History";
            this.personHistoryToolStripMenuItem.Click += new System.EventHandler(this.personHistoryToolStripMenuItem_Click);
            // 
            // TheTitleLabel
            // 
            this.TheTitleLabel.AutoSize = true;
            this.TheTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheTitleLabel.ForeColor = System.Drawing.Color.Red;
            this.TheTitleLabel.Location = new System.Drawing.Point(193, 224);
            this.TheTitleLabel.Name = "TheTitleLabel";
            this.TheTitleLabel.Size = new System.Drawing.Size(455, 31);
            this.TheTitleLabel.TabIndex = 1;
            this.TheTitleLabel.Text = "Manage The International License";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recordes : ";
            // 
            // TheRecordesLabel
            // 
            this.TheRecordesLabel.AutoSize = true;
            this.TheRecordesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheRecordesLabel.Location = new System.Drawing.Point(105, 566);
            this.TheRecordesLabel.Name = "TheRecordesLabel";
            this.TheRecordesLabel.Size = new System.Drawing.Size(44, 17);
            this.TheRecordesLabel.TabIndex = 3;
            this.TheRecordesLabel.Text = "????";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(713, 562);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // ManageApplicationTypeImage
            // 
            this.ManageApplicationTypeImage.BackgroundImage = global::TheSereens.Properties.Resources.international_driver_s_license_card_identification_data_information_concept;
            this.ManageApplicationTypeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManageApplicationTypeImage.Location = new System.Drawing.Point(300, 12);
            this.ManageApplicationTypeImage.Name = "ManageApplicationTypeImage";
            this.ManageApplicationTypeImage.Size = new System.Drawing.Size(203, 171);
            this.ManageApplicationTypeImage.TabIndex = 5;
            this.ManageApplicationTypeImage.TabStop = false;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(713, 205);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 50);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ManageApplicationTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ManageApplicationTypeImage);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.TheRecordesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TheTitleLabel);
            this.Controls.Add(this.TheInternationallicenseData);
            this.Name = "ManageApplicationTypesForm";
            this.Text = "ManageApplicationTypesForm";
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