namespace TheSereens.Manage_Screens
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
            this.components = new System.ComponentModel.Container();
            this.TheInternationalData = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.personInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageApplicationTypeImage = new System.Windows.Forms.PictureBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TheRecordesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TheTitleLabel = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TheInternationalData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManageApplicationTypeImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TheInternationalData
            // 
            this.TheInternationalData.AllowUserToAddRows = false;
            this.TheInternationalData.AllowUserToDeleteRows = false;
            this.TheInternationalData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TheInternationalData.ContextMenuStrip = this.contextMenuStrip1;
            this.TheInternationalData.Location = new System.Drawing.Point(3, 269);
            this.TheInternationalData.Name = "TheInternationalData";
            this.TheInternationalData.ReadOnly = true;
            this.TheInternationalData.Size = new System.Drawing.Size(795, 282);
            this.TheInternationalData.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personInfoToolStripMenuItem,
            this.licenseInfoToolStripMenuItem,
            this.personHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // personInfoToolStripMenuItem
            // 
            this.personInfoToolStripMenuItem.Name = "personInfoToolStripMenuItem";
            this.personInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personInfoToolStripMenuItem.Text = "Person Info";
            this.personInfoToolStripMenuItem.Click += new System.EventHandler(this.personInfoToolStripMenuItem_Click);
            // 
            // licenseInfoToolStripMenuItem
            // 
            this.licenseInfoToolStripMenuItem.Name = "licenseInfoToolStripMenuItem";
            this.licenseInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.licenseInfoToolStripMenuItem.Text = "License info";
            this.licenseInfoToolStripMenuItem.Click += new System.EventHandler(this.licenseInfoToolStripMenuItem_Click);
            // 
            // personHistoryToolStripMenuItem
            // 
            this.personHistoryToolStripMenuItem.Name = "personHistoryToolStripMenuItem";
            this.personHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personHistoryToolStripMenuItem.Text = "Person History";
            this.personHistoryToolStripMenuItem.Click += new System.EventHandler(this.personHistoryToolStripMenuItem_Click);
            // 
            // ManageApplicationTypeImage
            // 
            this.ManageApplicationTypeImage.BackgroundImage = global::TheSereens.Properties.Resources.international_driver_s_license_card_identification_data_information_concept;
            this.ManageApplicationTypeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManageApplicationTypeImage.Location = new System.Drawing.Point(296, 3);
            this.ManageApplicationTypeImage.Name = "ManageApplicationTypeImage";
            this.ManageApplicationTypeImage.Size = new System.Drawing.Size(203, 171);
            this.ManageApplicationTypeImage.TabIndex = 11;
            this.ManageApplicationTypeImage.TabStop = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(713, 562);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TheRecordesLabel
            // 
            this.TheRecordesLabel.AutoSize = true;
            this.TheRecordesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheRecordesLabel.Location = new System.Drawing.Point(105, 566);
            this.TheRecordesLabel.Name = "TheRecordesLabel";
            this.TheRecordesLabel.Size = new System.Drawing.Size(44, 17);
            this.TheRecordesLabel.TabIndex = 9;
            this.TheRecordesLabel.Text = "????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Recordes : ";
            // 
            // TheTitleLabel
            // 
            this.TheTitleLabel.AutoSize = true;
            this.TheTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheTitleLabel.ForeColor = System.Drawing.Color.Red;
            this.TheTitleLabel.Location = new System.Drawing.Point(194, 190);
            this.TheTitleLabel.Name = "TheTitleLabel";
            this.TheTitleLabel.Size = new System.Drawing.Size(470, 31);
            this.TheTitleLabel.TabIndex = 7;
            this.TheTitleLabel.Text = "Manage The International Licenses";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(713, 208);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 47);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(10, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 38);
            this.panel1.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filters : ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // ManageInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.TheInternationalData);
            this.Controls.Add(this.ManageApplicationTypeImage);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.TheRecordesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TheTitleLabel);
            this.Name = "ManageInternationalLicense";
            this.Text = "ManageInternationalLicense";
            this.Load += new System.EventHandler(this.ManageInternationalLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TheInternationalData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManageApplicationTypeImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}