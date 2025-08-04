namespace TheSereens
{
    partial class ChangePasswordControl
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserNameText = new System.Windows.Forms.Label();
            this.IsActiveText = new System.Windows.Forms.Label();
            this.UserIdText = new System.Windows.Forms.Label();
            this.ConfirmNewPassWordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NewPassWordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CurrentPassWordTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.personCard1 = new TheSereens.PersonCard();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 202);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login information";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.UserNameText);
            this.panel1.Controls.Add(this.IsActiveText);
            this.panel1.Controls.Add(this.UserIdText);
            this.panel1.Controls.Add(this.ConfirmNewPassWordTextBox);
            this.panel1.Controls.Add(this.NewPassWordTextBox);
            this.panel1.Controls.Add(this.CurrentPassWordTextbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 129);
            this.panel1.TabIndex = 5;
            // 
            // UserNameText
            // 
            this.UserNameText.AutoSize = true;
            this.UserNameText.Location = new System.Drawing.Point(142, 63);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(44, 17);
            this.UserNameText.TabIndex = 29;
            this.UserNameText.Text = "????";
            // 
            // IsActiveText
            // 
            this.IsActiveText.AutoSize = true;
            this.IsActiveText.Location = new System.Drawing.Point(142, 99);
            this.IsActiveText.Name = "IsActiveText";
            this.IsActiveText.Size = new System.Drawing.Size(44, 17);
            this.IsActiveText.TabIndex = 28;
            this.IsActiveText.Text = "????";
            // 
            // UserIdText
            // 
            this.UserIdText.AutoSize = true;
            this.UserIdText.Location = new System.Drawing.Point(142, 15);
            this.UserIdText.Name = "UserIdText";
            this.UserIdText.Size = new System.Drawing.Size(44, 17);
            this.UserIdText.TabIndex = 26;
            this.UserIdText.Text = "????";
            // 
            // ConfirmNewPassWordTextBox
            // 
            this.ConfirmNewPassWordTextBox.Location = new System.Drawing.Point(571, 93);
            this.ConfirmNewPassWordTextBox.Name = "ConfirmNewPassWordTextBox";
            this.ConfirmNewPassWordTextBox.Size = new System.Drawing.Size(162, 23);
            this.ConfirmNewPassWordTextBox.TabIndex = 25;
            // 
            // NewPassWordTextBox
            // 
            this.NewPassWordTextBox.Location = new System.Drawing.Point(571, 57);
            this.NewPassWordTextBox.Name = "NewPassWordTextBox";
            this.NewPassWordTextBox.Size = new System.Drawing.Size(162, 23);
            this.NewPassWordTextBox.TabIndex = 24;
            // 
            // CurrentPassWordTextbox
            // 
            this.CurrentPassWordTextbox.Location = new System.Drawing.Point(571, 15);
            this.CurrentPassWordTextbox.Name = "CurrentPassWordTextbox";
            this.CurrentPassWordTextbox.Size = new System.Drawing.Size(162, 23);
            this.CurrentPassWordTextbox.TabIndex = 23;
            this.CurrentPassWordTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.CurrentPassWordTextbox_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Confirm Password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "New password : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Current Password : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Is active : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "User name : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "User id : ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(679, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(581, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // personCard1
            // 
            this.personCard1.BackColor = System.Drawing.Color.White;
            this.personCard1.Location = new System.Drawing.Point(3, 3);
            this.personCard1.Name = "personCard1";
            this.personCard1.Size = new System.Drawing.Size(751, 307);
            this.personCard1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ChangePasswordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personCard1);
            this.Name = "ChangePasswordControl";
            this.Size = new System.Drawing.Size(763, 585);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonCard personCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label IsActiveText;
        private System.Windows.Forms.Label UserIdText;
        private System.Windows.Forms.MaskedTextBox ConfirmNewPassWordTextBox;
        private System.Windows.Forms.MaskedTextBox NewPassWordTextBox;
        private System.Windows.Forms.TextBox CurrentPassWordTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label UserNameText;
    }
}
