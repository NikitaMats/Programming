using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Индивидуальный номер песни.
        /// </summary>
        private int _id;

        /// <summary>
        /// Продолжительность песни в минутах.
        /// </summary>
        private int _durationMinutes;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="author">Имя музыканта (группы).</param>
        /// <param name="id"> Индивидуальный номер песни. Должно быть положительным числом.</param>
        /// <param name="name">Название песни.</param>
        /// <param name="durationminutes">Продолжительность песни в минутах. Должно быть положительным числом.</param>
        public Song(int id, string name, string author, int durationminutes)
        {
            Id = id;
            Name = name;
            Author = author;
            DurationMinutes = durationminutes;
        }

        /// <summary>
        /// Возвращает и задаёт индивидуальный номер песни.
        /// </summary>
        public int Id 
        {
            get
            {
                return _id;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Id));
                _id = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт название песни.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт имя музыканта (группы).
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Возвращает и задаёт продолжительность песни в минутах. Должно быть положительным числом.
        /// </summary>
        public int DurationMinutes 
        {
            get
            {
                return _durationMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationMinutes));
                _durationMinutes = value;
            }
        }
    }
}
