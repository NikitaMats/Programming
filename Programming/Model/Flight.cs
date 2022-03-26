using System;

namespace Programming.Model
{
    public class Flight
    {
        private int _flightTimeMinute;

        public Flight()
        { }

        public Flight(string departurePoint, string destinationPoint, int flightTimeMinute)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeMinute = flightTimeMinute;
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
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _flightTimeMinute = value;
            }
        }
    }
}
