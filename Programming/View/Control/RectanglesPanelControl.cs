using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Enums;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View.Control
{
    public partial class RectanglesPanelControl : UserControl
    {
        private List<Rectangle> _rectangles = new List<Rectangle>();

        private List<Panel> _rectanglePanels = new List<Panel>();

        private Rectangle _currentRectangle = new Rectangle();

        private static Random _random;

        public RectanglesPanelControl()
        {
            InitializeComponent();
        }
        
        public static Rectangle Randomize(int widthCanvas, int heightCanvas)
        {
            var colors = Enum.GetValues(typeof(Colors));
            Rectangle rectangle = new Rectangle();
            rectangle.Width = _random.Next(30, 100);
            rectangle.Length = _random.Next(30, 100);
            rectangle.Center = new Point2D(_random.Next(15, widthCanvas - rectangle.Width - 15),
                                           _random.Next(15, heightCanvas - rectangle.Height - 15));
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
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

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            _currentRectangle = Rectangle.Randomize(CanvasPanel.Width, CanvasPanel.Height);
        }
    }
}
