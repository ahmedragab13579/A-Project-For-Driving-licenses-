namespace DVDL_Persentation
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
            personCard1 = new PersonCard();
            FiltersCompoBox = new ComboBox();
            label1 = new Label();
            SearchButton = new Button();
            AddPersonButton = new Button();
            TheFilterGroupbox = new GroupBox();
            TheFilterInformation = new TextBox();
            TheFilterGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // personCard1
            // 
            personCard1.BackColor = Color.Gray;
            personCard1.Location = new Point(8, 83);
            personCard1.Margin = new Padding(5, 3, 5, 3);
            personCard1.Name = "personCard1";
            personCard1.Size = new Size(876, 354);
            personCard1.TabIndex = 0;
            personCard1.PersonFound += personCard1_PersonFound;
            // 
            // FiltersCompoBox
            // 
            FiltersCompoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FiltersCompoBox.FormattingEnabled = true;
            FiltersCompoBox.Items.AddRange(new object[] { "Person ID", "National ID" });
            FiltersCompoBox.Location = new Point(112, 33);
            FiltersCompoBox.Margin = new Padding(4, 3, 4, 3);
            FiltersCompoBox.Name = "FiltersCompoBox";
            FiltersCompoBox.Size = new Size(140, 24);
            FiltersCompoBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 17);
            label1.TabIndex = 3;
            label1.Text = "Find by ; ";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(490, 33);
            SearchButton.Margin = new Padding(4, 3, 4, 3);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(88, 27);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += Searchbutton_Click;
            // 
            // AddPersonButton
            // 
            AddPersonButton.Location = new Point(617, 33);
            AddPersonButton.Margin = new Padding(4, 3, 4, 3);
            AddPersonButton.Name = "AddPersonButton";
            AddPersonButton.Size = new Size(88, 27);
            AddPersonButton.TabIndex = 5;
            AddPersonButton.Text = "Add Person";
            AddPersonButton.UseVisualStyleBackColor = true;
            AddPersonButton.Click += AddPersonbutton_Click;
            // 
            // TheFilterGroupbox
            // 
            TheFilterGroupbox.BackColor = Color.Gray;
            TheFilterGroupbox.Controls.Add(TheFilterInformation);
            TheFilterGroupbox.Controls.Add(label1);
            TheFilterGroupbox.Controls.Add(AddPersonButton);
            TheFilterGroupbox.Controls.Add(FiltersCompoBox);
            TheFilterGroupbox.Controls.Add(SearchButton);
            TheFilterGroupbox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TheFilterGroupbox.Location = new Point(8, 3);
            TheFilterGroupbox.Margin = new Padding(4, 3, 4, 3);
            TheFilterGroupbox.Name = "TheFilterGroupbox";
            TheFilterGroupbox.Padding = new Padding(4, 3, 4, 3);
            TheFilterGroupbox.Size = new Size(876, 73);
            TheFilterGroupbox.TabIndex = 7;
            TheFilterGroupbox.TabStop = false;
            TheFilterGroupbox.Text = "The filter";
            // 
            // TheFilterInformation
            // 
            TheFilterInformation.Location = new Point(295, 33);
            TheFilterInformation.Name = "TheFilterInformation";
            TheFilterInformation.Size = new Size(162, 23);
            TheFilterInformation.TabIndex = 6;
            TheFilterInformation.KeyPress += TheFilterInformation_KeyPress;
            // 
            // PersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TheFilterGroupbox);
            Controls.Add(personCard1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PersonCardWithFilter";
            Size = new Size(886, 438);
            Load += PersonCardWithFilter_Load;
            TheFilterGroupbox.ResumeLayout(false);
            TheFilterGroupbox.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private PersonCard personCard1;
        private System.Windows.Forms.ComboBox FiltersCompoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.GroupBox TheFilterGroupbox;
        private TextBox TheFilterInformation;
    }
}
