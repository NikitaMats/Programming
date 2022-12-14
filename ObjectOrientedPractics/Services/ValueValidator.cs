using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс отвечающий за проверку входящих данных.
    /// </summary>
    internal class ValueValidator
    {
        /// <summary>
        /// Проверяет, что количество символов в строке находится в нужном диапазоне.
        /// </summary>
        /// <param name="FunctionName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <param name="value">Строка.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда количество символов строки не входит в диапазон.</exception>
        public static void AssertCountSymbolsInRange(string FunctionName, int min, int max, string value)
        {
            if (!(value.Length >= min && value.Length <= max))
                throw new ArgumentException(
                    $"The number of characters of the {FunctionName} field must be in the range from {min} to {max}.");
        }

        /// <summary>
        /// Проверяет, что значение переменной находится в нужном диапазоне.
        /// </summary>
        /// <param name="FunctionName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <param name="value">Вещественное число.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда количество символов переменной не входит в диапазон.</exception>
        public static void AssertValueInRange(string FunctionName, int min, int max, double value)
        {
            if (!(value >= min && value <= max))
                throw new ArgumentException(
                    $"The value of the {FunctionName} field must be in the range from {min} to {max}.");
        }
    }
}
