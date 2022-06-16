using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по представлению перечислений.
    /// </summary>
    public partial class EnumerationsControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="EnumerationsControl"/>.
        /// </summary>
        public EnumerationsControl()
        {
            InitializeComponent();
            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((Enums)EnumsListBox.SelectedItem)
            {
                case Enums.Weekday:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
                case Enums.Genre:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.Colors:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Colors));
                    break;
                case Enums.EducationForm:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(EducationForm));
                    break;
                case Enums.Smartphones:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Smartphones));
                    break;
                case Enums.Season:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ValuesListBox.SelectedItem;
            IntTextBox.Text = ((int)item).ToString();
        }

    }
}
