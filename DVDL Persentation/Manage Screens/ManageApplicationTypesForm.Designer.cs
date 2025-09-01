namespace DVDL_Persentation
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            TheInternationallicenseData = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            perosnInformationToolStripMenuItem = new ToolStripMenuItem();
            TheTitleLabel = new Label();
            label2 = new Label();
            TheRecordesLabel = new Label();
            CancelButton = new Button();
            ManageApplicationTypeImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)TheInternationallicenseData).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ManageApplicationTypeImage).BeginInit();
            SuspendLayout();
            // 
            // TheInternationallicenseData
            // 
            TheInternationallicenseData.AllowUserToAddRows = false;
            TheInternationallicenseData.AllowUserToDeleteRows = false;
            TheInternationallicenseData.BackgroundColor = Color.FromArgb(45, 45, 45);
            TheInternationallicenseData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TheInternationallicenseData.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            TheInternationallicenseData.DefaultCellStyle = dataGridViewCellStyle1;
            TheInternationallicenseData.GridColor = Color.Gray;
            TheInternationallicenseData.Location = new Point(23, 327);
            TheInternationallicenseData.Margin = new Padding(4);
            TheInternationallicenseData.Name = "TheInternationallicenseData";
            TheInternationallicenseData.ReadOnly = true;
            TheInternationallicenseData.Size = new Size(508, 200);
            TheInternationallicenseData.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.FromArgb(60, 60, 60);
            contextMenuStrip1.ForeColor = Color.White;
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { perosnInformationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(159, 26);
            // 
            // perosnInformationToolStripMenuItem
            // 
            perosnInformationToolStripMenuItem.Name = "perosnInformationToolStripMenuItem";
            perosnInformationToolStripMenuItem.Size = new Size(158, 22);
            perosnInformationToolStripMenuItem.Text = "Edit Application";
            perosnInformationToolStripMenuItem.Click += EditApplicationToolStripMenuItem_Click;
            // 
            // TheTitleLabel
            // 
            TheTitleLabel.AutoSize = true;
            TheTitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TheTitleLabel.ForeColor = Color.Teal;
            TheTitleLabel.Location = new Point(116, 265);
            TheTitleLabel.Margin = new Padding(4, 0, 4, 0);
            TheTitleLabel.Name = "TheTitleLabel";
            TheTitleLabel.Size = new Size(313, 32);
            TheTitleLabel.TabIndex = 10;
            TheTitleLabel.Text = "Manage Application Type ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(23, 584);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 9;
            label2.Text = "Records:";
            // 
            // TheRecordesLabel
            // 
            TheRecordesLabel.AutoSize = true;
            TheRecordesLabel.Font = new Font("Segoe UI", 10F);
            TheRecordesLabel.Location = new Point(117, 584);
            TheRecordesLabel.Margin = new Padding(4, 0, 4, 0);
            TheRecordesLabel.Name = "TheRecordesLabel";
            TheRecordesLabel.Size = new Size(17, 19);
            TheRecordesLabel.TabIndex = 8;
            TheRecordesLabel.Text = "0";
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.DarkRed;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(412, 584);
            CancelButton.Margin = new Padding(4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(93, 46);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // ManageApplicationTypeImage
            // 
            ManageApplicationTypeImage.BackgroundImage = Properties.Resource.Application_Types_512;
            ManageApplicationTypeImage.BackgroundImageLayout = ImageLayout.Stretch;
            ManageApplicationTypeImage.Location = new Point(156, 13);
            ManageApplicationTypeImage.Margin = new Padding(4);
            ManageApplicationTypeImage.Name = "ManageApplicationTypeImage";
            ManageApplicationTypeImage.Size = new Size(233, 209);
            ManageApplicationTypeImage.TabIndex = 7;
            ManageApplicationTypeImage.TabStop = false;
            // 
            // ManageApplicationTypesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(544, 637);
            Controls.Add(ManageApplicationTypeImage);
            Controls.Add(CancelButton);
            Controls.Add(TheRecordesLabel);
            Controls.Add(label2);
            Controls.Add(TheTitleLabel);
            Controls.Add(TheInternationallicenseData);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ManageApplicationTypesForm";
            Text = "Manage Application Types";
            Load += ManageApplicationTypesForm_Load;
            ((System.ComponentModel.ISupportInitialize)TheInternationallicenseData).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ManageApplicationTypeImage).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
    }
}
