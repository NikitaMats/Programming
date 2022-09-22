using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTabControl : UserControl
    {
        /// <summary>
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Выбранный студент.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Цвет поля с ошибкой.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Цвет поля без ошибок.
        /// </summary>
        private readonly Color _normalColor = Color.White;

        public ItemsTabControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает форматированный текст для вывода в List Box. 
        /// </summary>
        /// <param name="item"> Товар для форматирования.</param>
        /// <returns>Возвращает форматированный текст.</returns>
        private string FormattedText(Item item)
        {
            return $"{item.Id} " + $": {item.Name}";
        }

        /// <summary>
        ///Очищает информацию о товаре.
        /// </summary>
        private void ClearItemInfo()
        {
            ItemsListBox.Items.Clear();
            ItemIDTextBox.Clear();
            ItemNameTextBox.Clear();
            ItemInfoTextBox.Clear();
        }

        /// <summary>
        /// Обновляет информацию о товаре.
        /// </summary>
        /// <param name="student">Товар для обновления информации.</param>
        private void UpdateStudentInfo(Item item)
        {
            int indexSelectedStudent = ItemsListBox.SelectedIndex;

            if (indexSelectedStudent == -1) return;

            ItemsListBox.Items[indexSelectedStudent] = FormattedText(item);
        }

        private void ItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                _currentItem.Name = ItemNameTextBox.Text;
                UpdateStudentInfo(_currentItem);
            }
            catch
            {
                ItemNameTextBox.BackColor = _errorColor;
                return;
            }

            ItemNameTextBox.BackColor = _normalColor;
        }

        private void ItemCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                _currentItem.Cost = Convert.ToDouble(ItemCostTextBox.Text);
                UpdateStudentInfo(_currentItem);
            }
            catch
            {
                ItemCostTextBox.BackColor = _errorColor;
                return;
            }

            ItemCostTextBox.BackColor = _normalColor;
        }

        private void ItemInfoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                _currentItem.Info = ItemInfoTextBox.Text;
                UpdateStudentInfo(_currentItem);
            }
            catch
            {
                ItemInfoTextBox.BackColor = _errorColor;
                return;
            }

            ItemInfoTextBox.BackColor = _normalColor;
        }

        private void ItemAddButtom_Click(object sender, EventArgs e)
        {
            _currentItem = new Item(ItemNameTextBox.Text, ItemInfoTextBox.Text, Convert.ToDouble(ItemCostTextBox.Text));
            _items.Add(_currentItem);
            ItemsListBox.Items.Add(FormattedText(_currentItem));
            ItemIDTextBox.Text = _currentItem.Id.ToString();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null) return;

            int indexSelectedStudent = ItemsListBox.SelectedIndex;
            _currentItem = _items[indexSelectedStudent];
            ItemNameTextBox.Text = _currentItem.Name;
            ItemInfoTextBox.Text = _currentItem.Info;
            ItemCostTextBox.Text = _currentItem.Cost.ToString();
            ItemIDTextBox.Text = _currentItem.Id.ToString();
        }
    }
}
