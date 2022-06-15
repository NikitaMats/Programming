using System;
using Programming.Model.Enums;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Реализует создание прямоугольника.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Отступ внутри элемента размещения прямоугольников.
        /// </summary>
        private const int Margin = 15;

        /// <summary>
        /// Случайные значения.
        /// </summary>
        private static Random _random;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RectangleFactory"/>.
        /// </summary>
        static RectangleFactory()
        {
            _random = new Random();
        }

        /// <summary>
        /// Создаёт прямоугольник со случайными значениями высоты, ширины и координат.
        /// </summary>
        /// <param name="widthCanva">Ширина элемента размещения.</param>
        /// <param name="heightCanva">Высота элемента размещения.</param>
        /// <returns>Возвращает объект Rectangle.</returns>
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