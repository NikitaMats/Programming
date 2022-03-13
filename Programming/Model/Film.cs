using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Film
    {
        private int _durationMinute;

        private int _releaseYear;

        private double _rating;

        public Film()
        { }

        public Film(string name, int durationminute, int releaseyear,string genre,double rating)
        {
            Name = name;
            DurationMinute = durationminute;
            ReleaseYear = releaseyear;
            Genre = genre;
            Rating = rating;
        }
        public string Name { get; set; }
        public int DurationMinute 
        {
            get
            {
                return _durationMinute;
            }
            set
            {
                if (value < 0) throw new ArgumentException();
                _durationMinute = value;
            }
        }
        public int ReleaseYear 
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                if (value < 1900 && value > 2022) throw new ArgumentException();
                _releaseYear = value;
            }
        }
        public string Genre { get; set; }
        public double Rating 
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value < 0 && value > 10) throw new ArgumentException();
                _rating = value;
            }
        }
    }
}
