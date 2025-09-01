namespace DVDL_Persentation.License_Information
{
    partial class InternationalLicense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            TheLicenseInformation = new TabPage();
            findLicenseWithFilter1 = new FindLicenseWithFilter();
            ApplicationInfromation = new TabPage();
            LicenseInformation = new LinkLabel();
            InternationalLiceseInformation = new LinkLabel();
            button2 = new Button();
            issue = new Button();
            licenseInfomations1 = new LocalDrivingLicenseApplicationInfomations();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            TheLicenseInformation.SuspendLayout();
            ApplicationInfromation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TheLicenseInformation);
            tabControl1.Controls.Add(ApplicationInfromation);
            tabControl1.Location = new Point(7, 3);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(959, 708);
            tabControl1.TabIndex = 0;
            // 
            // TheLicenseInformation
            // 
            TheLicenseInformation.Controls.Add(pictureBox1);
            TheLicenseInformation.Controls.Add(findLicenseWithFilter1);
            TheLicenseInformation.Location = new Point(4, 24);
            TheLicenseInformation.Margin = new Padding(4, 3, 4, 3);
            TheLicenseInformation.Name = "TheLicenseInformation";
            TheLicenseInformation.Padding = new Padding(4, 3, 4, 3);
            TheLicenseInformation.Size = new Size(951, 680);
            TheLicenseInformation.TabIndex = 0;
            TheLicenseInformation.Text = "LicenseInformation";
            TheLicenseInformation.UseVisualStyleBackColor = true;
            TheLicenseInformation.Click += tabPage1_Click;
            // 
            // findLicenseWithFilter1
            // 
            findLicenseWithFilter1.BackColor = Color.FromArgb(244, 246, 249);
            findLicenseWithFilter1.BackgroundImageLayout = ImageLayout.Zoom;
            findLicenseWithFilter1.Location = new Point(7, 187);
            findLicenseWithFilter1.Name = "findLicenseWithFilter1";
            findLicenseWithFilter1.Size = new Size(918, 478);
            findLicenseWithFilter1.TabIndex = 0;
            // 
            // ApplicationInfromation
            // 
            ApplicationInfromation.Controls.Add(LicenseInformation);
            ApplicationInfromation.Controls.Add(InternationalLiceseInformation);
            ApplicationInfromation.Controls.Add(button2);
            ApplicationInfromation.Controls.Add(issue);
            ApplicationInfromation.Controls.Add(licenseInfomations1);
            ApplicationInfromation.Location = new Point(4, 24);
            ApplicationInfromation.Margin = new Padding(4, 3, 4, 3);
            ApplicationInfromation.Name = "ApplicationInfromation";
            ApplicationInfromation.Padding = new Padding(4, 3, 4, 3);
            ApplicationInfromation.Size = new Size(956, 564);
            ApplicationInfromation.TabIndex = 1;
            ApplicationInfromation.Text = "ApplicationInfromation";
            ApplicationInfromation.UseVisualStyleBackColor = true;
            // 
            // LicenseInformation
            // 
            LicenseInformation.AutoSize = true;
            LicenseInformation.Enabled = false;
            LicenseInformation.Location = new Point(288, 519);
            LicenseInformation.Margin = new Padding(4, 0, 4, 0);
            LicenseInformation.Name = "LicenseInformation";
            LicenseInformation.Size = new Size(109, 15);
            LicenseInformation.TabIndex = 59;
            LicenseInformation.TabStop = true;
            LicenseInformation.Text = "license Information";
            LicenseInformation.LinkClicked += linkLabel1_LinkClicked;
            // 
            // InternationalLiceseInformation
            // 
            InternationalLiceseInformation.AutoSize = true;
            InternationalLiceseInformation.Enabled = false;
            InternationalLiceseInformation.Location = new Point(50, 519);
            InternationalLiceseInformation.Margin = new Padding(4, 0, 4, 0);
            InternationalLiceseInformation.Name = "InternationalLiceseInformation";
            InternationalLiceseInformation.Size = new Size(169, 15);
            InternationalLiceseInformation.TabIndex = 58;
            InternationalLiceseInformation.TabStop = true;
            InternationalLiceseInformation.Text = "InternationalLiceseInformation";
            InternationalLiceseInformation.LinkClicked += InternationalLiceseInformation_LinkClicked;
            // 
            // button2
            // 
            button2.Location = new Point(738, 508);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(88, 27);
            button2.TabIndex = 57;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // issue
            // 
            issue.Location = new Point(868, 508);
            issue.Margin = new Padding(4, 3, 4, 3);
            issue.Name = "issue";
            issue.Size = new Size(88, 27);
            issue.TabIndex = 56;
            issue.Text = "Issue";
            issue.UseVisualStyleBackColor = true;
            issue.Click += button1_Click;
            // 
            // licenseInfomations1
            // 
            licenseInfomations1.BackColor = Color.FromArgb(244, 246, 249);
            licenseInfomations1.Location = new Point(7, 7);
            licenseInfomations1.Margin = new Padding(5, 3, 5, 3);
            licenseInfomations1.Name = "licenseInfomations1";
            licenseInfomations1.Size = new Size(936, 442);
            licenseInfomations1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resource.LicenseView_400;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(350, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 175);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // InternationalLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "InternationalLicense";
            Size = new Size(970, 695);
            tabControl1.ResumeLayout(false);
            TheLicenseInformation.ResumeLayout(false);
            ApplicationInfromation.ResumeLayout(false);
            ApplicationInfromation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TheLicenseInformation;
        private System.Windows.Forms.TabPage ApplicationInfromation;
        private LocalDrivingLicenseApplicationInfomations licenseInfomations1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button issue;
        private System.Windows.Forms.LinkLabel InternationalLiceseInformation;
        private System.Windows.Forms.LinkLabel LicenseInformation;
        private FindLicenseWithFilter findLicenseWithFilter1;
        private PictureBox pictureBox1;
    }
}
