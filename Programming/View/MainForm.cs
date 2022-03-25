using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private string[] _colors = { "Red", "Black", "Green", "Yellow", "Orange" };
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;
        private Film[] _movies;
        private Film _currentMovie;

        public MainForm()
        {
            InitializeComponent();
            //first page
            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            EnumsListBox.SelectedIndex = 0;
            //second page
            _rectangles = new Rectangle[5];
            var rand = new Random();
            double length, width;
            for (int i = 0; i < 5; i++)
            {
                length = Math.Round(rand.NextDouble() * 100, 1);
                width = Math.Round(rand.NextDouble() * 100, 1);
                _rectangles[i] = new Rectangle(length, width, _colors[i]);
                RectangleListBox.Items.Add("Rectangle " + (i + 1));
            }
            RectangleListBox.SelectedIndex = 0;

            _movies = new Film[5]
            {
                new Film("Tenet", 2, 2020, "Action", 8),
                new Film("The Gentlemen", 2, 2019, "Criminal", 9),
                new Film("Interstellar", 3, 2014, "Science fiction", 7),
                new Film("The Martian", 2, 2015, "Science fiction", 7.7),
                new Film("Stalk", 2, 2019, "с++", 7)
            };

            foreach (var movie in _movies)
            {
                FilmsListBox.Items.Add(movie.Name);
            }
            FilmsListBox.SelectedIndex = 0;
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

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
