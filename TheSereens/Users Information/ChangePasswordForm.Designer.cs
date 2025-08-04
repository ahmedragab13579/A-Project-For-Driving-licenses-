using System.Windows.Forms;

namespace TheSereens
{
    partial class ChangePasswordForm
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
            this.changePasswordControl1 = new TheSereens.ChangePasswordControl();
            this.SuspendLayout();
            // 
            // changePasswordControl1
            // 
            this.changePasswordControl1.BackColor = System.Drawing.Color.LightCyan;
            this.changePasswordControl1.Location = new System.Drawing.Point(2, 2);
            this.changePasswordControl1.Name = "changePasswordControl1";
            this.changePasswordControl1.Size = new System.Drawing.Size(763, 585);
            this.changePasswordControl1.TabIndex = 0;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(758, 577);
            this.Controls.Add(this.changePasswordControl1);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ChangePasswordControl changePasswordControl1;
    }
}