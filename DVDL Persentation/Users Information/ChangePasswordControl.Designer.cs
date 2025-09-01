namespace DVDL_Persentation
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            UserNameText = new Label();
            IsActiveText = new Label();
            UserIdText = new Label();
            ConfirmNewPassWordTextBox = new MaskedTextBox();
            NewPassWordTextBox = new MaskedTextBox();
            CurrentPassWordTextbox = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button2 = new Button();
            button1 = new Button();
            personCard1 = new PersonCard();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 383);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(876, 233);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login information";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(UserNameText);
            panel1.Controls.Add(IsActiveText);
            panel1.Controls.Add(UserIdText);
            panel1.Controls.Add(ConfirmNewPassWordTextBox);
            panel1.Controls.Add(NewPassWordTextBox);
            panel1.Controls.Add(CurrentPassWordTextbox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(0, 22);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 149);
            panel1.TabIndex = 5;
            // 
            // UserNameText
            // 
            UserNameText.AutoSize = true;
            UserNameText.Location = new Point(166, 73);
            UserNameText.Margin = new Padding(4, 0, 4, 0);
            UserNameText.Name = "UserNameText";
            UserNameText.Size = new Size(44, 17);
            UserNameText.TabIndex = 29;
            UserNameText.Text = "????";
            // 
            // IsActiveText
            // 
            IsActiveText.AutoSize = true;
            IsActiveText.Location = new Point(166, 114);
            IsActiveText.Margin = new Padding(4, 0, 4, 0);
            IsActiveText.Name = "IsActiveText";
            IsActiveText.Size = new Size(44, 17);
            IsActiveText.TabIndex = 28;
            IsActiveText.Text = "????";
            // 
            // UserIdText
            // 
            UserIdText.AutoSize = true;
            UserIdText.Location = new Point(166, 17);
            UserIdText.Margin = new Padding(4, 0, 4, 0);
            UserIdText.Name = "UserIdText";
            UserIdText.Size = new Size(44, 17);
            UserIdText.TabIndex = 26;
            UserIdText.Text = "????";
            // 
            // ConfirmNewPassWordTextBox
            // 
            ConfirmNewPassWordTextBox.Location = new Point(666, 107);
            ConfirmNewPassWordTextBox.Margin = new Padding(4, 3, 4, 3);
            ConfirmNewPassWordTextBox.Name = "ConfirmNewPassWordTextBox";
            ConfirmNewPassWordTextBox.Size = new Size(188, 23);
            ConfirmNewPassWordTextBox.TabIndex = 25;
            // 
            // NewPassWordTextBox
            // 
            NewPassWordTextBox.Location = new Point(666, 66);
            NewPassWordTextBox.Margin = new Padding(4, 3, 4, 3);
            NewPassWordTextBox.Name = "NewPassWordTextBox";
            NewPassWordTextBox.Size = new Size(188, 23);
            NewPassWordTextBox.TabIndex = 24;
            // 
            // CurrentPassWordTextbox
            // 
            CurrentPassWordTextbox.Location = new Point(666, 17);
            CurrentPassWordTextbox.Margin = new Padding(4, 3, 4, 3);
            CurrentPassWordTextbox.Name = "CurrentPassWordTextbox";
            CurrentPassWordTextbox.Size = new Size(188, 23);
            CurrentPassWordTextbox.TabIndex = 23;
            CurrentPassWordTextbox.Validating += CurrentPassWordTextbox_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(462, 114);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(152, 17);
            label5.TabIndex = 22;
            label5.Text = "Confirm Password : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(462, 69);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 17);
            label3.TabIndex = 20;
            label3.Text = "New password : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(462, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 17);
            label1.TabIndex = 18;
            label1.Text = "Current Password : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 114);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(83, 17);
            label7.TabIndex = 17;
            label7.Text = "Is active : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 69);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(101, 17);
            label8.TabIndex = 16;
            label8.Text = "User name : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 17);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(75, 17);
            label9.TabIndex = 15;
            label9.Text = "User id : ";
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(792, 635);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(88, 27);
            button2.TabIndex = 9;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Savebutton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(678, 635);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 8;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // personCard1
            // 
            personCard1.BackColor = Color.Gray;
            personCard1.Location = new Point(4, 3);
            personCard1.Margin = new Padding(5, 3, 5, 3);
            personCard1.Name = "personCard1";
            personCard1.Size = new Size(876, 354);
            personCard1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ChangePasswordControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(personCard1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ChangePasswordControl";
            Size = new Size(890, 675);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

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
