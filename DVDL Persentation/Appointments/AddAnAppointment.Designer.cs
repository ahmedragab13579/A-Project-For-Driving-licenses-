namespace DVDL_Persentation.Appointments
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            RecordesNumber = new Label();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            CloseButton = new Button();
            tabControl1 = new TabControl();
            AppointmentInformation = new TabPage();
            Cancel = new Button();
            pictureBox1 = new PictureBox();
            TheTitleLabel = new Label();
            AddAnAppointmentButton = new Button();
            label1 = new Label();
            AppointmentData = new DataGridView();
            ApplicationInformation = new TabPage();
            licenseInfomations1 = new DVDL_Persentation.License_Information.LocalDrivingLicenseApplicationInfomations();
            contextMenuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            AppointmentInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AppointmentData).BeginInit();
            ApplicationInformation.SuspendLayout();
            SuspendLayout();
            // 
            // RecordesNumber
            // 
            RecordesNumber.AutoSize = true;
            RecordesNumber.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecordesNumber.Location = new Point(170, 828);
            RecordesNumber.Margin = new Padding(4, 0, 4, 0);
            RecordesNumber.Name = "RecordesNumber";
            RecordesNumber.Size = new Size(60, 25);
            RecordesNumber.TabIndex = 15;
            RecordesNumber.Text = "????";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-5, 827);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 14;
            label2.Text = "Recordes : ";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, takeTestToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(123, 48);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(122, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // takeTestToolStripMenuItem
            // 
            takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            takeTestToolStripMenuItem.Size = new Size(122, 22);
            takeTestToolStripMenuItem.Text = "Take Test";
            takeTestToolStripMenuItem.Click += takeTestToolStripMenuItem_Click;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(847, 833);
            CloseButton.Margin = new Padding(4, 3, 4, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(88, 27);
            CloseButton.TabIndex = 16;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(AppointmentInformation);
            tabControl1.Controls.Add(ApplicationInformation);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1024, 725);
            tabControl1.TabIndex = 19;
            // 
            // AppointmentInformation
            // 
            AppointmentInformation.Controls.Add(Cancel);
            AppointmentInformation.Controls.Add(pictureBox1);
            AppointmentInformation.Controls.Add(TheTitleLabel);
            AppointmentInformation.Controls.Add(AddAnAppointmentButton);
            AppointmentInformation.Controls.Add(label1);
            AppointmentInformation.Controls.Add(AppointmentData);
            AppointmentInformation.Location = new Point(4, 24);
            AppointmentInformation.Name = "AppointmentInformation";
            AppointmentInformation.Padding = new Padding(3);
            AppointmentInformation.Size = new Size(1016, 697);
            AppointmentInformation.TabIndex = 1;
            AppointmentInformation.Text = "AppointmentInformation";
            AppointmentInformation.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.Red;
            Cancel.BackgroundImageLayout = ImageLayout.Stretch;
            Cancel.Cursor = Cursors.No;
            Cancel.FlatStyle = FlatStyle.Flat;
            Cancel.ForeColor = Color.DarkBlue;
            Cancel.Location = new Point(811, 602);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 45);
            Cancel.TabIndex = 25;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resource.Vision_512;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(366, 10);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 151);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // TheTitleLabel
            // 
            TheTitleLabel.AutoSize = true;
            TheTitleLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TheTitleLabel.ForeColor = Color.Red;
            TheTitleLabel.Location = new Point(307, 184);
            TheTitleLabel.Margin = new Padding(4, 0, 4, 0);
            TheTitleLabel.Name = "TheTitleLabel";
            TheTitleLabel.Size = new Size(331, 31);
            TheTitleLabel.TabIndex = 23;
            TheTitleLabel.Text = "Vision Test Appointment";
            // 
            // AddAnAppointmentButton
            // 
            AddAnAppointmentButton.BackColor = Color.Teal;
            AddAnAppointmentButton.BackgroundImageLayout = ImageLayout.Stretch;
            AddAnAppointmentButton.FlatStyle = FlatStyle.Flat;
            AddAnAppointmentButton.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddAnAppointmentButton.Location = new Point(791, 260);
            AddAnAppointmentButton.Margin = new Padding(4, 3, 4, 3);
            AddAnAppointmentButton.Name = "AddAnAppointmentButton";
            AddAnAppointmentButton.Size = new Size(95, 50);
            AddAnAppointmentButton.TabIndex = 22;
            AddAnAppointmentButton.Text = "+";
            AddAnAppointmentButton.UseVisualStyleBackColor = false;
            AddAnAppointmentButton.Click += AddAnAppointmentButton_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 276);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 24;
            label1.Text = "Appointments";
            // 
            // AppointmentData
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            AppointmentData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            AppointmentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AppointmentData.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            AppointmentData.DefaultCellStyle = dataGridViewCellStyle2;
            AppointmentData.Location = new Point(16, 359);
            AppointmentData.Margin = new Padding(4, 3, 4, 3);
            AppointmentData.Name = "AppointmentData";
            AppointmentData.ReadOnly = true;
            AppointmentData.Size = new Size(870, 198);
            AppointmentData.TabIndex = 23;
            // 
            // ApplicationInformation
            // 
            ApplicationInformation.Controls.Add(licenseInfomations1);
            ApplicationInformation.Location = new Point(4, 24);
            ApplicationInformation.Name = "ApplicationInformation";
            ApplicationInformation.Padding = new Padding(3);
            ApplicationInformation.Size = new Size(1016, 697);
            ApplicationInformation.TabIndex = 0;
            ApplicationInformation.Text = "ApplicationInformation";
            ApplicationInformation.UseVisualStyleBackColor = true;
            // 
            // licenseInfomations1
            // 
            licenseInfomations1.BackColor = Color.FromArgb(244, 246, 249);
            licenseInfomations1.Location = new Point(27, 21);
            licenseInfomations1.Margin = new Padding(5, 3, 5, 3);
            licenseInfomations1.Name = "licenseInfomations1";
            licenseInfomations1.Size = new Size(936, 441);
            licenseInfomations1.TabIndex = 20;
            // 
            // AddAnAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 695);
            Controls.Add(tabControl1);
            Controls.Add(CloseButton);
            Controls.Add(RecordesNumber);
            Controls.Add(label2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddAnAppointment";
            Text = "AddAnAppointment";
            Load += AddAnAppointment_Load;
            contextMenuStrip1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            AppointmentInformation.ResumeLayout(false);
            AppointmentInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AppointmentData).EndInit();
            ApplicationInformation.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RecordesNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private System.Windows.Forms.Button CloseButton;
        private TabControl tabControl1;
        private TabPage ApplicationInformation;
        private License_Information.LocalDrivingLicenseApplicationInfomations licenseInfomations1;
        private TabPage AppointmentInformation;
        private Label label1;
        private DataGridView AppointmentData;
        private Button AddAnAppointmentButton;
        private PictureBox pictureBox1;
        private Label TheTitleLabel;
        private Button Cancel;
    }
}