using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Student_Info
{
    public partial class Form1 : Form
    {
        public abstract class Person
        {
            public string ID { get; set; }
            public string Name { get; set; }

            public abstract override string ToString();
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
            private List<Student> advisees = new List<Student>();

            public string Major { get; set; }

            public void AddAdvisee(Student student)
            {
                advisees.Add(student);
            }

            public List<Student> GetAdvisees()
            {
                return advisees;
            }

            public override string ToString()
            {
                return $"{ID} - {Name} ({Major})";
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
            string id = txtID.Text.Trim();
            string name = txtName.Text.Trim();
            string major = txtMajor.Text.Trim();
            string advisorID = txtAdvisor.Text.Trim();
            double gpa;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(major) || string.IsNullOrEmpty(advisorID) || !double.TryParse(txtGPA.Text, out gpa))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน และกรอก GPA เป็นตัวเลข", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student student = new Student { ID = id, Name = name, Major = major, GPA = gpa, AdvisorName = advisorID };
            students.Add(student);
            lstStudents.Items.Add(student.ToString());

            // ¤é¹ËÒÍÒ¨ÒÃÂì¨Ò¡ ID á·¹ª×èÍ
            var advisor = teachers.FirstOrDefault(t => t.ID == advisorID);
            if (advisor != null)
            {
                advisor.AddAdvisee(student);
            }
            else
            {
                MessageBox.Show("ไม่พบอาจารย์ที่ปรึกษา กรุณาตรวจสอบรหัส!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Teacher_Click(object sender, EventArgs e)
        {
            string id = txtTeacherID.Text.Trim();
            string name = txtTeacherName.Text.Trim();
            string major = txtTeacherMajor.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(major))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!teachers.Any(t => t.ID == id)) // µÃÇ¨ÊÍºÇèÒ ID ¹ÕéÁÕÍÂÙèáÅéÇËÃ×ÍäÁè
            {
                Teacher newTeacher = new Teacher { ID = id, Name = name, Major = major };
                teachers.Add(newTeacher);
                lstTeachers.Items.Add(newTeacher.ToString());
            }
            else
            {
                MessageBox.Show("อาจารย์คนนี้มีอยู่แล้ว!", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void lstTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTeachers.SelectedIndex >= 0)
            {
                string selectedText = lstTeachers.SelectedItem.ToString();
                string teacherID = selectedText.Split('-')[0].Trim(); // ´Ö§ ID ¨Ò¡ ListBox

                var selectedTeacher = teachers.FirstOrDefault(t => t.ID == teacherID);
                if (selectedTeacher != null)
                {
                    var advisees = selectedTeacher.GetAdvisees();
                    string adviseeList = advisees.Count > 0 ? string.Join("\n", advisees.Select(s => s.ToString())) : "ไม่มีนักศึกษาในที่ปรึกษา";
                    MessageBox.Show(adviseeList, $"นักศึกษาที่อยู่ในที่ปรึกษาของ {selectedTeacher.Name}");
                }
            }
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
