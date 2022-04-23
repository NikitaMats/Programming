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
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.ParsingFlag = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ValueParsing = new System.Windows.Forms.TextBox();
            this.LabelParsing = new System.Windows.Forms.Label();
            this.EnumGroupBox = new System.Windows.Forms.GroupBox();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.LabelInt = new System.Windows.Forms.Label();
            this.LabelValue = new System.Windows.Forms.Label();
            this.LabelEnumeration = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
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
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
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
            this.Panel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.RectangleList = new System.Windows.Forms.ListBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TabControl.SuspendLayout();
            this.EnamsTabPage.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.FilmGroupBox.SuspendLayout();
            this.RectangleGroupBox.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateButton)).BeginInit();
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
            this.EnamsTabPage.Controls.Add(this.SeasonGroupBox);
            this.EnamsTabPage.Controls.Add(this.WeekdayGroupBox);
            this.EnamsTabPage.Controls.Add(this.EnumGroupBox);
            this.EnamsTabPage.Location = new System.Drawing.Point(4, 25);
            this.EnamsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnamsTabPage.Name = "EnamsTabPage";
            this.EnamsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnamsTabPage.Size = new System.Drawing.Size(792, 378);
            this.EnamsTabPage.TabIndex = 0;
            this.EnamsTabPage.Text = "Enums";
            this.EnamsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonGroupBox.Controls.Add(this.SeasonButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Controls.Add(this.SeasonLabel);
            this.SeasonGroupBox.Location = new System.Drawing.Point(398, 201);
            this.SeasonGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonGroupBox.Size = new System.Drawing.Size(391, 175);
            this.SeasonGroupBox.TabIndex = 2;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(227, 54);
            this.SeasonButton.Margin = new System.Windows.Forms.Padding(4);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(75, 28);
            this.SeasonButton.TabIndex = 6;
            this.SeasonButton.Text = "GO!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(8, 55);
            this.SeasonComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(209, 24);
            this.SeasonComboBox.TabIndex = 5;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(5, 34);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(105, 16);
            this.SeasonLabel.TabIndex = 4;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Controls.Add(this.ParsingFlag);
            this.WeekdayGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayGroupBox.Controls.Add(this.ValueParsing);
            this.WeekdayGroupBox.Controls.Add(this.LabelParsing);
            this.WeekdayGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.WeekdayGroupBox.Location = new System.Drawing.Point(3, 201);
            this.WeekdayGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayGroupBox.Size = new System.Drawing.Size(389, 175);
            this.WeekdayGroupBox.TabIndex = 1;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // ParsingFlag
            // 
            this.ParsingFlag.AutoSize = true;
            this.ParsingFlag.Location = new System.Drawing.Point(11, 78);
            this.ParsingFlag.Name = "ParsingFlag";
            this.ParsingFlag.Size = new System.Drawing.Size(0, 16);
            this.ParsingFlag.TabIndex = 3;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(305, 55);
            this.ParseButton.Margin = new System.Windows.Forms.Padding(4);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 27);
            this.ParseButton.TabIndex = 2;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ValueParsing
            // 
            this.ValueParsing.Location = new System.Drawing.Point(8, 55);
            this.ValueParsing.Margin = new System.Windows.Forms.Padding(4);
            this.ValueParsing.Name = "ValueParsing";
            this.ValueParsing.Size = new System.Drawing.Size(288, 22);
            this.ValueParsing.TabIndex = 1;
            // 
            // LabelParsing
            // 
            this.LabelParsing.AutoSize = true;
            this.LabelParsing.Location = new System.Drawing.Point(7, 34);
            this.LabelParsing.Name = "LabelParsing";
            this.LabelParsing.Size = new System.Drawing.Size(144, 16);
            this.LabelParsing.TabIndex = 0;
            this.LabelParsing.Text = "Type value for parsing:";
            // 
            // EnumGroupBox
            // 
            this.EnumGroupBox.Controls.Add(this.IntTextBox);
            this.EnumGroupBox.Controls.Add(this.LabelInt);
            this.EnumGroupBox.Controls.Add(this.LabelValue);
            this.EnumGroupBox.Controls.Add(this.LabelEnumeration);
            this.EnumGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnumGroupBox.Location = new System.Drawing.Point(3, 2);
            this.EnumGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumGroupBox.Name = "EnumGroupBox";
            this.EnumGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumGroupBox.Size = new System.Drawing.Size(786, 199);
            this.EnumGroupBox.TabIndex = 0;
            this.EnumGroupBox.TabStop = false;
            this.EnumGroupBox.Text = "Enumerations";
            // 
            // IntTextBox
            // 
            this.IntTextBox.Location = new System.Drawing.Point(384, 39);
            this.IntTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.Size = new System.Drawing.Size(131, 22);
            this.IntTextBox.TabIndex = 5;
            // 
            // LabelInt
            // 
            this.LabelInt.AutoSize = true;
            this.LabelInt.Location = new System.Drawing.Point(381, 22);
            this.LabelInt.Name = "LabelInt";
            this.LabelInt.Size = new System.Drawing.Size(59, 16);
            this.LabelInt.TabIndex = 4;
            this.LabelInt.Text = "Int value:";
            // 
            // LabelValue
            // 
            this.LabelValue.AutoSize = true;
            this.LabelValue.Location = new System.Drawing.Point(195, 22);
            this.LabelValue.Name = "LabelValue";
            this.LabelValue.Size = new System.Drawing.Size(93, 16);
            this.LabelValue.TabIndex = 3;
            this.LabelValue.Text = "Choose value:";
            // 
            // LabelEnumeration
            // 
            this.LabelEnumeration.AutoSize = true;
            this.LabelEnumeration.Location = new System.Drawing.Point(7, 22);
            this.LabelEnumeration.Name = "LabelEnumeration";
            this.LabelEnumeration.Size = new System.Drawing.Size(134, 16);
            this.LabelEnumeration.TabIndex = 2;
            this.LabelEnumeration.Text = "Choose enumeration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 16;
            this.ValuesListBox.Location = new System.Drawing.Point(197, 41);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(131, 148);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 16;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Colors",
            "EducationForm",
            "Genre",
            "Season",
            "Smartphones",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(8, 41);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(131, 148);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
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
            this.MovieRatingTextBox.TextChanged += new System.EventHandler(this.MovieRatingTextBox_TextChanged);
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
            this.MovieReleaseTextBox.TextChanged += new System.EventHandler(this.MovieReleaseTextBox_TextChanged);
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
            this.MovieDurationTextBox.TextChanged += new System.EventHandler(this.MovieDuretionTextBox_TextChanged);
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
            this.MovieGenreTextBox.TextChanged += new System.EventHandler(this.MovieGenreTextBox_TextChanged);
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
            this.MovieNameTextBox.TextChanged += new System.EventHandler(this.MovieNameTextBox_TextChanged);
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
            this.FindMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
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
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // RectangleGroupBox
            // 
            this.RectangleGroupBox.Controls.Add(this.CollisionLable);
            this.RectangleGroupBox.Controls.Add(this.IdRectangle);
            this.RectangleGroupBox.Controls.Add(this.Ycoordinate);
            this.RectangleGroupBox.Controls.Add(this.label10);
            this.RectangleGroupBox.Controls.Add(this.label9);
            this.RectangleGroupBox.Controls.Add(this.Xcoordinate);
            this.RectangleGroupBox.Controls.Add(this.FindRectangleButton);
            this.RectangleGroupBox.Controls.Add(this.ColorTextBox);
            this.RectangleGroupBox.Controls.Add(this.label3);
            this.RectangleGroupBox.Controls.Add(this.WidthBox);
            this.RectangleGroupBox.Controls.Add(this.label2);
            this.RectangleGroupBox.Controls.Add(this.LengthBox);
            this.RectangleGroupBox.Controls.Add(this.label1);
            this.RectangleGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectangleGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.RectangleGroupBox.Location = new System.Drawing.Point(3, 2);
            this.RectangleGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectangleGroupBox.Name = "RectangleGroupBox";
            this.RectangleGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectangleGroupBox.Size = new System.Drawing.Size(389, 374);
            this.RectangleGroupBox.TabIndex = 0;
            this.RectangleGroupBox.TabStop = false;
            this.RectangleGroupBox.Text = "Rectangles";
            // 
            // CollisionLable
            // 
            this.CollisionLable.AutoSize = true;
            this.CollisionLable.Location = new System.Drawing.Point(245, 295);
            this.CollisionLable.Name = "CollisionLable";
            this.CollisionLable.Size = new System.Drawing.Size(61, 16);
            this.CollisionLable.TabIndex = 13;
            this.CollisionLable.Text = "Collision:";
            // 
            // IdRectangle
            // 
            this.IdRectangle.AutoSize = true;
            this.IdRectangle.Location = new System.Drawing.Point(185, 295);
            this.IdRectangle.Name = "IdRectangle";
            this.IdRectangle.Size = new System.Drawing.Size(21, 16);
            this.IdRectangle.TabIndex = 12;
            this.IdRectangle.Text = "id:";
            // 
            // Ycoordinate
            // 
            this.Ycoordinate.Location = new System.Drawing.Point(185, 263);
            this.Ycoordinate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ycoordinate.Name = "Ycoordinate";
            this.Ycoordinate.Size = new System.Drawing.Size(160, 22);
            this.Ycoordinate.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(188, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Y:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "X:";
            // 
            // Xcoordinate
            // 
            this.Xcoordinate.Location = new System.Drawing.Point(185, 208);
            this.Xcoordinate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Xcoordinate.Name = "Xcoordinate";
            this.Xcoordinate.Size = new System.Drawing.Size(160, 22);
            this.Xcoordinate.TabIndex = 8;
            // 
            // FindRectangleButton
            // 
            this.FindRectangleButton.Location = new System.Drawing.Point(8, 336);
            this.FindRectangleButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindRectangleButton.Name = "FindRectangleButton";
            this.FindRectangleButton.Size = new System.Drawing.Size(100, 23);
            this.FindRectangleButton.TabIndex = 7;
            this.FindRectangleButton.Text = "Find";
            this.FindRectangleButton.UseVisualStyleBackColor = true;
            this.FindRectangleButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(185, 153);
            this.ColorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(160, 22);
            this.ColorTextBox.TabIndex = 6;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color:";
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(185, 98);
            this.WidthBox.Margin = new System.Windows.Forms.Padding(4);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(160, 22);
            this.WidthBox.TabIndex = 4;
            this.WidthBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width:";
            // 
            // LengthBox
            // 
            this.LengthBox.Location = new System.Drawing.Point(185, 44);
            this.LengthBox.Margin = new System.Windows.Forms.Padding(4);
            this.LengthBox.Name = "LengthBox";
            this.LengthBox.Size = new System.Drawing.Size(160, 22);
            this.LengthBox.TabIndex = 2;
            this.LengthBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Length:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 16;
            this.RectanglesListBox.Location = new System.Drawing.Point(8, 25);
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(168, 308);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.DeleteButton);
            this.RectanglesTabPage.Controls.Add(this.CreateButton);
            this.RectanglesTabPage.Controls.Add(this.label17);
            this.RectanglesTabPage.Controls.Add(this.label16);
            this.RectanglesTabPage.Controls.Add(this.label15);
            this.RectanglesTabPage.Controls.Add(this.label14);
            this.RectanglesTabPage.Controls.Add(this.label13);
            this.RectanglesTabPage.Controls.Add(this.LengthTextBox);
            this.RectanglesTabPage.Controls.Add(this.WidthTextBox);
            this.RectanglesTabPage.Controls.Add(this.YCoordinateTextBox);
            this.RectanglesTabPage.Controls.Add(this.XCoordinateTextBox);
            this.RectanglesTabPage.Controls.Add(this.label12);
            this.RectanglesTabPage.Controls.Add(this.idTextBox);
            this.RectanglesTabPage.Controls.Add(this.Panel);
            this.RectanglesTabPage.Controls.Add(this.label11);
            this.RectanglesTabPage.Controls.Add(this.RectangleList);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 25);
            this.RectanglesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesTabPage.Size = new System.Drawing.Size(792, 378);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackgroundImage = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DeleteButton.Location = new System.Drawing.Point(183, 166);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 43);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.MouseLeave += new System.EventHandler(this.DeleteButton_MouseLeave);
            this.DeleteButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeleteButton_MouseMove);
            // 
            // CreateButton
            // 
            this.CreateButton.BackgroundImage = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.CreateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CreateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateButton.Location = new System.Drawing.Point(31, 165);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(100, 43);
            this.CreateButton.TabIndex = 15;
            this.CreateButton.TabStop = false;
            this.CreateButton.MouseLeave += new System.EventHandler(this.CreateButton_MouseLeave);
            this.CreateButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreateButton_MouseMove);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 345);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 16);
            this.label17.TabIndex = 14;
            this.label17.Text = "Length:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 316);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 16);
            this.label16.TabIndex = 12;
            this.label16.Text = "Width:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(59, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 16);
            this.label15.TabIndex = 13;
            this.label15.Text = "Y:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "X:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "Id:";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(84, 341);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(113, 22);
            this.LengthTextBox.TabIndex = 10;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(84, 313);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(113, 22);
            this.WidthTextBox.TabIndex = 7;
            // 
            // YCoordinateTextBox
            // 
            this.YCoordinateTextBox.Location = new System.Drawing.Point(84, 286);
            this.YCoordinateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YCoordinateTextBox.Name = "YCoordinateTextBox";
            this.YCoordinateTextBox.Size = new System.Drawing.Size(113, 22);
            this.YCoordinateTextBox.TabIndex = 9;
            // 
            // XCoordinateTextBox
            // 
            this.XCoordinateTextBox.Location = new System.Drawing.Point(84, 257);
            this.XCoordinateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XCoordinateTextBox.Name = "XCoordinateTextBox";
            this.XCoordinateTextBox.Size = new System.Drawing.Size(113, 22);
            this.XCoordinateTextBox.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Selected Rectangle:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(84, 229);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(113, 22);
            this.idTextBox.TabIndex = 6;
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Location = new System.Drawing.Point(320, 2);
            this.Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(469, 374);
            this.Panel.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Rectangles:";
            // 
            // RectangleList
            // 
            this.RectangleList.FormattingEnabled = true;
            this.RectangleList.ItemHeight = 16;
            this.RectangleList.Location = new System.Drawing.Point(11, 27);
            this.RectangleList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectangleList.Name = "RectangleList";
            this.RectangleList.Size = new System.Drawing.Size(293, 132);
            this.RectangleList.TabIndex = 0;
            // 
            // ToolTip
            // 
            this.ToolTip.ShowAlways = true;
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
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
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.EnumGroupBox.ResumeLayout(false);
            this.EnumGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.FilmGroupBox.ResumeLayout(false);
            this.FilmGroupBox.PerformLayout();
            this.RectangleGroupBox.ResumeLayout(false);
            this.RectangleGroupBox.PerformLayout();
            this.RectanglesTabPage.ResumeLayout(false);
            this.RectanglesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage EnamsTabPage;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox EnumGroupBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.TextBox IntTextBox;
        private System.Windows.Forms.Label LabelInt;
        private System.Windows.Forms.Label LabelValue;
        private System.Windows.Forms.Label LabelEnumeration;
        private System.Windows.Forms.GroupBox WeekdayGroupBox;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox ValueParsing;
        private System.Windows.Forms.Label LabelParsing;
        private System.Windows.Forms.Label ParsingFlag;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.GroupBox RectangleGroupBox;
        private System.Windows.Forms.GroupBox FilmGroupBox;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LengthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Button FindRectangleButton;
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
        private System.Windows.Forms.TextBox Ycoordinate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Xcoordinate;
        private System.Windows.Forms.Label IdRectangle;
        private System.Windows.Forms.Label CollisionLable;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private System.Windows.Forms.ListBox RectangleList;
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
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox CreateButton;
        private System.Windows.Forms.PictureBox DeleteButton;
    }
}

