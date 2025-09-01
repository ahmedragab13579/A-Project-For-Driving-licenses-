namespace DVDL_Persentation.Manage_Screens
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
            components = new System.ComponentModel.Container();
            DetainLIceseses = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            perosnInformationToolStripMenuItem = new ToolStripMenuItem();
            licenseInformationToolStripMenuItem = new ToolStripMenuItem();
            personHistoryToolStripMenuItem = new ToolStripMenuItem();
            Add = new Button();
            CancelButton = new Button();
            TheRecordesLabel = new Label();
            label2 = new Label();
            TheTitleLabel = new Label();
            ManageApplicationTypeImage = new PictureBox();
            IsActiveCompoBox = new ComboBox();
            TheFiltersCommboBox = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DetainLIceseses).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ManageApplicationTypeImage).BeginInit();
            SuspendLayout();
            // 
            // DetainLIceseses
            // 
            DetainLIceseses.AllowUserToAddRows = false;
            DetainLIceseses.AllowUserToDeleteRows = false;
            DetainLIceseses.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            DetainLIceseses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DetainLIceseses.ContextMenuStrip = contextMenuStrip1;
            DetainLIceseses.Location = new Point(1, 301);
            DetainLIceseses.Margin = new Padding(4, 3, 4, 3);
            DetainLIceseses.Name = "DetainLIceseses";
            DetainLIceseses.ReadOnly = true;
            DetainLIceseses.Size = new Size(927, 325);
            DetainLIceseses.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { perosnInformationToolStripMenuItem, licenseInformationToolStripMenuItem, personHistoryToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(180, 70);
            // 
            // perosnInformationToolStripMenuItem
            // 
            perosnInformationToolStripMenuItem.Name = "perosnInformationToolStripMenuItem";
            perosnInformationToolStripMenuItem.Size = new Size(179, 22);
            perosnInformationToolStripMenuItem.Text = "Perosn Information";
            perosnInformationToolStripMenuItem.Click += perosnInformationToolStripMenuItem_Click;
            // 
            // licenseInformationToolStripMenuItem
            // 
            licenseInformationToolStripMenuItem.Name = "licenseInformationToolStripMenuItem";
            licenseInformationToolStripMenuItem.Size = new Size(179, 22);
            licenseInformationToolStripMenuItem.Text = "License Information";
            licenseInformationToolStripMenuItem.Click += licenseInformationToolStripMenuItem_Click;
            // 
            // personHistoryToolStripMenuItem
            // 
            personHistoryToolStripMenuItem.Name = "personHistoryToolStripMenuItem";
            personHistoryToolStripMenuItem.Size = new Size(179, 22);
            personHistoryToolStripMenuItem.Text = "Person History";
            personHistoryToolStripMenuItem.Click += personHistoryToolStripMenuItem_Click;
            // 
            // Add
            // 
            Add.Location = new Point(830, 227);
            Add.Margin = new Padding(4, 3, 4, 3);
            Add.Name = "Add";
            Add.Size = new Size(88, 58);
            Add.TabIndex = 13;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(830, 639);
            CancelButton.Margin = new Padding(4, 3, 4, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(88, 27);
            CancelButton.TabIndex = 11;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // TheRecordesLabel
            // 
            TheRecordesLabel.AutoSize = true;
            TheRecordesLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TheRecordesLabel.Location = new Point(120, 644);
            TheRecordesLabel.Margin = new Padding(4, 0, 4, 0);
            TheRecordesLabel.Name = "TheRecordesLabel";
            TheRecordesLabel.Size = new Size(44, 17);
            TheRecordesLabel.TabIndex = 10;
            TheRecordesLabel.Text = "????";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 639);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 9;
            label2.Text = "Recordes : ";
            // 
            // TheTitleLabel
            // 
            TheTitleLabel.AutoSize = true;
            TheTitleLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TheTitleLabel.ForeColor = Color.Red;
            TheTitleLabel.Location = new Point(245, 227);
            TheTitleLabel.Margin = new Padding(4, 0, 4, 0);
            TheTitleLabel.Name = "TheTitleLabel";
            TheTitleLabel.Size = new Size(392, 31);
            TheTitleLabel.TabIndex = 8;
            TheTitleLabel.Text = "Manage The Detain Licesens\r\n";
            // 
            // ManageApplicationTypeImage
            // 
            ManageApplicationTypeImage.BackgroundImage = Properties.Resource.Detain_512;
            ManageApplicationTypeImage.BackgroundImageLayout = ImageLayout.Stretch;
            ManageApplicationTypeImage.Location = new Point(349, 14);
            ManageApplicationTypeImage.Margin = new Padding(4, 3, 4, 3);
            ManageApplicationTypeImage.Name = "ManageApplicationTypeImage";
            ManageApplicationTypeImage.Size = new Size(237, 197);
            ManageApplicationTypeImage.TabIndex = 12;
            ManageApplicationTypeImage.TabStop = false;
            // 
            // IsActiveCompoBox
            // 
            IsActiveCompoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IsActiveCompoBox.Enabled = false;
            IsActiveCompoBox.FormattingEnabled = true;
            IsActiveCompoBox.Items.AddRange(new object[] { "Yes", "No" });
            IsActiveCompoBox.Location = new Point(295, 267);
            IsActiveCompoBox.Margin = new Padding(4, 3, 4, 3);
            IsActiveCompoBox.Name = "IsActiveCompoBox";
            IsActiveCompoBox.Size = new Size(140, 23);
            IsActiveCompoBox.TabIndex = 25;
            IsActiveCompoBox.Visible = false;
            IsActiveCompoBox.SelectedIndexChanged += IsActiveCompoBox_SelectedIndexChanged;
            // 
            // TheFiltersCommboBox
            // 
            TheFiltersCommboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TheFiltersCommboBox.FormattingEnabled = true;
            TheFiltersCommboBox.Location = new Point(110, 267);
            TheFiltersCommboBox.Margin = new Padding(4, 3, 4, 3);
            TheFiltersCommboBox.Name = "TheFiltersCommboBox";
            TheFiltersCommboBox.Size = new Size(140, 23);
            TheFiltersCommboBox.TabIndex = 23;
            TheFiltersCommboBox.SelectedIndexChanged += TheFiltersCommboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 270);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 22;
            label1.Text = "Filter By : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(295, 270);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 26;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(277, 270);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 23);
            dateTimePicker1.TabIndex = 27;
            dateTimePicker1.Visible = false;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // ManageDetainLicesneForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 673);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(IsActiveCompoBox);
            Controls.Add(TheFiltersCommboBox);
            Controls.Add(label1);
            Controls.Add(DetainLIceseses);
            Controls.Add(Add);
            Controls.Add(ManageApplicationTypeImage);
            Controls.Add(CancelButton);
            Controls.Add(TheRecordesLabel);
            Controls.Add(label2);
            Controls.Add(TheTitleLabel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManageDetainLicesneForm";
            Text = "ManageDetainLicesneForm";
            Load += ManageDetainLicesneForm_Load;
            ((System.ComponentModel.ISupportInitialize)DetainLIceseses).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ManageApplicationTypeImage).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.ComboBox TheFiltersCommboBox;
        private System.Windows.Forms.Label label1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
    }
}