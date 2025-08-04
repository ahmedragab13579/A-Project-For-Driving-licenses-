namespace TheSereens
{
    partial class UserInformationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.userCardControl1 = new TheSereens.UserCardControl();
            this.SuspendLayout();
            // 
            // userCardControl1
            // 
            this.userCardControl1.BackColor = System.Drawing.Color.FromArgb(38, 50, 56); // أزرق رمادي غامق
            this.userCardControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.userCardControl1.ForeColor = System.Drawing.Color.White;
            this.userCardControl1.Location = new System.Drawing.Point(20, 20);
            this.userCardControl1.Margin = new System.Windows.Forms.Padding(4);
            this.userCardControl1.Name = "userCardControl1";
            this.userCardControl1.Size = new System.Drawing.Size(860, 480);
            this.userCardControl1.TabIndex = 0;
            this.userCardControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // UserInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30); // خلفية الفورم داكنة
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.userCardControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Information";
            this.ResumeLayout(false);
        }

        #endregion

        private UserCardControl userCardControl1;
    }
}
