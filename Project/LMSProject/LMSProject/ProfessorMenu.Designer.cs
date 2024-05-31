namespace LMSProject
{
    partial class ProfessorMenu
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
            addCourse = new Button();
            listView1 = new ListView();
            profNameLabel = new Label();
            PassTBox_prof = new TextBox();
            emailTbox_prof = new TextBox();
            nameTBox_prof = new TextBox();
            labelPass = new Label();
            labelEmail = new Label();
            labelName = new Label();
            textBox1 = new TextBox();
            labelUId = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // addCourse
            // 
            addCourse.Location = new Point(414, 358);
            addCourse.Name = "addCourse";
            addCourse.Size = new Size(112, 34);
            addCourse.TabIndex = 0;
            addCourse.Text = "AddCourse";
            addCourse.UseVisualStyleBackColor = true;
            addCourse.Click += addCourse_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(414, 92);
            listView1.Name = "listView1";
            listView1.Size = new Size(341, 246);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // profNameLabel
            // 
            profNameLabel.AutoSize = true;
            profNameLabel.Location = new Point(12, 19);
            profNameLabel.Name = "profNameLabel";
            profNameLabel.Size = new Size(85, 25);
            profNameLabel.TabIndex = 2;
            profNameLabel.Text = "Welcome";
            // 
            // PassTBox_prof
            // 
            PassTBox_prof.Location = new Point(12, 324);
            PassTBox_prof.Name = "PassTBox_prof";
            PassTBox_prof.Size = new Size(254, 31);
            PassTBox_prof.TabIndex = 19;
            // 
            // emailTbox_prof
            // 
            emailTbox_prof.Location = new Point(12, 242);
            emailTbox_prof.Name = "emailTbox_prof";
            emailTbox_prof.Size = new Size(254, 31);
            emailTbox_prof.TabIndex = 18;
            // 
            // nameTBox_prof
            // 
            nameTBox_prof.Location = new Point(12, 164);
            nameTBox_prof.Name = "nameTBox_prof";
            nameTBox_prof.Size = new Size(254, 31);
            nameTBox_prof.TabIndex = 17;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Location = new Point(12, 296);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(87, 25);
            labelPass.TabIndex = 16;
            labelPass.Text = "Password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(12, 214);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(54, 25);
            labelEmail.TabIndex = 15;
            labelEmail.Text = "Email";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 136);
            labelName.Name = "labelName";
            labelName.Size = new Size(59, 25);
            labelName.TabIndex = 14;
            labelName.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 92);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(254, 31);
            textBox1.TabIndex = 21;
            // 
            // labelUId
            // 
            labelUId.AutoSize = true;
            labelUId.Location = new Point(12, 64);
            labelUId.Name = "labelUId";
            labelUId.Size = new Size(70, 25);
            labelUId.TabIndex = 20;
            labelUId.Text = "User ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(414, 64);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 22;
            label1.Text = "Courses";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(62, 384);
            button1.Name = "button1";
            button1.Size = new Size(139, 34);
            button1.TabIndex = 24;
            button1.Text = "UpdateProfile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(610, 358);
            button2.Name = "button2";
            button2.Size = new Size(145, 34);
            button2.TabIndex = 25;
            button2.Text = "ManageCourse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ProfessorMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(labelUId);
            Controls.Add(PassTBox_prof);
            Controls.Add(emailTbox_prof);
            Controls.Add(nameTBox_prof);
            Controls.Add(labelPass);
            Controls.Add(labelEmail);
            Controls.Add(labelName);
            Controls.Add(profNameLabel);
            Controls.Add(listView1);
            Controls.Add(addCourse);
            Name = "ProfessorMenu";
            Text = "ProfessorMenu";
            Load += ProfessorMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addCourse;
        private ListView listView1;
        private Label profNameLabel;
        private TextBox PassTBox_prof;
        private TextBox emailTbox_prof;
        private TextBox nameTBox_prof;
        private Label labelPass;
        private Label labelEmail;
        private Label labelName;
        private TextBox textBox1;
        private Label labelUId;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}