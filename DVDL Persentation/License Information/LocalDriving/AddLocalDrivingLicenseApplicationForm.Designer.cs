namespace DVDL_Persentation
{
    partial class AddLocalDrivingLicenseApplicationForm
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
            LicenseInformation = new TabControl();
            PersonInformation = new TabPage();
            NextButton = new Button();
            personCardWithFilter1 = new PersonCardWithFilter();
            ApplicationInfomation = new TabPage();
            CancelButton = new Button();
            SaveButton = new Button();
            LicenseClass = new ComboBox();
            CreatedByLabel = new Label();
            ApplicationFeesLabel = new Label();
            ApplicationDateLabel = new Label();
            ApplicationIDLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TitleLabel = new Label();
            LicenseInformation.SuspendLayout();
            PersonInformation.SuspendLayout();
            ApplicationInfomation.SuspendLayout();
            SuspendLayout();
            // 
            // LicenseInformation
            // 
            LicenseInformation.Controls.Add(PersonInformation);
            LicenseInformation.Controls.Add(ApplicationInfomation);
            LicenseInformation.Location = new Point(14, 77);
            LicenseInformation.Margin = new Padding(4, 3, 4, 3);
            LicenseInformation.Name = "LicenseInformation";
            LicenseInformation.SelectedIndex = 0;
            LicenseInformation.Size = new Size(979, 527);
            LicenseInformation.TabIndex = 0;
            // 
            // PersonInformation
            // 
            PersonInformation.BackColor = Color.Black;
            PersonInformation.Controls.Add(NextButton);
            PersonInformation.Controls.Add(personCardWithFilter1);
            PersonInformation.Location = new Point(4, 24);
            PersonInformation.Margin = new Padding(4, 3, 4, 3);
            PersonInformation.Name = "PersonInformation";
            PersonInformation.Padding = new Padding(4, 3, 4, 3);
            PersonInformation.Size = new Size(971, 499);
            PersonInformation.TabIndex = 0;
            PersonInformation.Text = "Person Infomation";
            // 
            // NextButton
            // 
            NextButton.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NextButton.Location = new Point(790, 407);
            NextButton.Margin = new Padding(4, 3, 4, 3);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(99, 43);
            NextButton.TabIndex = 2;
            NextButton.Text = "Next ->";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // personCardWithFilter1
            // 
            personCardWithFilter1.Location = new Point(20, 21);
            personCardWithFilter1.Margin = new Padding(5, 3, 5, 3);
            personCardWithFilter1.Name = "personCardWithFilter1";
            personCardWithFilter1.Size = new Size(930, 455);
            personCardWithFilter1.TabIndex = 1;
            personCardWithFilter1.UserFound += personCardWithFilter1_UserFound;
            // 
            // ApplicationInfomation
            // 
            ApplicationInfomation.BackColor = Color.Gray;
            ApplicationInfomation.Controls.Add(CancelButton);
            ApplicationInfomation.Controls.Add(SaveButton);
            ApplicationInfomation.Controls.Add(LicenseClass);
            ApplicationInfomation.Controls.Add(CreatedByLabel);
            ApplicationInfomation.Controls.Add(ApplicationFeesLabel);
            ApplicationInfomation.Controls.Add(ApplicationDateLabel);
            ApplicationInfomation.Controls.Add(ApplicationIDLabel);
            ApplicationInfomation.Controls.Add(label5);
            ApplicationInfomation.Controls.Add(label4);
            ApplicationInfomation.Controls.Add(label3);
            ApplicationInfomation.Controls.Add(label2);
            ApplicationInfomation.Controls.Add(label1);
            ApplicationInfomation.Location = new Point(4, 24);
            ApplicationInfomation.Margin = new Padding(4, 3, 4, 3);
            ApplicationInfomation.Name = "ApplicationInfomation";
            ApplicationInfomation.Padding = new Padding(4, 3, 4, 3);
            ApplicationInfomation.Size = new Size(192, 72);
            ApplicationInfomation.TabIndex = 1;
            ApplicationInfomation.Text = "Application Information";
            // 
            // CancelButton
            // 
            CancelButton.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.Location = new Point(770, 453);
            CancelButton.Margin = new Padding(4, 3, 4, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(88, 27);
            CancelButton.TabIndex = 11;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Enabled = false;
            SaveButton.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(875, 453);
            SaveButton.Margin = new Padding(4, 3, 4, 3);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(88, 27);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // LicenseClass
            // 
            LicenseClass.DropDownStyle = ComboBoxStyle.DropDownList;
            LicenseClass.FormattingEnabled = true;
            LicenseClass.Location = new Point(262, 263);
            LicenseClass.Margin = new Padding(4, 3, 4, 3);
            LicenseClass.Name = "LicenseClass";
            LicenseClass.Size = new Size(252, 23);
            LicenseClass.TabIndex = 9;
            // 
            // CreatedByLabel
            // 
            CreatedByLabel.AutoSize = true;
            CreatedByLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreatedByLabel.Location = new Point(259, 370);
            CreatedByLabel.Margin = new Padding(4, 0, 4, 0);
            CreatedByLabel.Name = "CreatedByLabel";
            CreatedByLabel.Size = new Size(44, 18);
            CreatedByLabel.TabIndex = 8;
            CreatedByLabel.Text = "????";
            // 
            // ApplicationFeesLabel
            // 
            ApplicationFeesLabel.AutoSize = true;
            ApplicationFeesLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ApplicationFeesLabel.Location = new Point(259, 318);
            ApplicationFeesLabel.Margin = new Padding(4, 0, 4, 0);
            ApplicationFeesLabel.Name = "ApplicationFeesLabel";
            ApplicationFeesLabel.Size = new Size(44, 18);
            ApplicationFeesLabel.TabIndex = 7;
            ApplicationFeesLabel.Text = "????";
            // 
            // ApplicationDateLabel
            // 
            ApplicationDateLabel.AutoSize = true;
            ApplicationDateLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ApplicationDateLabel.Location = new Point(259, 215);
            ApplicationDateLabel.Margin = new Padding(4, 0, 4, 0);
            ApplicationDateLabel.Name = "ApplicationDateLabel";
            ApplicationDateLabel.Size = new Size(44, 18);
            ApplicationDateLabel.TabIndex = 6;
            ApplicationDateLabel.Text = "????";
            // 
            // ApplicationIDLabel
            // 
            ApplicationIDLabel.AutoSize = true;
            ApplicationIDLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ApplicationIDLabel.Location = new Point(259, 163);
            ApplicationIDLabel.Margin = new Padding(4, 0, 4, 0);
            ApplicationIDLabel.Name = "ApplicationIDLabel";
            ApplicationIDLabel.Size = new Size(44, 18);
            ApplicationIDLabel.TabIndex = 5;
            ApplicationIDLabel.Text = "????";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 370);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 18);
            label5.TabIndex = 4;
            label5.Text = "Created By : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 318);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(147, 18);
            label4.TabIndex = 3;
            label4.Text = "Application Fees : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 267);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 18);
            label3.TabIndex = 2;
            label3.Text = "License Class : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 215);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 18);
            label2.TabIndex = 1;
            label2.Text = "Application Date : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 163);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 18);
            label1.TabIndex = 0;
            label1.Text = "Application ID : ";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.Red;
            TitleLabel.Location = new Point(251, 43);
            TitleLabel.Margin = new Padding(4, 0, 4, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(504, 31);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "New Local Driving License Appication";
            // 
            // AddLocalDrivingLicenseApplicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1007, 618);
            Controls.Add(TitleLabel);
            Controls.Add(LicenseInformation);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddLocalDrivingLicenseApplicationForm";
            Text = "AddDrivingLicenseForm";
            Load += AddDrivingLicenseForm_Load;
            LicenseInformation.ResumeLayout(false);
            PersonInformation.ResumeLayout(false);
            ApplicationInfomation.ResumeLayout(false);
            ApplicationInfomation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl LicenseInformation;
        private System.Windows.Forms.TabPage PersonInformation;
        private System.Windows.Forms.TabPage ApplicationInfomation;
        private System.Windows.Forms.Label TitleLabel;
        private PersonCardWithFilter personCardWithFilter1;
        private System.Windows.Forms.Label CreatedByLabel;
        private System.Windows.Forms.Label ApplicationFeesLabel;
        private System.Windows.Forms.Label ApplicationDateLabel;
        private System.Windows.Forms.Label ApplicationIDLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ComboBox LicenseClass;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
    }
}