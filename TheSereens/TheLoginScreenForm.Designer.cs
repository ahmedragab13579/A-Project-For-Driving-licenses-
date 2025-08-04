namespace TheSereens
{
    partial class TheLoginScreenForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.WellcomeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LoginPassWord = new System.Windows.Forms.Button();
            this.RememberMe = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LoginMenuImage = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginMenuImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // WellcomeLabel
            // 
            this.WellcomeLabel.AutoSize = true;
            this.WellcomeLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.WellcomeLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.WellcomeLabel.Location = new System.Drawing.Point(456, 9);
            this.WellcomeLabel.Name = "WellcomeLabel";
            this.WellcomeLabel.Size = new System.Drawing.Size(338, 41);
            this.WellcomeLabel.TabIndex = 0;
            this.WellcomeLabel.Text = "Welcome, Please Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(458, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Location = new System.Drawing.Point(464, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UserNameTextBox.Location = new System.Drawing.Point(600, 120);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(180, 29);
            this.UserNameTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PasswordTextBox.Location = new System.Drawing.Point(600, 190);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(180, 29);
            this.PasswordTextBox.TabIndex = 4;
            // 
            // LoginPassWord
            // 
            this.LoginPassWord.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.LoginPassWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginPassWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LoginPassWord.ForeColor = System.Drawing.Color.White;
            this.LoginPassWord.Location = new System.Drawing.Point(600, 260);
            this.LoginPassWord.Name = "LoginPassWord";
            this.LoginPassWord.Size = new System.Drawing.Size(180, 40);
            this.LoginPassWord.TabIndex = 5;
            this.LoginPassWord.Text = "Login";
            this.LoginPassWord.UseVisualStyleBackColor = false;
            this.LoginPassWord.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // RememberMe
            // 
            this.RememberMe.AutoSize = true;
            this.RememberMe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RememberMe.Location = new System.Drawing.Point(600, 230);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(118, 23);
            this.RememberMe.TabIndex = 6;
            this.RememberMe.Text = "Remember Me";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(560, 190);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(560, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // LoginMenuImage
            // 
            this.LoginMenuImage.BackgroundImage = global::TheSereens.Properties.Resources._20946030;
            this.LoginMenuImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginMenuImage.Location = new System.Drawing.Point(0, 0);
            this.LoginMenuImage.Name = "LoginMenuImage";
            this.LoginMenuImage.Size = new System.Drawing.Size(450, 450);
            this.LoginMenuImage.TabIndex = 9;
            this.LoginMenuImage.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::TheSereens.Properties.Resources._20946030;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Location = new System.Drawing.Point(700, 265);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // TheLoginScreenForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WellcomeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginPassWord);
            this.Controls.Add(this.RememberMe);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.LoginMenuImage);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TheLoginScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginMenuImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginMenuImage;
        private System.Windows.Forms.Label WellcomeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.MaskedTextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginPassWord;
        private System.Windows.Forms.CheckBox RememberMe;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
