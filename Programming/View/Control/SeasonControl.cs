using System;
using System.Windows.Forms;
using System.Drawing;
using Programming.Model.Enums;

namespace Programming.View.Control
{
    /// <summary>
    /// Предоставляет реализацию по изменению цвета фона.
    /// </summary>
    public partial class SeasonControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="SeasonControl"/>.
        /// </summary>
        public SeasonControl()
        {
            InitializeComponent();
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            switch ((Season)SeasonComboBox.SelectedItem)
            {
                case Season.Winter:
                    BackColor = Color.LightBlue;
                    MessageBox.Show("Br-r-r! Coldly!", "Message", MessageBoxButtons.OKCancel);
                    break;
                case Season.Spring:
                    BackColor = Color.LightGreen;
                    break;
                case Season.Summer:
                    BackColor = Color.Green;
                    MessageBox.Show("Hooray! Sun!", "Message", MessageBoxButtons.OKCancel);
                    break;
                case Season.Autumn:
                    BackColor = Color.Orange;
                    break;
                default:
                    MessageBox.Show("Not selected season!", "Warning!", MessageBoxButtons.OKCancel);
                    break;
            }
        }
    }
}
