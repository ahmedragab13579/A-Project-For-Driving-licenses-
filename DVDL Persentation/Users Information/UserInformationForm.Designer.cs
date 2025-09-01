namespace DVDL_Persentation
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
            userCardControl1 = new UserCardControl();
            SuspendLayout();
            // 
            // userCardControl1
            // 
            userCardControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userCardControl1.BackColor = Color.FromArgb(38, 50, 56);
            userCardControl1.Font = new Font("Segoe UI", 10F);
            userCardControl1.ForeColor = Color.White;
            userCardControl1.Location = new Point(13, 13);
            userCardControl1.Margin = new Padding(4);
            userCardControl1.Name = "userCardControl1";
            userCardControl1.Size = new Size(937, 480);
            userCardControl1.TabIndex = 0;
            // 
            // UserInformationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(963, 520);
            Controls.Add(userCardControl1);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserInformationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Information";
            Load += UserInformationForm_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private UserCardControl userCardControl1;
    }
}
