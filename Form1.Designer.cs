namespace Student_Info
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
            StudentInfo = new Label();
            TeacherInfo = new Label();
            ADDStudentInfo = new Button();
            ADDTeacherInfo = new Button();
            GPA = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtMajor = new TextBox();
            txtAdvisor = new TextBox();
            txtGPA = new TextBox();
            lstStudents = new ListBox();
            showGPA = new Button();
            lblTopStudent = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTeacherID = new TextBox();
            txtTeacherName = new TextBox();
            lstTeachers = new ListBox();
            txtTeacherMajor = new TextBox();
            SuspendLayout();
            // 
            // StudentInfo
            // 
            StudentInfo.AutoSize = true;
            StudentInfo.Font = new Font("Segoe UI", 15F);
            StudentInfo.Location = new Point(112, 19);
            StudentInfo.Name = "StudentInfo";
            StudentInfo.Size = new Size(94, 28);
            StudentInfo.TabIndex = 1;
            StudentInfo.Text = "ชื่อ - สาขา";
            StudentInfo.Click += Student_Click;
            // 
            // TeacherInfo
            // 
            TeacherInfo.AutoSize = true;
            TeacherInfo.Font = new Font("Segoe UI", 15F);
            TeacherInfo.Location = new Point(478, 19);
            TeacherInfo.Name = "TeacherInfo";
            TeacherInfo.Size = new Size(135, 28);
            TeacherInfo.TabIndex = 2;
            TeacherInfo.Text = "อาจารย์ที่ปรึกษา";
            TeacherInfo.Click += Teacher_Click;
            // 
            // ADDStudentInfo
            // 
            ADDStudentInfo.Font = new Font("Segoe UI", 15F);
            ADDStudentInfo.Location = new Point(97, 259);
            ADDStudentInfo.Name = "ADDStudentInfo";
            ADDStudentInfo.Size = new Size(132, 42);
            ADDStudentInfo.TabIndex = 3;
            ADDStudentInfo.Text = "เพิ่มนักศึกษา";
            ADDStudentInfo.UseVisualStyleBackColor = true;
            ADDStudentInfo.Click += StudentInfo_Click;
            // 
            // ADDTeacherInfo
            // 
            ADDTeacherInfo.Font = new Font("Segoe UI", 15F);
            ADDTeacherInfo.Location = new Point(520, 259);
            ADDTeacherInfo.Name = "ADDTeacherInfo";
            ADDTeacherInfo.Size = new Size(110, 42);
            ADDTeacherInfo.TabIndex = 4;
            ADDTeacherInfo.Text = "เพิ่มอาจารย์";
            ADDTeacherInfo.UseVisualStyleBackColor = true;
            ADDTeacherInfo.Click += ADDTeacherInfo_Click;
            // 
            // GPA
            // 
            GPA.AutoSize = true;
            GPA.Font = new Font("Segoe UI", 15F);
            GPA.Location = new Point(332, 288);
            GPA.Name = "GPA";
            GPA.Size = new Size(91, 28);
            GPA.TabIndex = 5;
            GPA.Text = "เกรดสูงสุด";
            // 
            // txtID
            // 
            txtID.Location = new Point(112, 307);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 336);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 7;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(112, 365);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(100, 23);
            txtMajor.TabIndex = 8;
            // 
            // txtAdvisor
            // 
            txtAdvisor.Location = new Point(112, 394);
            txtAdvisor.Name = "txtAdvisor";
            txtAdvisor.Size = new Size(100, 23);
            txtAdvisor.TabIndex = 9;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(112, 423);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(100, 23);
            txtGPA.TabIndex = 10;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 15;
            lstStudents.Location = new Point(64, 50);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(197, 199);
            lstStudents.TabIndex = 11;
            lstStudents.SelectedIndexChanged += lstStudents_SelectedIndexChanged;
            // 
            // showGPA
            // 
            showGPA.Location = new Point(332, 364);
            showGPA.Name = "showGPA";
            showGPA.Size = new Size(75, 23);
            showGPA.TabIndex = 12;
            showGPA.Text = "แสดงเกรด";
            showGPA.UseVisualStyleBackColor = true;
            showGPA.Click += showGPA_Click;
            // 
            // lblTopStudent
            // 
            lblTopStudent.AutoSize = true;
            lblTopStudent.Location = new Point(332, 327);
            lblTopStudent.Name = "lblTopStudent";
            lblTopStudent.Size = new Size(0, 15);
            lblTopStudent.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 310);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 14;
            label1.Text = "ใส่ ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 339);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 15;
            label2.Text = "ใส่ ชื่อ :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 372);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 16;
            label3.Text = "ใส่ สาขา :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 397);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 17;
            label4.Text = "ใส่ อาจารย์ที่ปรึกษา :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 426);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 18;
            label5.Text = "ใส่ GPA :";
            // 
            // txtTeacherID
            // 
            txtTeacherID.Location = new Point(520, 310);
            txtTeacherID.Name = "txtTeacherID";
            txtTeacherID.Size = new Size(100, 23);
            txtTeacherID.TabIndex = 19;
            // 
            // txtTeacherName
            // 
            txtTeacherName.Location = new Point(520, 339);
            txtTeacherName.Name = "txtTeacherName";
            txtTeacherName.Size = new Size(100, 23);
            txtTeacherName.TabIndex = 20;
            // 
            // lstTeachers
            // 
            lstTeachers.FormattingEnabled = true;
            lstTeachers.ItemHeight = 15;
            lstTeachers.Location = new Point(457, 50);
            lstTeachers.Name = "lstTeachers";
            lstTeachers.Size = new Size(213, 199);
            lstTeachers.TabIndex = 21;
            lstTeachers.SelectedIndexChanged += lstTeachers_SelectedIndexChanged;
            // 
            // txtTeacherMajor
            // 
            txtTeacherMajor.Location = new Point(520, 369);
            txtTeacherMajor.Name = "txtTeacherMajor";
            txtTeacherMajor.Size = new Size(100, 23);
            txtTeacherMajor.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTeacherMajor);
            Controls.Add(lstTeachers);
            Controls.Add(txtTeacherName);
            Controls.Add(txtTeacherID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTopStudent);
            Controls.Add(showGPA);
            Controls.Add(lstStudents);
            Controls.Add(txtGPA);
            Controls.Add(txtAdvisor);
            Controls.Add(txtMajor);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(GPA);
            Controls.Add(ADDTeacherInfo);
            Controls.Add(ADDStudentInfo);
            Controls.Add(TeacherInfo);
            Controls.Add(StudentInfo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentInfo;
        private Label TeacherInfo;
        private Button ADDStudentInfo;
        private Button ADDTeacherInfo;
        private Label GPA;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtMajor;
        private TextBox txtAdvisor;
        private TextBox txtGPA;
        private ListBox lstStudents;
        private Button showGPA;
        private Label lblTopStudent;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTeacherID;
        private TextBox txtTeacherName;
        private ListBox lstTeachers;
        private TextBox txtTeacherMajor;
    }
}
