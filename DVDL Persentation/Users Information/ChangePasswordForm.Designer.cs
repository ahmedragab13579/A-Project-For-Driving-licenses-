using System.Windows.Forms;

namespace DVDL_Persentation
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
            changePasswordControl1 = new ChangePasswordControl();
            SuspendLayout();
            // 
            // changePasswordControl1
            // 
            changePasswordControl1.BackColor = Color.Gray;
            changePasswordControl1.Location = new Point(2, 2);
            changePasswordControl1.Margin = new Padding(5, 3, 5, 3);
            changePasswordControl1.Name = "changePasswordControl1";
            changePasswordControl1.Size = new Size(890, 675);
            changePasswordControl1.TabIndex = 0;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(884, 666);
            Controls.Add(changePasswordControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            Load += ChangePasswordForm_Load;
            ResumeLayout(false);

        }

        #endregion

        private ChangePasswordControl changePasswordControl1;
    }
}