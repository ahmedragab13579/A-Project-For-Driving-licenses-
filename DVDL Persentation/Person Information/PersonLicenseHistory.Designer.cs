namespace DVDL_Persentation
{
    partial class PersonLicenseHistory
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
            personCard1 = new PersonCard();
            Cancel = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            PersonLicenses = new DataGridView();
            tabPage2 = new TabPage();
            InternationalLicenses = new DataGridView();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PersonLicenses).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InternationalLicenses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // personCard1
            // 
            personCard1.BackColor = Color.FromArgb(244, 246, 249);
            personCard1.Location = new Point(14, 3);
            personCard1.Margin = new Padding(5, 3, 5, 3);
            personCard1.Name = "personCard1";
            personCard1.Size = new Size(876, 354);
            personCard1.TabIndex = 0;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(790, 606);
            Cancel.Margin = new Padding(4, 3, 4, 3);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(88, 27);
            Cancel.TabIndex = 2;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(14, 412);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(863, 220);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(PersonLicenses);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(855, 192);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Local Licenses";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // PersonLicenses
            // 
            PersonLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonLicenses.Location = new Point(7, 10);
            PersonLicenses.Margin = new Padding(4, 3, 4, 3);
            PersonLicenses.Name = "PersonLicenses";
            PersonLicenses.Size = new Size(840, 173);
            PersonLicenses.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(InternationalLicenses);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(855, 192);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "International licenses";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // InternationalLicenses
            // 
            InternationalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InternationalLicenses.Location = new Point(7, 3);
            InternationalLicenses.Margin = new Padding(4, 3, 4, 3);
            InternationalLicenses.Name = "InternationalLicenses";
            InternationalLicenses.Size = new Size(840, 180);
            InternationalLicenses.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resource.PersonLicenseHistory_512;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(329, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 162);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // PersonLicenseHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 646);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            Controls.Add(Cancel);
            Controls.Add(personCard1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PersonLicenseHistory";
            Text = "PersonLicenseHistory";
            Load += PersonLicenseHistory_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PersonLicenses).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InternationalLicenses).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private PersonCard personCard1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView PersonLicenses;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView InternationalLicenses;
        private PictureBox pictureBox1;
    }
}