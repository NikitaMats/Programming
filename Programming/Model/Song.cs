using System;

namespace Programming.Model
{
    public class Song
    {
        private int _id;

        private int _durationMinutes;

        public Song()
        { }

        public Song(int id, string name, string author, int durationminutes)
        {
            Id = id;
            Name = name;
            Author = author;
            DurationMinutes = durationminutes;
        }

        public int Id 
        {
            get
            {
                return _id;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Id));
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
                Validator.AssertOnPositiveValue(value, nameof(DurationMinutes));
                _durationMinutes = value;
            }
        }
    }
}
