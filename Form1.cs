using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Student_Info
{
    public partial class Form1 : Form
    {
        public class Person
        {
            public string ID { get; set; }
            public string Name { get; set; }
        }
        public class Student : Person
        {
            public string Major { get; set; }
            public string AdvisorName { get; set; }
            public double GPA { get; set; }

            public override string ToString()
            {
                return $"{ID} - {Name} ({Major}) - GPA: {GPA}, Advisor: {AdvisorName}";
            }
        }

        public class Teacher : Person
        {
            public override string ToString()
            {
                return $"{ID} - {Name}";
            }

        }

        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Student_Click(object sender, EventArgs e)
        {

        }

        private void Teacher_Click(object sender, EventArgs e)
        {

        }

        private void StudentInfo_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            string name = txtName.Text.Trim();
            string major = txtMajor.Text.Trim();
            string advisorName = txtAdvisor.Text.Trim();
            double gpa;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(major) || string.IsNullOrEmpty(advisorName) || !double.TryParse(txtGPA.Text, out gpa))
            {
                MessageBox.Show("????????????????????????? ??????? GPA ??????????", "??????????", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student student = new Student { ID = id, Name = name, Major = major, GPA = gpa, AdvisorName = advisorName };
            students.Add(student);
            lstStudents.Items.Add(student.ToString());


        }
        private void showGPA_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("??????????????????????", "?????????", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var topStudent = students.OrderByDescending(s => s.GPA).First();
            lblTopStudent.Text = $"{topStudent.Name} ({topStudent.GPA})";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ADDTeacherInfo_Click(object sender, EventArgs e)
        {
            string id = txtTeacherID.Text.Trim();
            string name = txtTeacherName.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("????????????????????????????????", "??????????", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Teacher newTeacher = new Teacher { ID = id, Name = name };
            teachers.Add(newTeacher);

            // ????????????????????????????????????
            MessageBox.Show($"????????????: {newTeacher.ToString()}", "Debug");

            // ?????? ListBox
            lstTeachers.Items.Add(newTeacher.ToString());
        }
    }
}
