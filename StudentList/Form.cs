using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using StudentList.Model;
using StudentList.Model.Enums;
using Newtonsoft.Json;
using System.IO;

namespace StudentList
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private List<Student> _students = new List<Student>();

        private Student _currentStudent;


        public MainForm()
        {
            InitializeComponent();

            FacultyComboBox.DataSource = Enum.GetValues(typeof(Faculties));

            FormOfEducationComboBox.DataSource = Enum.GetValues(typeof(FormOfEducation));

            var file = File.ReadAllText(@"D:\text.txt");

            _students = JsonConvert.DeserializeObject<List<Student>>(file);

            for(int i = 0; i <= _students.Count - 1; i++)
            {
                StudentsListBox.Items.Add(FormattedText(_students[i]));
            }
           // _students = (List<Student>)readedProduct;
        }

        private string FormattedText(Student student)
        {
            return $"{student.Name} " + $": {student.Group}";
        }

        private void ClearStudentInfo()
        {
            StudentsListBox.Items.Clear();
            NameTextBox.Clear();
            GroupTextBox.Clear();
            IdLabel.Text = "Record book number: ";
        }

        private void UpdateStudentInfo(Student student)
        {
            int indexSelectedStudent = StudentsListBox.SelectedIndex;

            if (indexSelectedStudent == -1) return;

            StudentsListBox.Items[indexSelectedStudent] = FormattedText(student);
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedIndex == -1) return;

            try
            {
                _currentStudent.Name = NameTextBox.Text;
                UpdateStudentInfo(_currentStudent);
            }
            catch
            {
                NameTextBox.BackColor = Color.LightPink;
                return;
            }

            NameTextBox.BackColor = Color.White;
        }

        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            _currentStudent = new Student("Student Name", "Group", "Faculty", "FormOfEducation");
            _students.Add(_currentStudent);
            StudentsListBox.Items.Add(FormattedText(_currentStudent));
        }

        private void DeletePictureBox_Click(object sender, EventArgs e)
        {
            int indexSelectedStudent = StudentsListBox.SelectedIndex;

            if (indexSelectedStudent == -1) return;

            _students.RemoveAt(indexSelectedStudent);

            ClearStudentInfo();

            foreach (var student in _students)
            {
                StudentsListBox.Items.Add(FormattedText(student));
                StudentsListBox.SelectedIndex = 0;
            }
        }

        private void StudentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedItem == null) return;

            int indexSelectedStudent = StudentsListBox.SelectedIndex;
            _currentStudent = _students[indexSelectedStudent];
            IdLabel.Text = "Record book number: " + _currentStudent.Id.ToString();
            NameTextBox.Text = _currentStudent.Name.ToString();
            GroupTextBox.Text = _currentStudent.Group.ToString();
            FacultyComboBox.Text = _currentStudent.Faculty.ToString();
            FormOfEducationComboBox.Text = _currentStudent.EducationForm.ToString();
        }

        private void GroupTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedIndex == -1) return;

            try
            {
                _currentStudent.Group = GroupTextBox.Text;
                UpdateStudentInfo(_currentStudent);
            }
            catch
            {
                GroupTextBox.BackColor = Color.LightPink;
                return;
            }

            GroupTextBox.BackColor = Color.White;
        }

        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedIndex == -1) return;

            try
            {
                _currentStudent.Faculty = FacultyComboBox.Text;
            }
            catch
            {
                FacultyComboBox.BackColor = Color.LightPink;
                return;
            }

            FacultyComboBox.BackColor = Color.White;
        }

        private void FormOfEducationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedIndex == -1) return;

            try
            {
                _currentStudent.EducationForm = FormOfEducationComboBox.Text;
            }
            catch
            {
                FormOfEducationComboBox.BackColor = Color.LightPink;
                return;
            }

            FormOfEducationComboBox.BackColor = Color.White;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var jsonObject = JsonConvert.SerializeObject(_students);
            File.WriteAllText(@"D:\text.txt", jsonObject);

        }
    }
}
