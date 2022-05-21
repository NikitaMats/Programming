using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Enums;
using System.Collections.Generic;
using Rectangle = Programming.Model.Rectangle;


namespace Programming.View.Control
{
    public partial class RectanglesControl : UserControl
    {
        private ToolTip _toolTip = new ToolTip();

        private string[] _colors = { "Red", "Black", "Green", "Yellow", "Orange" };

        private Rectangle[] _rectangles;

        private Rectangle _currentRectangle;

        private int _rectanglesAmount = 5;

        private string _errorСolor = "LightPink";

        private string _normalColor = "Window";

        public RectanglesControl()
        {
            InitializeComponent();
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
        }

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

        private void LengthBox_TextChanged(object sender, EventArgs e)
        {
            LengthBox.BackColor = ColorTranslator.FromHtml(_normalColor);
            try
            {
                _currentRectangle.Length = Convert.ToDouble(LengthBox.Text);
                _toolTip.SetToolTip(LengthBox, "");
            }
            catch (Exception exception)
            {
                LengthBox.BackColor = ColorTranslator.FromHtml(_errorСolor);
                _toolTip.SetToolTip(LengthBox, exception.Message);
            }
        }

        private void WidthBox_TextChanged(object sender, EventArgs e)
        {
            WidthBox.BackColor = ColorTranslator.FromHtml(_normalColor);
            try
            {
                _currentRectangle.Width = Convert.ToDouble(WidthBox.Text);
                _toolTip.SetToolTip(WidthBox, "");
            }
            catch (Exception exception)
            {
                WidthBox.BackColor = ColorTranslator.FromHtml(_errorСolor);
                _toolTip.SetToolTip(WidthBox, exception.Message);
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
    }
}
