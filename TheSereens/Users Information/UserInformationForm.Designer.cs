namespace TheSereens
{
    partial class UserInformationForm
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
            this.userCardControl1 = new TheSereens.UserCardControl();
            this.SuspendLayout();
            // 
            // userCardControl1
            // 
            this.userCardControl1.Location = new System.Drawing.Point(12, 11);
            this.userCardControl1.Name = "userCardControl1";
            this.userCardControl1.Size = new System.Drawing.Size(771, 483);
            this.userCardControl1.TabIndex = 0;
            // 
            // UserInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.userCardControl1);
            this.Name = "UserInformationForm";
            this.Text = "UserInformationForm";
            this.Load += new System.EventHandler(this.UserInformationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserCardControl userCardControl1;
    }
}