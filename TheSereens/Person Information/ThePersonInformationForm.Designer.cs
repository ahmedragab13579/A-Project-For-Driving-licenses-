namespace TheSereens
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
            this.personCard1 = new TheSereens.PersonCard();
            this.SuspendLayout();
            // 
            // personCard1
            // 
            this.personCard1.BackColor = System.Drawing.Color.LightCyan;
            this.personCard1.Location = new System.Drawing.Point(23, 105);
            this.personCard1.Name = "personCard1";
            this.personCard1.Size = new System.Drawing.Size(751, 307);
            this.personCard1.TabIndex = 0;
            // 
            // ThePersonInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.personCard1);
            this.Name = "ThePersonInformationForm";
            this.Text = "ThePersonInformationForm";
            this.Load += new System.EventHandler(this.ThePersonInformationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PersonCard personCard1;
    }
}