using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Subject
    {
        private int _position;

        public Subject()
        { }

        public Subject(string lesson, string instructor, int position)
        {
            Lesson = lesson;
            Instructor = instructor;
            Position = position;
        }
        public string Lesson { get; set; }
        public string Instructor { get; set; }
        public int Position 
        {
            get
            {
                return _position;
            }
            set
            {
                if (value <= 0) throw new ArgumentException();
                _position = value;
            }
        }
    }
}
