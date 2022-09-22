namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTabControl
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
            this.ItemInfoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemIDTextBox = new System.Windows.Forms.TextBox();
            this.ItemCostTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemDeleteButton = new System.Windows.Forms.Button();
            this.ItemAddButtom = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemInfoTextBox
            // 
            this.ItemInfoTextBox.Location = new System.Drawing.Point(293, 234);
            this.ItemInfoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemInfoTextBox.Multiline = true;
            this.ItemInfoTextBox.Name = "ItemInfoTextBox";
            this.ItemInfoTextBox.Size = new System.Drawing.Size(441, 150);
            this.ItemInfoTextBox.TabIndex = 25;
            this.ItemInfoTextBox.TextChanged += new System.EventHandler(this.ItemInfoTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Info:";
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(293, 124);
            this.ItemNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemNameTextBox.Multiline = true;
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(441, 72);
            this.ItemNameTextBox.TabIndex = 23;
            this.ItemNameTextBox.TextChanged += new System.EventHandler(this.ItemNameTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Name:";
            // 
            // ItemIDTextBox
            // 
            this.ItemIDTextBox.Location = new System.Drawing.Point(339, 37);
            this.ItemIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemIDTextBox.Name = "ItemIDTextBox";
            this.ItemIDTextBox.ReadOnly = true;
            this.ItemIDTextBox.Size = new System.Drawing.Size(132, 22);
            this.ItemIDTextBox.TabIndex = 21;
            // 
            // ItemCostTextBox
            // 
            this.ItemCostTextBox.Location = new System.Drawing.Point(339, 69);
            this.ItemCostTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemCostTextBox.Name = "ItemCostTextBox";
            this.ItemCostTextBox.Size = new System.Drawing.Size(132, 22);
            this.ItemCostTextBox.TabIndex = 20;
            this.ItemCostTextBox.TextChanged += new System.EventHandler(this.ItemCostTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Selected Item:";
            // 
            // ItemDeleteButton
            // 
            this.ItemDeleteButton.Location = new System.Drawing.Point(153, 390);
            this.ItemDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemDeleteButton.Name = "ItemDeleteButton";
            this.ItemDeleteButton.Size = new System.Drawing.Size(109, 32);
            this.ItemDeleteButton.TabIndex = 16;
            this.ItemDeleteButton.Text = "Delete";
            this.ItemDeleteButton.UseVisualStyleBackColor = true;
            this.ItemDeleteButton.Click += new System.EventHandler(this.ItemDeleteButton_Click);
            // 
            // ItemAddButtom
            // 
            this.ItemAddButtom.Location = new System.Drawing.Point(19, 390);
            this.ItemAddButtom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemAddButtom.Name = "ItemAddButtom";
            this.ItemAddButtom.Size = new System.Drawing.Size(109, 32);
            this.ItemAddButtom.TabIndex = 15;
            this.ItemAddButtom.Text = "Add";
            this.ItemAddButtom.UseVisualStyleBackColor = true;
            this.ItemAddButtom.Click += new System.EventHandler(this.ItemAddButtom_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 16;
            this.ItemsListBox.Location = new System.Drawing.Point(11, 28);
            this.ItemsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(257, 356);
            this.ItemsListBox.TabIndex = 14;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(42, 16);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Items:";
            // 
            // ItemsTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemInfoTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ItemNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ItemIDTextBox);
            this.Controls.Add(this.ItemCostTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemDeleteButton);
            this.Controls.Add(this.ItemAddButtom);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemsTabControl";
            this.Size = new System.Drawing.Size(751, 433);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemInfoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ItemIDTextBox;
        private System.Windows.Forms.TextBox ItemCostTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ItemDeleteButton;
        private System.Windows.Forms.Button ItemAddButtom;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label Label1;
    }
}
