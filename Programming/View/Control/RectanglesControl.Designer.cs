namespace Programming.View.Control
{
    partial class RectanglesControl
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
            this.CollisionLable = new System.Windows.Forms.Label();
            this.IdRectangle = new System.Windows.Forms.Label();
            this.Ycoordinate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Xcoordinate = new System.Windows.Forms.TextBox();
            this.FindRectangleButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LengthBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CollisionLable
            // 
            this.CollisionLable.AutoSize = true;
            this.CollisionLable.Location = new System.Drawing.Point(250, 283);
            this.CollisionLable.Name = "CollisionLable";
            this.CollisionLable.Size = new System.Drawing.Size(61, 16);
            this.CollisionLable.TabIndex = 27;
            this.CollisionLable.Text = "Collision:";
            // 
            // IdRectangle
            // 
            this.IdRectangle.AutoSize = true;
            this.IdRectangle.Location = new System.Drawing.Point(190, 283);
            this.IdRectangle.Name = "IdRectangle";
            this.IdRectangle.Size = new System.Drawing.Size(21, 16);
            this.IdRectangle.TabIndex = 26;
            this.IdRectangle.Text = "id:";
            // 
            // Ycoordinate
            // 
            this.Ycoordinate.Location = new System.Drawing.Point(190, 251);
            this.Ycoordinate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ycoordinate.Name = "Ycoordinate";
            this.Ycoordinate.Size = new System.Drawing.Size(160, 22);
            this.Ycoordinate.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Y:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(192, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "X:";
            // 
            // Xcoordinate
            // 
            this.Xcoordinate.Location = new System.Drawing.Point(190, 196);
            this.Xcoordinate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Xcoordinate.Name = "Xcoordinate";
            this.Xcoordinate.Size = new System.Drawing.Size(160, 22);
            this.Xcoordinate.TabIndex = 22;
            // 
            // FindRectangleButton
            // 
            this.FindRectangleButton.Location = new System.Drawing.Point(13, 324);
            this.FindRectangleButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindRectangleButton.Name = "FindRectangleButton";
            this.FindRectangleButton.Size = new System.Drawing.Size(100, 23);
            this.FindRectangleButton.TabIndex = 21;
            this.FindRectangleButton.Text = "Find";
            this.FindRectangleButton.UseVisualStyleBackColor = true;
            this.FindRectangleButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(190, 141);
            this.ColorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(160, 22);
            this.ColorTextBox.TabIndex = 20;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Color:";
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(190, 86);
            this.WidthBox.Margin = new System.Windows.Forms.Padding(4);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(160, 22);
            this.WidthBox.TabIndex = 18;
            this.WidthBox.TextChanged += new System.EventHandler(this.WidthBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Width:";
            // 
            // LengthBox
            // 
            this.LengthBox.Location = new System.Drawing.Point(190, 32);
            this.LengthBox.Margin = new System.Windows.Forms.Padding(4);
            this.LengthBox.Name = "LengthBox";
            this.LengthBox.Size = new System.Drawing.Size(160, 22);
            this.LengthBox.TabIndex = 16;
            this.LengthBox.TextChanged += new System.EventHandler(this.LengthBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Length:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 16;
            this.RectanglesListBox.Location = new System.Drawing.Point(13, 13);
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(168, 308);
            this.RectanglesListBox.TabIndex = 14;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CollisionLable);
            this.Controls.Add(this.IdRectangle);
            this.Controls.Add(this.Ycoordinate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Xcoordinate);
            this.Controls.Add(this.FindRectangleButton);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LengthBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RectanglesListBox);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(359, 351);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CollisionLable;
        private System.Windows.Forms.Label IdRectangle;
        private System.Windows.Forms.TextBox Ycoordinate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Xcoordinate;
        private System.Windows.Forms.Button FindRectangleButton;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LengthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox RectanglesListBox;
    }
}
