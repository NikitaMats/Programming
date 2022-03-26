using System;

namespace Programming.Model
{
    public class Flight
    {
        private int _flightTimeMinutes;

        public Flight()
        { }

        public Flight(string departure, string destination, int flightTimeMinutes)
        {
            Departure = departure;
            Destination = destination;
            FlightTimeMinutes = flightTimeMinutes;
        }
        public string Departure { get; set; }

        public string Destination { get; set; }

        public int FlightTimeMinutes
        {
            get
            {
                return _flightTimeMinutes;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _flightTimeMinutes = value;
            }
        }
    }
}
