﻿namespace Programming.View
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
            this.FilmRatingTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FilmReleaseTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FilmDurationTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FilmGenreTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FilmNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FindFilmButton = new System.Windows.Forms.Button();
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.RectangleGroupBox = new System.Windows.Forms.GroupBox();
            this.FindRectangleButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LenghtTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RectangleListBox = new System.Windows.Forms.ListBox();
            this.TabPage = new System.Windows.Forms.TabPage();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TabControl.SuspendLayout();
            this.EnamsTabPage.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.FilmGroupBox.SuspendLayout();
            this.RectangleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnamsTabPage);
            this.TabControl.Controls.Add(this.ClassesTabPage);
            this.TabControl.Controls.Add(this.TabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 399);
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
            this.EnamsTabPage.Size = new System.Drawing.Size(792, 370);
            this.EnamsTabPage.TabIndex = 0;
            this.EnamsTabPage.Text = "Enums";
            this.EnamsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.SeasonButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Controls.Add(this.SeasonLabel);
            this.SeasonGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.SeasonGroupBox.Location = new System.Drawing.Point(400, 201);
            this.SeasonGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonGroupBox.Size = new System.Drawing.Size(389, 167);
            this.SeasonGroupBox.TabIndex = 2;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(225, 52);
            this.SeasonButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.SeasonComboBox.Location = new System.Drawing.Point(9, 53);
            this.SeasonComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(209, 24);
            this.SeasonComboBox.TabIndex = 5;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(5, 33);
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
            this.WeekdayGroupBox.Size = new System.Drawing.Size(389, 167);
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
            this.ParseButton.Location = new System.Drawing.Point(304, 52);
            this.ParseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 27);
            this.ParseButton.TabIndex = 2;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ValueParsing
            // 
            this.ValueParsing.Location = new System.Drawing.Point(11, 53);
            this.ValueParsing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValueParsing.Name = "ValueParsing";
            this.ValueParsing.Size = new System.Drawing.Size(288, 22);
            this.ValueParsing.TabIndex = 1;
            // 
            // LabelParsing
            // 
            this.LabelParsing.AutoSize = true;
            this.LabelParsing.Location = new System.Drawing.Point(11, 33);
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
            this.IntTextBox.Location = new System.Drawing.Point(384, 41);
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
            this.EnumsListBox.Location = new System.Drawing.Point(11, 41);
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
            this.ClassesTabPage.Size = new System.Drawing.Size(792, 370);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // FilmGroupBox
            // 
            this.FilmGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FilmGroupBox.Controls.Add(this.FilmRatingTextBox);
            this.FilmGroupBox.Controls.Add(this.label8);
            this.FilmGroupBox.Controls.Add(this.FilmReleaseTextBox);
            this.FilmGroupBox.Controls.Add(this.label7);
            this.FilmGroupBox.Controls.Add(this.FilmDurationTextBox);
            this.FilmGroupBox.Controls.Add(this.label6);
            this.FilmGroupBox.Controls.Add(this.FilmGenreTextBox);
            this.FilmGroupBox.Controls.Add(this.label5);
            this.FilmGroupBox.Controls.Add(this.FilmNameTextBox);
            this.FilmGroupBox.Controls.Add(this.label4);
            this.FilmGroupBox.Controls.Add(this.FindFilmButton);
            this.FilmGroupBox.Controls.Add(this.FilmsListBox);
            this.FilmGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.FilmGroupBox.Location = new System.Drawing.Point(401, 2);
            this.FilmGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.FilmGroupBox.Name = "FilmGroupBox";
            this.FilmGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.FilmGroupBox.Size = new System.Drawing.Size(388, 366);
            this.FilmGroupBox.TabIndex = 1;
            this.FilmGroupBox.TabStop = false;
            this.FilmGroupBox.Text = "Films";
            // 
            // FilmRatingTextBox
            // 
            this.FilmRatingTextBox.Location = new System.Drawing.Point(185, 263);
            this.FilmRatingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FilmRatingTextBox.Name = "FilmRatingTextBox";
            this.FilmRatingTextBox.Size = new System.Drawing.Size(160, 22);
            this.FilmRatingTextBox.TabIndex = 18;
            this.FilmRatingTextBox.TextChanged += new System.EventHandler(this.FilmRatingTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 242);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Rating";
            // 
            // FilmReleaseTextBox
            // 
            this.FilmReleaseTextBox.Location = new System.Drawing.Point(185, 208);
            this.FilmReleaseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FilmReleaseTextBox.Name = "FilmReleaseTextBox";
            this.FilmReleaseTextBox.Size = new System.Drawing.Size(160, 22);
            this.FilmReleaseTextBox.TabIndex = 16;
            this.FilmReleaseTextBox.TextChanged += new System.EventHandler(this.FilmReleaseTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Release Year";
            // 
            // FilmDurationTextBox
            // 
            this.FilmDurationTextBox.Location = new System.Drawing.Point(185, 153);
            this.FilmDurationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FilmDurationTextBox.Name = "FilmDurationTextBox";
            this.FilmDurationTextBox.Size = new System.Drawing.Size(160, 22);
            this.FilmDurationTextBox.TabIndex = 14;
            this.FilmDurationTextBox.TextChanged += new System.EventHandler(this.FimDuretionTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Duration in Minute";
            // 
            // FilmGenreTextBox
            // 
            this.FilmGenreTextBox.Location = new System.Drawing.Point(185, 98);
            this.FilmGenreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FilmGenreTextBox.Name = "FilmGenreTextBox";
            this.FilmGenreTextBox.Size = new System.Drawing.Size(160, 22);
            this.FilmGenreTextBox.TabIndex = 12;
            this.FilmGenreTextBox.TextChanged += new System.EventHandler(this.FilmGenreTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Genre";
            // 
            // FilmNameTextBox
            // 
            this.FilmNameTextBox.Location = new System.Drawing.Point(185, 44);
            this.FilmNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FilmNameTextBox.Name = "FilmNameTextBox";
            this.FilmNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.FilmNameTextBox.TabIndex = 10;
            this.FilmNameTextBox.TextChanged += new System.EventHandler(this.FilmNameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // FindFilmButton
            // 
            this.FindFilmButton.Location = new System.Drawing.Point(185, 310);
            this.FindFilmButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindFilmButton.Name = "FindFilmButton";
            this.FindFilmButton.Size = new System.Drawing.Size(100, 23);
            this.FindFilmButton.TabIndex = 8;
            this.FindFilmButton.Text = "Find";
            this.FindFilmButton.UseVisualStyleBackColor = true;
            this.FindFilmButton.Click += new System.EventHandler(this.FindFilmButton_Click);
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.ItemHeight = 16;
            this.FilmsListBox.Location = new System.Drawing.Point(8, 25);
            this.FilmsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(168, 308);
            this.FilmsListBox.TabIndex = 0;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
            // 
            // RectangleGroupBox
            // 
            this.RectangleGroupBox.Controls.Add(this.FindRectangleButton);
            this.RectangleGroupBox.Controls.Add(this.ColorTextBox);
            this.RectangleGroupBox.Controls.Add(this.label3);
            this.RectangleGroupBox.Controls.Add(this.WidthTextBox);
            this.RectangleGroupBox.Controls.Add(this.label2);
            this.RectangleGroupBox.Controls.Add(this.LenghtTextBox);
            this.RectangleGroupBox.Controls.Add(this.label1);
            this.RectangleGroupBox.Controls.Add(this.RectangleListBox);
            this.RectangleGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.RectangleGroupBox.Location = new System.Drawing.Point(3, 2);
            this.RectangleGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectangleGroupBox.Name = "RectangleGroupBox";
            this.RectangleGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectangleGroupBox.Size = new System.Drawing.Size(389, 366);
            this.RectangleGroupBox.TabIndex = 0;
            this.RectangleGroupBox.TabStop = false;
            this.RectangleGroupBox.Text = "Rectangles";
            // 
            // FindRectangleButton
            // 
            this.FindRectangleButton.Location = new System.Drawing.Point(185, 310);
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
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(185, 98);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(160, 22);
            this.WidthTextBox.TabIndex = 4;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width";
            // 
            // LenghtTextBox
            // 
            this.LenghtTextBox.Location = new System.Drawing.Point(185, 44);
            this.LenghtTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LenghtTextBox.Name = "LenghtTextBox";
            this.LenghtTextBox.Size = new System.Drawing.Size(160, 22);
            this.LenghtTextBox.TabIndex = 2;
            this.LenghtTextBox.TextChanged += new System.EventHandler(this.LenghtTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lenght";
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.ItemHeight = 16;
            this.RectangleListBox.Location = new System.Drawing.Point(8, 25);
            this.RectangleListBox.Margin = new System.Windows.Forms.Padding(4);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(168, 308);
            this.RectangleListBox.TabIndex = 0;
            this.RectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // TabPage
            // 
            this.TabPage.Location = new System.Drawing.Point(4, 25);
            this.TabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPage.Name = "TabPage";
            this.TabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPage.Size = new System.Drawing.Size(792, 370);
            this.TabPage.TabIndex = 2;
            this.TabPage.Text = "tabPage";
            this.TabPage.UseVisualStyleBackColor = true;
            // 
            // ToolTip
            // 
            this.ToolTip.AutomaticDelay = 50;
            this.ToolTip.ShowAlways = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
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
        private System.Windows.Forms.TabPage TabPage;
        private System.Windows.Forms.GroupBox FilmGroupBox;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LenghtTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox RectangleListBox;
        private System.Windows.Forms.Button FindRectangleButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FindFilmButton;
        private System.Windows.Forms.ListBox FilmsListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FilmNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FilmGenreTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FilmDurationTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FilmReleaseTextBox;
        private System.Windows.Forms.TextBox FilmRatingTextBox;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}

