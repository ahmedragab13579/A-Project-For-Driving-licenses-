namespace TheSereens
{
    partial class ManagePeopleForm
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
            this.TheTitleLabel = new System.Windows.Forms.Label();
            this.DataOfAllPeopleDataGradeView = new System.Windows.Forms.DataGridView();
            this.TheProcessInPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updaateInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletaThePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TheNumberOfRecordesButton = new System.Windows.Forms.Label();
            this.TheFiltersCommboBox = new System.Windows.Forms.ComboBox();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.MainMenuImage = new System.Windows.Forms.PictureBox();
            this.TheRecordesNumberLable = new System.Windows.Forms.Label();
            this.TheFilterInformationTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataOfAllPeopleDataGradeView)).BeginInit();
            this.TheProcessInPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TheTitleLabel
            // 
            this.TheTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheTitleLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TheTitleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TheTitleLabel.Location = new System.Drawing.Point(463, 141);
            this.TheTitleLabel.Name = "TheTitleLabel";
            this.TheTitleLabel.Size = new System.Drawing.Size(231, 36);
            this.TheTitleLabel.TabIndex = 1;
            this.TheTitleLabel.Text = "Manage People";
            this.TheTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataOfAllPeopleDataGradeView
            // 
            this.DataOfAllPeopleDataGradeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataOfAllPeopleDataGradeView.ContextMenuStrip = this.TheProcessInPeople;
            this.DataOfAllPeopleDataGradeView.Location = new System.Drawing.Point(0, 190);
            this.DataOfAllPeopleDataGradeView.Name = "DataOfAllPeopleDataGradeView";
            this.DataOfAllPeopleDataGradeView.Size = new System.Drawing.Size(1154, 188);
            this.DataOfAllPeopleDataGradeView.TabIndex = 2;
            // 
            // TheProcessInPeople
            // 
            this.TheProcessInPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updaateInformationToolStripMenuItem,
            this.deletaThePersonToolStripMenuItem,
            this.theInformationToolStripMenuItem});
            this.TheProcessInPeople.Name = "contextMenuStrip1";
            this.TheProcessInPeople.Size = new System.Drawing.Size(182, 92);
            // 
            // updaateInformationToolStripMenuItem
            // 
            this.updaateInformationToolStripMenuItem.Name = "updaateInformationToolStripMenuItem";
            this.updaateInformationToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.updaateInformationToolStripMenuItem.Text = "UpdaateInformation";
            this.updaateInformationToolStripMenuItem.Click += new System.EventHandler(this.UpdateInformationToolStripMenuItem_Click);
            // 
            // deletaThePersonToolStripMenuItem
            // 
            this.deletaThePersonToolStripMenuItem.Name = "deletaThePersonToolStripMenuItem";
            this.deletaThePersonToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.deletaThePersonToolStripMenuItem.Text = "Deleta the person";
            this.deletaThePersonToolStripMenuItem.Click += new System.EventHandler(this.DeleteaThePersonToolStripMenuItem_Click);
            // 
            // theInformationToolStripMenuItem
            // 
            this.theInformationToolStripMenuItem.Name = "theInformationToolStripMenuItem";
            this.theInformationToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.theInformationToolStripMenuItem.Text = "The Information";
            this.theInformationToolStripMenuItem.Click += new System.EventHandler(this.TheInformationToolStripMenuItem_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(1083, 400);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(62, 43);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter By : ";
            // 
            // TheNumberOfRecordesButton
            // 
            this.TheNumberOfRecordesButton.Location = new System.Drawing.Point(24, 415);
            this.TheNumberOfRecordesButton.Name = "TheNumberOfRecordesButton";
            this.TheNumberOfRecordesButton.Size = new System.Drawing.Size(82, 23);
            this.TheNumberOfRecordesButton.TabIndex = 6;
            this.TheNumberOfRecordesButton.Text = "# Recordes : ";
            // 
            // TheFiltersCommboBox
            // 
            this.TheFiltersCommboBox.FormattingEnabled = true;
            this.TheFiltersCommboBox.Location = new System.Drawing.Point(103, 150);
            this.TheFiltersCommboBox.Name = "TheFiltersCommboBox";
            this.TheFiltersCommboBox.Size = new System.Drawing.Size(121, 21);
            this.TheFiltersCommboBox.TabIndex = 7;
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.BackgroundImage = global::TheSereens.Properties.Resources._9731573;
            this.AddPersonButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPersonButton.Location = new System.Drawing.Point(1083, 124);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(62, 47);
            this.AddPersonButton.TabIndex = 3;
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPeopleButton_Click);
            // 
            // MainMenuImage
            // 
            this.MainMenuImage.BackgroundImage = global::TheSereens.Properties.Resources._1606_m00_i125_n016_S_c12_Business_people_team_work_managment_structure_vector_illustration;
            this.MainMenuImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenuImage.Location = new System.Drawing.Point(463, 3);
            this.MainMenuImage.Name = "MainMenuImage";
            this.MainMenuImage.Size = new System.Drawing.Size(231, 135);
            this.MainMenuImage.TabIndex = 0;
            this.MainMenuImage.TabStop = false;
            // 
            // TheRecordesNumberLable
            // 
            this.TheRecordesNumberLable.Location = new System.Drawing.Point(100, 415);
            this.TheRecordesNumberLable.Name = "TheRecordesNumberLable";
            this.TheRecordesNumberLable.Size = new System.Drawing.Size(82, 23);
            this.TheRecordesNumberLable.TabIndex = 8;
            // 
            // TheFilterInformationTextBox
            // 
            this.TheFilterInformationTextBox.Location = new System.Drawing.Point(247, 150);
            this.TheFilterInformationTextBox.Name = "TheFilterInformationTextBox";
            this.TheFilterInformationTextBox.Size = new System.Drawing.Size(122, 20);
            this.TheFilterInformationTextBox.TabIndex = 10;
            this.TheFilterInformationTextBox.TextChanged += new System.EventHandler(this.TheFilterInformationTextBox_TextChanged);
            // 
            // ManagePeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1157, 450);
            this.Controls.Add(this.TheFilterInformationTextBox);
            this.Controls.Add(this.TheRecordesNumberLable);
            this.Controls.Add(this.TheFiltersCommboBox);
            this.Controls.Add(this.TheNumberOfRecordesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddPersonButton);
            this.Controls.Add(this.DataOfAllPeopleDataGradeView);
            this.Controls.Add(this.TheTitleLabel);
            this.Controls.Add(this.MainMenuImage);
            this.Name = "ManagePeopleForm";
            this.Text = "ManagePeopleForm";
            this.Load += new System.EventHandler(this.ManagePeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataOfAllPeopleDataGradeView)).EndInit();
            this.TheProcessInPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainMenuImage;
        private System.Windows.Forms.Label TheTitleLabel;
        private System.Windows.Forms.DataGridView DataOfAllPeopleDataGradeView;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TheNumberOfRecordesButton;
        private System.Windows.Forms.ComboBox TheFiltersCommboBox;
        private System.Windows.Forms.Label TheRecordesNumberLable;
        private System.Windows.Forms.ContextMenuStrip TheProcessInPeople;
        private System.Windows.Forms.ToolStripMenuItem updaateInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletaThePersonToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox TheFilterInformationTextBox;
        private System.Windows.Forms.ToolStripMenuItem theInformationToolStripMenuItem;
    }
}