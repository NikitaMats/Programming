using System;
using Programming.Model.Enums;

namespace Programming.Model.Geometry
{
    public static class RectangleFactory
    {
        private const int Margin = 15;

        private static Random _random;

        static RectangleFactory()
        {
            _random = new Random();
        }

        public static Rectangle Randomize(int widthCanva, int heightCanva)
        {
            var colors = Enum.GetValues(typeof(Colors));
            Rectangle rectangle = new Rectangle();
            rectangle.Width = _random.Next(30, 100);
            rectangle.Length = _random.Next(30, 100);
            rectangle.Center = new Point2D(_random.Next(Margin, widthCanva - (int)rectangle.Width + Margin),
                                           _random.Next(Margin, heightCanva - (int)rectangle.Length + Margin));
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
        }
    }
}