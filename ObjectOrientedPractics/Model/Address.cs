using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    internal class Address
    {
        /// <summary>
        /// Почтовый индекс покупателя.
        /// </summary>
        private string _index;

        /// <summary>
        /// Страна/регион покупателя.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город/населенный пункт покупателя.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица покупателя.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома покупателя.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения покупателя.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс. Должен содержать 6 цифр.</param>
        /// <param name="country">Страна/регион. Должно быть не более 50 символов.</param>
        /// <param name="city">Город (населенный пункт). Должно быть не более 50 символов.</param>
        /// <param name="street">Улица. Должно быть не более 100 символов.</param>
        /// <param name="building">Номер дома. Должно быть не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения. Должно быть не более 10 символов.</param>
        public Address(string index, string country, string city,
                        string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            Сity = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Возвращает и задаёт почтовый индекс покупателя.
        /// </summary>
        public string Index
        {
            get
            {
                return _index;
            }
            set
            {
                ValueValidator.AssertCountSymbolsInRange(nameof(Index), 6, 6, value);
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт страну/регион покупателя.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertCountSymbolsInRange(nameof(Country), 1, 50, value);
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт город/населенный пункт покупателя.
        /// </summary>
        public string Сity
        {
            get
            {
                return _city;
            }
            set
            {
                ValueValidator.AssertCountSymbolsInRange(nameof(Сity), 1, 50, value);
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт улицу покупателя.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValueValidator.AssertCountSymbolsInRange(nameof(Street), 1, 100, value);
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер квартиры/помещения покупателя.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                ValueValidator.AssertCountSymbolsInRange(nameof(Apartment), 1, 10, value);
                _apartment = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер дома покупателя.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                ValueValidator.AssertCountSymbolsInRange(nameof(Building), 1, 10, value);
                _building = value;
            }
        }
    }
}
