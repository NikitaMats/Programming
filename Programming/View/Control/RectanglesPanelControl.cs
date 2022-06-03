using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Geometry;
using Programming.Properties;
using Rectangle = Programming.Model.Geometry.Rectangle;


namespace Programming.View.Control
{
    public partial class RectanglesPanelControl : UserControl
    {

        private List<Rectangle> _rectangles;
        private List<Panel> _rectanglePanels;
        private Rectangle _currentRectangle;
        private static Color IsNotCollision = Color.FromArgb(127, 127, 255, 127);
        private static Color IsCollision = Color.FromArgb(127, 255, 127, 127);

        public RectanglesPanelControl()
        {
            InitializeComponent();
            _rectangles = new List<Rectangle>();
            _rectanglePanels = new List<Panel>();
        }

        private Panel CreatePanel()
        {
            Panel panel = new Panel();
            panel.Width = (int)_currentRectangle.Width;
            panel.Height = (int)_currentRectangle.Length;
            panel.Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            panel.BackColor = IsNotCollision;

            return panel;
        }

        private string FormattedText(Rectangle rectangle)
        {
            return $"{rectangle.Id}: " +
                   $"(X: {rectangle.Center.X};" +
                   $" Y: {rectangle.Center.Y};" +
                   $" W: {rectangle.Width};" +
                   $" H: {rectangle.Length})";
        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                CanvasPanel.Controls[i].BackColor = IsNotCollision;
            }

            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (!CollisionManager.IsCollision(_rectangles[i], _rectangles[j])) continue;

                    CanvasPanel.Controls[i].BackColor =IsCollision;
                    CanvasPanel.Controls[j].BackColor = IsCollision;
                }
            }
        }

        private void ClearRectangleInfo()
        {
            RectangleList.Items.Clear();
            idTextBox.Clear();
            XCoordinateTextBox.Clear();
            YCoordinateTextBox.Clear();
            WidthTextBox.Clear();
            LengthTextBox.Clear();
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int ind = RectangleList.FindString(rectangle.Id.ToString());

            if (ind == -1) return;

            RectangleList.Items[ind] = FormattedText(rectangle);
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

        private void RectangleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectangleList.SelectedItem == null) return;

            int indexSelectedRectangle = RectangleList.SelectedIndex;
            _currentRectangle = _rectangles[indexSelectedRectangle];
            idTextBox.Text = _currentRectangle.Id.ToString();
            XCoordinateTextBox.Text = _currentRectangle.Center.X.ToString();
            YCoordinateTextBox.Text = _currentRectangle.Center.Y.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            LengthTextBox.Text = _currentRectangle.Length.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int indexSelectedRectangle = RectangleList.SelectedIndex;

            if (indexSelectedRectangle == -1) return;

            _rectanglePanels.RemoveAt(indexSelectedRectangle);
            _rectangles.RemoveAt(indexSelectedRectangle);
            ClearRectangleInfo();

            foreach (var rectangle in _rectangles)
            {
                RectangleList.Items.Add(FormattedText(rectangle));
                RectangleList.SelectedIndex = 0;
            }

            CanvasPanel.Controls.RemoveAt(indexSelectedRectangle);
            FindCollisions();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            _currentRectangle = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);
            _rectangles.Add(_currentRectangle);
            RectangleList.Items.Add(FormattedText(_currentRectangle));

            Panel rectanglePanel = CreatePanel();
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);
            FindCollisions();
        }
    }
}