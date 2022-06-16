namespace Programming.View
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.enamsTabPage = new System.Windows.Forms.TabPage();
            this.enumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.enumerationsControl = new Programming.View.Controls.EnumerationsControl();
            this.seasonGroupBox = new System.Windows.Forms.GroupBox();
            this.seasonControl = new Programming.View.Controls.SeasonControl();
            this.weekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.weekdayControl = new Programming.View.Controls.WeekdayControl();
            this.сlassesTabPage = new System.Windows.Forms.TabPage();
            this.filmGroupBox = new System.Windows.Forms.GroupBox();
            this.moviesControl = new Programming.View.Controls.MoviesControl();
            this.rectangleGroupBox = new System.Windows.Forms.GroupBox();
            this.rectanglesControl = new Programming.View.Controls.RectanglesControl();
            this.rectanglesTabPage = new System.Windows.Forms.TabPage();
            this.rectanglesPanelControl = new Programming.View.Controls.RectanglesCollisionControl();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.enamsTabPage.SuspendLayout();
            this.enumerationsGroupBox.SuspendLayout();
            this.seasonGroupBox.SuspendLayout();
            this.weekdayGroupBox.SuspendLayout();
            this.сlassesTabPage.SuspendLayout();
            this.filmGroupBox.SuspendLayout();
            this.rectangleGroupBox.SuspendLayout();
            this.rectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.enamsTabPage);
            this.tabControl.Controls.Add(this.сlassesTabPage);
            this.tabControl.Controls.Add(this.rectanglesTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(803, 415);
            this.tabControl.TabIndex = 0;
            // 
            // enamsTabPage
            // 
            this.enamsTabPage.Controls.Add(this.enumerationsGroupBox);
            this.enamsTabPage.Controls.Add(this.seasonGroupBox);
            this.enamsTabPage.Controls.Add(this.weekdayGroupBox);
            this.enamsTabPage.Location = new System.Drawing.Point(4, 25);
            this.enamsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enamsTabPage.Name = "enamsTabPage";
            this.enamsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enamsTabPage.Size = new System.Drawing.Size(795, 386);
            this.enamsTabPage.TabIndex = 0;
            this.enamsTabPage.Text = "Enums";
            this.enamsTabPage.UseVisualStyleBackColor = true;
            // 
            // enumerationsGroupBox
            // 
            this.enumerationsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enumerationsGroupBox.Controls.Add(this.enumerationsControl);
            this.enumerationsGroupBox.Location = new System.Drawing.Point(3, 2);
            this.enumerationsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enumerationsGroupBox.Name = "enumerationsGroupBox";
            this.enumerationsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enumerationsGroupBox.Size = new System.Drawing.Size(789, 202);
            this.enumerationsGroupBox.TabIndex = 3;
            this.enumerationsGroupBox.TabStop = false;
            this.enumerationsGroupBox.Text = "Enumerations";
            // 
            // enumerationsControl
            // 
            this.enumerationsControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enumerationsControl.Location = new System.Drawing.Point(3, 18);
            this.enumerationsControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enumerationsControl.Name = "enumerationsControl";
            this.enumerationsControl.Size = new System.Drawing.Size(783, 174);
            this.enumerationsControl.TabIndex = 0;
            // 
            // seasonGroupBox
            // 
            this.seasonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seasonGroupBox.Controls.Add(this.seasonControl);
            this.seasonGroupBox.Location = new System.Drawing.Point(401, 208);
            this.seasonGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seasonGroupBox.Name = "seasonGroupBox";
            this.seasonGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seasonGroupBox.Size = new System.Drawing.Size(391, 175);
            this.seasonGroupBox.TabIndex = 2;
            this.seasonGroupBox.TabStop = false;
            this.seasonGroupBox.Text = "Season Handle";
            // 
            // seasonControl
            // 
            this.seasonControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seasonControl.Location = new System.Drawing.Point(3, 17);
            this.seasonControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seasonControl.Name = "seasonControl";
            this.seasonControl.Size = new System.Drawing.Size(385, 156);
            this.seasonControl.TabIndex = 0;
            // 
            // weekdayGroupBox
            // 
            this.weekdayGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.weekdayGroupBox.Controls.Add(this.weekdayControl);
            this.weekdayGroupBox.Location = new System.Drawing.Point(3, 208);
            this.weekdayGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weekdayGroupBox.Name = "weekdayGroupBox";
            this.weekdayGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weekdayGroupBox.Size = new System.Drawing.Size(395, 175);
            this.weekdayGroupBox.TabIndex = 1;
            this.weekdayGroupBox.TabStop = false;
            this.weekdayGroupBox.Text = "Weekday Parsing";
            // 
            // weekdayControl
            // 
            this.weekdayControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayControl.Location = new System.Drawing.Point(3, 17);
            this.weekdayControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weekdayControl.Name = "weekdayControl";
            this.weekdayControl.Size = new System.Drawing.Size(389, 156);
            this.weekdayControl.TabIndex = 0;
            // 
            // сlassesTabPage
            // 
            this.сlassesTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.сlassesTabPage.Controls.Add(this.filmGroupBox);
            this.сlassesTabPage.Controls.Add(this.rectangleGroupBox);
            this.сlassesTabPage.Location = new System.Drawing.Point(4, 25);
            this.сlassesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.сlassesTabPage.Name = "сlassesTabPage";
            this.сlassesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.сlassesTabPage.Size = new System.Drawing.Size(795, 386);
            this.сlassesTabPage.TabIndex = 1;
            this.сlassesTabPage.Text = "Classes";
            this.сlassesTabPage.UseVisualStyleBackColor = true;
            // 
            // filmGroupBox
            // 
            this.filmGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filmGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.filmGroupBox.Controls.Add(this.moviesControl);
            this.filmGroupBox.Location = new System.Drawing.Point(401, 2);
            this.filmGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filmGroupBox.Name = "filmGroupBox";
            this.filmGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filmGroupBox.Size = new System.Drawing.Size(388, 374);
            this.filmGroupBox.TabIndex = 1;
            this.filmGroupBox.TabStop = false;
            this.filmGroupBox.Text = "Movies";
            // 
            // moviesControl
            // 
            this.moviesControl.Location = new System.Drawing.Point(7, 12);
            this.moviesControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moviesControl.Name = "moviesControl";
            this.moviesControl.Size = new System.Drawing.Size(365, 362);
            this.moviesControl.TabIndex = 0;
            // 
            // rectangleGroupBox
            // 
            this.rectangleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rectangleGroupBox.Controls.Add(this.rectanglesControl);
            this.rectangleGroupBox.Location = new System.Drawing.Point(3, 2);
            this.rectangleGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectangleGroupBox.Name = "rectangleGroupBox";
            this.rectangleGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectangleGroupBox.Size = new System.Drawing.Size(389, 374);
            this.rectangleGroupBox.TabIndex = 0;
            this.rectangleGroupBox.TabStop = false;
            this.rectangleGroupBox.Text = "Rectangles";
            // 
            // rectanglesControl
            // 
            this.rectanglesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesControl.Location = new System.Drawing.Point(3, 17);
            this.rectanglesControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectanglesControl.Name = "rectanglesControl";
            this.rectanglesControl.Size = new System.Drawing.Size(383, 355);
            this.rectanglesControl.TabIndex = 0;
            // 
            // rectanglesTabPage
            // 
            this.rectanglesTabPage.Controls.Add(this.rectanglesPanelControl);
            this.rectanglesTabPage.Location = new System.Drawing.Point(4, 25);
            this.rectanglesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectanglesTabPage.Name = "rectanglesTabPage";
            this.rectanglesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectanglesTabPage.Size = new System.Drawing.Size(795, 386);
            this.rectanglesTabPage.TabIndex = 2;
            this.rectanglesTabPage.Text = "Rectangles";
            this.rectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesPanelControl
            // 
            this.rectanglesPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesPanelControl.Location = new System.Drawing.Point(3, 2);
            this.rectanglesPanelControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectanglesPanelControl.Name = "rectanglesPanelControl";
            this.rectanglesPanelControl.Size = new System.Drawing.Size(789, 382);
            this.rectanglesPanelControl.TabIndex = 0;
            // 
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 415);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 452);
            this.Name = "mainForm";
            this.Text = "Programming Demo";
            this.tabControl.ResumeLayout(false);
            this.enamsTabPage.ResumeLayout(false);
            this.enumerationsGroupBox.ResumeLayout(false);
            this.seasonGroupBox.ResumeLayout(false);
            this.weekdayGroupBox.ResumeLayout(false);
            this.сlassesTabPage.ResumeLayout(false);
            this.filmGroupBox.ResumeLayout(false);
            this.rectangleGroupBox.ResumeLayout(false);
            this.rectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage enamsTabPage;
        private System.Windows.Forms.TabPage сlassesTabPage;
        private System.Windows.Forms.GroupBox weekdayGroupBox;
        private System.Windows.Forms.GroupBox seasonGroupBox;
        private System.Windows.Forms.GroupBox rectangleGroupBox;
        private System.Windows.Forms.GroupBox filmGroupBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage rectanglesTabPage;
        private System.Windows.Forms.GroupBox enumerationsGroupBox;
        private Controls.EnumerationsControl enumerationsControl;
        private Controls.WeekdayControl weekdayControl;
        private Controls.SeasonControl seasonControl;
        private Controls.RectanglesControl rectanglesControl;
        private Controls.RectanglesCollisionControl rectanglesPanelControl;
        private Controls.MoviesControl moviesControl;
    }
}

