namespace DVDL_Persentation.Tests
{
    partial class TestForm
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
            pictureBox1 = new PictureBox();
            CloseButton = new Button();
            SaveButton = new Button();
            TitleLabel = new Label();
            TestResult = new GroupBox();
            textBox1 = new TextBox();
            label9 = new Label();
            Fail = new RadioButton();
            Pass = new RadioButton();
            label7 = new Label();
            AppointmentDate = new DateTimePicker();
            FeesLabel = new Label();
            TrailLabel = new Label();
            PersonNameLabel = new Label();
            IDLabel = new Label();
            LicenseClass = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TestIDLabel = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            TestResult.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resource.Vision_512;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(146, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 132);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(274, 641);
            CloseButton.Margin = new Padding(4, 3, 4, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(88, 27);
            CloseButton.TabIndex = 30;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(134, 641);
            SaveButton.Margin = new Padding(4, 3, 4, 3);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(88, 27);
            SaveButton.TabIndex = 29;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.Red;
            TitleLabel.Location = new Point(175, 135);
            TitleLabel.Margin = new Padding(4, 0, 4, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(152, 25);
            TitleLabel.TabIndex = 31;
            TitleLabel.Text = "Schedual Test";
            // 
            // TestResult
            // 
            TestResult.Controls.Add(textBox1);
            TestResult.Controls.Add(label9);
            TestResult.Controls.Add(Fail);
            TestResult.Controls.Add(Pass);
            TestResult.Controls.Add(label7);
            TestResult.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TestResult.Location = new Point(17, 512);
            TestResult.Margin = new Padding(4, 3, 4, 3);
            TestResult.Name = "TestResult";
            TestResult.Padding = new Padding(4, 3, 4, 3);
            TestResult.Size = new Size(444, 132);
            TestResult.TabIndex = 28;
            TestResult.TabStop = false;
            TestResult.Text = "The Test Result";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 75);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 48);
            textBox1.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(21, 75);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(60, 18);
            label9.TabIndex = 37;
            label9.Text = "Notes : ";
            // 
            // Fail
            // 
            Fail.AutoSize = true;
            Fail.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Fail.Location = new Point(186, 31);
            Fail.Margin = new Padding(4, 3, 4, 3);
            Fail.Name = "Fail";
            Fail.Size = new Size(41, 17);
            Fail.TabIndex = 36;
            Fail.TabStop = true;
            Fail.Text = "Fail";
            Fail.UseVisualStyleBackColor = true;
            // 
            // Pass
            // 
            Pass.AutoSize = true;
            Pass.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pass.Location = new Point(117, 31);
            Pass.Margin = new Padding(4, 3, 4, 3);
            Pass.Name = "Pass";
            Pass.Size = new Size(48, 17);
            Pass.TabIndex = 35;
            Pass.TabStop = true;
            Pass.Text = "Pass";
            Pass.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 29);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(62, 18);
            label7.TabIndex = 34;
            label7.Text = "Result : ";
            // 
            // AppointmentDate
            // 
            AppointmentDate.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AppointmentDate.Location = new Point(163, 362);
            AppointmentDate.Margin = new Padding(4, 3, 4, 3);
            AppointmentDate.Name = "AppointmentDate";
            AppointmentDate.Size = new Size(312, 24);
            AppointmentDate.TabIndex = 27;
            // 
            // FeesLabel
            // 
            FeesLabel.AutoSize = true;
            FeesLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FeesLabel.Location = new Point(163, 418);
            FeesLabel.Margin = new Padding(4, 0, 4, 0);
            FeesLabel.Name = "FeesLabel";
            FeesLabel.Size = new Size(44, 18);
            FeesLabel.TabIndex = 26;
            FeesLabel.Text = "????";
            // 
            // TrailLabel
            // 
            TrailLabel.AutoSize = true;
            TrailLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TrailLabel.Location = new Point(163, 317);
            TrailLabel.Margin = new Padding(4, 0, 4, 0);
            TrailLabel.Name = "TrailLabel";
            TrailLabel.Size = new Size(44, 18);
            TrailLabel.TabIndex = 25;
            TrailLabel.Text = "????";
            // 
            // PersonNameLabel
            // 
            PersonNameLabel.AutoSize = true;
            PersonNameLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PersonNameLabel.Location = new Point(163, 270);
            PersonNameLabel.Margin = new Padding(4, 0, 4, 0);
            PersonNameLabel.Name = "PersonNameLabel";
            PersonNameLabel.Size = new Size(44, 18);
            PersonNameLabel.TabIndex = 24;
            PersonNameLabel.Text = "????";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IDLabel.Location = new Point(163, 171);
            IDLabel.Margin = new Padding(4, 0, 4, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(44, 18);
            IDLabel.TabIndex = 22;
            IDLabel.Text = "????";
            // 
            // LicenseClass
            // 
            LicenseClass.AutoSize = true;
            LicenseClass.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LicenseClass.Location = new Point(163, 219);
            LicenseClass.Margin = new Padding(4, 0, 4, 0);
            LicenseClass.Name = "LicenseClass";
            LicenseClass.Size = new Size(44, 18);
            LicenseClass.TabIndex = 23;
            LicenseClass.Text = "????";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 418);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 18);
            label6.TabIndex = 21;
            label6.Text = "Fees : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 369);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 18);
            label5.TabIndex = 20;
            label5.Text = "Date : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 317);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 19;
            label4.Text = "Trail : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 222);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 18);
            label3.TabIndex = 17;
            label3.Text = "D.Class : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 270);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 18);
            label2.TabIndex = 18;
            label2.Text = "Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 171);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 18);
            label1.TabIndex = 16;
            label1.Text = "D.L.App.ID : ";
            // 
            // TestIDLabel
            // 
            TestIDLabel.AutoSize = true;
            TestIDLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TestIDLabel.Location = new Point(166, 467);
            TestIDLabel.Margin = new Padding(4, 0, 4, 0);
            TestIDLabel.Name = "TestIDLabel";
            TestIDLabel.Size = new Size(44, 18);
            TestIDLabel.TabIndex = 34;
            TestIDLabel.Text = "????";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 467);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(72, 18);
            label8.TabIndex = 33;
            label8.Text = "TestID : ";
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 670);
            Controls.Add(TestIDLabel);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(CloseButton);
            Controls.Add(SaveButton);
            Controls.Add(TitleLabel);
            Controls.Add(TestResult);
            Controls.Add(AppointmentDate);
            Controls.Add(FeesLabel);
            Controls.Add(TrailLabel);
            Controls.Add(PersonNameLabel);
            Controls.Add(IDLabel);
            Controls.Add(LicenseClass);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TestForm";
            Text = "TestForm";
            Load += TestForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            TestResult.ResumeLayout(false);
            TestResult.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox TestResult;
        private System.Windows.Forms.RadioButton Fail;
        private System.Windows.Forms.RadioButton Pass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker AppointmentDate;
        private System.Windows.Forms.Label FeesLabel;
        private System.Windows.Forms.Label TrailLabel;
        private System.Windows.Forms.Label PersonNameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label LicenseClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TestIDLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
    }
}