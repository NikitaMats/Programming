using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
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

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday day;
            if (Enum.TryParse(ValueParsing.Text, out day))
            {
                ParsingFlag.Text = $"This day of week ({day.ToString()} = {(int)day+1}).";
            }
            else
            {
                ParsingFlag.Text = "Is it the exact day of the week? o_0";
            }
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
