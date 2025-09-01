namespace TheSereens.License_Information
{
    partial class IssueDrivingLicenseForm
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
            this.licenseInfomations1 = new TheSereens.License_Information.LicenseInfomations();
            this.label1 = new System.Windows.Forms.Label();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Issue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // licenseInfomations1
            // 
            this.licenseInfomations1.Location = new System.Drawing.Point(24, 12);
            this.licenseInfomations1.Name = "licenseInfomations1";
            this.licenseInfomations1.Size = new System.Drawing.Size(802, 383);
            this.licenseInfomations1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notes";
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesTextBox.Location = new System.Drawing.Point(95, 461);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(545, 89);
            this.NotesTextBox.TabIndex = 2;
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(612, 603);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Issue
            // 
            this.Issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Issue.Location = new System.Drawing.Point(730, 603);
            this.Issue.Name = "Issue";
            this.Issue.Size = new System.Drawing.Size(75, 23);
            this.Issue.TabIndex = 4;
            this.Issue.Text = "Issue";
            this.Issue.UseVisualStyleBackColor = true;
            this.Issue.Click += new System.EventHandler(this.Issue_Click);
            // 
            // IssueDrivingLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 661);
            this.Controls.Add(this.Issue);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.licenseInfomations1);
            this.Name = "IssueDrivingLicenseForm";
            this.Text = "IssueDrivingLicenseForm";
            this.Load += new System.EventHandler(this.IssueDrivingLicenseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LicenseInfomations licenseInfomations1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Issue;
    }
}