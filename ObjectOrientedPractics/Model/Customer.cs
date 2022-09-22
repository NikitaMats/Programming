using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Customer
    {
        /// <summary>
        /// Счетчик покупателей.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Индивидуальный номер покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Информация о адресе доставки покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            _allItemsCount++;
            _id = _allItemsCount;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Название товара.</param>
        /// <param name="address">Информация о товаре.</param>
        public Customer(string fullname, string address)
        {
            _allItemsCount++;
            Id = _allItemsCount;
            Fullname = fullname;
            Address = address;
        }

        /// <summary>
        /// Возвращает и задает Id покупателя.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Возвращает и задаёт полное имя покупателя.
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес доставки для покупателя.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
    }
}
