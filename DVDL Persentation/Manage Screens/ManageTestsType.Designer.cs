namespace DVDL_Persentation
{
    partial class ManageTestsType
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
            TheTestsTypeData = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editTheApplicationToolStripMenuItem = new ToolStripMenuItem();
            ManageTestsTypeImage = new PictureBox();
            CancelButton = new Button();
            TheRecordesLabel = new Label();
            label2 = new Label();
            TheTitleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)TheTestsTypeData).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ManageTestsTypeImage).BeginInit();
            SuspendLayout();
            // 
            // TheTestsTypeData
            // 
            TheTestsTypeData.AllowUserToAddRows = false;
            TheTestsTypeData.AllowUserToDeleteRows = false;
            TheTestsTypeData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TheTestsTypeData.ContextMenuStrip = contextMenuStrip1;
            TheTestsTypeData.Location = new Point(8, 238);
            TheTestsTypeData.Margin = new Padding(4, 3, 4, 3);
            TheTestsTypeData.Name = "TheTestsTypeData";
            TheTestsTypeData.ReadOnly = true;
            TheTestsTypeData.Size = new Size(457, 211);
            TheTestsTypeData.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editTheApplicationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(142, 26);
            // 
            // editTheApplicationToolStripMenuItem
            // 
            editTheApplicationToolStripMenuItem.Name = "editTheApplicationToolStripMenuItem";
            editTheApplicationToolStripMenuItem.Size = new Size(141, 22);
            editTheApplicationToolStripMenuItem.Text = "Edit The Test";
            editTheApplicationToolStripMenuItem.Click += editTheApplicationToolStripMenuItem_Click;
            // 
            // ManageTestsTypeImage
            // 
            ManageTestsTypeImage.BackgroundImage = Properties.Resource.TestType_512;
            ManageTestsTypeImage.BackgroundImageLayout = ImageLayout.Stretch;
            ManageTestsTypeImage.Location = new Point(95, 12);
            ManageTestsTypeImage.Margin = new Padding(4, 3, 4, 3);
            ManageTestsTypeImage.Name = "ManageTestsTypeImage";
            ManageTestsTypeImage.Size = new Size(237, 174);
            ManageTestsTypeImage.TabIndex = 11;
            ManageTestsTypeImage.TabStop = false;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(377, 514);
            CancelButton.Margin = new Padding(4, 3, 4, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(88, 27);
            CancelButton.TabIndex = 10;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // TheRecordesLabel
            // 
            TheRecordesLabel.AutoSize = true;
            TheRecordesLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TheRecordesLabel.Location = new Point(122, 500);
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
            label2.Location = new Point(8, 500);
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
            TheTitleLabel.Location = new Point(13, 189);
            TheTitleLabel.Margin = new Padding(4, 0, 4, 0);
            TheTitleLabel.Name = "TheTitleLabel";
            TheTitleLabel.Size = new Size(415, 31);
            TheTitleLabel.TabIndex = 7;
            TheTitleLabel.Text = "Manage The Application Types";
            // 
            // ManageTestsType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 556);
            Controls.Add(TheTestsTypeData);
            Controls.Add(ManageTestsTypeImage);
            Controls.Add(CancelButton);
            Controls.Add(TheRecordesLabel);
            Controls.Add(label2);
            Controls.Add(TheTitleLabel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManageTestsType";
            Text = "ManageTestTypes";
            Load += ManageTestsType_Load;
            ((System.ComponentModel.ISupportInitialize)TheTestsTypeData).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ManageTestsTypeImage).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TheTestsTypeData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editTheApplicationToolStripMenuItem;
        private System.Windows.Forms.PictureBox ManageTestsTypeImage;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label TheRecordesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TheTitleLabel;
    }
}