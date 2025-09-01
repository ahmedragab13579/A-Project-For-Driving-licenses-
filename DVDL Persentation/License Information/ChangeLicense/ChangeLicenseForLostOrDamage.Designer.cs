namespace DVDL_Persentation
{
    partial class ChangeLicenseForLostOrDamage
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
            LIcenseInfromation = new TabPage();
            findLicenseWithFilter1 = new FindLicenseWithFilter();
            NewLicInfo = new TabPage();
            ShowNewLicenseInformarion = new LinkLabel();
            ShowHistoryLicenses = new LinkLabel();
            ReplaceAppInfo = new GroupBox();
            CreatedUser = new Label();
            OldLicId = new Label();
            RepLicID = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            RepAppFees = new Label();
            RepAppDate = new Label();
            ReplaceAppID = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            Issue = new Button();
            Cancel = new Button();
            ChangeForWhat = new GroupBox();
            Lost = new RadioButton();
            Damage = new RadioButton();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            LIcenseInfromation.SuspendLayout();
            NewLicInfo.SuspendLayout();
            ReplaceAppInfo.SuspendLayout();
            ChangeForWhat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(LIcenseInfromation);
            tabControl1.Controls.Add(NewLicInfo);
            tabControl1.Location = new Point(14, 14);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(897, 603);
            tabControl1.TabIndex = 0;
            // 
            // LIcenseInfromation
            // 
            LIcenseInfromation.BackColor = Color.Gray;
            LIcenseInfromation.Controls.Add(findLicenseWithFilter1);
            LIcenseInfromation.Location = new Point(4, 24);
            LIcenseInfromation.Margin = new Padding(4, 3, 4, 3);
            LIcenseInfromation.Name = "LIcenseInfromation";
            LIcenseInfromation.Padding = new Padding(4, 3, 4, 3);
            LIcenseInfromation.Size = new Size(889, 575);
            LIcenseInfromation.TabIndex = 0;
            LIcenseInfromation.Text = "LIcense Infromation";
            // 
            // findLicenseWithFilter1
            // 
            findLicenseWithFilter1.BackColor = Color.FromArgb(244, 246, 249);
            findLicenseWithFilter1.Location = new Point(0, 3);
            findLicenseWithFilter1.Name = "findLicenseWithFilter1";
            findLicenseWithFilter1.Size = new Size(882, 472);
            findLicenseWithFilter1.TabIndex = 0;
            findLicenseWithFilter1.LicenseInformation += findLicenseWithFilter1_LicenseInformation;
            findLicenseWithFilter1.Load += findLicenseWithFilter1_Load;
            // 
            // NewLicInfo
            // 
            NewLicInfo.BackColor = Color.Gray;
            NewLicInfo.Controls.Add(ShowNewLicenseInformarion);
            NewLicInfo.Controls.Add(ShowHistoryLicenses);
            NewLicInfo.Controls.Add(ReplaceAppInfo);
            NewLicInfo.Controls.Add(Issue);
            NewLicInfo.Controls.Add(Cancel);
            NewLicInfo.Controls.Add(ChangeForWhat);
            NewLicInfo.Location = new Point(4, 24);
            NewLicInfo.Margin = new Padding(4, 3, 4, 3);
            NewLicInfo.Name = "NewLicInfo";
            NewLicInfo.Padding = new Padding(4, 3, 4, 3);
            NewLicInfo.Size = new Size(889, 575);
            NewLicInfo.TabIndex = 1;
            NewLicInfo.Text = "New License Information";
            // 
            // ShowNewLicenseInformarion
            // 
            ShowNewLicenseInformarion.AutoSize = true;
            ShowNewLicenseInformarion.Enabled = false;
            ShowNewLicenseInformarion.Location = new Point(216, 412);
            ShowNewLicenseInformarion.Margin = new Padding(4, 0, 4, 0);
            ShowNewLicenseInformarion.Name = "ShowNewLicenseInformarion";
            ShowNewLicenseInformarion.Size = new Size(162, 15);
            ShowNewLicenseInformarion.TabIndex = 100;
            ShowNewLicenseInformarion.TabStop = true;
            ShowNewLicenseInformarion.Text = "ShowNewLicenseInformarion";
            ShowNewLicenseInformarion.LinkClicked += ShowNewLicenseInformarion_LinkClicked;
            // 
            // ShowHistoryLicenses
            // 
            ShowHistoryLicenses.AutoSize = true;
            ShowHistoryLicenses.Enabled = false;
            ShowHistoryLicenses.Location = new Point(37, 412);
            ShowHistoryLicenses.Margin = new Padding(4, 0, 4, 0);
            ShowHistoryLicenses.Name = "ShowHistoryLicenses";
            ShowHistoryLicenses.Size = new Size(118, 15);
            ShowHistoryLicenses.TabIndex = 99;
            ShowHistoryLicenses.TabStop = true;
            ShowHistoryLicenses.Text = "ShowHistoryLicenses";
            ShowHistoryLicenses.LinkClicked += ShowHistoryLicenses_LinkClicked;
            // 
            // ReplaceAppInfo
            // 
            ReplaceAppInfo.Controls.Add(CreatedUser);
            ReplaceAppInfo.Controls.Add(OldLicId);
            ReplaceAppInfo.Controls.Add(RepLicID);
            ReplaceAppInfo.Controls.Add(label17);
            ReplaceAppInfo.Controls.Add(label18);
            ReplaceAppInfo.Controls.Add(label19);
            ReplaceAppInfo.Controls.Add(RepAppFees);
            ReplaceAppInfo.Controls.Add(RepAppDate);
            ReplaceAppInfo.Controls.Add(ReplaceAppID);
            ReplaceAppInfo.Controls.Add(label11);
            ReplaceAppInfo.Controls.Add(label10);
            ReplaceAppInfo.Controls.Add(label9);
            ReplaceAppInfo.Location = new Point(7, 78);
            ReplaceAppInfo.Margin = new Padding(4, 3, 4, 3);
            ReplaceAppInfo.Name = "ReplaceAppInfo";
            ReplaceAppInfo.Padding = new Padding(4, 3, 4, 3);
            ReplaceAppInfo.Size = new Size(822, 268);
            ReplaceAppInfo.TabIndex = 3;
            ReplaceAppInfo.TabStop = false;
            ReplaceAppInfo.Text = "Application Replace license Information";
            // 
            // CreatedUser
            // 
            CreatedUser.AutoSize = true;
            CreatedUser.Location = new Point(537, 201);
            CreatedUser.Margin = new Padding(4, 0, 4, 0);
            CreatedUser.Name = "CreatedUser";
            CreatedUser.Size = new Size(35, 15);
            CreatedUser.TabIndex = 30;
            CreatedUser.Text = "[????]";
            // 
            // OldLicId
            // 
            OldLicId.AutoSize = true;
            OldLicId.Location = new Point(537, 149);
            OldLicId.Margin = new Padding(4, 0, 4, 0);
            OldLicId.Name = "OldLicId";
            OldLicId.Size = new Size(35, 15);
            OldLicId.TabIndex = 29;
            OldLicId.Text = "[????]";
            // 
            // RepLicID
            // 
            RepLicID.AutoSize = true;
            RepLicID.Location = new Point(537, 76);
            RepLicID.Margin = new Padding(4, 0, 4, 0);
            RepLicID.Name = "RepLicID";
            RepLicID.Size = new Size(35, 15);
            RepLicID.TabIndex = 28;
            RepLicID.Text = "[????]";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(394, 201);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(58, 15);
            label17.TabIndex = 27;
            label17.Text = "Crated By";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(394, 149);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(88, 15);
            label18.TabIndex = 26;
            label18.Text = "Old License ID: ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(394, 76);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(110, 15);
            label19.TabIndex = 25;
            label19.Text = "replace License ID : ";
            // 
            // RepAppFees
            // 
            RepAppFees.AutoSize = true;
            RepAppFees.Location = new Point(205, 215);
            RepAppFees.Margin = new Padding(4, 0, 4, 0);
            RepAppFees.Name = "RepAppFees";
            RepAppFees.Size = new Size(35, 15);
            RepAppFees.TabIndex = 23;
            RepAppFees.Text = "[????]";
            // 
            // RepAppDate
            // 
            RepAppDate.AutoSize = true;
            RepAppDate.Location = new Point(205, 142);
            RepAppDate.Margin = new Padding(4, 0, 4, 0);
            RepAppDate.Name = "RepAppDate";
            RepAppDate.Size = new Size(35, 15);
            RepAppDate.TabIndex = 22;
            RepAppDate.Text = "[????]";
            // 
            // ReplaceAppID
            // 
            ReplaceAppID.AutoSize = true;
            ReplaceAppID.Location = new Point(205, 76);
            ReplaceAppID.Margin = new Padding(4, 0, 4, 0);
            ReplaceAppID.Name = "ReplaceAppID";
            ReplaceAppID.Size = new Size(35, 15);
            ReplaceAppID.TabIndex = 21;
            ReplaceAppID.Text = "[????]";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 215);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 15);
            label11.TabIndex = 19;
            label11.Text = "Application Fees: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 142);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(95, 15);
            label10.TabIndex = 18;
            label10.Text = "Application Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 76);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(93, 15);
            label9.TabIndex = 17;
            label9.Text = "Replace App ID: ";
            // 
            // Issue
            // 
            Issue.Enabled = false;
            Issue.Location = new Point(796, 428);
            Issue.Margin = new Padding(4, 3, 4, 3);
            Issue.Name = "Issue";
            Issue.Size = new Size(88, 27);
            Issue.TabIndex = 2;
            Issue.Text = "issue";
            Issue.UseVisualStyleBackColor = true;
            Issue.Click += Issue_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(673, 428);
            Cancel.Margin = new Padding(4, 3, 4, 3);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(88, 27);
            Cancel.TabIndex = 1;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // ChangeForWhat
            // 
            ChangeForWhat.Controls.Add(pictureBox1);
            ChangeForWhat.Controls.Add(Lost);
            ChangeForWhat.Controls.Add(Damage);
            ChangeForWhat.Location = new Point(7, 3);
            ChangeForWhat.Margin = new Padding(4, 3, 4, 3);
            ChangeForWhat.Name = "ChangeForWhat";
            ChangeForWhat.Padding = new Padding(4, 3, 4, 3);
            ChangeForWhat.Size = new Size(414, 59);
            ChangeForWhat.TabIndex = 0;
            ChangeForWhat.TabStop = false;
            ChangeForWhat.Text = "Change for What : ";
            ChangeForWhat.UseWaitCursor = true;
            // 
            // Lost
            // 
            Lost.AutoSize = true;
            Lost.Location = new Point(162, 22);
            Lost.Margin = new Padding(4, 3, 4, 3);
            Lost.Name = "Lost";
            Lost.Size = new Size(92, 19);
            Lost.TabIndex = 1;
            Lost.TabStop = true;
            Lost.Text = "Lost License ";
            Lost.UseVisualStyleBackColor = true;
            Lost.UseWaitCursor = true;
            Lost.CheckedChanged += Lost_CheckedChanged;
            // 
            // Damage
            // 
            Damage.AutoSize = true;
            Damage.Location = new Point(7, 22);
            Damage.Margin = new Padding(4, 3, 4, 3);
            Damage.Name = "Damage";
            Damage.Size = new Size(111, 19);
            Damage.TabIndex = 0;
            Damage.TabStop = true;
            Damage.Text = "Damage License";
            Damage.UseVisualStyleBackColor = true;
            Damage.UseWaitCursor = true;
            Damage.CheckedChanged += Lost_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resource.Damaged_Driving_License_32;
            pictureBox1.Location = new Point(327, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 37);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // ChangeLicenseForLostOrDamage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(918, 519);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ChangeLicenseForLostOrDamage";
            Text = "ChangeLicenseForLostOrDamage";
            tabControl1.ResumeLayout(false);
            LIcenseInfromation.ResumeLayout(false);
            NewLicInfo.ResumeLayout(false);
            NewLicInfo.PerformLayout();
            ReplaceAppInfo.ResumeLayout(false);
            ReplaceAppInfo.PerformLayout();
            ChangeForWhat.ResumeLayout(false);
            ChangeForWhat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage LIcenseInfromation;
        private System.Windows.Forms.TabPage NewLicInfo;
        private System.Windows.Forms.GroupBox ChangeForWhat;
        private System.Windows.Forms.Button Issue;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.RadioButton Lost;
        private System.Windows.Forms.RadioButton Damage;
        private System.Windows.Forms.GroupBox ReplaceAppInfo;
        private System.Windows.Forms.Label CreatedUser;
        private System.Windows.Forms.Label OldLicId;
        private System.Windows.Forms.Label RepLicID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label RepAppFees;
        private System.Windows.Forms.Label RepAppDate;
        private System.Windows.Forms.Label ReplaceAppID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel ShowNewLicenseInformarion;
        private System.Windows.Forms.LinkLabel ShowHistoryLicenses;
        private FindLicenseWithFilter findLicenseWithFilter1;
        private PictureBox pictureBox1;
    }
}