namespace DVDL_Persentation
{
    partial class ThePersonInformationForm
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
            SuspendLayout();
            // 
            // personCard1
            // 
            personCard1.BackColor = Color.White;
            personCard1.Location = new Point(14, 12);
            personCard1.Margin = new Padding(5, 3, 5, 3);
            personCard1.Name = "personCard1";
            personCard1.Size = new Size(876, 354);
            personCard1.TabIndex = 0;
            // 
            // ThePersonInformationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(893, 362);
            Controls.Add(personCard1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ThePersonInformationForm";
            Text = "ThePersonInformationForm";
            Load += ThePersonInformationForm_Load;
            ResumeLayout(false);

        }

        #endregion

        private PersonCard personCard1;
    }
}