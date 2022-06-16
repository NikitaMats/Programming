using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по парсингу дней недели.
    /// </summary>
    public partial class WeekdayControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="WeekdayParsingControl"/>.
        /// </summary>
        public WeekdayControl()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday day;
            if (Enum.TryParse(ValueParsing.Text, out day))
            {
                ParsingFlag.Text = $"This day of week ({day.ToString()} = {(int)day + 1}).";
            }
            else
            {
                ParsingFlag.Text = "Is it the exact day of the week? o_0";
            }
        }
    }
}
