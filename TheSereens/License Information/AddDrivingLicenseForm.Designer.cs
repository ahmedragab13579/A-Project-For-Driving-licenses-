namespace TheSereens
{
    partial class AddDrivingLicenseForm
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
            this.LicenseInformation = new System.Windows.Forms.TabControl();
            this.PersonInformation = new System.Windows.Forms.TabPage();
            this.NextButton = new System.Windows.Forms.Button();
            this.personCardWithFilter1 = new TheSereens.PersonCardWithFilter();
            this.ApplicationInfomation = new System.Windows.Forms.TabPage();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LicenseClass = new System.Windows.Forms.ComboBox();
            this.CreatedByLabel = new System.Windows.Forms.Label();
            this.ApplicationFeesLabel = new System.Windows.Forms.Label();
            this.ApplicationDateLabel = new System.Windows.Forms.Label();
            this.ApplicationIDLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LicenseInformation.SuspendLayout();
            this.PersonInformation.SuspendLayout();
            this.ApplicationInfomation.SuspendLayout();
            this.SuspendLayout();
            // 
            // LicenseInformation
            // 
            this.LicenseInformation.Controls.Add(this.PersonInformation);
            this.LicenseInformation.Controls.Add(this.ApplicationInfomation);
            this.LicenseInformation.Location = new System.Drawing.Point(12, 67);
            this.LicenseInformation.Name = "LicenseInformation";
            this.LicenseInformation.SelectedIndex = 0;
            this.LicenseInformation.Size = new System.Drawing.Size(839, 457);
            this.LicenseInformation.TabIndex = 0;
            // 
            // PersonInformation
            // 
            this.PersonInformation.Controls.Add(this.NextButton);
            this.PersonInformation.Controls.Add(this.personCardWithFilter1);
            this.PersonInformation.Location = new System.Drawing.Point(4, 22);
            this.PersonInformation.Name = "PersonInformation";
            this.PersonInformation.Padding = new System.Windows.Forms.Padding(3);
            this.PersonInformation.Size = new System.Drawing.Size(831, 431);
            this.PersonInformation.TabIndex = 0;
            this.PersonInformation.Text = "Person Infomation";
            this.PersonInformation.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(729, 375);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(85, 37);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next ->";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // personCardWithFilter1
            // 
            this.personCardWithFilter1.Location = new System.Drawing.Point(17, 18);
            this.personCardWithFilter1.Name = "personCardWithFilter1";
            this.personCardWithFilter1.Size = new System.Drawing.Size(797, 394);
            this.personCardWithFilter1.TabIndex = 1;
            // 
            // ApplicationInfomation
            // 
            this.ApplicationInfomation.Controls.Add(this.CancelButton);
            this.ApplicationInfomation.Controls.Add(this.SaveButton);
            this.ApplicationInfomation.Controls.Add(this.LicenseClass);
            this.ApplicationInfomation.Controls.Add(this.CreatedByLabel);
            this.ApplicationInfomation.Controls.Add(this.ApplicationFeesLabel);
            this.ApplicationInfomation.Controls.Add(this.ApplicationDateLabel);
            this.ApplicationInfomation.Controls.Add(this.ApplicationIDLabel);
            this.ApplicationInfomation.Controls.Add(this.label5);
            this.ApplicationInfomation.Controls.Add(this.label4);
            this.ApplicationInfomation.Controls.Add(this.label3);
            this.ApplicationInfomation.Controls.Add(this.label2);
            this.ApplicationInfomation.Controls.Add(this.label1);
            this.ApplicationInfomation.Location = new System.Drawing.Point(4, 22);
            this.ApplicationInfomation.Name = "ApplicationInfomation";
            this.ApplicationInfomation.Padding = new System.Windows.Forms.Padding(3);
            this.ApplicationInfomation.Size = new System.Drawing.Size(831, 431);
            this.ApplicationInfomation.TabIndex = 1;
            this.ApplicationInfomation.Text = "Application Information";
            this.ApplicationInfomation.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(660, 393);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(750, 393);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LicenseClass
            // 
            this.LicenseClass.FormattingEnabled = true;
            this.LicenseClass.Location = new System.Drawing.Point(225, 228);
            this.LicenseClass.Name = "LicenseClass";
            this.LicenseClass.Size = new System.Drawing.Size(121, 21);
            this.LicenseClass.TabIndex = 9;
            // 
            // CreatedByLabel
            // 
            this.CreatedByLabel.AutoSize = true;
            this.CreatedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedByLabel.Location = new System.Drawing.Point(222, 321);
            this.CreatedByLabel.Name = "CreatedByLabel";
            this.CreatedByLabel.Size = new System.Drawing.Size(44, 18);
            this.CreatedByLabel.TabIndex = 8;
            this.CreatedByLabel.Text = "????";
            // 
            // ApplicationFeesLabel
            // 
            this.ApplicationFeesLabel.AutoSize = true;
            this.ApplicationFeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationFeesLabel.Location = new System.Drawing.Point(222, 276);
            this.ApplicationFeesLabel.Name = "ApplicationFeesLabel";
            this.ApplicationFeesLabel.Size = new System.Drawing.Size(44, 18);
            this.ApplicationFeesLabel.TabIndex = 7;
            this.ApplicationFeesLabel.Text = "????";
            // 
            // ApplicationDateLabel
            // 
            this.ApplicationDateLabel.AutoSize = true;
            this.ApplicationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationDateLabel.Location = new System.Drawing.Point(222, 186);
            this.ApplicationDateLabel.Name = "ApplicationDateLabel";
            this.ApplicationDateLabel.Size = new System.Drawing.Size(44, 18);
            this.ApplicationDateLabel.TabIndex = 6;
            this.ApplicationDateLabel.Text = "????";
            // 
            // ApplicationIDLabel
            // 
            this.ApplicationIDLabel.AutoSize = true;
            this.ApplicationIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationIDLabel.Location = new System.Drawing.Point(222, 141);
            this.ApplicationIDLabel.Name = "ApplicationIDLabel";
            this.ApplicationIDLabel.Size = new System.Drawing.Size(44, 18);
            this.ApplicationIDLabel.TabIndex = 5;
            this.ApplicationIDLabel.Text = "????";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Created By : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Application Fees : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "License Class : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Application Date : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application ID : ";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Red;
            this.TitleLabel.Location = new System.Drawing.Point(148, 33);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(504, 31);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "New Local Driving License Appication";
            // 
            // AddDrivingLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 536);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.LicenseInformation);
            this.Name = "AddDrivingLicenseForm";
            this.Text = "AddDrivingLicenseForm";
            this.Load += new System.EventHandler(this.AddDrivingLicenseForm_Load);
            this.LicenseInformation.ResumeLayout(false);
            this.PersonInformation.ResumeLayout(false);
            this.ApplicationInfomation.ResumeLayout(false);
            this.ApplicationInfomation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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