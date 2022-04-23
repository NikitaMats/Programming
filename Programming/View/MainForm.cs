using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Enums;
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
        private int _rectanglesAmount = 5;
        private int _moviesAmount = 5;
        private string _errorСolor = "LightPink";
        private string _normalColor = "Window";

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int indexOfMaxWidth = 0;
            double max = 0;
            for (int i = 0; i < _rectanglesAmount; i++)
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
            for (int i = 0; i < _moviesAmount; i++)
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
            _rectangles = new Rectangle[_rectanglesAmount];
            var rand = new Random();
            double length, width;
            int centerX, centerY;
            for (int i = 0; i < 5; i++)
            {
                length = Math.Round(rand.NextDouble() * 100, 1);
                width = Math.Round(rand.NextDouble() * 100, 1);
                centerX = rand.Next(10);
                centerY = rand.Next(10);
                _rectangles[i] = new Rectangle(length, width, _colors[1], new Point2D(centerX, centerY));
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
            LengthBox.Text = _currentRectangle.Length.ToString();
            WidthBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            Xcoordinate.Text = _currentRectangle.Center.X.ToString();
            Ycoordinate.Text = _currentRectangle.Center.Y.ToString();
            IdRectangle.Text = "Id:" + _currentRectangle.Id.ToString();
            if (CollisionManager.IsCollision(_rectangles[0], _rectangles[1]))
            {
                CollisionLable.Text = "Collision: True";
            }
            else
            {
                CollisionLable.Text = "Collision: False";
            }
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            LengthBox.BackColor = ColorTranslator.FromHtml(_normalColor);
            try
            {
                _currentRectangle.Length = Convert.ToDouble(LengthBox.Text);
                ToolTip.SetToolTip(MovieDurationTextBox, "");
            }
            catch (Exception exception)
            {
                LengthBox.BackColor = ColorTranslator.FromHtml(_errorСolor);
                ToolTip.SetToolTip(MovieDurationTextBox, exception.Message);
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            WidthBox.BackColor = ColorTranslator.FromHtml(_normalColor);
            try
            {
                _currentRectangle.Width = Convert.ToDouble(WidthBox.Text);
                ToolTip.SetToolTip(MovieDurationTextBox, "");
            }
            catch (Exception exception)
            {
                WidthBox.BackColor = ColorTranslator.FromHtml(_errorСolor);
                ToolTip.SetToolTip(MovieDurationTextBox, exception.Message);
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
            MovieDurationTextBox.BackColor = ColorTranslator.FromHtml(_normalColor);
            try
            {
                _currentMovie.DurationMinutes = Convert.ToInt32(MovieDurationTextBox.Text);
                ToolTip.SetToolTip(MovieDurationTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(MovieDurationTextBox, exception.Message);
                MovieDurationTextBox.BackColor = ColorTranslator.FromHtml(_errorСolor);
            }
        }

        private void MovieReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieReleaseTextBox.BackColor = ColorTranslator.FromHtml(_normalColor);
            try
            {
                _currentMovie.ReleaseYear = Convert.ToInt32(MovieReleaseTextBox.Text);
                ToolTip.SetToolTip(MovieReleaseTextBox, "");
            }
            catch (Exception exception)
            {
                MovieReleaseTextBox.BackColor = ColorTranslator.FromHtml(_errorСolor);
                ToolTip.SetToolTip(MovieReleaseTextBox, exception.Message);
            }
        }
        
        private void MovieRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieRatingTextBox.BackColor = ColorTranslator.FromHtml(_normalColor);
            try
            {
                _currentMovie.Rating = Convert.ToDouble(MovieRatingTextBox.Text);
                ToolTip.SetToolTip(MovieRatingTextBox, "");
            }
            catch (Exception exception)
            {
                MovieRatingTextBox.BackColor = ColorTranslator.FromHtml(_errorСolor);
                ToolTip.SetToolTip(MovieRatingTextBox, exception.Message);
            }
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int indexFindMovie = FindMovieWithMaxRating(_movies);
            MoviesListBox.SelectedIndex = indexFindMovie;
        }

        private void CreateButton_MouseMove(object sender, MouseEventArgs e)
        {
            CreateButton.BackgroundImage = Properties.Resources.rectangle_add_24x24;
        }

        private void CreateButton_MouseLeave(object sender, EventArgs e)
        {
            CreateButton.BackgroundImage = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void DeleteButton_MouseMove(object sender, MouseEventArgs e)
        {
            DeleteButton.BackgroundImage = Properties.Resources.rectangle_remove_24x24;
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.BackgroundImage = Properties.Resources.rectangle_remove_24x24_uncolor;
        }
    }
}
