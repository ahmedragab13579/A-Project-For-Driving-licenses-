namespace DVDL_Persentation
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            TheTitleLabel = new Label();
            DataOfAllPeopleDataGradeView = new DataGridView();
            TheProcessInPeople = new ContextMenuStrip(components);
            updaateInformationToolStripMenuItem = new ToolStripMenuItem();
            deletaThePersonToolStripMenuItem = new ToolStripMenuItem();
            theInformationToolStripMenuItem = new ToolStripMenuItem();
            CancelButton = new Button();
            label2 = new Label();
            TheNumberOfRecordesButton = new Label();
            TheFiltersCommboBox = new ComboBox();
            AddPersonButton = new Button();
            MainMenuImage = new PictureBox();
            TheRecordesNumberLable = new Label();
            FilterTextbox = new TextBox();
            Add = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)DataOfAllPeopleDataGradeView).BeginInit();
            TheProcessInPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainMenuImage).BeginInit();
            SuspendLayout();
            // 
            // TheTitleLabel
            // 
            TheTitleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            TheTitleLabel.ForeColor = Color.DeepSkyBlue;
            TheTitleLabel.Location = new Point(350, 192);
            TheTitleLabel.Name = "TheTitleLabel";
            TheTitleLabel.Size = new Size(300, 40);
            TheTitleLabel.TabIndex = 2;
            TheTitleLabel.Text = "Manage People";
            TheTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DataOfAllPeopleDataGradeView
            // 
            DataOfAllPeopleDataGradeView.AllowUserToAddRows = false;
            DataOfAllPeopleDataGradeView.AllowUserToDeleteRows = false;
            DataOfAllPeopleDataGradeView.BackgroundColor = Color.FromArgb(45, 45, 45);
            DataOfAllPeopleDataGradeView.BorderStyle = BorderStyle.None;
            DataOfAllPeopleDataGradeView.ContextMenuStrip = TheProcessInPeople;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DataOfAllPeopleDataGradeView.DefaultCellStyle = dataGridViewCellStyle1;
            DataOfAllPeopleDataGradeView.GridColor = Color.Gray;
            DataOfAllPeopleDataGradeView.Location = new Point(18, 299);
            DataOfAllPeopleDataGradeView.Name = "DataOfAllPeopleDataGradeView";
            DataOfAllPeopleDataGradeView.ReadOnly = true;
            DataOfAllPeopleDataGradeView.Size = new Size(967, 190);
            DataOfAllPeopleDataGradeView.TabIndex = 3;
            // 
            // TheProcessInPeople
            // 
            TheProcessInPeople.Items.AddRange(new ToolStripItem[] { updaateInformationToolStripMenuItem, deletaThePersonToolStripMenuItem, theInformationToolStripMenuItem });
            TheProcessInPeople.Name = "TheProcessInPeople";
            TheProcessInPeople.Size = new Size(179, 70);
            TheProcessInPeople.Opening += TheProcessInPeople_Opening;
            // 
            // updaateInformationToolStripMenuItem
            // 
            updaateInformationToolStripMenuItem.Name = "updaateInformationToolStripMenuItem";
            updaateInformationToolStripMenuItem.Size = new Size(178, 22);
            updaateInformationToolStripMenuItem.Text = "Update Information";
            updaateInformationToolStripMenuItem.Click += UpdateInformationToolStripMenuItem_Click;
            // 
            // deletaThePersonToolStripMenuItem
            // 
            deletaThePersonToolStripMenuItem.Name = "deletaThePersonToolStripMenuItem";
            deletaThePersonToolStripMenuItem.Size = new Size(178, 22);
            deletaThePersonToolStripMenuItem.Text = "Delete Person";
            deletaThePersonToolStripMenuItem.Click += DeleteaThePersonToolStripMenuItem_Click;
            // 
            // theInformationToolStripMenuItem
            // 
            theInformationToolStripMenuItem.Name = "theInformationToolStripMenuItem";
            theInformationToolStripMenuItem.Size = new Size(178, 22);
            theInformationToolStripMenuItem.Text = "View Information";
            theInformationToolStripMenuItem.Click += TheInformationToolStripMenuItem_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(64, 64, 64);
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(905, 512);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(80, 35);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // label2
            // 
            label2.Location = new Point(18, 264);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 6;
            label2.Text = "Filter By:";
            // 
            // TheNumberOfRecordesButton
            // 
            TheNumberOfRecordesButton.Location = new Point(18, 509);
            TheNumberOfRecordesButton.Name = "TheNumberOfRecordesButton";
            TheNumberOfRecordesButton.Size = new Size(120, 24);
            TheNumberOfRecordesButton.TabIndex = 9;
            TheNumberOfRecordesButton.Text = "Total Records:";
            // 
            // TheFiltersCommboBox
            // 
            TheFiltersCommboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TheFiltersCommboBox.Items.AddRange(new object[] { "None" });
            TheFiltersCommboBox.Location = new Point(88, 261);
            TheFiltersCommboBox.Name = "TheFiltersCommboBox";
            TheFiltersCommboBox.Size = new Size(130, 25);
            TheFiltersCommboBox.TabIndex = 7;
            TheFiltersCommboBox.SelectedIndexChanged += TheFiltersCommboBox_SelectedIndexChanged;
            // 
            // AddPersonButton
            // 
            AddPersonButton.BackgroundImageLayout = ImageLayout.Stretch;
            AddPersonButton.FlatAppearance.BorderSize = 0;
            AddPersonButton.FlatStyle = FlatStyle.Flat;
            AddPersonButton.Location = new Point(1038, 239);
            AddPersonButton.Name = "AddPersonButton";
            AddPersonButton.Size = new Size(50, 45);
            AddPersonButton.TabIndex = 4;
            AddPersonButton.UseVisualStyleBackColor = true;
            // 
            // MainMenuImage
            // 
            MainMenuImage.BackgroundImage = Properties.Resource.People_400;
            MainMenuImage.BackgroundImageLayout = ImageLayout.Stretch;
            MainMenuImage.Location = new Point(375, 17);
            MainMenuImage.Name = "MainMenuImage";
            MainMenuImage.Size = new Size(250, 172);
            MainMenuImage.TabIndex = 1;
            MainMenuImage.TabStop = false;
            // 
            // TheRecordesNumberLable
            // 
            TheRecordesNumberLable.Location = new Point(148, 509);
            TheRecordesNumberLable.Name = "TheRecordesNumberLable";
            TheRecordesNumberLable.Size = new Size(100, 24);
            TheRecordesNumberLable.TabIndex = 10;
            // 
            // FilterTextbox
            // 
            FilterTextbox.Location = new Point(245, 261);
            FilterTextbox.Name = "FilterTextbox";
            FilterTextbox.Size = new Size(148, 25);
            FilterTextbox.TabIndex = 11;
            FilterTextbox.TextChanged += FilterTextbox_TextChanged;
            FilterTextbox.KeyPress += textBox1_KeyPress;
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(64, 64, 64);
            Add.FlatStyle = FlatStyle.Flat;
            Add.ForeColor = Color.White;
            Add.Location = new Point(905, 239);
            Add.Name = "Add";
            Add.Size = new Size(80, 35);
            Add.TabIndex = 12;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(18, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 25);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.Visible = false;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // ManagePeopleForm
            // 
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1001, 556);
            Controls.Add(dateTimePicker1);
            Controls.Add(Add);
            Controls.Add(FilterTextbox);
            Controls.Add(MainMenuImage);
            Controls.Add(TheTitleLabel);
            Controls.Add(DataOfAllPeopleDataGradeView);
            Controls.Add(AddPersonButton);
            Controls.Add(CancelButton);
            Controls.Add(label2);
            Controls.Add(TheFiltersCommboBox);
            Controls.Add(TheNumberOfRecordesButton);
            Controls.Add(TheRecordesNumberLable);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ManagePeopleForm";
            Text = "Manage People";
            Load += ManagePeopleForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataOfAllPeopleDataGradeView).EndInit();
            TheProcessInPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainMenuImage).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.ToolStripMenuItem theInformationToolStripMenuItem;
        private System.Windows.Forms.TextBox FilterTextbox;
        private Button Add;
        private DateTimePicker dateTimePicker1;
    }
}
