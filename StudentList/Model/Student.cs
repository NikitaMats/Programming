using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentList.Model.Enums;

namespace StudentList.Model
{
    internal class Student
    {
        private int _id;
        
        private string _name;
        
        private string _group;
        
        private static int _allStudentCount;

        public Student()
        {
            _allStudentCount++;
            _id = _allStudentCount;
        }
        
        public int Id { get; }
        
        public string Faculty { get; set; }
        
        public string EducationForm { get; set; }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertCountSymbolsInRange(nameof(Name), 0, 200, value);
                _name = value;
            }
        }

        public string Group
        {
            get
            {
                return _group;
            }
            set
            {
                Validator.AssertCountSymbolsInRange(nameof(Group), 0, 10, value);
                _group = value;
            }
        }

        public Student(string name, string group,string faculty, string educationForm)
        {
            Name = name;
            Group = group;
            Faculty = faculty;
            EducationForm = educationForm;
            _allStudentCount++;
            Id = _allStudentCount;
        }
    }
}
