namespace DVDL_Persentation.License_Information
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
            internationalLicense2 = new InternationalLicense();
            SuspendLayout();
            // 
            // internationalLicense2
            // 
            internationalLicense2.Location = new Point(13, 1);
            internationalLicense2.Margin = new Padding(4, 3, 4, 3);
            internationalLicense2.Name = "internationalLicense2";
            internationalLicense2.Size = new Size(1018, 610);
            internationalLicense2.TabIndex = 0;
            internationalLicense2.Load += internationalLicense2_Load;
            // 
            // IssueInternationalLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 636);
            Controls.Add(internationalLicense2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "IssueInternationalLicense";
            Text = "IssueInternationalLicense";
            ResumeLayout(false);

        }

        #endregion

        private InternationalLicense internationalLicense2;
    }
}