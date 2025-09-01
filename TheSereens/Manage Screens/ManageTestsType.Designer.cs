namespace TheSereens
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
            this.components = new System.ComponentModel.Container();
            this.TheTestsTypeData = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTheApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageTestsTypeImage = new System.Windows.Forms.PictureBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TheRecordesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TheTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TheTestsTypeData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManageTestsTypeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TheTestsTypeData
            // 
            this.TheTestsTypeData.AllowUserToAddRows = false;
            this.TheTestsTypeData.AllowUserToDeleteRows = false;
            this.TheTestsTypeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TheTestsTypeData.ContextMenuStrip = this.contextMenuStrip1;
            this.TheTestsTypeData.Location = new System.Drawing.Point(-7, 219);
            this.TheTestsTypeData.Name = "TheTestsTypeData";
            this.TheTestsTypeData.ReadOnly = true;
            this.TheTestsTypeData.Size = new System.Drawing.Size(795, 282);
            this.TheTestsTypeData.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTheApplicationToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // editTheApplicationToolStripMenuItem
            // 
            this.editTheApplicationToolStripMenuItem.Name = "editTheApplicationToolStripMenuItem";
            this.editTheApplicationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editTheApplicationToolStripMenuItem.Text = "Edit The Test";
            this.editTheApplicationToolStripMenuItem.Click += new System.EventHandler(this.editTheApplicationToolStripMenuItem_Click);
            // 
            // ManageTestsTypeImage
            // 
            this.ManageTestsTypeImage.BackgroundImage = global::TheSereens.Properties.Resources._3d_illustration_hand_putting_tick_paper;
            this.ManageTestsTypeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManageTestsTypeImage.Location = new System.Drawing.Point(300, 12);
            this.ManageTestsTypeImage.Name = "ManageTestsTypeImage";
            this.ManageTestsTypeImage.Size = new System.Drawing.Size(203, 151);
            this.ManageTestsTypeImage.TabIndex = 11;
            this.ManageTestsTypeImage.TabStop = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(713, 517);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // TheRecordesLabel
            // 
            this.TheRecordesLabel.AutoSize = true;
            this.TheRecordesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheRecordesLabel.Location = new System.Drawing.Point(105, 517);
            this.TheRecordesLabel.Name = "TheRecordesLabel";
            this.TheRecordesLabel.Size = new System.Drawing.Size(44, 17);
            this.TheRecordesLabel.TabIndex = 9;
            this.TheRecordesLabel.Text = "????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 517);
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
            this.TheTitleLabel.Location = new System.Drawing.Point(192, 166);
            this.TheTitleLabel.Name = "TheTitleLabel";
            this.TheTitleLabel.Size = new System.Drawing.Size(415, 31);
            this.TheTitleLabel.TabIndex = 7;
            this.TheTitleLabel.Text = "Manage The Application Types";
            // 
            // ManageTestsType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.TheTestsTypeData);
            this.Controls.Add(this.ManageTestsTypeImage);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.TheRecordesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TheTitleLabel);
            this.Name = "ManageTestsType";
            this.Text = "ManageTestTypes";
            this.Load += new System.EventHandler(this.ManageTestsType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TheTestsTypeData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManageTestsTypeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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