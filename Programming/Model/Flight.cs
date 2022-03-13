using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Flight
    {
        private int _flightTimeMinute;

        public Flight()
        { }

        public Flight(string departurePoint, string destinationPoint, int flightTimrMinute)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeMinute = flightTimrMinute;
        }
        public string DeparturePoint { get; set; }
        public string DestinationPoint { get; set; }
        public int FlightTimeMinute 
        {
            get
            {
                return _flightTimeMinute;
            }
            set
            {
                if (value <= 0) throw new ArgumentException();
                _flightTimeMinute = value;
            }
        }
    }
}
