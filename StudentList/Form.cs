using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using StudentList.Model;
using StudentList.Model.Enums;

namespace StudentList
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        /// <summary>
        /// Коллекция студентов.
        /// </summary>
        private List<Student> _students = new List<Student>();

        /// <summary>
        /// Выбранный студент.
        /// </summary>
        private Student _currentStudent;

        /// <summary>
        /// Цвет ошибки.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Цвет окна без ошибок.
        /// </summary>
        private readonly Color _normalColor = Color.White;

        public MainForm()
        {
            InitializeComponent();

            FacultyComboBox.DataSource = Enum.GetValues(typeof(Faculties));

            FormOfEducationComboBox.DataSource = Enum.GetValues(typeof(FormOfEducation));

            try
            {
                _students = Serializer.LoadData();
                for (int i = 0; i <= _students.Count - 1; i++)
                {
                    StudentsListBox.Items.Add(FormattedText(_students[i]));
                }
            }
            catch
            {
                Serializer.CreateFile();
                _students = new List<Student>();
            }
        }

        /// <summary>
        /// Возвращает форматированный текст для вывода в List Box. 
        /// </summary>
        /// <param name="student"> Студент для форматирования.</param>
        /// /// <returns>Возвращает форматированный текст.</returns>
        private string FormattedText(Student student)
        {
            return $"{student.Name} " + $": {student.Group}";
        }

        /// <summary>
        ///Очищает информацию о студенте.
        /// </summary>
        private void ClearStudentInfo()
        {
            StudentsListBox.Items.Clear();
            NameTextBox.Clear();
            GroupTextBox.Clear();
            IdLabel.Text = "Record book number: ";
        }

        /// <summary>
        /// Обновляет информацию о студенте.
        /// </summary>
        /// <param name="student">Студент для обновления информации.</param>
        private void UpdateStudentInfo(Student student)
        {
            int indexSelectedStudent = StudentsListBox.SelectedIndex;

            if (indexSelectedStudent == -1) return;

            StudentsListBox.Items[indexSelectedStudent] = FormattedText(student);
        }

        /// <summary>
        /// Сортировка списка студентов.
        /// </summary>
        private void StudentSort()
        {
            _students.Sort(delegate (Student student1, Student student2)
            { return student1.Name.CompareTo(student2.Name); });
            StudentsListBox.Items.Clear();
            for (int i = 0; i <= _students.Count - 1; i++)
            {
                StudentsListBox.Items.Add(FormattedText(_students[i]));
            }
            StudentsListBox.SelectedIndex = _students.IndexOf(_currentStudent);

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedIndex == -1) return;

            try
            {
                _currentStudent.Name = NameTextBox.Text;
                UpdateStudentInfo(_currentStudent);
                StudentSort();
            }
            catch
            {
                NameTextBox.BackColor = _errorColor;
                return;
            }

            NameTextBox.BackColor = _normalColor;
        }

        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            _currentStudent = new Student("Student Name", "Group", Faculties.Gryffindor, FormOfEducation.FullTimeEducation);
            _students.Add(_currentStudent);
            StudentsListBox.Items.Add(FormattedText(_currentStudent));
        }

        private void DeletePictureBox_Click(object sender, EventArgs e)
        {
            int indexSelectedStudent = StudentsListBox.SelectedIndex;

            if (indexSelectedStudent == -1) return;

            _students.RemoveAt(indexSelectedStudent);

            ClearStudentInfo();

            for (int i = 0; i <= _students.Count - 1; i++)
            {
                StudentsListBox.Items.Add(FormattedText(_students[i]));
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
                GroupTextBox.BackColor = _errorColor;
                return;
            }

            GroupTextBox.BackColor = _normalColor;
        }

        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedIndex == -1) return;

            try
            {
                _currentStudent.Faculty = (Faculties)FacultyComboBox.SelectedItem;
            }
            catch
            {
                FacultyComboBox.BackColor = _errorColor;
                return;
            }

            FacultyComboBox.BackColor = _normalColor;
        }

        private void FormOfEducationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedIndex == -1) return;

            try
            {
                _currentStudent.EducationForm = (FormOfEducation)FormOfEducationComboBox.SelectedItem;
            }
            catch
            {
                FormOfEducationComboBox.BackColor = _errorColor;
                return;
            }

            FormOfEducationComboBox.BackColor = _normalColor;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Serializer.WriteData(_students);

        }
    }
}
