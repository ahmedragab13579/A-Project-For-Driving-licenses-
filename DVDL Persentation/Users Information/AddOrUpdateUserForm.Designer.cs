namespace DVDL_Persentation
{
    partial class AddOrUpdateUserForm
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
            components = new System.ComponentModel.Container();
            PagesControl = new TabControl();
            tabPage1 = new TabPage();
            Next = new Button();
            button1 = new Button();
            personCardWithFilter1 = new PersonCardWithFilter();
            tabPage2 = new TabPage();
            checkBox1 = new CheckBox();
            UserIdLabel = new Label();
            ConfirmPasswordTB = new TextBox();
            PasswordTB = new TextBox();
            UserNameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TheProcesLabel = new Label();
            Validating = new ErrorProvider(components);
            button3 = new Button();
            button4 = new Button();
            PagesControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Validating).BeginInit();
            SuspendLayout();
            // 
            // PagesControl
            // 
            PagesControl.Controls.Add(tabPage1);
            PagesControl.Controls.Add(tabPage2);
            PagesControl.Location = new Point(14, 90);
            PagesControl.Margin = new Padding(4, 3, 4, 3);
            PagesControl.Name = "PagesControl";
            PagesControl.SelectedIndex = 0;
            PagesControl.Size = new Size(950, 482);
            PagesControl.TabIndex = 0;
            PagesControl.SelectedIndexChanged += PagesControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gray;
            tabPage1.Controls.Add(Next);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(personCardWithFilter1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(942, 454);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Person information";
            // 
            // Next
            // 
            Next.Enabled = false;
            Next.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Next.Location = new Point(780, 361);
            Next.Margin = new Padding(4, 3, 4, 3);
            Next.Name = "Next";
            Next.Size = new Size(88, 27);
            Next.TabIndex = 2;
            Next.Text = "Next ->";
            Next.UseVisualStyleBackColor = true;
            Next.Visible = false;
            Next.Click += ChangePagebutton_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(818, 501);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 46);
            button1.TabIndex = 1;
            button1.Text = "Next ->";
            button1.UseVisualStyleBackColor = true;
            // 
            // personCardWithFilter1
            // 
            personCardWithFilter1.BackColor = Color.Gray;
            personCardWithFilter1.Location = new Point(9, 6);
            personCardWithFilter1.Margin = new Padding(5, 3, 5, 3);
            personCardWithFilter1.Name = "personCardWithFilter1";
            personCardWithFilter1.Size = new Size(894, 441);
            personCardWithFilter1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Gray;
            tabPage2.Controls.Add(checkBox1);
            tabPage2.Controls.Add(UserIdLabel);
            tabPage2.Controls.Add(ConfirmPasswordTB);
            tabPage2.Controls.Add(PasswordTB);
            tabPage2.Controls.Add(UserNameTextBox);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Login information";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(35, 375);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(87, 21);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Is active";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // UserIdLabel
            // 
            UserIdLabel.AutoSize = true;
            UserIdLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserIdLabel.Location = new Point(174, 44);
            UserIdLabel.Margin = new Padding(4, 0, 4, 0);
            UserIdLabel.Name = "UserIdLabel";
            UserIdLabel.Size = new Size(44, 17);
            UserIdLabel.TabIndex = 8;
            UserIdLabel.Text = "????";
            // 
            // ConfirmPasswordTB
            // 
            ConfirmPasswordTB.Location = new Point(196, 312);
            ConfirmPasswordTB.Margin = new Padding(4, 3, 4, 3);
            ConfirmPasswordTB.Name = "ConfirmPasswordTB";
            ConfirmPasswordTB.PasswordChar = '*';
            ConfirmPasswordTB.Size = new Size(176, 23);
            ConfirmPasswordTB.TabIndex = 7;
            ConfirmPasswordTB.Validating += PassWordtextBox_Validating;
            // 
            // PasswordTB
            // 
            PasswordTB.Location = new Point(196, 223);
            PasswordTB.Margin = new Padding(4, 3, 4, 3);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.PasswordChar = '*';
            PasswordTB.Size = new Size(176, 23);
            PasswordTB.TabIndex = 6;
            PasswordTB.Validating += PassWordtextBox_Validating;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(196, 134);
            UserNameTextBox.Margin = new Padding(4, 3, 4, 3);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(176, 23);
            UserNameTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 312);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 17);
            label4.TabIndex = 3;
            label4.Text = "Confirm password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 223);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 134);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 17);
            label2.TabIndex = 1;
            label2.Text = "User name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 0;
            label1.Text = "User id";
            // 
            // TheProcesLabel
            // 
            TheProcesLabel.AutoSize = true;
            TheProcesLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TheProcesLabel.ForeColor = Color.Red;
            TheProcesLabel.Location = new Point(378, 40);
            TheProcesLabel.Margin = new Padding(4, 0, 4, 0);
            TheProcesLabel.Name = "TheProcesLabel";
            TheProcesLabel.Size = new Size(191, 31);
            TheProcesLabel.TabIndex = 1;
            TheProcesLabel.Text = "Add new user";
            // 
            // Validating
            // 
            Validating.ContainerControl = this;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(707, 576);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(88, 27);
            button3.TabIndex = 3;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Cancelbutton_Click;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(840, 576);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(88, 27);
            button4.TabIndex = 4;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Savebutton_Click;
            // 
            // AddOrUpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(978, 609);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(TheProcesLabel);
            Controls.Add(PagesControl);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddOrUpdateUserForm";
            Text = "AddUserForm";
            Load += AddOrUpdateUserForm_Load;
            PagesControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Validating).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl PagesControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private PersonCardWithFilter personCardWithFilter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.TextBox ConfirmPasswordTB;
        private System.Windows.Forms.Label TheProcesLabel;
        private System.Windows.Forms.ErrorProvider Validating;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}