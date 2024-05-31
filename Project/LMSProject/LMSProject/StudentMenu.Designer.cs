namespace LMSProject
{
    partial class StudentMenu
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
            updateProf_std = new Button();
            label1 = new Label();
            uIdTB_std = new TextBox();
            labelUId = new Label();
            PassTBox_std = new TextBox();
            emailTbox_std = new TextBox();
            nameTBox_std = new TextBox();
            labelPass = new Label();
            labelEmail = new Label();
            labelName = new Label();
            stdNameLabel = new Label();
            listView1 = new ListView();
            addCourse = new Button();
            SuspendLayout();
            // 
            // updateProf_std
            // 
            updateProf_std.Location = new Point(79, 391);
            updateProf_std.Name = "updateProf_std";
            updateProf_std.Size = new Size(139, 34);
            updateProf_std.TabIndex = 37;
            updateProf_std.Text = "UpdateProfile";
            updateProf_std.UseVisualStyleBackColor = true;
            updateProf_std.Click += updateProf_std_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(431, 71);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 36;
            label1.Text = "Courses";
            // 
            // uIdTB_std
            // 
            uIdTB_std.Location = new Point(29, 99);
            uIdTB_std.Name = "uIdTB_std";
            uIdTB_std.ReadOnly = true;
            uIdTB_std.Size = new Size(254, 31);
            uIdTB_std.TabIndex = 35;
            // 
            // labelUId
            // 
            labelUId.AutoSize = true;
            labelUId.Location = new Point(29, 71);
            labelUId.Name = "labelUId";
            labelUId.Size = new Size(70, 25);
            labelUId.TabIndex = 34;
            labelUId.Text = "User ID";
            // 
            // PassTBox_std
            // 
            PassTBox_std.Location = new Point(29, 331);
            PassTBox_std.Name = "PassTBox_std";
            PassTBox_std.Size = new Size(254, 31);
            PassTBox_std.TabIndex = 33;
            // 
            // emailTbox_std
            // 
            emailTbox_std.Location = new Point(29, 249);
            emailTbox_std.Name = "emailTbox_std";
            emailTbox_std.Size = new Size(254, 31);
            emailTbox_std.TabIndex = 32;
            // 
            // nameTBox_std
            // 
            nameTBox_std.Location = new Point(29, 171);
            nameTBox_std.Name = "nameTBox_std";
            nameTBox_std.Size = new Size(254, 31);
            nameTBox_std.TabIndex = 31;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Location = new Point(29, 303);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(87, 25);
            labelPass.TabIndex = 30;
            labelPass.Text = "Password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(29, 221);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(54, 25);
            labelEmail.TabIndex = 29;
            labelEmail.Text = "Email";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(29, 143);
            labelName.Name = "labelName";
            labelName.Size = new Size(59, 25);
            labelName.TabIndex = 28;
            labelName.Text = "Name";
            // 
            // stdNameLabel
            // 
            stdNameLabel.AutoSize = true;
            stdNameLabel.Location = new Point(29, 26);
            stdNameLabel.Name = "stdNameLabel";
            stdNameLabel.Size = new Size(85, 25);
            stdNameLabel.TabIndex = 27;
            stdNameLabel.Text = "Welcome";
            // 
            // listView1
            // 
            listView1.Location = new Point(431, 99);
            listView1.Name = "listView1";
            listView1.Size = new Size(341, 246);
            listView1.TabIndex = 26;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // addCourse
            // 
            addCourse.Location = new Point(431, 365);
            addCourse.Name = "addCourse";
            addCourse.Size = new Size(112, 34);
            addCourse.TabIndex = 25;
            addCourse.Text = "AddCourse";
            addCourse.UseVisualStyleBackColor = true;
            addCourse.Click += addCourse_Click;
            // 
            // StudentMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updateProf_std);
            Controls.Add(label1);
            Controls.Add(uIdTB_std);
            Controls.Add(labelUId);
            Controls.Add(PassTBox_std);
            Controls.Add(emailTbox_std);
            Controls.Add(nameTBox_std);
            Controls.Add(labelPass);
            Controls.Add(labelEmail);
            Controls.Add(labelName);
            Controls.Add(stdNameLabel);
            Controls.Add(listView1);
            Controls.Add(addCourse);
            Name = "StudentMenu";
            Text = "StudentMenu";
            Load += StudentMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateProf_std;
        private Label label1;
        private TextBox uIdTB_std;
        private Label labelUId;
        private TextBox PassTBox_std;
        private TextBox emailTbox_std;
        private TextBox nameTBox_std;
        private Label labelPass;
        private Label labelEmail;
        private Label labelName;
        private Label stdNameLabel;
        private ListView listView1;
        private Button addCourse;
    }
}