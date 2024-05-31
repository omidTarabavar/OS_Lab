namespace LMSProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login = new Button();
            signup = new Button();
            SuspendLayout();
            // 
            // login
            // 
            login.Location = new Point(348, 168);
            login.Name = "login";
            login.Size = new Size(112, 34);
            login.TabIndex = 0;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // signup
            // 
            signup.Location = new Point(348, 273);
            signup.Name = "signup";
            signup.Size = new Size(112, 34);
            signup.TabIndex = 1;
            signup.Text = "Sign up";
            signup.UseVisualStyleBackColor = true;
            signup.Click += signup_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signup);
            Controls.Add(login);
            Name = "Form1";
            Text = "LMS";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button login;
        private Button signup;
    }
}
