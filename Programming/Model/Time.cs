using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Time
    {
        private int _hour;
        private int _minute;
        private int _second;

        public Time()
        { }

        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        public int Hour 
        {
            get
            {
                return _hour;
            }
            set
            {
                if (value < 0 && value > 23) throw new ArgumentException();
                _hour = value;
            }
        }
        public int Minute 
        {
            get
            {
                return _minute;
            }
            set
            {
                if (value < 0 && value > 60) throw new ArgumentException();
                _minute = value;
            }
        }
        public int Second 
        {
            get
            {
                return _second;
            }
            set
            {
                if (value < 0 && value > 60) throw new ArgumentException();
                _second = value;
            }
        }
    }
}
