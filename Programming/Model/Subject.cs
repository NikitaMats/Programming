using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные об образовательном предмете.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Номер дисциплины в списке.
        /// </summary>
        private int _position;

        /// <summary>
        /// Преподаватель по дисциплине.
        /// </summary>
        private string _lecturer;

        /// <summary>
        /// Название дисциплины.
        /// </summary>
        private string _name;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        public Subject()
        { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="name">Название дисциплины.</param>
        /// <param name="lecturer">Преподаватель по дисциплине.</param>
        /// <param name="position">Номер дисциплины в списке.</param>
        public Subject(string name, string lecturer, int position)
        {
            Name = name;
            Lecturer = lecturer;
            Position = position;
        }

        /// <summary>
        /// Возвращает и задаёт название дисциплины.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает преподввтеля по дисциплине. Должно состоять только из букв.
        /// </summary>
        public string Lecturer
        {
            get
            {
                return _lecturer;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Lecturer));
                _lecturer = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер дисциплины в списке. Должно быть положительным числом.
        /// </summary>
        public int Position 
        {
            get
            {
                return _position;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Position));
                _position = value;
            }
        }
    }
}
