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
                if (value < 0 && value > 23)
                {
                    throw new ArgumentException();
                }
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
                if (value < 0 && value > 60)
                {
                    throw new ArgumentException();
                }
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
                if (value < 0 && value > 60)
                {
                    throw new ArgumentException();
                }
                _seconds = value;
            }
        }
    }
}
