namespace DVDL_Persentation
{
    partial class UserCardControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            personCard1 = new PersonCard();
            groupBox1 = new GroupBox();
            IsActiveLabel = new Label();
            label5 = new Label();
            UserIDLabel = new Label();
            label3 = new Label();
            UserNameLabel = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // personCard1
            // 
            personCard1.BackColor = Color.Gray;
            personCard1.Location = new Point(20, 14);
            personCard1.Margin = new Padding(4, 3, 4, 3);
            personCard1.Name = "personCard1";
            personCard1.Size = new Size(906, 310);
            personCard1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(IsActiveLabel);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(UserIDLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(UserNameLabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(10, 330);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(916, 130);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Information";
            // 
            // IsActiveLabel
            // 
            IsActiveLabel.AutoSize = true;
            IsActiveLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            IsActiveLabel.ForeColor = Color.Black;
            IsActiveLabel.Location = new Point(600, 60);
            IsActiveLabel.Name = "IsActiveLabel";
            IsActiveLabel.Size = new Size(33, 19);
            IsActiveLabel.TabIndex = 5;
            IsActiveLabel.Text = "????";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(500, 60);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 4;
            label5.Text = "Is Active:";
            // 
            // UserIDLabel
            // 
            UserIDLabel.AutoSize = true;
            UserIDLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            UserIDLabel.ForeColor = Color.Black;
            UserIDLabel.Location = new Point(330, 60);
            UserIDLabel.Name = "UserIDLabel";
            UserIDLabel.Size = new Size(33, 19);
            UserIDLabel.TabIndex = 3;
            UserIDLabel.Text = "????";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 60);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "User ID:";
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            UserNameLabel.ForeColor = Color.Black;
            UserNameLabel.Location = new Point(110, 60);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(33, 19);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "????";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 60);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resource.Users_2_4001;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(370, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 139);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // UserCardControl
            // 
            BackColor = Color.Gray;
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(personCard1);
            Name = "UserCardControl";
            Size = new Size(930, 480);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private PersonCard personCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label IsActiveLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label label1;
        private PictureBox pictureBox1;
    }
}
