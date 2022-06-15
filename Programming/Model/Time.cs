using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Количество часов.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Количество минут.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Количество секунд.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        public Time()
        { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Количество часов. Должно быть в пределах от 0 до 23 .</param>
        /// <param name="minutes">Количество минут. Должно быть в пределах от 0 до 59 .</param>
        /// <param name="seconds">Количество секунд. Должно быть в пределах от 0 до 59 .</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Возвращает и задаёт количество часов.Должно быть в пределах от 0 до 23.
        /// </summary>
        public int Hours 
        {
            get
            {
                return _hours;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 23, nameof(Minutes));
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт количество минут.Должно быть в пределах от 0 до 59.
        /// </summary>
        public int Minutes 
        {
            get
            {
                return _minutes;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Minutes));
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт количество секунд. Должно быть в пределах от 0 до 59.
        /// </summary>
        public int Seconds 
        {
            get
            {
                return _seconds;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Seconds));
                _seconds = value;
            }
        }
    }
}
