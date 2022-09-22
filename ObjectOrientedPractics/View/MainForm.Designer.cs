namespace ObjectOrientedPractics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ItemsTab = new System.Windows.Forms.TabPage();
            this.ItemDeleteButton = new System.Windows.Forms.Button();
            this.ItemAddButtom = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.CustomersTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemCostTextBox = new System.Windows.Forms.TextBox();
            this.ItemIDTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ItemInfoTextBox = new System.Windows.Forms.TextBox();
            this.CustomerAddressTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.CustomerFullNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CustomerDeleteButton = new System.Windows.Forms.Button();
            this.CustomerAddButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.ItemsTab.SuspendLayout();
            this.CustomersTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ItemsTab);
            this.TabControl.Controls.Add(this.CustomersTab);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(569, 392);
            this.TabControl.TabIndex = 0;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Controls.Add(this.ItemInfoTextBox);
            this.ItemsTab.Controls.Add(this.label6);
            this.ItemsTab.Controls.Add(this.ItemNameTextBox);
            this.ItemsTab.Controls.Add(this.label5);
            this.ItemsTab.Controls.Add(this.ItemIDTextBox);
            this.ItemsTab.Controls.Add(this.ItemCostTextBox);
            this.ItemsTab.Controls.Add(this.label4);
            this.ItemsTab.Controls.Add(this.label3);
            this.ItemsTab.Controls.Add(this.label2);
            this.ItemsTab.Controls.Add(this.ItemDeleteButton);
            this.ItemsTab.Controls.Add(this.ItemAddButtom);
            this.ItemsTab.Controls.Add(this.ItemsListBox);
            this.ItemsTab.Controls.Add(this.Label1);
            this.ItemsTab.Location = new System.Drawing.Point(4, 22);
            this.ItemsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ItemsTab.Size = new System.Drawing.Size(561, 366);
            this.ItemsTab.TabIndex = 0;
            this.ItemsTab.Text = "Items";
            this.ItemsTab.UseVisualStyleBackColor = true;
            // 
            // ItemDeleteButton
            // 
            this.ItemDeleteButton.Location = new System.Drawing.Point(116, 318);
            this.ItemDeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ItemDeleteButton.Name = "ItemDeleteButton";
            this.ItemDeleteButton.Size = new System.Drawing.Size(82, 26);
            this.ItemDeleteButton.TabIndex = 3;
            this.ItemDeleteButton.Text = "Delete";
            this.ItemDeleteButton.UseVisualStyleBackColor = true;
            // 
            // ItemAddButtom
            // 
            this.ItemAddButtom.Location = new System.Drawing.Point(15, 318);
            this.ItemAddButtom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ItemAddButtom.Name = "ItemAddButtom";
            this.ItemAddButtom.Size = new System.Drawing.Size(82, 26);
            this.ItemAddButtom.TabIndex = 2;
            this.ItemAddButtom.Text = "Add";
            this.ItemAddButtom.UseVisualStyleBackColor = true;
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(9, 24);
            this.ItemsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(194, 290);
            this.ItemsListBox.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 7);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Items:";
            // 
            // CustomersTab
            // 
            this.CustomersTab.Controls.Add(this.CustomerAddressTextBox);
            this.CustomersTab.Controls.Add(this.label7);
            this.CustomersTab.Controls.Add(this.CustomerIDTextBox);
            this.CustomersTab.Controls.Add(this.CustomerFullNameTextBox);
            this.CustomersTab.Controls.Add(this.label8);
            this.CustomersTab.Controls.Add(this.label9);
            this.CustomersTab.Controls.Add(this.label10);
            this.CustomersTab.Controls.Add(this.CustomerDeleteButton);
            this.CustomersTab.Controls.Add(this.CustomerAddButton);
            this.CustomersTab.Controls.Add(this.CustomersListBox);
            this.CustomersTab.Controls.Add(this.label11);
            this.CustomersTab.Location = new System.Drawing.Point(4, 22);
            this.CustomersTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomersTab.Size = new System.Drawing.Size(561, 366);
            this.CustomersTab.TabIndex = 1;
            this.CustomersTab.Text = "Customers";
            this.CustomersTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selected Item:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cost:";
            // 
            // ItemCostTextBox
            // 
            this.ItemCostTextBox.Location = new System.Drawing.Point(255, 57);
            this.ItemCostTextBox.Name = "ItemCostTextBox";
            this.ItemCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemCostTextBox.TabIndex = 7;
            // 
            // ItemIDTextBox
            // 
            this.ItemIDTextBox.Location = new System.Drawing.Point(255, 31);
            this.ItemIDTextBox.Name = "ItemIDTextBox";
            this.ItemIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemIDTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name:";
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(221, 102);
            this.ItemNameTextBox.Multiline = true;
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(332, 59);
            this.ItemNameTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Info:";
            // 
            // ItemInfoTextBox
            // 
            this.ItemInfoTextBox.Location = new System.Drawing.Point(221, 191);
            this.ItemInfoTextBox.Multiline = true;
            this.ItemInfoTextBox.Name = "ItemInfoTextBox";
            this.ItemInfoTextBox.Size = new System.Drawing.Size(332, 123);
            this.ItemInfoTextBox.TabIndex = 12;
            // 
            // CustomerAddressTextBox
            // 
            this.CustomerAddressTextBox.Location = new System.Drawing.Point(221, 102);
            this.CustomerAddressTextBox.Multiline = true;
            this.CustomerAddressTextBox.Name = "CustomerAddressTextBox";
            this.CustomerAddressTextBox.Size = new System.Drawing.Size(332, 59);
            this.CustomerAddressTextBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Address:";
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(280, 31);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerIDTextBox.TabIndex = 19;
            // 
            // CustomerFullNameTextBox
            // 
            this.CustomerFullNameTextBox.Location = new System.Drawing.Point(280, 57);
            this.CustomerFullNameTextBox.Name = "CustomerFullNameTextBox";
            this.CustomerFullNameTextBox.Size = new System.Drawing.Size(273, 20);
            this.CustomerFullNameTextBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Full Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Selected Customer:";
            // 
            // CustomerDeleteButton
            // 
            this.CustomerDeleteButton.Location = new System.Drawing.Point(116, 318);
            this.CustomerDeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerDeleteButton.Name = "CustomerDeleteButton";
            this.CustomerDeleteButton.Size = new System.Drawing.Size(82, 26);
            this.CustomerDeleteButton.TabIndex = 14;
            this.CustomerDeleteButton.Text = "Delete";
            this.CustomerDeleteButton.UseVisualStyleBackColor = true;
            // 
            // CustomerAddButton
            // 
            this.CustomerAddButton.Location = new System.Drawing.Point(15, 318);
            this.CustomerAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerAddButton.Name = "CustomerAddButton";
            this.CustomerAddButton.Size = new System.Drawing.Size(82, 26);
            this.CustomerAddButton.TabIndex = 13;
            this.CustomerAddButton.Text = "Add";
            this.CustomerAddButton.UseVisualStyleBackColor = true;
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(9, 24);
            this.CustomersListBox.Margin = new System.Windows.Forms.Padding(2);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(194, 290);
            this.CustomersListBox.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Customers:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 392);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.TabControl.ResumeLayout(false);
            this.ItemsTab.ResumeLayout(false);
            this.ItemsTab.PerformLayout();
            this.CustomersTab.ResumeLayout(false);
            this.CustomersTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ItemsTab;
        private System.Windows.Forms.TabPage CustomersTab;
        private System.Windows.Forms.Button ItemDeleteButton;
        private System.Windows.Forms.Button ItemAddButtom;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ItemIDTextBox;
        private System.Windows.Forms.TextBox ItemCostTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ItemInfoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CustomerAddressTextBox;
        private System.Windows.Forms.Label label7;
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

