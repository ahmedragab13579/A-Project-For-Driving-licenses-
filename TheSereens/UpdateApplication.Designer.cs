namespace TheSereens
{
    partial class UpdateApplication
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
            this.TheManageApplicationTitle = new System.Windows.Forms.Label();
            this.ApplicationIDLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FeesLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.FeesTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TheManageApplicationTitle
            // 
            this.TheManageApplicationTitle.AutoSize = true;
            this.TheManageApplicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheManageApplicationTitle.ForeColor = System.Drawing.Color.Red;
            this.TheManageApplicationTitle.Location = new System.Drawing.Point(0, 4);
            this.TheManageApplicationTitle.Name = "TheManageApplicationTitle";
            this.TheManageApplicationTitle.Size = new System.Drawing.Size(421, 31);
            this.TheManageApplicationTitle.TabIndex = 0;
            this.TheManageApplicationTitle.Text = "Edit The Application Informaion";
            // 
            // ApplicationIDLabel
            // 
            this.ApplicationIDLabel.AutoSize = true;
            this.ApplicationIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationIDLabel.ForeColor = System.Drawing.Color.Black;
            this.ApplicationIDLabel.Location = new System.Drawing.Point(113, 48);
            this.ApplicationIDLabel.Name = "ApplicationIDLabel";
            this.ApplicationIDLabel.Size = new System.Drawing.Size(78, 31);
            this.ApplicationIDLabel.TabIndex = 1;
            this.ApplicationIDLabel.Text = "????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Title : ";
            // 
            // FeesLabel
            // 
            this.FeesLabel.AutoSize = true;
            this.FeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesLabel.ForeColor = System.Drawing.Color.Black;
            this.FeesLabel.Location = new System.Drawing.Point(0, 163);
            this.FeesLabel.Name = "FeesLabel";
            this.FeesLabel.Size = new System.Drawing.Size(104, 31);
            this.FeesLabel.TabIndex = 4;
            this.FeesLabel.Text = "Fees : ";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleTextBox.Location = new System.Drawing.Point(102, 114);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(182, 13);
            this.TitleTextBox.TabIndex = 5;
            // 
            // FeesTextBox
            // 
            this.FeesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FeesTextBox.Location = new System.Drawing.Point(102, 178);
            this.FeesTextBox.Name = "FeesTextBox";
            this.FeesTextBox.Size = new System.Drawing.Size(181, 13);
            this.FeesTextBox.TabIndex = 6;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(251, 220);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(332, 220);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UpdateApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 255);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FeesTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.FeesLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ApplicationIDLabel);
            this.Controls.Add(this.TheManageApplicationTitle);
            this.Name = "UpdateApplication";
            this.Text = "UpdateApplication";
            this.Load += new System.EventHandler(this.UpdateApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TheManageApplicationTitle;
        private System.Windows.Forms.Label ApplicationIDLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FeesLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox FeesTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
    }
}