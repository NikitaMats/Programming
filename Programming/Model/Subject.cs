using System;

namespace Programming.Model
{
    public class Subject
    {
        private int _position;

        public Subject()
        { }

        public Subject(string name, string lecturer, int position)
        {
            Name = name;
            Lecturer = lecturer;
            Position = position;
        }

        public string Name { get; set; }

        public string Lecturer { get; set; }

        public int Position 
        {
            get
            {
                return _position;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _position = value;
            }
        }
    }
}
