namespace TheSereens
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
            this.personCard1 = new TheSereens.PersonCard();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IsActiveLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // personCard1
            // 
            this.personCard1.BackColor = System.Drawing.Color.LightCyan;
            this.personCard1.Location = new System.Drawing.Point(10, 10);
            this.personCard1.Name = "personCard1";
            this.personCard1.Size = new System.Drawing.Size(821, 310);
            this.personCard1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.IsActiveLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.UserIDLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UserNameLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(10, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // IsActiveLabel
            // 
            this.IsActiveLabel.AutoSize = true;
            this.IsActiveLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.IsActiveLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.IsActiveLabel.Location = new System.Drawing.Point(600, 60);
            this.IsActiveLabel.Name = "IsActiveLabel";
            this.IsActiveLabel.Size = new System.Drawing.Size(33, 19);
            this.IsActiveLabel.TabIndex = 5;
            this.IsActiveLabel.Text = "????";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Is Active:";
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.UserIDLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.UserIDLabel.Location = new System.Drawing.Point(330, 60);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(33, 19);
            this.UserIDLabel.TabIndex = 3;
            this.UserIDLabel.Text = "????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "User ID:";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.UserNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.UserNameLabel.Location = new System.Drawing.Point(110, 60);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(33, 19);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "????";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // UserCardControl
            // 
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.personCard1);
            this.Name = "UserCardControl";
            this.Size = new System.Drawing.Size(834, 480);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}
