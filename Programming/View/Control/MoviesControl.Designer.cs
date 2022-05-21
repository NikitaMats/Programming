namespace Programming.View.Control
{
    partial class MoviesControl
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
            this.MovieRatingTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MovieReleaseTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MovieDurationTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MovieGenreTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MovieNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FindMovieButton = new System.Windows.Forms.Button();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // MovieRatingTextBox
            // 
            this.MovieRatingTextBox.Location = new System.Drawing.Point(191, 253);
            this.MovieRatingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieRatingTextBox.Name = "MovieRatingTextBox";
            this.MovieRatingTextBox.Size = new System.Drawing.Size(160, 22);
            this.MovieRatingTextBox.TabIndex = 30;
            this.MovieRatingTextBox.TextChanged += new System.EventHandler(this.MovieRatingTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 232);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Rating:";
            // 
            // MovieReleaseTextBox
            // 
            this.MovieReleaseTextBox.Location = new System.Drawing.Point(191, 198);
            this.MovieReleaseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieReleaseTextBox.Name = "MovieReleaseTextBox";
            this.MovieReleaseTextBox.Size = new System.Drawing.Size(160, 22);
            this.MovieReleaseTextBox.TabIndex = 28;
            this.MovieReleaseTextBox.TextChanged += new System.EventHandler(this.MovieReleaseTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Release Year:";
            // 
            // MovieDurationTextBox
            // 
            this.MovieDurationTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MovieDurationTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MovieDurationTextBox.Location = new System.Drawing.Point(191, 143);
            this.MovieDurationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieDurationTextBox.Name = "MovieDurationTextBox";
            this.MovieDurationTextBox.Size = new System.Drawing.Size(160, 22);
            this.MovieDurationTextBox.TabIndex = 26;
            this.MovieDurationTextBox.TextChanged += new System.EventHandler(this.MovieDurationTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Duration in Minutes:";
            // 
            // MovieGenreTextBox
            // 
            this.MovieGenreTextBox.Location = new System.Drawing.Point(191, 88);
            this.MovieGenreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieGenreTextBox.Name = "MovieGenreTextBox";
            this.MovieGenreTextBox.Size = new System.Drawing.Size(160, 22);
            this.MovieGenreTextBox.TabIndex = 24;
            this.MovieGenreTextBox.TextChanged += new System.EventHandler(this.MovieGenreTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Genre:";
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.Location = new System.Drawing.Point(191, 34);
            this.MovieNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.MovieNameTextBox.TabIndex = 22;
            this.MovieNameTextBox.TextChanged += new System.EventHandler(this.MovieNameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Name:";
            // 
            // FindMovieButton
            // 
            this.FindMovieButton.Location = new System.Drawing.Point(14, 326);
            this.FindMovieButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindMovieButton.Name = "FindMovieButton";
            this.FindMovieButton.Size = new System.Drawing.Size(100, 23);
            this.FindMovieButton.TabIndex = 20;
            this.FindMovieButton.Text = "Find";
            this.FindMovieButton.UseVisualStyleBackColor = true;
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 16;
            this.MoviesListBox.Location = new System.Drawing.Point(14, 15);
            this.MoviesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(168, 308);
            this.MoviesListBox.TabIndex = 19;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MovieRatingTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MovieReleaseTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MovieDurationTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MovieGenreTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MovieNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FindMovieButton);
            this.Controls.Add(this.MoviesListBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(366, 362);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MovieRatingTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MovieReleaseTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MovieDurationTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MovieGenreTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MovieNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FindMovieButton;
        private System.Windows.Forms.ListBox MoviesListBox;
    }
}
