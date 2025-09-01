namespace TheSereens.Manage_Screens
{
    partial class ManageDetainLicesneForm
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
            this.DetainLIceseses = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.perosnInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TheRecordesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TheTitleLabel = new System.Windows.Forms.Label();
            this.ManageApplicationTypeImage = new System.Windows.Forms.PictureBox();
            this.IsActiveCompoBox = new System.Windows.Forms.ComboBox();
            this.TheFilterInformaion = new System.Windows.Forms.MaskedTextBox();
            this.TheFiltersCommboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DetainLIceseses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManageApplicationTypeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DetainLIceseses
            // 
            this.DetainLIceseses.AllowUserToAddRows = false;
            this.DetainLIceseses.AllowUserToDeleteRows = false;
            this.DetainLIceseses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DetainLIceseses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetainLIceseses.ContextMenuStrip = this.contextMenuStrip1;
            this.DetainLIceseses.Location = new System.Drawing.Point(1, 261);
            this.DetainLIceseses.Name = "DetainLIceseses";
            this.DetainLIceseses.ReadOnly = true;
            this.DetainLIceseses.Size = new System.Drawing.Size(795, 282);
            this.DetainLIceseses.TabIndex = 7;
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
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(711, 197);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 50);
            this.Add.TabIndex = 13;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(711, 554);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TheRecordesLabel
            // 
            this.TheRecordesLabel.AutoSize = true;
            this.TheRecordesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheRecordesLabel.Location = new System.Drawing.Point(103, 558);
            this.TheRecordesLabel.Name = "TheRecordesLabel";
            this.TheRecordesLabel.Size = new System.Drawing.Size(44, 17);
            this.TheRecordesLabel.TabIndex = 10;
            this.TheRecordesLabel.Text = "????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Recordes : ";
            // 
            // TheTitleLabel
            // 
            this.TheTitleLabel.AutoSize = true;
            this.TheTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheTitleLabel.ForeColor = System.Drawing.Color.Red;
            this.TheTitleLabel.Location = new System.Drawing.Point(210, 197);
            this.TheTitleLabel.Name = "TheTitleLabel";
            this.TheTitleLabel.Size = new System.Drawing.Size(392, 31);
            this.TheTitleLabel.TabIndex = 8;
            this.TheTitleLabel.Text = "Manage The Detain Licesens\r\n";
            // 
            // ManageApplicationTypeImage
            // 
            this.ManageApplicationTypeImage.BackgroundImage = global::TheSereens.Properties.Resources.international_driver_s_license_card_identification_data_information_concept;
            this.ManageApplicationTypeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManageApplicationTypeImage.Location = new System.Drawing.Point(299, 12);
            this.ManageApplicationTypeImage.Name = "ManageApplicationTypeImage";
            this.ManageApplicationTypeImage.Size = new System.Drawing.Size(203, 171);
            this.ManageApplicationTypeImage.TabIndex = 12;
            this.ManageApplicationTypeImage.TabStop = false;
            // 
            // IsActiveCompoBox
            // 
            this.IsActiveCompoBox.Enabled = false;
            this.IsActiveCompoBox.FormattingEnabled = true;
            this.IsActiveCompoBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.IsActiveCompoBox.Location = new System.Drawing.Point(226, 232);
            this.IsActiveCompoBox.Name = "IsActiveCompoBox";
            this.IsActiveCompoBox.Size = new System.Drawing.Size(121, 21);
            this.IsActiveCompoBox.TabIndex = 25;
            this.IsActiveCompoBox.Visible = false;
            // 
            // TheFilterInformaion
            // 
            this.TheFilterInformaion.Location = new System.Drawing.Point(226, 232);
            this.TheFilterInformaion.Name = "TheFilterInformaion";
            this.TheFilterInformaion.Size = new System.Drawing.Size(122, 20);
            this.TheFilterInformaion.TabIndex = 24;
            // 
            // TheFiltersCommboBox
            // 
            this.TheFiltersCommboBox.FormattingEnabled = true;
            this.TheFiltersCommboBox.Location = new System.Drawing.Point(94, 231);
            this.TheFiltersCommboBox.Name = "TheFiltersCommboBox";
            this.TheFiltersCommboBox.Size = new System.Drawing.Size(121, 21);
            this.TheFiltersCommboBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Filter By : ";
            // 
            // ManageDetainLicesneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.IsActiveCompoBox);
            this.Controls.Add(this.TheFilterInformaion);
            this.Controls.Add(this.TheFiltersCommboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetainLIceseses);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ManageApplicationTypeImage);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.TheRecordesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TheTitleLabel);
            this.Name = "ManageDetainLicesneForm";
            this.Text = "ManageDetainLicesneForm";
            this.Load += new System.EventHandler(this.ManageDetainLicesneForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetainLIceseses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManageApplicationTypeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DetainLIceseses;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem perosnInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personHistoryToolStripMenuItem;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.PictureBox ManageApplicationTypeImage;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label TheRecordesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TheTitleLabel;
        private System.Windows.Forms.ComboBox IsActiveCompoBox;
        private System.Windows.Forms.MaskedTextBox TheFilterInformaion;
        private System.Windows.Forms.ComboBox TheFiltersCommboBox;
        private System.Windows.Forms.Label label1;
    }
}