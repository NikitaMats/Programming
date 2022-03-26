using System;

namespace Programming.Model
{
    public class Song
    {
        private int _id;

        private int _durationMinutes;

        public Song()
        { }

        public Song(int id, string name, string author, int duretionminutes)
        {
            Id = id;
            Name = name;
            Author = author;
            DurationMinutes = duretionminutes;
        }

        public int Id 
        {
            get
            {
                return _id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _id = value;
            }
        }

        public string Name { get; set; }

        public string Author { get; set; }

        public int DurationMinutes 
        {
            get
            {
                return _durationMinutes;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _durationMinutes = value;
            }
        }
    }
}
