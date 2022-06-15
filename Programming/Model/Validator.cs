using System;

namespace Programming.Model
{
    /// <summary>
    /// Предоставляет методы для проверки входных данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что число является положительным.
        /// </summary>
        /// <param name="fieldName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число. </param>
        /// <exception cref="ArgumentException">Выбрасывается, когда число меньше нуля.</exception>
        public static void AssertOnPositiveValue(int value, string fieldName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Введите корректное значение {fieldName}");
            }
        }

        /// <summary>
        /// Проверяет, что число является положительным.
        /// </summary>
        /// <param name="fieldName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число. </param>
        /// <exception cref="ArgumentException">Выбрасывается, когда число меньше нуля.</exception>
        public static void AssertOnPositiveValue(double value, string fieldName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Введите корректное значение {fieldName}");
            }
        }

        /// <summary>
        /// Проверяет, что число находится в определённом диапазоне.
        /// </summary>
        /// <param name="fieldName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число находится вне диапазона.</exception>
        public static void AssertValueInRange(int value, int min, int max, string fieldName) 
        {
            if (!(value <= max && value >= min))
            {
                throw new ArgumentException($"Введите корректное значение {fieldName}");
            }
        }

        /// <summary>
        /// Проверяет, что число находится в определённом диапазоне.
        /// </summary>
        /// <param name="fieldName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число находится вне диапазона.</exception>
        public static void AssertValueInRange(double value, double min, double max, string fieldName)
        {
            if (!(value <= max && value >= min))
            {
                throw new ArgumentException($"Введите корректное значение {fieldName}");
            }
        }

        /// <summary>
        /// Проверяет, что строка состоит только из букв английского алфавита.
        /// </summary>
        /// <param name="fieldName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Строка.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если строка состоит не только из
        /// букв английского алфавита.</exception>
        public static void AssertStringContainsOnlyLetters(string value, string fieldName)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsLetter(value[i]) != true)
                {
                    throw new ArgumentException($"Введите корректное значение {fieldName}");
                }
            }
        }
    }
}
