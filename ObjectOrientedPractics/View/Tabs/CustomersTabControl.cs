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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTabControl : UserControl
    {
        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        private List<Customer> _сustomers = new List<Customer>();

        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Цвет поля с ошибкой.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Цвет поля без ошибок.
        /// </summary>
        private readonly Color _normalColor = Color.White;

        public CustomersTabControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает форматированный текст для вывода в List Box. 
        /// </summary>
        /// <param name="сustomer"> Покупатель для форматирования.</param>
        /// <returns>Возвращает форматированный текст.</returns>
        private string FormattedText(Customer сustomer)
        {
            return $"{сustomer.Id} " + $": {сustomer.Fullname}";
        }

        /// <summary>
        ///Очищает информацию о покупателе.
        /// </summary>
        private void ClearCustomerInfo()
        {
            CustomersListBox.Items.Clear();
            CustomerIDTextBox.Clear();
            CustomerFullNameTextBox.Clear();
            CustomerAddressTextBox.Clear();
        }

        /// <summary>
        /// Обновляет информацию о покупателе.
        /// </summary>
        /// <param name="сustomer">Покупатель для обновления информации.</param>
        private void UpdateItemInfo(Customer сustomer)
        {
            int indexSelectedCustomer = CustomersListBox.SelectedIndex;

            if (indexSelectedCustomer == -1) return;

            CustomersListBox.Items[indexSelectedCustomer] = FormattedText(сustomer);
        }

        private void CustomerFullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            try
            {
                _currentCustomer.Fullname = CustomerFullNameTextBox.Text;
                UpdateItemInfo(_currentCustomer);
            }
            catch
            {
                CustomerFullNameTextBox.BackColor = _errorColor;
                return;
            }

            CustomerFullNameTextBox.BackColor = _normalColor;
        }

        private void CustomerAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            try
            {
                _currentCustomer.Address = CustomerAddressTextBox.Text;
                UpdateItemInfo(_currentCustomer);
            }
            catch
            {
                CustomerAddressTextBox.BackColor = _errorColor;
                return;
            }

            CustomerAddressTextBox.BackColor = _normalColor;
        }

        private void CustomerAddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer(CustomerFullNameTextBox.Text, CustomerAddressTextBox.Text);
            _сustomers.Add(_currentCustomer);
            CustomersListBox.Items.Add(FormattedText(_currentCustomer));
            CustomerIDTextBox.Text = _currentCustomer.Id.ToString();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem == null) return;

            int indexSelectedCustomer = CustomersListBox.SelectedIndex;
            _currentCustomer = _сustomers[indexSelectedCustomer];
            CustomerFullNameTextBox.Text = _currentCustomer.Fullname;
            CustomerAddressTextBox.Text = _currentCustomer.Address;
 
        }

        private void CustomerDeleteButton_Click(object sender, EventArgs e)
        {
            int indexSelectedCustomer = CustomersListBox.SelectedIndex;

            if (indexSelectedCustomer == -1) return;

            _сustomers.RemoveAt(indexSelectedCustomer);

            ClearCustomerInfo();

            for (int i = 0; i <= _сustomers.Count - 1; i++)
            {
                CustomersListBox.Items.Add(FormattedText(_сustomers[i]));
            }
        }
    }
}
