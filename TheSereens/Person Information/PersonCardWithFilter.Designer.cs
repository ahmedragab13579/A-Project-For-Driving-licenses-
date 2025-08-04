namespace TheSereens
{
    partial class PersonCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.personCard1 = new TheSereens.PersonCard();
            this.FiltersCompoBox = new System.Windows.Forms.ComboBox();
            this.TheFilterInformation = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.TheFilterGroupbox = new System.Windows.Forms.GroupBox();
            this.TheFilterGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // personCard1
            // 
            this.personCard1.Location = new System.Drawing.Point(7, 72);
            this.personCard1.Name = "personCard1";
            this.personCard1.Size = new System.Drawing.Size(751, 307);
            this.personCard1.TabIndex = 0;
            // 
            // FiltersCompoBox
            // 
            this.FiltersCompoBox.FormattingEnabled = true;
            this.FiltersCompoBox.Items.AddRange(new object[] {
            "Person ID",
            "National ID"});
            this.FiltersCompoBox.Location = new System.Drawing.Point(96, 29);
            this.FiltersCompoBox.Name = "FiltersCompoBox";
            this.FiltersCompoBox.Size = new System.Drawing.Size(121, 24);
            this.FiltersCompoBox.TabIndex = 1;
            this.FiltersCompoBox.SelectedIndexChanged += new System.EventHandler(this.FiltersCompoBox_SelectedIndexChanged);
            // 
            // TheFilterInformation
            // 
            this.TheFilterInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TheFilterInformation.Location = new System.Drawing.Point(241, 29);
            this.TheFilterInformation.Mask = "00000000000000000";
            this.TheFilterInformation.Name = "TheFilterInformation";
            this.TheFilterInformation.Size = new System.Drawing.Size(128, 23);
            this.TheFilterInformation.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Find by ; ";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(420, 29);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(529, 29);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(75, 23);
            this.AddPersonButton.TabIndex = 5;
            this.AddPersonButton.Text = "Add Person";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonbutton_Click);
            // 
            // TheFilterGroupbox
            // 
            this.TheFilterGroupbox.Controls.Add(this.label1);
            this.TheFilterGroupbox.Controls.Add(this.AddPersonButton);
            this.TheFilterGroupbox.Controls.Add(this.FiltersCompoBox);
            this.TheFilterGroupbox.Controls.Add(this.SearchButton);
            this.TheFilterGroupbox.Controls.Add(this.TheFilterInformation);
            this.TheFilterGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheFilterGroupbox.Location = new System.Drawing.Point(7, 3);
            this.TheFilterGroupbox.Name = "TheFilterGroupbox";
            this.TheFilterGroupbox.Size = new System.Drawing.Size(751, 63);
            this.TheFilterGroupbox.TabIndex = 7;
            this.TheFilterGroupbox.TabStop = false;
            this.TheFilterGroupbox.Text = "The filter";
            // 
            // PersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TheFilterGroupbox);
            this.Controls.Add(this.personCard1);
            this.Name = "PersonCardWithFilter";
            this.Size = new System.Drawing.Size(797, 394);
            this.Load += new System.EventHandler(this.PersonCardWithFilter_Load);
            this.TheFilterGroupbox.ResumeLayout(false);
            this.TheFilterGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonCard personCard1;
        private System.Windows.Forms.ComboBox FiltersCompoBox;
        private System.Windows.Forms.MaskedTextBox TheFilterInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.GroupBox TheFilterGroupbox;
    }
}
