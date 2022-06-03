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
        public RectanglesPanelControl()
        {
            InitializeComponent();
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

    }
}
