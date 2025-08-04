namespace TheSereens.Appointments
{
    partial class AddAnAppointment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RecordesNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TheTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddAnAppointmentButton = new System.Windows.Forms.Button();
            this.AppointmentData = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseButton = new System.Windows.Forms.Button();
            this.licenseInfomations1 = new TheSereens.License_Information.LicenseInfomations();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RecordesNumber
            // 
            this.RecordesNumber.AutoSize = true;
            this.RecordesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordesNumber.Location = new System.Drawing.Point(146, 718);
            this.RecordesNumber.Name = "RecordesNumber";
            this.RecordesNumber.Size = new System.Drawing.Size(60, 25);
            this.RecordesNumber.TabIndex = 15;
            this.RecordesNumber.Text = "????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 717);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Recordes : ";
            // 
            // TheTitleLabel
            // 
            this.TheTitleLabel.AutoSize = true;
            this.TheTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheTitleLabel.ForeColor = System.Drawing.Color.Red;
            this.TheTitleLabel.Location = new System.Drawing.Point(12, 19);
            this.TheTitleLabel.Name = "TheTitleLabel";
            this.TheTitleLabel.Size = new System.Drawing.Size(322, 31);
            this.TheTitleLabel.TabIndex = 12;
            this.TheTitleLabel.Text = "Vision Test Applintment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Appointments";
            // 
            // AddAnAppointmentButton
            // 
            this.AddAnAppointmentButton.BackColor = System.Drawing.Color.Teal;
            this.AddAnAppointmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddAnAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAnAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAnAppointmentButton.Location = new System.Drawing.Point(719, 487);
            this.AddAnAppointmentButton.Name = "AddAnAppointmentButton";
            this.AddAnAppointmentButton.Size = new System.Drawing.Size(75, 43);
            this.AddAnAppointmentButton.TabIndex = 10;
            this.AddAnAppointmentButton.Text = "+";
            this.AddAnAppointmentButton.UseVisualStyleBackColor = false;
            this.AddAnAppointmentButton.Click += new System.EventHandler(this.AddAnAppointmentButton_Click);
            // 
            // AppointmentData
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppointmentData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AppointmentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentData.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AppointmentData.DefaultCellStyle = dataGridViewCellStyle2;
            this.AppointmentData.Location = new System.Drawing.Point(-1, 537);
            this.AppointmentData.Name = "AppointmentData";
            this.AppointmentData.ReadOnly = true;
            this.AppointmentData.Size = new System.Drawing.Size(802, 172);
            this.AppointmentData.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(726, 722);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // licenseInfomations1
            // 
            this.licenseInfomations1.Location = new System.Drawing.Point(-1, 98);
            this.licenseInfomations1.Name = "licenseInfomations1";
            this.licenseInfomations1.Size = new System.Drawing.Size(802, 383);
            this.licenseInfomations1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TheSereens.Properties.Resources.numbers_table_with_glasses_magnifier;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(614, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 131);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // AddAnAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RecordesNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TheTitleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddAnAppointmentButton);
            this.Controls.Add(this.AppointmentData);
            this.Controls.Add(this.licenseInfomations1);
            this.Name = "AddAnAppointment";
            this.Text = "AddAnAppointment";
            this.Load += new System.EventHandler(this.AddAnAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RecordesNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TheTitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddAnAppointmentButton;
        private System.Windows.Forms.DataGridView AppointmentData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private License_Information.LicenseInfomations licenseInfomations1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}