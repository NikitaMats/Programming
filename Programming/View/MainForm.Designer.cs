namespace Programming.View
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.EnamsTabPage = new System.Windows.Forms.TabPage();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.enumerationsControl1 = new Programming.View.Control.EnumerationsControl();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.seasonControl1 = new Programming.View.Control.SeasonControl();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.weekdayControl1 = new Programming.View.Control.WeekdayControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.FilmGroupBox = new System.Windows.Forms.GroupBox();
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
            this.RectangleGroupBox = new System.Windows.Forms.GroupBox();
            this.rectanglesControl1 = new Programming.View.Control.RectanglesControl();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.rectanglesPanelControl1 = new Programming.View.Control.RectanglesPanelControl();
            this.TabControl.SuspendLayout();
            this.EnamsTabPage.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.FilmGroupBox.SuspendLayout();
            this.RectangleGroupBox.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnamsTabPage);
            this.TabControl.Controls.Add(this.ClassesTabPage);
            this.TabControl.Controls.Add(this.RectanglesTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 407);
            this.TabControl.TabIndex = 0;
            // 
            // EnamsTabPage
            // 
            this.EnamsTabPage.Controls.Add(this.EnumerationsGroupBox);
            this.EnamsTabPage.Controls.Add(this.SeasonGroupBox);
            this.EnamsTabPage.Controls.Add(this.WeekdayGroupBox);
            this.EnamsTabPage.Location = new System.Drawing.Point(4, 25);
            this.EnamsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnamsTabPage.Name = "EnamsTabPage";
            this.EnamsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnamsTabPage.Size = new System.Drawing.Size(792, 378);
            this.EnamsTabPage.TabIndex = 0;
            this.EnamsTabPage.Text = "Enums";
            this.EnamsTabPage.UseVisualStyleBackColor = true;
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumerationsGroupBox.Controls.Add(this.enumerationsControl1);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(3, 2);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(786, 194);
            this.EnumerationsGroupBox.TabIndex = 3;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // enumerationsControl1
            // 
            this.enumerationsControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enumerationsControl1.Location = new System.Drawing.Point(3, 18);
            this.enumerationsControl1.Name = "enumerationsControl1";
            this.enumerationsControl1.Size = new System.Drawing.Size(780, 173);
            this.enumerationsControl1.TabIndex = 0;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonGroupBox.Controls.Add(this.seasonControl1);
            this.SeasonGroupBox.Location = new System.Drawing.Point(401, 201);
            this.SeasonGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonGroupBox.Size = new System.Drawing.Size(388, 175);
            this.SeasonGroupBox.TabIndex = 2;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // seasonControl1
            // 
            this.seasonControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seasonControl1.Location = new System.Drawing.Point(3, 17);
            this.seasonControl1.Name = "seasonControl1";
            this.seasonControl1.Size = new System.Drawing.Size(382, 156);
            this.seasonControl1.TabIndex = 0;
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WeekdayGroupBox.Controls.Add(this.weekdayControl1);
            this.WeekdayGroupBox.Location = new System.Drawing.Point(3, 201);
            this.WeekdayGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayGroupBox.Size = new System.Drawing.Size(395, 175);
            this.WeekdayGroupBox.TabIndex = 1;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // weekdayControl1
            // 
            this.weekdayControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayControl1.Location = new System.Drawing.Point(3, 17);
            this.weekdayControl1.Name = "weekdayControl1";
            this.weekdayControl1.Size = new System.Drawing.Size(389, 156);
            this.weekdayControl1.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClassesTabPage.Controls.Add(this.FilmGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectangleGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 25);
            this.ClassesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesTabPage.Size = new System.Drawing.Size(792, 378);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // FilmGroupBox
            // 
            this.FilmGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilmGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FilmGroupBox.Controls.Add(this.MovieRatingTextBox);
            this.FilmGroupBox.Controls.Add(this.label8);
            this.FilmGroupBox.Controls.Add(this.MovieReleaseTextBox);
            this.FilmGroupBox.Controls.Add(this.label7);
            this.FilmGroupBox.Controls.Add(this.MovieDurationTextBox);
            this.FilmGroupBox.Controls.Add(this.label6);
            this.FilmGroupBox.Controls.Add(this.MovieGenreTextBox);
            this.FilmGroupBox.Controls.Add(this.label5);
            this.FilmGroupBox.Controls.Add(this.MovieNameTextBox);
            this.FilmGroupBox.Controls.Add(this.label4);
            this.FilmGroupBox.Controls.Add(this.FindMovieButton);
            this.FilmGroupBox.Controls.Add(this.MoviesListBox);
            this.FilmGroupBox.Location = new System.Drawing.Point(401, 2);
            this.FilmGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.FilmGroupBox.Name = "FilmGroupBox";
            this.FilmGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.FilmGroupBox.Size = new System.Drawing.Size(388, 374);
            this.FilmGroupBox.TabIndex = 1;
            this.FilmGroupBox.TabStop = false;
            this.FilmGroupBox.Text = "Movies";
            // 
            // MovieRatingTextBox
            // 
            this.MovieRatingTextBox.Location = new System.Drawing.Point(185, 263);
            this.MovieRatingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieRatingTextBox.Name = "MovieRatingTextBox";
            this.MovieRatingTextBox.Size = new System.Drawing.Size(160, 22);
            this.MovieRatingTextBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 242);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Rating:";
            // 
            // MovieReleaseTextBox
            // 
            this.MovieReleaseTextBox.Location = new System.Drawing.Point(185, 208);
            this.MovieReleaseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieReleaseTextBox.Name = "MovieReleaseTextBox";
            this.MovieReleaseTextBox.Size = new System.Drawing.Size(160, 22);
            this.MovieReleaseTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Release Year:";
            // 
            // MovieDurationTextBox
            // 
            this.MovieDurationTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MovieDurationTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MovieDurationTextBox.Location = new System.Drawing.Point(185, 153);
            this.MovieDurationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieDurationTextBox.Name = "MovieDurationTextBox";
            this.MovieDurationTextBox.Size = new System.Drawing.Size(160, 22);
            this.MovieDurationTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Duration in Minutes:";
            // 
            // MovieGenreTextBox
            // 
            this.MovieGenreTextBox.Location = new System.Drawing.Point(185, 98);
            this.MovieGenreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieGenreTextBox.Name = "MovieGenreTextBox";
            this.MovieGenreTextBox.Size = new System.Drawing.Size(160, 22);
            this.MovieGenreTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Genre:";
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.Location = new System.Drawing.Point(185, 44);
            this.MovieNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.MovieNameTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name:";
            // 
            // FindMovieButton
            // 
            this.FindMovieButton.Location = new System.Drawing.Point(8, 336);
            this.FindMovieButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindMovieButton.Name = "FindMovieButton";
            this.FindMovieButton.Size = new System.Drawing.Size(100, 23);
            this.FindMovieButton.TabIndex = 8;
            this.FindMovieButton.Text = "Find";
            this.FindMovieButton.UseVisualStyleBackColor = true;
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 16;
            this.MoviesListBox.Location = new System.Drawing.Point(8, 25);
            this.MoviesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(168, 308);
            this.MoviesListBox.TabIndex = 0;
            // 
            // RectangleGroupBox
            // 
            this.RectangleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangleGroupBox.Controls.Add(this.rectanglesControl1);
            this.RectangleGroupBox.Location = new System.Drawing.Point(3, 2);
            this.RectangleGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectangleGroupBox.Name = "RectangleGroupBox";
            this.RectangleGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectangleGroupBox.Size = new System.Drawing.Size(389, 374);
            this.RectangleGroupBox.TabIndex = 0;
            this.RectangleGroupBox.TabStop = false;
            this.RectangleGroupBox.Text = "Rectangles";
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesControl1.Location = new System.Drawing.Point(3, 17);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(383, 355);
            this.rectanglesControl1.TabIndex = 0;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.rectanglesPanelControl1);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 25);
            this.RectanglesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesTabPage.Size = new System.Drawing.Size(792, 378);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // ToolTip
            // 
            this.ToolTip.ShowAlways = true;
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            // 
            // rectanglesPanelControl1
            // 
            this.rectanglesPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesPanelControl1.Location = new System.Drawing.Point(3, 2);
            this.rectanglesPanelControl1.Name = "rectanglesPanelControl1";
            this.rectanglesPanelControl1.Size = new System.Drawing.Size(786, 374);
            this.rectanglesPanelControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.TabControl.ResumeLayout(false);
            this.EnamsTabPage.ResumeLayout(false);
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.FilmGroupBox.ResumeLayout(false);
            this.FilmGroupBox.PerformLayout();
            this.RectangleGroupBox.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage EnamsTabPage;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox WeekdayGroupBox;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.GroupBox RectangleGroupBox;
        private System.Windows.Forms.GroupBox FilmGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FindMovieButton;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MovieNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MovieGenreTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MovieDurationTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MovieReleaseTextBox;
        private System.Windows.Forms.TextBox MovieRatingTextBox;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private Control.EnumerationsControl enumerationsControl1;
        private Control.WeekdayControl weekdayControl1;
        private Control.SeasonControl seasonControl1;
        private Control.RectanglesControl rectanglesControl1;
        private Control.RectanglesPanelControl rectanglesPanelControl1;
    }
}

