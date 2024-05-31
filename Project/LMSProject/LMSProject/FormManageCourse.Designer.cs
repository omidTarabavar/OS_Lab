namespace LMSProject
{
    partial class FormManageCourse
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
            button1 = new Button();
            cId_mng = new TextBox();
            label3 = new Label();
            titleTB_mng = new TextBox();
            label1 = new Label();
            deleteCourse = new Button();
            listView1_mng = new ListView();
            label4 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(38, 342);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 13;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cId_mng
            // 
            cId_mng.Location = new Point(38, 82);
            cId_mng.Name = "cId_mng";
            cId_mng.ReadOnly = true;
            cId_mng.Size = new Size(263, 31);
            cId_mng.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 54);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 11;
            label3.Text = "Course Id";
            // 
            // titleTB_mng
            // 
            titleTB_mng.Location = new Point(38, 194);
            titleTB_mng.Name = "titleTB_mng";
            titleTB_mng.Size = new Size(263, 31);
            titleTB_mng.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 166);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 7;
            label1.Text = "Course Title";
            // 
            // deleteCourse
            // 
            deleteCourse.Location = new Point(164, 342);
            deleteCourse.Name = "deleteCourse";
            deleteCourse.Size = new Size(137, 34);
            deleteCourse.TabIndex = 14;
            deleteCourse.Text = "Delete_Course";
            deleteCourse.UseVisualStyleBackColor = true;
            deleteCourse.Click += deleteCourse_Click;
            // 
            // listView1_mng
            // 
            listView1_mng.Location = new Point(371, 82);
            listView1_mng.Name = "listView1_mng";
            listView1_mng.Size = new Size(402, 220);
            listView1_mng.TabIndex = 15;
            listView1_mng.UseCompatibleStateImageBehavior = false;
            listView1_mng.SelectedIndexChanged += listView1_mng_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 54);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 16;
            label4.Text = "Students";
            label4.Click += label4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(436, 342);
            button3.Name = "button3";
            button3.Size = new Size(267, 34);
            button3.TabIndex = 17;
            button3.Text = "Delete_Selected_Student";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FormManageCourse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(listView1_mng);
            Controls.Add(deleteCourse);
            Controls.Add(button1);
            Controls.Add(cId_mng);
            Controls.Add(label3);
            Controls.Add(titleTB_mng);
            Controls.Add(label1);
            Name = "FormManageCourse";
            Text = "FormManageCourse";
            Load += FormManageCourse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox cId_mng;
        private Label label3;
        private TextBox titleTB_mng;
        private Label label1;
        private Button deleteCourse;
        private ListView listView1_mng;
        private Label label4;
        private Button button3;
    }
}