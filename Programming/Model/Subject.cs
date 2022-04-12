using System;

namespace Programming.Model
{
    public class Subject
    {
        private int _position;
        private string _lecturer;
        private string _name;

        public Subject()
        { }

        public Subject(string name, string lecturer, int position)
        {
            Name = name;
            Lecturer = lecturer;
            Position = position;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }

        public string Lecturer
        {
            get
            {
                return _lecturer;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Lecturer));
                _lecturer = value;
            }
        }

        public int Position 
        {
            get
            {
                return _position;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Position));
                _position = value;
            }
        }
    }
}
