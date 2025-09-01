namespace DVDL_Persentation
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
            WellcomeLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            UserNameTextBox = new TextBox();
            PasswordTextBox = new MaskedTextBox();
            LoginPassWord = new Button();
            RememberMe = new CheckBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            LoginMenuImage = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LoginMenuImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // WellcomeLabel
            // 
            WellcomeLabel.AutoSize = true;
            WellcomeLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            WellcomeLabel.ForeColor = Color.DarkSlateBlue;
            WellcomeLabel.Location = new Point(456, 9);
            WellcomeLabel.Name = "WellcomeLabel";
            WellcomeLabel.Size = new Size(338, 41);
            WellcomeLabel.TabIndex = 0;
            WellcomeLabel.Text = "Welcome, Please Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(458, 120);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(464, 190);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            UserNameTextBox.Font = new Font("Segoe UI", 12F);
            UserNameTextBox.Location = new Point(600, 120);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(180, 29);
            UserNameTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordTextBox.Font = new Font("Segoe UI", 12F);
            PasswordTextBox.Location = new Point(600, 190);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(180, 29);
            PasswordTextBox.TabIndex = 4;
            // 
            // LoginPassWord
            // 
            LoginPassWord.BackColor = Color.DarkSlateBlue;
            LoginPassWord.FlatStyle = FlatStyle.Flat;
            LoginPassWord.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LoginPassWord.ForeColor = Color.White;
            LoginPassWord.Location = new Point(600, 260);
            LoginPassWord.Name = "LoginPassWord";
            LoginPassWord.Size = new Size(180, 40);
            LoginPassWord.TabIndex = 5;
            LoginPassWord.Text = "Login";
            LoginPassWord.UseVisualStyleBackColor = false;
            LoginPassWord.Click += Loginbutton_Click;
            // 
            // RememberMe
            // 
            RememberMe.AutoSize = true;
            RememberMe.Font = new Font("Segoe UI", 10F);
            RememberMe.Location = new Point(600, 230);
            RememberMe.Name = "RememberMe";
            RememberMe.Size = new Size(118, 23);
            RememberMe.TabIndex = 6;
            RememberMe.Text = "Remember Me";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resource.Password_32;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(560, 190);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resource.Email_32;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(560, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // LoginMenuImage
            // 
            LoginMenuImage.BackgroundImage = Properties.Resource._20946030;
            LoginMenuImage.BackgroundImageLayout = ImageLayout.Stretch;
            LoginMenuImage.Location = new Point(0, 0);
            LoginMenuImage.Name = "LoginMenuImage";
            LoginMenuImage.Size = new Size(450, 450);
            LoginMenuImage.TabIndex = 9;
            LoginMenuImage.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resource._296fe121_5dfa_43f4_98b5_db50019738a7;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Enabled = false;
            pictureBox4.Location = new Point(700, 265);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // TheLoginScreenForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(WellcomeLabel);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(UserNameTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginPassWord);
            Controls.Add(RememberMe);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(LoginMenuImage);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TheLoginScreenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += TheLoginScreenForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)LoginMenuImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
