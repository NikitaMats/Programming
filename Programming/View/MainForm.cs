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
        private Movie[] _movies;
        private Movie _currentMovie;
        private int RectanglesAmount = 5;
        private int MoviesAmount = 5;
        private string errorСolor = "LightPink";
        private string normalColor = "Window";

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int indexOfMaxWidth = 0;
            double max = 0;
            for (int i = 0; i < RectanglesAmount; i++)
            {
                if (rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    indexOfMaxWidth = i;
                }
            }
            return indexOfMaxWidth;
        }
        private int FindMovieWithMaxRating(Movie[] movies)
        {
            int indexOfMaxRating = 0;
            double max = 0;
            for (int i = 0; i < MoviesAmount; i++)
            {
                if (movies[i].Rating > max)
                {
                    max = movies[i].Rating;
                    indexOfMaxRating = i;
                }
            }
            return indexOfMaxRating;
        }
        public MainForm()
        {
            InitializeComponent();

            // first page
            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            EnumsListBox.SelectedIndex = 0;

            // second page
            _rectangles = new Rectangle[RectanglesAmount];
            var rand = new Random();
            double length, width;
            for (int i = 0; i < 5; i++)
            {
                length = Math.Round(rand.NextDouble() * 100, 1);
                width = Math.Round(rand.NextDouble() * 100, 1);
                _rectangles[i] = new Rectangle(length, width, _colors[1]);
                RectanglesListBox.Items.Add("Rectangle " + (i + 1));
            }

            RectanglesListBox.SelectedIndex = 0;

            _movies = new Movie[5]
            {
                new Movie("The Green Mile", 189, 1999, "Drama", 9.1),
                new Movie("Intouchables", 112, 2011, "Drama", 8.8),
                new Movie("Interstellar", 169, 2014, "Science fiction", 7),
                new Movie("Back to the Future", 116, 1985, "Science fiction", 8.7),
                new Movie("WALL·E", 98, 2008, "Сartoon", 8.6),
            };

            foreach (var movie in _movies)
            {
                MoviesListBox.Items.Add(movie.Name);
            }
            MoviesListBox.SelectedIndex = 0;
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

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedRectangle];
            LenghtTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            LenghtTextBox.BackColor = ColorTranslator.FromHtml(normalColor);
            try
            {
                _currentRectangle.Length = Convert.ToDouble(LenghtTextBox.Text);
                ToolTip.SetToolTip(MovieDurationTextBox, "");
            }
            catch
            {
                LenghtTextBox.BackColor = ColorTranslator.FromHtml(errorСolor);
                ToolTip.SetToolTip(MovieDurationTextBox, "Error");
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            WidthTextBox.BackColor = ColorTranslator.FromHtml(normalColor);
            try
            {
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
                ToolTip.SetToolTip(MovieDurationTextBox, "");
            }
            catch
            {
                WidthTextBox.BackColor = ColorTranslator.FromHtml(errorСolor);
                ToolTip.SetToolTip(MovieDurationTextBox, "Error");
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int indexFindRectangle = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = indexFindRectangle;
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMovie = MoviesListBox.SelectedIndex;
            _currentMovie = _movies[selectedMovie];
            MovieNameTextBox.Text = _currentMovie.Name;
            MovieGenreTextBox.Text = _currentMovie.Genre;
            MovieDurationTextBox.Text = _currentMovie.DurationMinutes.ToString();
            MovieReleaseTextBox.Text = _currentMovie.ReleaseYear.ToString();
            MovieRatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void MovieNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = MovieNameTextBox.Text;
        }

        private void MovieGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = MovieGenreTextBox.Text;
        }

        private void MovieDuretionTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieDurationTextBox.BackColor = ColorTranslator.FromHtml(normalColor);
            try
            {
                _currentMovie.DurationMinutes = Convert.ToInt32(MovieDurationTextBox.Text);
                ToolTip.SetToolTip(MovieDurationTextBox, "");
            }
            catch
            {
                ToolTip.SetToolTip(MovieDurationTextBox, "Error");
                MovieDurationTextBox.BackColor = ColorTranslator.FromHtml(errorСolor);
            }
        }

        private void MovieReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieReleaseTextBox.BackColor = ColorTranslator.FromHtml(normalColor);
            try
            {
                _currentMovie.ReleaseYear = Convert.ToInt32(MovieReleaseTextBox.Text);
                ToolTip.SetToolTip(MovieDurationTextBox, "");
            }
            catch
            {
                MovieReleaseTextBox.BackColor = ColorTranslator.FromHtml(errorСolor);
                ToolTip.SetToolTip(MovieDurationTextBox, "Error");
            }
        }
        
        private void MovieRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieRatingTextBox.BackColor = ColorTranslator.FromHtml(normalColor);
            try
            {
                _currentMovie.Rating = Convert.ToDouble(MovieRatingTextBox.Text);
                ToolTip.SetToolTip(MovieDurationTextBox, "");
            }
            catch
            {
                MovieRatingTextBox.BackColor = ColorTranslator.FromHtml(errorСolor);
                ToolTip.SetToolTip(MovieDurationTextBox, "Error");
            }
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int indexFindMovie = FindMovieWithMaxRating(_movies);
            MoviesListBox.SelectedIndex = indexFindMovie;
        }
    }
}
