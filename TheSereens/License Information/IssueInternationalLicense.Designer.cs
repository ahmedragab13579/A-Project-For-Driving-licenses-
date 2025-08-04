namespace TheSereens.License_Information
{
    partial class IssueInternationalLicense
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
            this.internationalLicense1 = new TheSereens.License_Information.InternationalLicense();
            this.SuspendLayout();
            // 
            // internationalLicense1
            // 
            this.internationalLicense1.Location = new System.Drawing.Point(12, 10);
            this.internationalLicense1.Name = "internationalLicense1";
            this.internationalLicense1.Size = new System.Drawing.Size(873, 529);
            this.internationalLicense1.TabIndex = 0;
            // 
            // IssueInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 551);
            this.Controls.Add(this.internationalLicense1);
            this.Name = "IssueInternationalLicense";
            this.Text = "IssueInternationalLicense";
            this.ResumeLayout(false);

        }

        #endregion

        private InternationalLicense internationalLicense1;
    }
}