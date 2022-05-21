using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Enums;
using System.Collections.Generic;

namespace Programming.View.Control
{
    public partial class MoviesControl : UserControl
    {
        private Movie[] _movies;

        private Movie _currentMovie;

        private int _moviesAmount = 5;

        private string _errorСolor = "LightPink";

        private string _normalColor = "Window";

        private ToolTip _toolTip = new ToolTip();

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

        public MoviesControl()
        {
            InitializeComponent();
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

        private void MovieDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieDurationTextBox.BackColor = ColorTranslator.FromHtml(_normalColor);
            try
            {
                _currentMovie.DurationMinutes = Convert.ToInt32(MovieDurationTextBox.Text);
                _toolTip.SetToolTip(MovieDurationTextBox, "");
            }
            catch (Exception exception)
            {
                _toolTip.SetToolTip(MovieDurationTextBox, exception.Message);
                MovieDurationTextBox.BackColor = ColorTranslator.FromHtml(_errorСolor);
            }
        }

        private void MovieReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieReleaseTextBox.BackColor = ColorTranslator.FromHtml(_normalColor);
            try
            {
                _currentMovie.ReleaseYear = Convert.ToInt32(MovieReleaseTextBox.Text);
                _toolTip.SetToolTip(MovieReleaseTextBox, "");
            }
            catch (Exception exception)
            {
                MovieReleaseTextBox.BackColor = ColorTranslator.FromHtml(_errorСolor);
                _toolTip.SetToolTip(MovieReleaseTextBox, exception.Message);
            }
        }

        private void MovieRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieRatingTextBox.BackColor = ColorTranslator.FromHtml(_normalColor);
            try
            {
                _currentMovie.Rating = Convert.ToDouble(MovieRatingTextBox.Text);
                _toolTip.SetToolTip(MovieRatingTextBox, "");
            }
            catch (Exception exception)
            {
                MovieRatingTextBox.BackColor = ColorTranslator.FromHtml(_errorСolor);
                _toolTip.SetToolTip(MovieRatingTextBox, exception.Message);
            }
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int indexFindMovie = FindMovieWithMaxRating(_movies);
            MoviesListBox.SelectedIndex = indexFindMovie;
        }
    }
}
