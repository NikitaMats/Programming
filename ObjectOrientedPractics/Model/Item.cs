using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// Индивидуальный номер товара.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Информация о товаре.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Счетчик товаров.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            _allItemsCount++;
            _id = _allItemsCount;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Информация о товаре.</param>
        /// <param name="cost">Стоимость товара.</param>
        public Item(string name, string info, double cost)
        {
            _allItemsCount++;
            Id = _allItemsCount;
            Name = name;
            Info = info;
            Cost = cost;
        }

        /// <summary>
        /// Возвращает Id товара.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает и задаёт название товара.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт информацию о товаре.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт цену товара.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }
    }
}
