namespace TheSereens.Manage_Screens
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
            this.Drivers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.RecordesLabel = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterInfomation = new System.Windows.Forms.TextBox();
            this.Filters = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Drivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Drivers
            // 
            this.Drivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Drivers.Location = new System.Drawing.Point(17, 287);
            this.Drivers.Name = "Drivers";
            this.Drivers.Size = new System.Drawing.Size(811, 176);
            this.Drivers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recordes:";
            // 
            // RecordesLabel
            // 
            this.RecordesLabel.AutoSize = true;
            this.RecordesLabel.Location = new System.Drawing.Point(117, 504);
            this.RecordesLabel.Name = "RecordesLabel";
            this.RecordesLabel.Size = new System.Drawing.Size(44, 17);
            this.RecordesLabel.TabIndex = 2;
            this.RecordesLabel.Text = "????";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(715, 504);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 28);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filters:";
            // 
            // FilterInfomation
            // 
            this.FilterInfomation.Location = new System.Drawing.Point(242, 248);
            this.FilterInfomation.Name = "FilterInfomation";
            this.FilterInfomation.Size = new System.Drawing.Size(147, 22);
            this.FilterInfomation.TabIndex = 6;
            this.FilterInfomation.TextChanged += new System.EventHandler(this.FilterInfomation_TextChanged);
            this.FilterInfomation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Filters
            // 
            this.Filters.FormattingEnabled = true;
            this.Filters.Items.AddRange(new object[] {
            "PersonID",
            "DriverID",
            "FullName",
            "NationalNo"});
            this.Filters.Location = new System.Drawing.Point(88, 249);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(121, 24);
            this.Filters.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TheSereens.Properties.Resources.woman_drivers_hands_car_steering_wheel;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(293, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 140);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Manage Drivers";
            // 
            // ManageDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 532);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Filters);
            this.Controls.Add(this.FilterInfomation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.RecordesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Drivers);
            this.Name = "ManageDrivers";
            this.Text = "ManageDrivers";
            this.Load += new System.EventHandler(this.ManageDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Drivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            // ----------- Custom UI Enhancements -------------
            this.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.RecordesLabel.ForeColor = System.Drawing.Color.LightGreen;
            this.RecordesLabel.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20, System.Drawing.FontStyle.Bold);

            this.FilterInfomation.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            this.FilterInfomation.ForeColor = System.Drawing.Color.White;
            this.FilterInfomation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterInfomation.Font = new System.Drawing.Font("Segoe UI", 9);

            this.Filters.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            this.Filters.ForeColor = System.Drawing.Color.White;
            this.Filters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filters.Font = new System.Drawing.Font("Segoe UI", 9);

            this.Close.BackColor = System.Drawing.Color.Firebrick;
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;

            this.Drivers.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.Drivers.GridColor = System.Drawing.Color.Gray;
            this.Drivers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Drivers.EnableHeadersVisualStyles = false;
            this.Drivers.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            this.Drivers.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.Drivers.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.Drivers.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Drivers.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9);
            this.Drivers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.Drivers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.Drivers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
        }

        #endregion

        private System.Windows.Forms.DataGridView Drivers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RecordesLabel;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FilterInfomation;
        private System.Windows.Forms.ComboBox Filters;
        private System.Windows.Forms.Label label3;
    }
}
