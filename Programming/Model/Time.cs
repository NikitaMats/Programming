using System;

namespace Programming.Model
{
    public class Time
    {
        private int _hours;

        private int _minutes;

        private int _seconds;

        public Time()
        { }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public int Hours 
        {
            get
            {
                return _hours;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 23, nameof(Minutes));
                _hours = value;
            }
        }

        public int Minutes 
        {
            get
            {
                return _minutes;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Minutes));
                _minutes = value;
            }
        }

        public int Seconds 
        {
            get
            {
                return _seconds;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Seconds));
                _seconds = value;
            }
        }
    }
}
