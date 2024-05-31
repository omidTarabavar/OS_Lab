namespace LMSProject
{
    partial class FormAdd
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
            label1 = new Label();
            titleTB = new TextBox();
            label2 = new Label();
            profTB = new TextBox();
            label3 = new Label();
            profIdTB = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 57);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "Course Title";
            // 
            // titleTB
            // 
            titleTB.Location = new Point(311, 85);
            titleTB.Name = "titleTB";
            titleTB.Size = new Size(150, 31);
            titleTB.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 149);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 2;
            label2.Text = "Professor";
            // 
            // profTB
            // 
            profTB.Location = new Point(311, 177);
            profTB.Name = "profTB";
            profTB.Size = new Size(150, 31);
            profTB.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(311, 246);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 4;
            label3.Text = "Professor Id";
            // 
            // profIdTB
            // 
            profIdTB.Location = new Point(311, 274);
            profIdTB.Name = "profIdTB";
            profIdTB.Size = new Size(150, 31);
            profIdTB.TabIndex = 5;
            profIdTB.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(330, 345);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addCourse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(profIdTB);
            Controls.Add(label3);
            Controls.Add(profTB);
            Controls.Add(label2);
            Controls.Add(titleTB);
            Controls.Add(label1);
            Name = "addCourse";
            Text = "addCourse";
            Load += addCourse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titleTB;
        private Label label2;
        private TextBox profTB;
        private Label label3;
        private TextBox profIdTB;
        private Button button1;
    }
}