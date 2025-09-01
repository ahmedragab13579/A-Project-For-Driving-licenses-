namespace DVDL_Persentation
{
    partial class UpdateTest
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
            SaveButton = new Button();
            CancelButton = new Button();
            FeesTextBox = new TextBox();
            TitleTextBox = new TextBox();
            FeesLabel = new Label();
            label4 = new Label();
            label3 = new Label();
            TestIDLabel = new Label();
            TheManageTestTitle = new Label();
            DescriptionTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(418, 332);
            SaveButton.Margin = new Padding(4, 3, 4, 3);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(88, 27);
            SaveButton.TabIndex = 17;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(323, 332);
            CancelButton.Margin = new Padding(4, 3, 4, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(88, 27);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // FeesTextBox
            // 
            FeesTextBox.BorderStyle = BorderStyle.None;
            FeesTextBox.Location = new Point(133, 211);
            FeesTextBox.Margin = new Padding(4, 3, 4, 3);
            FeesTextBox.Name = "FeesTextBox";
            FeesTextBox.Size = new Size(211, 16);
            FeesTextBox.TabIndex = 15;
            // 
            // TitleTextBox
            // 
            TitleTextBox.BorderStyle = BorderStyle.None;
            TitleTextBox.Location = new Point(133, 137);
            TitleTextBox.Margin = new Padding(4, 3, 4, 3);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(212, 16);
            TitleTextBox.TabIndex = 14;
            // 
            // FeesLabel
            // 
            FeesLabel.AutoSize = true;
            FeesLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FeesLabel.ForeColor = Color.Black;
            FeesLabel.Location = new Point(14, 194);
            FeesLabel.Margin = new Padding(4, 0, 4, 0);
            FeesLabel.Name = "FeesLabel";
            FeesLabel.Size = new Size(104, 31);
            FeesLabel.TabIndex = 13;
            FeesLabel.Text = "Fees : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(14, 120);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 31);
            label4.TabIndex = 12;
            label4.Text = "Title : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(14, 61);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 31);
            label3.TabIndex = 11;
            label3.Text = "ID : ";
            // 
            // TestIDLabel
            // 
            TestIDLabel.AutoSize = true;
            TestIDLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TestIDLabel.ForeColor = Color.Black;
            TestIDLabel.Location = new Point(146, 61);
            TestIDLabel.Margin = new Padding(4, 0, 4, 0);
            TestIDLabel.Name = "TestIDLabel";
            TestIDLabel.Size = new Size(78, 31);
            TestIDLabel.TabIndex = 10;
            TestIDLabel.Text = "????";
            // 
            // TheManageTestTitle
            // 
            TheManageTestTitle.AutoSize = true;
            TheManageTestTitle.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TheManageTestTitle.ForeColor = Color.Red;
            TheManageTestTitle.Location = new Point(14, 10);
            TheManageTestTitle.Margin = new Padding(4, 0, 4, 0);
            TheManageTestTitle.Name = "TheManageTestTitle";
            TheManageTestTitle.Size = new Size(421, 31);
            TheManageTestTitle.TabIndex = 9;
            TheManageTestTitle.Text = "Edit The Application Informaion";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.BorderStyle = BorderStyle.None;
            DescriptionTextBox.Location = new Point(239, 280);
            DescriptionTextBox.Margin = new Padding(4, 3, 4, 3);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(212, 23);
            DescriptionTextBox.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 263);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 31);
            label1.TabIndex = 18;
            label1.Text = "Description : ";
            // 
            // UpdateTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 384);
            Controls.Add(DescriptionTextBox);
            Controls.Add(label1);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Controls.Add(FeesTextBox);
            Controls.Add(TitleTextBox);
            Controls.Add(FeesLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TestIDLabel);
            Controls.Add(TheManageTestTitle);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UpdateTest";
            Text = "UpdateTest";
            Load += UpdateTest_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox FeesTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label FeesLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TestIDLabel;
        private System.Windows.Forms.Label TheManageTestTitle;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label label1;
    }
}