namespace TheSereens.License_Information
{
    partial class LocalLicenseApplicationInfomationForm
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
            this.SuspendLayout();
            // 
            // licenseInfomations1
            // 
            this.licenseInfomations1.Location = new System.Drawing.Point(12, 12);
            this.licenseInfomations1.Name = "licenseInfomations1";
            this.licenseInfomations1.Size = new System.Drawing.Size(878, 454);
            this.licenseInfomations1.TabIndex = 0;
            // 
            // LocalLicenseApplicationInfomationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 507);
            this.Controls.Add(this.licenseInfomations1);
            this.Name = "LocalLicenseApplicationInfomationForm";
            this.Text = "LocalLicenseInfomation";
            this.Load += new System.EventHandler(this.LocalLicenseInfomation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LicenseInfomations licenseInfomations1;
    }
}