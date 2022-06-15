using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Geometry;
using Programming.Properties;
using Rectangle = Programming.Model.Geometry.Rectangle;


namespace Programming.View.Control
{
    /// <summary>
    /// Предоставляет реализацию по проверке пересечения прямоугольников.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {

        /// <summary>
        /// Коллекция прямоугольников.
        /// </summary>
        private List<Rectangle> _rectangles;

        /// <summary>
        /// Коллекция отображаемых прямоугольников.
        /// </summary>
        private List<Panel> _rectanglePanels;

        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Цвет прямоугольника без пересечений.
        /// </summary>
        private static Color NotCollision = Color.LightGreen;

        /// <summary>
        /// Цвет пересекающихся прямоугольников.
        /// </summary>
        private static Color Collision = Color.LightPink;

        /// <summary>
        /// Цвет ошибки.
        /// </summary>
        private static Color ErrorColor = Color.LightPink;

        /// <summary>
        /// Цвет отсутствия ошибки.
        /// </summary>
        private static Color CorrectColor = Color.White;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RectanglesCollisionControl"/>.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();
            _rectangles = new List<Rectangle>();
            _rectanglePanels = new List<Panel>();
        }
        
        /// <summary>
        /// Создает новый прямоугольник на панели.
        /// </summary>
        /// <returns> Новую панель в качестве прямоугольника.</returns>
        private Panel CreatePanel()
        {
            Panel panel = new Panel();
            panel.Width = (int)_currentRectangle.Width;
            panel.Height = (int)_currentRectangle.Length;
            panel.Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            panel.BackColor = NotCollision;

            return panel;
        }

        /// <summary>
        /// Преобразует параметры прямоугольника в текст для ListBox.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        /// <returns>Возвращает форматированный текст.</returns>
        private string FormattedText(Rectangle rectangle)
        {
            return $"{rectangle.Id}: " 
                    + $"(X: {rectangle.Center.X};" 
                    + $" Y: {rectangle.Center.Y};" 
                    + $" W: {rectangle.Width};" 
                    + $" H: {rectangle.Length})";
        }

        /// <summary>
        /// Находит пересекающиеся прямоугольники и перекрашивает их.
        /// </summary>
        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                CanvasPanel.Controls[i].BackColor = NotCollision;
            }

            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (!CollisionManager.IsCollision(_rectangles[i], _rectangles[j])) continue;

                    CanvasPanel.Controls[i].BackColor =Collision;
                    CanvasPanel.Controls[j].BackColor = Collision;
                }
            }
        }

        /// <summary>
        /// Очищает информацию с текстовых полей и со списка.
        /// </summary>
        private void ClearRectangleInfo()
        {
            RectangleListBox.Items.Clear();
            idTextBox.Clear();
            XCoordinateTextBox.Clear();
            YCoordinateTextBox.Clear();
            WidthTextBox.Clear();
            LengthTextBox.Clear();
        }

        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int ind = RectangleListBox.FindString(rectangle.Id.ToString());

            if (ind == -1) return;

            RectangleListBox.Items[ind] = FormattedText(rectangle);
        }


        private void CreateButton_MouseMove(object sender, MouseEventArgs e)
        {
            CreateButton.BackgroundImage = Resources.rectangle_add_24x24;
        }

        private void CreateButton_MouseLeave(object sender, EventArgs e)
        {
            CreateButton.BackgroundImage = Resources.rectangle_add_24x24_uncolor;
        }

        private void DeleteButton_MouseMove(object sender, MouseEventArgs e)
        {
            DeleteButton.BackgroundImage = Resources.rectangle_remove_24x24;
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.BackgroundImage = Resources.rectangle_remove_24x24_uncolor;
        }

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedItem == null) return;

            int indexSelectedRectangle = RectangleListBox.SelectedIndex;
            _currentRectangle = _rectangles[indexSelectedRectangle];
            idTextBox.Text = _currentRectangle.Id.ToString();
            XCoordinateTextBox.Text = _currentRectangle.Center.X.ToString();
            YCoordinateTextBox.Text = _currentRectangle.Center.Y.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            LengthTextBox.Text = _currentRectangle.Length.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int indexSelectedRectangle = RectangleListBox.SelectedIndex;

            if (indexSelectedRectangle == -1) return;

            _rectanglePanels.RemoveAt(indexSelectedRectangle);
            _rectangles.RemoveAt(indexSelectedRectangle);
            ClearRectangleInfo();

            foreach (var rectangle in _rectangles)
            {
                RectangleListBox.Items.Add(FormattedText(rectangle));
                RectangleListBox.SelectedIndex = 0;
            }

            CanvasPanel.Controls.RemoveAt(indexSelectedRectangle);
            FindCollisions();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            _currentRectangle = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);
            _rectangles.Add(_currentRectangle);
            RectangleListBox.Items.Add(FormattedText(_currentRectangle));

            Panel rectanglePanel = CreatePanel();
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);
            FindCollisions();
        }
        private void XCoordinateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedIndex == -1) return;

            try
            {
                string currentXRectangle = XCoordinateTextBox.Text;
                int xRectangleValue = int.Parse(currentXRectangle);
                _currentRectangle.Center.X = xRectangleValue;
                CanvasPanel.Controls[RectangleListBox.SelectedIndex].Location =
                    new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                XCoordinateTextBox.BackColor = ErrorColor;
                return;
            }

            XCoordinateTextBox.BackColor = CorrectColor;
        }

        private void YCoordinateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedIndex == -1) return;

            try
            {
                string currentYRectangle = YCoordinateTextBox.Text;
                int yRectangleValue = int.Parse(currentYRectangle);
                _currentRectangle.Center.Y = yRectangleValue;
                CanvasPanel.Controls[RectangleListBox.SelectedIndex].Location =
                    new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                YCoordinateTextBox.BackColor = ErrorColor;
                return;
            }

            YCoordinateTextBox.BackColor = CorrectColor;
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedIndex == -1) return;

            try
            {
                string currentWidthRectangle = WidthTextBox.Text;
                int widthRectangleValue = int.Parse(currentWidthRectangle);
                _currentRectangle.Width = widthRectangleValue;
                CanvasPanel.Controls[RectangleListBox.SelectedIndex].Width = (int)_currentRectangle.Width;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                WidthTextBox.BackColor = ErrorColor;
                return;
            }
            WidthTextBox.BackColor = CorrectColor;
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedIndex == -1) return;

            try
            {
                string currentHeightRectangle = LengthTextBox.Text;
                int heightRectangleValue = int.Parse(currentHeightRectangle);
                _currentRectangle.Length = heightRectangleValue;
                CanvasPanel.Controls[RectangleListBox.SelectedIndex].Height = (int)_currentRectangle.Length;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                LengthTextBox.BackColor = ErrorColor;
                return;
            }
            LengthTextBox.BackColor = CorrectColor;
        }
    }
}