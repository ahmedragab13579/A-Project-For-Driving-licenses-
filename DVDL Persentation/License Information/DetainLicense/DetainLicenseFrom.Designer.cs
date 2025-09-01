namespace DVDL_Persentation
{
    partial class DetainLicenseFrom
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
            tabControl1 = new TabControl();
            LicenseInformation = new TabPage();
            findLicenseWithFilter1 = new FindLicenseWithFilter();
            DetainInformation = new TabPage();
            FeesTextbox = new MaskedTextBox();
            Save = new Button();
            Cancel = new Button();
            User = new Label();
            ID = new Label();
            label17 = new Label();
            label18 = new Label();
            DetainDate = new Label();
            DetainID = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            LicenseInformation.SuspendLayout();
            DetainInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(LicenseInformation);
            tabControl1.Controls.Add(DetainInformation);
            tabControl1.Location = new Point(8, 14);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(924, 664);
            tabControl1.TabIndex = 1;
            // 
            // LicenseInformation
            // 
            LicenseInformation.Controls.Add(pictureBox1);
            LicenseInformation.Controls.Add(findLicenseWithFilter1);
            LicenseInformation.Location = new Point(4, 24);
            LicenseInformation.Margin = new Padding(4, 3, 4, 3);
            LicenseInformation.Name = "LicenseInformation";
            LicenseInformation.Padding = new Padding(4, 3, 4, 3);
            LicenseInformation.Size = new Size(916, 636);
            LicenseInformation.TabIndex = 0;
            LicenseInformation.Text = "LicenseI nformation";
            LicenseInformation.UseVisualStyleBackColor = true;
            // 
            // findLicenseWithFilter1
            // 
            findLicenseWithFilter1.BackColor = Color.FromArgb(244, 246, 249);
            findLicenseWithFilter1.Location = new Point(6, 152);
            findLicenseWithFilter1.Name = "findLicenseWithFilter1";
            findLicenseWithFilter1.Size = new Size(910, 478);
            findLicenseWithFilter1.TabIndex = 0;
            findLicenseWithFilter1.LicenseInformation += findLicenseWithFilter1_LicenseInformation;
            // 
            // DetainInformation
            // 
            DetainInformation.Controls.Add(FeesTextbox);
            DetainInformation.Controls.Add(Save);
            DetainInformation.Controls.Add(Cancel);
            DetainInformation.Controls.Add(User);
            DetainInformation.Controls.Add(ID);
            DetainInformation.Controls.Add(label17);
            DetainInformation.Controls.Add(label18);
            DetainInformation.Controls.Add(DetainDate);
            DetainInformation.Controls.Add(DetainID);
            DetainInformation.Controls.Add(label11);
            DetainInformation.Controls.Add(label10);
            DetainInformation.Controls.Add(label9);
            DetainInformation.Location = new Point(4, 24);
            DetainInformation.Margin = new Padding(4, 3, 4, 3);
            DetainInformation.Name = "DetainInformation";
            DetainInformation.Padding = new Padding(4, 3, 4, 3);
            DetainInformation.Size = new Size(916, 465);
            DetainInformation.TabIndex = 1;
            DetainInformation.Text = "Detain Information";
            DetainInformation.UseVisualStyleBackColor = true;
            // 
            // FeesTextbox
            // 
            FeesTextbox.Location = new Point(212, 390);
            FeesTextbox.Margin = new Padding(4, 3, 4, 3);
            FeesTextbox.Name = "FeesTextbox";
            FeesTextbox.Size = new Size(135, 23);
            FeesTextbox.TabIndex = 69;
            FeesTextbox.KeyPress += FeesTextbox_KeyPress;
            // 
            // Save
            // 
            Save.Enabled = false;
            Save.Location = new Point(806, 411);
            Save.Margin = new Padding(4, 3, 4, 3);
            Save.Name = "Save";
            Save.Size = new Size(88, 27);
            Save.TabIndex = 68;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(693, 411);
            Cancel.Margin = new Padding(4, 3, 4, 3);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(88, 27);
            Cancel.TabIndex = 67;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // User
            // 
            User.AutoSize = true;
            User.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            User.Location = new Point(734, 318);
            User.Margin = new Padding(4, 0, 4, 0);
            User.Name = "User";
            User.Size = new Size(44, 17);
            User.TabIndex = 66;
            User.Text = "????";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ID.Location = new Point(734, 240);
            ID.Margin = new Padding(4, 0, 4, 0);
            ID.Name = "ID";
            ID.Size = new Size(44, 17);
            ID.TabIndex = 65;
            ID.Text = "????";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(578, 318);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(88, 17);
            label17.TabIndex = 64;
            label17.Text = "Created By";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(578, 240);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(94, 17);
            label18.TabIndex = 63;
            label18.Text = "License ID: ";
            // 
            // DetainDate
            // 
            DetainDate.AutoSize = true;
            DetainDate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DetainDate.Location = new Point(208, 318);
            DetainDate.Margin = new Padding(4, 0, 4, 0);
            DetainDate.Name = "DetainDate";
            DetainDate.Size = new Size(44, 17);
            DetainDate.TabIndex = 61;
            DetainDate.Text = "????";
            // 
            // DetainID
            // 
            DetainID.AutoSize = true;
            DetainID.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DetainID.Location = new Point(208, 240);
            DetainID.Margin = new Padding(4, 0, 4, 0);
            DetainID.Name = "DetainID";
            DetainID.Size = new Size(44, 17);
            DetainID.TabIndex = 60;
            DetainID.Text = "????";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(42, 391);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(84, 17);
            label11.TabIndex = 59;
            label11.Text = "Fone Fees";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(42, 318);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(99, 17);
            label10.TabIndex = 58;
            label10.Text = "DetainDate: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(42, 240);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(85, 17);
            label9.TabIndex = 57;
            label9.Text = "Detain ID :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resource.Detain_512;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(340, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 148);
            pictureBox1.TabIndex = 71;
            pictureBox1.TabStop = false;
            // 
            // DetainLicenseFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 690);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DetainLicenseFrom";
            Text = "DetainLicenseFrom";
            tabControl1.ResumeLayout(false);
            LicenseInformation.ResumeLayout(false);
            DetainInformation.ResumeLayout(false);
            DetainInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage LicenseInformation;
        private System.Windows.Forms.TabPage DetainInformation;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label DetainDate;
        private System.Windows.Forms.Label DetainID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox FeesTextbox;
        private FindLicenseWithFilter findLicenseWithFilter1;
        private PictureBox pictureBox1;
    }
}