namespace Programming.View.Control
{
    partial class WeekdayControl
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
            this.ParseButton = new System.Windows.Forms.Button();
            this.ValueParsing = new System.Windows.Forms.TextBox();
            this.LabelParsing = new System.Windows.Forms.Label();
            this.ParsingFlag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(311, 37);
            this.ParseButton.Margin = new System.Windows.Forms.Padding(4);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 27);
            this.ParseButton.TabIndex = 5;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ValueParsing
            // 
            this.ValueParsing.Location = new System.Drawing.Point(14, 37);
            this.ValueParsing.Margin = new System.Windows.Forms.Padding(4);
            this.ValueParsing.Name = "ValueParsing";
            this.ValueParsing.Size = new System.Drawing.Size(288, 22);
            this.ValueParsing.TabIndex = 4;
            // 
            // LabelParsing
            // 
            this.LabelParsing.AutoSize = true;
            this.LabelParsing.Location = new System.Drawing.Point(13, 16);
            this.LabelParsing.Name = "LabelParsing";
            this.LabelParsing.Size = new System.Drawing.Size(144, 16);
            this.LabelParsing.TabIndex = 3;
            this.LabelParsing.Text = "Type value for parsing:";
            // 
            // ParsingFlag
            // 
            this.ParsingFlag.AutoSize = true;
            this.ParsingFlag.Location = new System.Drawing.Point(13, 63);
            this.ParsingFlag.Name = "ParsingFlag";
            this.ParsingFlag.Size = new System.Drawing.Size(0, 16);
            this.ParsingFlag.TabIndex = 6;
            // 
            // WeekdayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParsingFlag);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.ValueParsing);
            this.Controls.Add(this.LabelParsing);
            this.Name = "WeekdayControl";
            this.Size = new System.Drawing.Size(400, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox ValueParsing;
        private System.Windows.Forms.Label LabelParsing;
        private System.Windows.Forms.Label ParsingFlag;
    }
}
