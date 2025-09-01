namespace DVDL_Persentation
{
    partial class RenewDrivingLicenseForm
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
            findLicenseWithFilter2 = new FindLicenseWithFilter();
            renewLicensetab = new TabPage();
            ShowNewLicenseInformarion = new LinkLabel();
            ShowHistoryLicenses = new LinkLabel();
            Renew = new Button();
            Cancel = new Button();
            Notes = new TextBox();
            TotalFees = new Label();
            CreatedID = new Label();
            ExpData = new Label();
            OldLicenseID = new Label();
            RenewLicenseID = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            label10 = new Label();
            LicenseFees = new Label();
            AppFees = new Label();
            NewLiceenseIssueDate = new Label();
            AppDate = new Label();
            RenewAppID = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label27 = new Label();
            tabControl1.SuspendLayout();
            LicenseInformation.SuspendLayout();
            renewLicensetab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(LicenseInformation);
            tabControl1.Controls.Add(renewLicensetab);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(813, 518);
            tabControl1.TabIndex = 1;
            // 
            // LicenseInformation
            // 
            LicenseInformation.BackColor = Color.Gray;
            LicenseInformation.Controls.Add(findLicenseWithFilter2);
            LicenseInformation.Location = new Point(4, 24);
            LicenseInformation.Margin = new Padding(4, 3, 4, 3);
            LicenseInformation.Name = "LicenseInformation";
            LicenseInformation.Padding = new Padding(4, 3, 4, 3);
            LicenseInformation.Size = new Size(805, 490);
            LicenseInformation.TabIndex = 0;
            LicenseInformation.Text = "LicenseI nformation";
            // 
            // findLicenseWithFilter2
            // 
            findLicenseWithFilter2.BackColor = Color.FromArgb(244, 246, 249);
            findLicenseWithFilter2.Location = new Point(-4, 0);
            findLicenseWithFilter2.Name = "findLicenseWithFilter2";
            findLicenseWithFilter2.Size = new Size(802, 498);
            findLicenseWithFilter2.TabIndex = 0;
            findLicenseWithFilter2.LicenseInformation += findLicenseWithFilter2_LicenseInformation;
            // 
            // renewLicensetab
            // 
            renewLicensetab.BackColor = Color.Gray;
            renewLicensetab.Controls.Add(ShowNewLicenseInformarion);
            renewLicensetab.Controls.Add(ShowHistoryLicenses);
            renewLicensetab.Controls.Add(Renew);
            renewLicensetab.Controls.Add(Cancel);
            renewLicensetab.Controls.Add(Notes);
            renewLicensetab.Controls.Add(TotalFees);
            renewLicensetab.Controls.Add(CreatedID);
            renewLicensetab.Controls.Add(ExpData);
            renewLicensetab.Controls.Add(OldLicenseID);
            renewLicensetab.Controls.Add(RenewLicenseID);
            renewLicensetab.Controls.Add(label31);
            renewLicensetab.Controls.Add(label32);
            renewLicensetab.Controls.Add(label33);
            renewLicensetab.Controls.Add(label34);
            renewLicensetab.Controls.Add(label35);
            renewLicensetab.Controls.Add(label10);
            renewLicensetab.Controls.Add(LicenseFees);
            renewLicensetab.Controls.Add(AppFees);
            renewLicensetab.Controls.Add(NewLiceenseIssueDate);
            renewLicensetab.Controls.Add(AppDate);
            renewLicensetab.Controls.Add(RenewAppID);
            renewLicensetab.Controls.Add(label18);
            renewLicensetab.Controls.Add(label19);
            renewLicensetab.Controls.Add(label20);
            renewLicensetab.Controls.Add(label21);
            renewLicensetab.Controls.Add(label27);
            renewLicensetab.Location = new Point(4, 24);
            renewLicensetab.Margin = new Padding(4, 3, 4, 3);
            renewLicensetab.Name = "renewLicensetab";
            renewLicensetab.Padding = new Padding(4, 3, 4, 3);
            renewLicensetab.Size = new Size(805, 490);
            renewLicensetab.TabIndex = 1;
            renewLicensetab.Text = "The New LIcense Information";
            // 
            // ShowNewLicenseInformarion
            // 
            ShowNewLicenseInformarion.ActiveLinkColor = Color.Blue;
            ShowNewLicenseInformarion.AutoSize = true;
            ShowNewLicenseInformarion.BackColor = Color.Gray;
            ShowNewLicenseInformarion.Enabled = false;
            ShowNewLicenseInformarion.LinkColor = Color.Blue;
            ShowNewLicenseInformarion.Location = new Point(242, 30);
            ShowNewLicenseInformarion.Margin = new Padding(4, 0, 4, 0);
            ShowNewLicenseInformarion.Name = "ShowNewLicenseInformarion";
            ShowNewLicenseInformarion.Size = new Size(162, 15);
            ShowNewLicenseInformarion.TabIndex = 98;
            ShowNewLicenseInformarion.TabStop = true;
            ShowNewLicenseInformarion.Text = "ShowNewLicenseInformarion";
            ShowNewLicenseInformarion.LinkClicked += ShowNewLicenseInformarion_LinkClicked_1;
            // 
            // ShowHistoryLicenses
            // 
            ShowHistoryLicenses.ActiveLinkColor = Color.Blue;
            ShowHistoryLicenses.AutoSize = true;
            ShowHistoryLicenses.BackColor = Color.Gray;
            ShowHistoryLicenses.Enabled = false;
            ShowHistoryLicenses.LinkColor = Color.Blue;
            ShowHistoryLicenses.Location = new Point(63, 30);
            ShowHistoryLicenses.Margin = new Padding(4, 0, 4, 0);
            ShowHistoryLicenses.Name = "ShowHistoryLicenses";
            ShowHistoryLicenses.Size = new Size(118, 15);
            ShowHistoryLicenses.TabIndex = 97;
            ShowHistoryLicenses.TabStop = true;
            ShowHistoryLicenses.Text = "ShowHistoryLicenses";
            ShowHistoryLicenses.LinkClicked += ShowHistoryLicenses_LinkClicked;
            // 
            // Renew
            // 
            Renew.Enabled = false;
            Renew.Location = new Point(692, 412);
            Renew.Margin = new Padding(4, 3, 4, 3);
            Renew.Name = "Renew";
            Renew.Size = new Size(88, 27);
            Renew.TabIndex = 96;
            Renew.Text = "Renew";
            Renew.UseVisualStyleBackColor = true;
            Renew.Click += Renew_Click_1;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(575, 412);
            Cancel.Margin = new Padding(4, 3, 4, 3);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(88, 27);
            Cancel.TabIndex = 95;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            // 
            // Notes
            // 
            Notes.Location = new Point(107, 361);
            Notes.Margin = new Padding(4, 3, 4, 3);
            Notes.Multiline = true;
            Notes.Name = "Notes";
            Notes.Size = new Size(386, 93);
            Notes.TabIndex = 94;
            // 
            // TotalFees
            // 
            TotalFees.AutoSize = true;
            TotalFees.Location = new Point(644, 326);
            TotalFees.Margin = new Padding(4, 0, 4, 0);
            TotalFees.Name = "TotalFees";
            TotalFees.Size = new Size(27, 15);
            TotalFees.TabIndex = 93;
            TotalFees.Text = "????";
            // 
            // CreatedID
            // 
            CreatedID.AutoSize = true;
            CreatedID.Location = new Point(644, 274);
            CreatedID.Margin = new Padding(4, 0, 4, 0);
            CreatedID.Name = "CreatedID";
            CreatedID.Size = new Size(27, 15);
            CreatedID.TabIndex = 92;
            CreatedID.Text = "????";
            // 
            // ExpData
            // 
            ExpData.AutoSize = true;
            ExpData.Location = new Point(644, 222);
            ExpData.Margin = new Padding(4, 0, 4, 0);
            ExpData.Name = "ExpData";
            ExpData.Size = new Size(27, 15);
            ExpData.TabIndex = 91;
            ExpData.Text = "????";
            // 
            // OldLicenseID
            // 
            OldLicenseID.AutoSize = true;
            OldLicenseID.Location = new Point(644, 170);
            OldLicenseID.Margin = new Padding(4, 0, 4, 0);
            OldLicenseID.Name = "OldLicenseID";
            OldLicenseID.Size = new Size(27, 15);
            OldLicenseID.TabIndex = 90;
            OldLicenseID.Text = "????";
            // 
            // RenewLicenseID
            // 
            RenewLicenseID.AutoSize = true;
            RenewLicenseID.Location = new Point(692, 118);
            RenewLicenseID.Margin = new Padding(4, 0, 4, 0);
            RenewLicenseID.Name = "RenewLicenseID";
            RenewLicenseID.Size = new Size(27, 15);
            RenewLicenseID.TabIndex = 89;
            RenewLicenseID.Text = "????";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(495, 324);
            label31.Margin = new Padding(4, 0, 4, 0);
            label31.Name = "label31";
            label31.Size = new Size(85, 17);
            label31.TabIndex = 88;
            label31.Text = "Total Fees";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(492, 274);
            label32.Margin = new Padding(4, 0, 4, 0);
            label32.Name = "label32";
            label32.Size = new Size(87, 17);
            label32.TabIndex = 87;
            label32.Text = "Created by";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.Location = new Point(492, 222);
            label33.Margin = new Padding(4, 0, 4, 0);
            label33.Name = "label33";
            label33.Size = new Size(119, 17);
            label33.TabIndex = 86;
            label33.Text = "Expiration Date";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.Location = new Point(492, 170);
            label34.Margin = new Padding(4, 0, 4, 0);
            label34.Name = "label34";
            label34.Size = new Size(105, 17);
            label34.TabIndex = 85;
            label34.Text = "Old Licese ID";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label35.Location = new Point(495, 118);
            label35.Margin = new Padding(4, 0, 4, 0);
            label35.Name = "label35";
            label35.Size = new Size(137, 17);
            label35.TabIndex = 84;
            label35.Text = "Renew License ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(32, 371);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(50, 17);
            label10.TabIndex = 82;
            label10.Text = "Notes";
            // 
            // LicenseFees
            // 
            LicenseFees.AutoSize = true;
            LicenseFees.Location = new Point(242, 331);
            LicenseFees.Margin = new Padding(4, 0, 4, 0);
            LicenseFees.Name = "LicenseFees";
            LicenseFees.Size = new Size(27, 15);
            LicenseFees.TabIndex = 81;
            LicenseFees.Text = "????";
            // 
            // AppFees
            // 
            AppFees.AutoSize = true;
            AppFees.Location = new Point(242, 279);
            AppFees.Margin = new Padding(4, 0, 4, 0);
            AppFees.Name = "AppFees";
            AppFees.Size = new Size(27, 15);
            AppFees.TabIndex = 80;
            AppFees.Text = "????";
            // 
            // NewLiceenseIssueDate
            // 
            NewLiceenseIssueDate.AutoSize = true;
            NewLiceenseIssueDate.Location = new Point(242, 227);
            NewLiceenseIssueDate.Margin = new Padding(4, 0, 4, 0);
            NewLiceenseIssueDate.Name = "NewLiceenseIssueDate";
            NewLiceenseIssueDate.Size = new Size(27, 15);
            NewLiceenseIssueDate.TabIndex = 79;
            NewLiceenseIssueDate.Text = "????";
            // 
            // AppDate
            // 
            AppDate.AutoSize = true;
            AppDate.Location = new Point(242, 175);
            AppDate.Margin = new Padding(4, 0, 4, 0);
            AppDate.Name = "AppDate";
            AppDate.Size = new Size(27, 15);
            AppDate.TabIndex = 78;
            AppDate.Text = "????";
            // 
            // RenewAppID
            // 
            RenewAppID.AutoSize = true;
            RenewAppID.Location = new Point(242, 123);
            RenewAppID.Margin = new Padding(4, 0, 4, 0);
            RenewAppID.Name = "RenewAppID";
            RenewAppID.Size = new Size(27, 15);
            RenewAppID.TabIndex = 77;
            RenewAppID.Text = "????";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(32, 324);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(104, 17);
            label18.TabIndex = 74;
            label18.Text = "License Fees";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(28, 274);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(128, 17);
            label19.TabIndex = 73;
            label19.Text = "Application Fees";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(28, 222);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(85, 17);
            label20.TabIndex = 72;
            label20.Text = "Issue Date";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(28, 170);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(127, 17);
            label21.TabIndex = 71;
            label21.Text = "Application Date";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.Location = new Point(32, 118);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(156, 17);
            label27.TabIndex = 70;
            label27.Text = "Renew ApplicationID";
            // 
            // RenewDrivingLicenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(826, 522);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "RenewDrivingLicenseForm";
            Text = "RenewDrivingLicenseForm";
            tabControl1.ResumeLayout(false);
            LicenseInformation.ResumeLayout(false);
            renewLicensetab.ResumeLayout(false);
            renewLicensetab.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage LicenseInformation;
        private TabPage renewLicensetab;
        private LinkLabel ShowNewLicenseInformarion;
        private LinkLabel ShowHistoryLicenses;
        private Button Renew;
        private Button Cancel;
        private TextBox Notes;
        private Label TotalFees;
        private Label CreatedID;
        private Label ExpData;
        private Label OldLicenseID;
        private Label RenewLicenseID;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label10;
        private Label LicenseFees;
        private Label AppFees;
        private Label NewLiceenseIssueDate;
        private Label AppDate;
        private Label RenewAppID;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label27;
        private FindLicenseWithFilter findLicenseWithFilter1;
        private FindLicenseWithFilter findLicenseWithFilter2;
    }
}