namespace TheSereens
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
            this.personCard1 = new TheSereens.PersonCard();
            this.Cancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PersonLicenses = new System.Windows.Forms.DataGridView();
            this.InternationalLicenses = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InternationalLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // personCard1
            // 
            this.personCard1.Location = new System.Drawing.Point(12, 3);
            this.personCard1.Name = "personCard1";
            this.personCard1.Size = new System.Drawing.Size(751, 307);
            this.personCard1.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(677, 525);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 357);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(740, 191);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PersonLicenses);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(732, 165);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Local Licenses";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.InternationalLicenses);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 165);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International licenses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PersonLicenses
            // 
            this.PersonLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonLicenses.Location = new System.Drawing.Point(6, 9);
            this.PersonLicenses.Name = "PersonLicenses";
            this.PersonLicenses.Size = new System.Drawing.Size(720, 150);
            this.PersonLicenses.TabIndex = 4;
            // 
            // InternationalLicenses
            // 
            this.InternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InternationalLicenses.Location = new System.Drawing.Point(6, 3);
            this.InternationalLicenses.Name = "InternationalLicenses";
            this.InternationalLicenses.Size = new System.Drawing.Size(720, 156);
            this.InternationalLicenses.TabIndex = 4;
            // 
            // PersonLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 560);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.personCard1);
            this.Name = "PersonLicenseHistory";
            this.Text = "PersonLicenseHistory";
            this.Load += new System.EventHandler(this.PersonLicenseHistory_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersonLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InternationalLicenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonCard personCard1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView PersonLicenses;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView InternationalLicenses;
    }
}