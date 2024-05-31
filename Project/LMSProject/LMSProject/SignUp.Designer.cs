namespace LMSProject
{
    partial class SignUp
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
            PassTBox_signUp = new TextBox();
            emailTbox_signUp = new TextBox();
            nameTBox_signUp = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            signUp_signUp = new Button();
            profRadioBut = new RadioButton();
            stdRadioBut = new RadioButton();
            SuspendLayout();
            // 
            // PassTBox_signUp
            // 
            PassTBox_signUp.Location = new Point(273, 237);
            PassTBox_signUp.Name = "PassTBox_signUp";
            PassTBox_signUp.Size = new Size(254, 31);
            PassTBox_signUp.TabIndex = 13;
            // 
            // emailTbox_signUp
            // 
            emailTbox_signUp.Location = new Point(273, 155);
            emailTbox_signUp.Name = "emailTbox_signUp";
            emailTbox_signUp.Size = new Size(254, 31);
            emailTbox_signUp.TabIndex = 12;
            // 
            // nameTBox_signUp
            // 
            nameTBox_signUp.Location = new Point(273, 77);
            nameTBox_signUp.Name = "nameTBox_signUp";
            nameTBox_signUp.Size = new Size(254, 31);
            nameTBox_signUp.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 209);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 127);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 9;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 49);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // signUp_signUp
            // 
            signUp_signUp.Location = new Point(345, 367);
            signUp_signUp.Name = "signUp_signUp";
            signUp_signUp.Size = new Size(112, 34);
            signUp_signUp.TabIndex = 7;
            signUp_signUp.Text = "Sign Up";
            signUp_signUp.UseVisualStyleBackColor = true;
            signUp_signUp.Click += signUp_signUp_Click;
            // 
            // profRadioBut
            // 
            profRadioBut.AutoSize = true;
            profRadioBut.Location = new Point(273, 299);
            profRadioBut.Name = "profRadioBut";
            profRadioBut.Size = new Size(112, 29);
            profRadioBut.TabIndex = 14;
            profRadioBut.TabStop = true;
            profRadioBut.Text = "Professor";
            profRadioBut.UseVisualStyleBackColor = true;
            // 
            // stdRadioBut
            // 
            stdRadioBut.AutoSize = true;
            stdRadioBut.Location = new Point(429, 299);
            stdRadioBut.Name = "stdRadioBut";
            stdRadioBut.Size = new Size(98, 29);
            stdRadioBut.TabIndex = 15;
            stdRadioBut.TabStop = true;
            stdRadioBut.Text = "Student";
            stdRadioBut.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stdRadioBut);
            Controls.Add(profRadioBut);
            Controls.Add(PassTBox_signUp);
            Controls.Add(emailTbox_signUp);
            Controls.Add(nameTBox_signUp);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(signUp_signUp);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PassTBox_signUp;
        private TextBox emailTbox_signUp;
        private TextBox nameTBox_signUp;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button signUp_signUp;
        private RadioButton profRadioBut;
        private RadioButton stdRadioBut;
    }
}