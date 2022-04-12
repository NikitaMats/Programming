using System;

namespace Programming.Model
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value, string fieldName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Введите корректное значение {fieldName}");
            }
        }

        public static void AssertOnPositiveValue(double value, string fieldName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Введите корректное значение {fieldName}");
            }
        }

        public static void AssertValueInRange(int value, int min, int max, string fieldName) 
        {
            if (!(value <= max || value >= min))
            {
                throw new ArgumentException($"Введите корректное значение {fieldName}");
            }
        }

        public static void AssertValueInRange(double value, double min, double max, string fieldName)
        {
            if (!(value <= max || value >= min))
            {
                throw new ArgumentException($"Введите корректное значение {fieldName}");
            }
        }

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
