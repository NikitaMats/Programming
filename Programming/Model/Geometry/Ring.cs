﻿using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные об кольце.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Внутренний радиус кольца.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="center">Координаты центра.</param>
        /// <param name="outerRadius">Внешний радиус. Должен быть положительным числом.
        /// Должен быть больше внутреннего радиуса.</param>
        /// <param name="innerRadius">Внутренний радиус. Должен быть положительным числом.
        /// Должен быть меньше внешнего радиуса.</param>
        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;

        }

        /// <summary>
        /// Возвращает и задает координаты центра кольца.
        /// </summary>
        public Point2D Center { get; set; }

        // <summary>
        /// Возвращает и задаёт внешний радиус. Должен быть положительным числом.
        /// Должен быть больше внутреннего радиуса.
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                Validator.AssertValueInRange(value, _innerRadius, _outerRadius, nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт внутренний радиус. Должен быть положительным числом.
        /// Должен быть меньше внешнего радиуса.
        /// </summary>
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                Validator.AssertValueInRange(value, 0, _innerRadius, nameof(InnerRadius));
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает площадь кольца. 
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * (_outerRadius * _outerRadius - _innerRadius * _innerRadius);
            }
        }
    }
}