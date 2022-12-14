namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTabControl
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
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.CustomerFullNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CustomerDeleteButton = new System.Windows.Forms.Button();
            this.CustomerAddButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(362, 37);
            this.CustomerIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.ReadOnly = true;
            this.CustomerIDTextBox.Size = new System.Drawing.Size(142, 22);
            this.CustomerIDTextBox.TabIndex = 30;
            // 
            // CustomerFullNameTextBox
            // 
            this.CustomerFullNameTextBox.Location = new System.Drawing.Point(362, 69);
            this.CustomerFullNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerFullNameTextBox.Name = "CustomerFullNameTextBox";
            this.CustomerFullNameTextBox.Size = new System.Drawing.Size(373, 22);
            this.CustomerFullNameTextBox.TabIndex = 29;
            this.CustomerFullNameTextBox.TextChanged += new System.EventHandler(this.CustomerFullNameTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Full Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Selected Customer:";
            // 
            // CustomerDeleteButton
            // 
            this.CustomerDeleteButton.Location = new System.Drawing.Point(153, 390);
            this.CustomerDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerDeleteButton.Name = "CustomerDeleteButton";
            this.CustomerDeleteButton.Size = new System.Drawing.Size(109, 32);
            this.CustomerDeleteButton.TabIndex = 25;
            this.CustomerDeleteButton.Text = "Delete";
            this.CustomerDeleteButton.UseVisualStyleBackColor = true;
            this.CustomerDeleteButton.Click += new System.EventHandler(this.CustomerDeleteButton_Click);
            // 
            // CustomerAddButton
            // 
            this.CustomerAddButton.Location = new System.Drawing.Point(19, 390);
            this.CustomerAddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerAddButton.Name = "CustomerAddButton";
            this.CustomerAddButton.Size = new System.Drawing.Size(109, 32);
            this.CustomerAddButton.TabIndex = 24;
            this.CustomerAddButton.Text = "Add";
            this.CustomerAddButton.UseVisualStyleBackColor = true;
            this.CustomerAddButton.Click += new System.EventHandler(this.CustomerAddButton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 16;
            this.CustomersListBox.Location = new System.Drawing.Point(11, 28);
            this.CustomersListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(257, 356);
            this.CustomersListBox.TabIndex = 23;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Customers:";
            // 
            // CustomersTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(this.CustomerFullNameTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CustomerDeleteButton);
            this.Controls.Add(this.CustomerAddButton);
            this.Controls.Add(this.CustomersListBox);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomersTabControl";
            this.Size = new System.Drawing.Size(751, 433);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.TextBox CustomerFullNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CustomerDeleteButton;
        private System.Windows.Forms.Button CustomerAddButton;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Label label11;
    }
}
