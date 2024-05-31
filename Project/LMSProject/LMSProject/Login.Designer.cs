namespace LMSProject
{
    partial class Login
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
            login_login = new Button();
            label2 = new Label();
            label3 = new Label();
            emailTbox_login = new TextBox();
            PassTBox_login = new TextBox();
            SuspendLayout();
            // 
            // login_login
            // 
            login_login.Location = new Point(308, 329);
            login_login.Name = "login_login";
            login_login.Size = new Size(112, 34);
            login_login.TabIndex = 0;
            login_login.Text = "Login";
            login_login.UseVisualStyleBackColor = true;
            login_login.Click += login_login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 87);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 212);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // emailTbox_login
            // 
            emailTbox_login.Location = new Point(242, 115);
            emailTbox_login.Name = "emailTbox_login";
            emailTbox_login.Size = new Size(254, 31);
            emailTbox_login.TabIndex = 5;
            // 
            // PassTBox_login
            // 
            PassTBox_login.Location = new Point(242, 240);
            PassTBox_login.Name = "PassTBox_login";
            PassTBox_login.Size = new Size(254, 31);
            PassTBox_login.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PassTBox_login);
            Controls.Add(emailTbox_login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(login_login);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_login;
        private Label label2;
        private Label label3;
        private TextBox emailTbox_login;
        private TextBox PassTBox_login;
    }
}