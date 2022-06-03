namespace Programming.View.Control
{
    partial class RectanglesPanelControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteButton = new System.Windows.Forms.PictureBox();
            this.CreateButton = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.YCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.XCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.RectangleList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateButton)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackgroundImage = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DeleteButton.Location = new System.Drawing.Point(182, 166);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 43);
            this.DeleteButton.TabIndex = 32;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            this.DeleteButton.MouseLeave += new System.EventHandler(this.DeleteButton_MouseLeave);
            this.DeleteButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeleteButton_MouseMove);
            // 
            // CreateButton
            // 
            this.CreateButton.BackgroundImage = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.CreateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CreateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateButton.Location = new System.Drawing.Point(30, 165);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(100, 43);
            this.CreateButton.TabIndex = 31;
            this.CreateButton.TabStop = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            this.CreateButton.MouseLeave += new System.EventHandler(this.CreateButton_MouseLeave);
            this.CreateButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreateButton_MouseMove);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 345);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "Length:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 316);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 16);
            this.label16.TabIndex = 27;
            this.label16.Text = "Width:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(58, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "Y:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(59, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "X:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(56, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Id:";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(83, 341);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(113, 22);
            this.LengthTextBox.TabIndex = 25;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(83, 313);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(113, 22);
            this.WidthTextBox.TabIndex = 21;
            // 
            // YCoordinateTextBox
            // 
            this.YCoordinateTextBox.Location = new System.Drawing.Point(83, 286);
            this.YCoordinateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YCoordinateTextBox.Name = "YCoordinateTextBox";
            this.YCoordinateTextBox.Size = new System.Drawing.Size(113, 22);
            this.YCoordinateTextBox.TabIndex = 24;
            // 
            // XCoordinateTextBox
            // 
            this.XCoordinateTextBox.Location = new System.Drawing.Point(83, 257);
            this.XCoordinateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XCoordinateTextBox.Name = "XCoordinateTextBox";
            this.XCoordinateTextBox.Size = new System.Drawing.Size(113, 22);
            this.XCoordinateTextBox.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Selected Rectangle:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(83, 229);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(113, 22);
            this.idTextBox.TabIndex = 20;
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CanvasPanel.Location = new System.Drawing.Point(322, 0);
            this.CanvasPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(454, 387);
            this.CanvasPanel.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Rectangles:";
            // 
            // RectangleList
            // 
            this.RectangleList.FormattingEnabled = true;
            this.RectangleList.ItemHeight = 16;
            this.RectangleList.Location = new System.Drawing.Point(10, 27);
            this.RectangleList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectangleList.Name = "RectangleList";
            this.RectangleList.Size = new System.Drawing.Size(293, 132);
            this.RectangleList.TabIndex = 17;
            this.RectangleList.SelectedIndexChanged += new System.EventHandler(this.RectangleList_SelectedIndexChanged);
            // 
            // RectanglesPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.YCoordinateTextBox);
            this.Controls.Add(this.XCoordinateTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RectangleList);
            this.Name = "RectanglesPanelControl";
            this.Size = new System.Drawing.Size(776, 387);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DeleteButton;
        private System.Windows.Forms.PictureBox CreateButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox YCoordinateTextBox;
        private System.Windows.Forms.TextBox XCoordinateTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox RectangleList;
    }
}
