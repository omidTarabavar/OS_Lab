namespace LMSProject
{
    partial class AddCourseSTD
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
            profTB_addCs = new TextBox();
            label2 = new Label();
            titleTB_addCs = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(340, 312);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // profTB_addCs
            // 
            profTB_addCs.Location = new Point(322, 241);
            profTB_addCs.Name = "profTB_addCs";
            profTB_addCs.Size = new Size(150, 31);
            profTB_addCs.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 213);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 9;
            label2.Text = "Professor";
            // 
            // titleTB_addCs
            // 
            titleTB_addCs.Location = new Point(322, 149);
            titleTB_addCs.Name = "titleTB_addCs";
            titleTB_addCs.Size = new Size(150, 31);
            titleTB_addCs.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 121);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 7;
            label1.Text = "Course Title";
            // 
            // AddCourseSTD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(profTB_addCs);
            Controls.Add(label2);
            Controls.Add(titleTB_addCs);
            Controls.Add(label1);
            Name = "AddCourseSTD";
            Text = "AddCourseSTD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox profTB_addCs;
        private Label label2;
        private TextBox titleTB_addCs;
        private Label label1;
    }
}