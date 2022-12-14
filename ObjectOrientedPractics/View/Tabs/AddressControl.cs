using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Адрес.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Создает экземпляр класса <see cref="AddressControl"/>.
        /// </summary>
        public AddressControl()
        {
            _address = new Address();

            InitializeComponent();

            /// <summary>
            /// Устанавливает базовые значения в переменные.
            /// </summary>
            Address Address()
            {
                Address standartAnddress = new Address();
                standartAnddress.Index = "666666";
                standartAnddress.Country = "Country";
                standartAnddress.Сity = "City";
                standartAnddress.Street = "Street";
                standartAnddress.Building = "Building";
                standartAnddress.Apartment = "Apartment";
                return standartAnddress;
            }

        }

        /// <summary>
        /// Устанавливает значения в поля.
        /// </summary>
        private void SetValuesTextBoxes()
        {
            PostIndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.Сity;   
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }

        
    }
}
