namespace TheSereens
{
    partial class ManagePeopleForm
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

            // Form
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ClientSize = new System.Drawing.Size(1157, 450);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManagePeopleForm";
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.ManagePeopleForm_Load);

            // Main Image
            this.MainMenuImage.BackgroundImage = global::TheSereens.Properties.Resources._1606_m00_i125_n016_S_c12_Business_people_team_work_managment_structure_vector_illustration;
            this.MainMenuImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainMenuImage.Location = new System.Drawing.Point(450, 10);
            this.MainMenuImage.Size = new System.Drawing.Size(250, 120);
            this.MainMenuImage.TabStop = false;

            // Title Label
            this.TheTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.TheTitleLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.TheTitleLabel.Location = new System.Drawing.Point(430, 130);
            this.TheTitleLabel.Size = new System.Drawing.Size(300, 40);
            this.TheTitleLabel.Text = "Manage People";
            this.TheTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // DataGridView
            this.DataOfAllPeopleDataGradeView.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.DataOfAllPeopleDataGradeView.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.DataOfAllPeopleDataGradeView.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DataOfAllPeopleDataGradeView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.DataOfAllPeopleDataGradeView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataOfAllPeopleDataGradeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataOfAllPeopleDataGradeView.GridColor = System.Drawing.Color.Gray;
            this.DataOfAllPeopleDataGradeView.Location = new System.Drawing.Point(30, 190);
            this.DataOfAllPeopleDataGradeView.Size = new System.Drawing.Size(1090, 190);
            this.DataOfAllPeopleDataGradeView.ContextMenuStrip = this.TheProcessInPeople;

            // Context Menu
            this.TheProcessInPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.updaateInformationToolStripMenuItem,
                this.deletaThePersonToolStripMenuItem,
                this.theInformationToolStripMenuItem
            });

            this.updaateInformationToolStripMenuItem.Text = "Update Information";
            this.updaateInformationToolStripMenuItem.Click += new System.EventHandler(this.UpdateInformationToolStripMenuItem_Click);

            this.deletaThePersonToolStripMenuItem.Text = "Delete Person";
            this.deletaThePersonToolStripMenuItem.Click += new System.EventHandler(this.DeleteaThePersonToolStripMenuItem_Click);

            this.theInformationToolStripMenuItem.Text = "View Information";
            this.theInformationToolStripMenuItem.Click += new System.EventHandler(this.TheInformationToolStripMenuItem_Click);

            // Cancel Button
            this.CancelButton.Text = "Cancel";
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(1050, 400);
            this.CancelButton.Size = new System.Drawing.Size(80, 35);
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);

            // Filter Label
            this.label2.Text = "Filter By:";
            this.label2.Location = new System.Drawing.Point(30, 155);
            this.label2.Size = new System.Drawing.Size(60, 23);

            // ComboBox
            this.TheFiltersCommboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TheFiltersCommboBox.Location = new System.Drawing.Point(100, 152);
            this.TheFiltersCommboBox.Size = new System.Drawing.Size(130, 24);

            // Filter TextBox
            this.TheFilterInformationTextBox.Location = new System.Drawing.Point(250, 152);
            this.TheFilterInformationTextBox.Size = new System.Drawing.Size(150, 24);
            this.TheFilterInformationTextBox.TextChanged += new System.EventHandler(this.TheFilterInformationTextBox_TextChanged);

            // Record Labels
            this.TheNumberOfRecordesButton.Text = "Total Records:";
            this.TheNumberOfRecordesButton.Location = new System.Drawing.Point(30, 400);
            this.TheNumberOfRecordesButton.Size = new System.Drawing.Size(120, 24);

            this.TheRecordesNumberLable.Location = new System.Drawing.Point(160, 400);
            this.TheRecordesNumberLable.Size = new System.Drawing.Size(100, 24);

            // Add Button
            this.AddPersonButton.BackgroundImage = global::TheSereens.Properties.Resources._9731573;
            this.AddPersonButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPersonButton.FlatAppearance.BorderSize = 0;
            this.AddPersonButton.Location = new System.Drawing.Point(1050, 130);
            this.AddPersonButton.Size = new System.Drawing.Size(50, 45);
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPeopleButton_Click);

            // Add Controls
            this.Controls.Add(this.MainMenuImage);
            this.Controls.Add(this.TheTitleLabel);
            this.Controls.Add(this.DataOfAllPeopleDataGradeView);
            this.Controls.Add(this.AddPersonButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TheFiltersCommboBox);
            this.Controls.Add(this.TheFilterInformationTextBox);
            this.Controls.Add(this.TheNumberOfRecordesButton);
            this.Controls.Add(this.TheRecordesNumberLable);

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
