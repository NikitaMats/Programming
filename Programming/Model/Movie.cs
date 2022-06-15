using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Продолжительность фильма в минутах.
        /// </summary>
        private int _durationMinutes;

        /// <summary>
        /// Год релиза фильма.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Содержит значение текущего года.
        /// </summary>
        private int _year = DateTime.Now.Year;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie()
        { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="releaseyear">Год релиза фильма. Должно быть в диапазоне от 1900 до 2022.</param>
        /// <param name="durationminutes">Продолжительность фильма в минутах. Должно быть положительным числом.</param>
        /// <param name="rating">Рейтинг фильма. Должен быть в диапазоне от 0 до 10.</param>
        /// <param name="name">Название фильма.</param>
        /// <param name="genre">Жанр фильма.</param>
        public Movie(string name, int durationminutes, int releaseyear,string genre,double rating)
        {
            Name = name;
            DurationMinutes = durationminutes;
            ReleaseYear = releaseyear;
            Genre = genre;
            Rating = rating;
        }

        /// <summary>
        /// Возвращает и задаёт название фильма.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт продолжительность фильма в минутах. Должно быть положительным числом.
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

        /// <summary>
        /// Возвращает и задаёт год релиза фильма. Должно быть в диапазоне от 1900 до 2022 (включительно).
        /// </summary>
        public int ReleaseYear 
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, _year, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задаёт рейтинг фильма. Должен быть в диапазоне от 0 до 10.
        /// </summary>
        public double Rating 
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }
    }
}
