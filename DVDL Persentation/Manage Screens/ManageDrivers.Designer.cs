namespace DVDL_Persentation.Manage_Screens
{
    partial class ManageDrivers
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            RecordesLabel = new Label();
            Close = new Button();
            label2 = new Label();
            FilterInfomation = new TextBox();
            Filters = new ComboBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            DriversData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DriversData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 472);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 1;
            label1.Text = "Recordes:";
            // 
            // RecordesLabel
            // 
            RecordesLabel.AutoSize = true;
            RecordesLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            RecordesLabel.ForeColor = Color.LightGreen;
            RecordesLabel.Location = new Point(102, 472);
            RecordesLabel.Name = "RecordesLabel";
            RecordesLabel.Size = new Size(33, 19);
            RecordesLabel.TabIndex = 2;
            RecordesLabel.Text = "????";
            // 
            // Close
            // 
            Close.BackColor = Color.Firebrick;
            Close.Cursor = Cursors.Hand;
            Close.FlatAppearance.BorderSize = 0;
            Close.FlatStyle = FlatStyle.Flat;
            Close.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Close.ForeColor = Color.White;
            Close.Location = new Point(894, 472);
            Close.Name = "Close";
            Close.Size = new Size(66, 26);
            Close.TabIndex = 3;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = false;
            Close.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(12, 233);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 5;
            label2.Text = "Filters:";
            // 
            // FilterInfomation
            // 
            FilterInfomation.BackColor = Color.FromArgb(55, 55, 55);
            FilterInfomation.BorderStyle = BorderStyle.FixedSingle;
            FilterInfomation.Font = new Font("Segoe UI", 9F);
            FilterInfomation.ForeColor = Color.White;
            FilterInfomation.Location = new Point(212, 232);
            FilterInfomation.Name = "FilterInfomation";
            FilterInfomation.Size = new Size(129, 23);
            FilterInfomation.TabIndex = 6;
            FilterInfomation.TextChanged += FilterInfomation_TextChanged;
            FilterInfomation.KeyPress += textBox1_KeyPress;
            // 
            // Filters
            // 
            Filters.BackColor = Color.FromArgb(55, 55, 55);
            Filters.DropDownStyle = ComboBoxStyle.DropDownList;
            Filters.FlatStyle = FlatStyle.Flat;
            Filters.Font = new Font("Segoe UI", 9F);
            Filters.ForeColor = Color.White;
            Filters.FormattingEnabled = true;
            Filters.Items.AddRange(new object[] { "None", "PersonID", "DriverID", "FullName", "NationalNo", "NumberOfActiveLicenses" });
            Filters.Location = new Point(77, 233);
            Filters.Name = "Filters";
            Filters.Size = new Size(106, 23);
            Filters.TabIndex = 7;
            Filters.SelectedIndexChanged += Filters_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resource.Driver_Main;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(397, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 131);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(380, 158);
            label3.Name = "label3";
            label3.Size = new Size(220, 37);
            label3.TabIndex = 8;
            label3.Text = "Manage Drivers";
            // 
            // DriversData
            // 
            DriversData.AllowUserToAddRows = false;
            DriversData.AllowUserToDeleteRows = false;
            DriversData.BackgroundColor = Color.FromArgb(45, 45, 45);
            DriversData.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DriversData.DefaultCellStyle = dataGridViewCellStyle1;
            DriversData.GridColor = Color.Gray;
            DriversData.Location = new Point(12, 276);
            DriversData.Name = "DriversData";
            DriversData.ReadOnly = true;
            DriversData.Size = new Size(956, 190);
            DriversData.TabIndex = 9;
            // 
            // ManageDrivers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(980, 507);
            Controls.Add(DriversData);
            Controls.Add(label3);
            Controls.Add(Filters);
            Controls.Add(FilterInfomation);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(Close);
            Controls.Add(RecordesLabel);
            Controls.Add(label1);
            Name = "ManageDrivers";
            Text = "ManageDrivers";
            Load += ManageDrivers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DriversData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RecordesLabel;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FilterInfomation;
        private System.Windows.Forms.ComboBox Filters;
        private System.Windows.Forms.Label label3;
        private DataGridView DriversData;
    }
}
