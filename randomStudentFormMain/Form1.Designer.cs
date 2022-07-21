namespace randomStudentFormMain
{
    partial class Form1
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
            this.addStudent = new System.Windows.Forms.Button();
            this.loadClass = new System.Windows.Forms.Button();
            this.saveClass = new System.Windows.Forms.Button();
            this.pickStudent = new System.Windows.Forms.Button();
            this.clearStudents = new System.Windows.Forms.Button();
            this.resetStudents = new System.Windows.Forms.Button();
            this.studentsBox = new System.Windows.Forms.ListBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.addStudentsBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(189, 72);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(75, 23);
            this.addStudent.TabIndex = 0;
            this.addStudent.Text = "addStudent";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // loadClass
            // 
            this.loadClass.Location = new System.Drawing.Point(189, 101);
            this.loadClass.Name = "loadClass";
            this.loadClass.Size = new System.Drawing.Size(75, 23);
            this.loadClass.TabIndex = 1;
            this.loadClass.Text = "loadClass";
            this.loadClass.UseVisualStyleBackColor = true;
            this.loadClass.Click += new System.EventHandler(this.loadClass_Click);
            // 
            // saveClass
            // 
            this.saveClass.Location = new System.Drawing.Point(189, 130);
            this.saveClass.Name = "saveClass";
            this.saveClass.Size = new System.Drawing.Size(75, 23);
            this.saveClass.TabIndex = 2;
            this.saveClass.Text = "saveClass";
            this.saveClass.UseVisualStyleBackColor = true;
            this.saveClass.Click += new System.EventHandler(this.saveClass_Click);
            // 
            // pickStudent
            // 
            this.pickStudent.Location = new System.Drawing.Point(189, 159);
            this.pickStudent.Name = "pickStudent";
            this.pickStudent.Size = new System.Drawing.Size(75, 23);
            this.pickStudent.TabIndex = 3;
            this.pickStudent.Text = "pickStudent";
            this.pickStudent.UseVisualStyleBackColor = true;
            this.pickStudent.Click += new System.EventHandler(this.pickStudent_Click);
            // 
            // clearStudents
            // 
            this.clearStudents.Location = new System.Drawing.Point(189, 188);
            this.clearStudents.Name = "clearStudents";
            this.clearStudents.Size = new System.Drawing.Size(75, 23);
            this.clearStudents.TabIndex = 4;
            this.clearStudents.Text = "clear";
            this.clearStudents.UseVisualStyleBackColor = true;
            this.clearStudents.Click += new System.EventHandler(this.clearStudents_Click);
            // 
            // resetStudents
            // 
            this.resetStudents.Location = new System.Drawing.Point(189, 217);
            this.resetStudents.Name = "resetStudents";
            this.resetStudents.Size = new System.Drawing.Size(75, 23);
            this.resetStudents.TabIndex = 5;
            this.resetStudents.Text = "reset";
            this.resetStudents.UseVisualStyleBackColor = true;
            this.resetStudents.Click += new System.EventHandler(this.resetStudents_Click);
            // 
            // studentsBox
            // 
            this.studentsBox.FormattingEnabled = true;
            this.studentsBox.Location = new System.Drawing.Point(311, 72);
            this.studentsBox.Name = "studentsBox";
            this.studentsBox.Size = new System.Drawing.Size(120, 108);
            this.studentsBox.TabIndex = 6;
            this.studentsBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.studentsBox_MouseDoubleClick);
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(308, 253);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(63, 13);
            this.resultsLabel.TabIndex = 7;
            this.resultsLabel.Text = "resultsLabel";
            // 
            // addStudentsBox
            // 
            this.addStudentsBox.Location = new System.Drawing.Point(421, 246);
            this.addStudentsBox.Name = "addStudentsBox";
            this.addStudentsBox.Size = new System.Drawing.Size(100, 20);
            this.addStudentsBox.TabIndex = 8;
            this.addStudentsBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addStudentsBox_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addStudentsBox);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.studentsBox);
            this.Controls.Add(this.resetStudents);
            this.Controls.Add(this.clearStudents);
            this.Controls.Add(this.pickStudent);
            this.Controls.Add(this.saveClass);
            this.Controls.Add(this.loadClass);
            this.Controls.Add(this.addStudent);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button loadClass;
        private System.Windows.Forms.Button saveClass;
        private System.Windows.Forms.Button pickStudent;
        private System.Windows.Forms.Button clearStudents;
        private System.Windows.Forms.Button resetStudents;
        private System.Windows.Forms.ListBox studentsBox;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.TextBox addStudentsBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

