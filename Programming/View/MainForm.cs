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

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int indexMaxWide = 0;
            double max = 0;
            for (int i = 0; i < 5; i++)
            {
                if (rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    indexMaxWide = i;
                }
            }
            return indexMaxWide;
        }
        private int FindMaxRatingFilm(Film[] movies)
        {
            int indexMaxRating = 0;
            double max = 0;
            for (int i = 0; i < 5; i++)
            {
                if (movies[i].Rating > max)
                {
                    max = movies[i].Rating;
                    indexMaxRating = i;
                }
            }
            return indexMaxRating;
        }
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
                _rectangles[i] = new Rectangle(length, width, _colors[1]);
                RectangleListBox.Items.Add("Rectangle " + (i + 1));
            }
            RectangleListBox.SelectedIndex = 0;

            _movies = new Film[5]
            {
                new Film("The Green Mile", 189, 1999, "Drama", 9.1),
                new Film("Intouchables", 112, 2011, "Drama", 8.8),
                new Film("Interstellar", 169, 2014, "Science fiction", 7),
                new Film("Back to the Future", 116, 1985, "Science fiction", 8.7),
                new Film("WALL·E", 98, 2008, "Сartoon", 8.6),
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
            var selectedRectangle = RectangleListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedRectangle];
            LenghtTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            LenghtTextBox.BackColor = ColorTranslator.FromHtml("Window");
            try
            {
                _currentRectangle.Length = Convert.ToDouble(LenghtTextBox.Text);
            }
            catch
            {
                LenghtTextBox.BackColor = ColorTranslator.FromHtml("LightPink");
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            WidthTextBox.BackColor = ColorTranslator.FromHtml("Window");
            try
            {
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
            }
            catch
            {
                WidthTextBox.BackColor = ColorTranslator.FromHtml("LightPink");
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int indexFindRectangle = FindRectangleWithMaxWidth(_rectangles);
            RectangleListBox.SelectedIndex = indexFindRectangle;
        }

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMovie = FilmsListBox.SelectedIndex;
            _currentMovie = _movies[selectedMovie];
            FilmNameTextBox.Text = _currentMovie.Name;
            FilmGenreTextBox.Text = _currentMovie.Genre;
            FilmDurationTextBox.Text = _currentMovie.DurationMinute.ToString();
            FilmReleaseTextBox.Text = _currentMovie.ReleaseYear.ToString();
            FilmRatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void FilmNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = FilmNameTextBox.Text;
        }

        private void FilmGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = FilmGenreTextBox.Text;
        }

        private void FimDuretionTextBox_TextChanged(object sender, EventArgs e)
        {
            FilmDurationTextBox.BackColor = ColorTranslator.FromHtml("Window");
            try
            {
                _currentMovie.DurationMinute = Convert.ToInt32(FilmDurationTextBox.Text);
            }
            catch
            {
                FilmDurationTextBox.BackColor = ColorTranslator.FromHtml("LightPink");
            }
        }

        private void FilmReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            FilmReleaseTextBox.BackColor = ColorTranslator.FromHtml("Window");
            try
            {
                _currentMovie.ReleaseYear = Convert.ToInt32(FilmReleaseTextBox.Text);
            }
            catch
            {
                FilmReleaseTextBox.BackColor = ColorTranslator.FromHtml("LightPink");
            }
        }

        private void FilmRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            FilmRatingTextBox.BackColor = ColorTranslator.FromHtml("Window");
            try
            {
                _currentMovie.Rating = Convert.ToDouble(FilmRatingTextBox.Text);
            }
            catch
            {
                FilmRatingTextBox.BackColor = ColorTranslator.FromHtml("LightPink");
            }
        }

        private void FindFilmButton_Click(object sender, EventArgs e)
        {
            int indexFindMovie = FindMaxRatingFilm(_movies);
            FilmsListBox.SelectedIndex = indexFindMovie;
        }
    }
}
