using System;

namespace Programming.Model
{
    public class Movie
    {
        private int _durationMinutes;

        private int _releaseYear;

        private double _rating;

        private int _year = DateTime.Now.Year;

        public Movie()
        { }

        public Movie(string name, int durationminutes, int releaseyear,string genre,double rating)
        {
            Name = name;
            DurationMinutes = durationminutes;
            ReleaseYear = releaseyear;
            Genre = genre;
            Rating = rating;
        }

        public string Name { get; set; }

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

        public int ReleaseYear 
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, _year, nameof(ReleaseYear));
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
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }
    }
}
