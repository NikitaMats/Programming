using System;

namespace Programming.Model
{
    public class Rectangle
    {
        private double _length;

        private double _width;

        public Rectangle()
        { }

        public Rectangle(double lenght, double width, string color)
        {
            Length = lenght;
            Width = width;
            Color = color;
        }

        public double Length 
        {
            get
            {
                return _length;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _length = value;
            }
        }

        public double Width 
        {
            get
            {
                return _width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _width = value;
            }
        }

        public string Color { get; set; }
    }
}
