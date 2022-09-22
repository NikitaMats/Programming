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
            this.DeleteItemButton = new System.Windows.Forms.Button();
            this.AddItemButtom = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.CustomersTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.ItemsTab.SuspendLayout();
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
            this.ItemsTab.Controls.Add(this.textBox3);
            this.ItemsTab.Controls.Add(this.label5);
            this.ItemsTab.Controls.Add(this.textBox2);
            this.ItemsTab.Controls.Add(this.textBox1);
            this.ItemsTab.Controls.Add(this.label4);
            this.ItemsTab.Controls.Add(this.label3);
            this.ItemsTab.Controls.Add(this.label2);
            this.ItemsTab.Controls.Add(this.DeleteItemButton);
            this.ItemsTab.Controls.Add(this.AddItemButtom);
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
            // DeleteItemButton
            // 
            this.DeleteItemButton.Location = new System.Drawing.Point(116, 318);
            this.DeleteItemButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(82, 26);
            this.DeleteItemButton.TabIndex = 3;
            this.DeleteItemButton.Text = "Delete";
            this.DeleteItemButton.UseVisualStyleBackColor = true;
            // 
            // AddItemButtom
            // 
            this.AddItemButtom.Location = new System.Drawing.Point(15, 318);
            this.AddItemButtom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddItemButtom.Name = "AddItemButtom";
            this.AddItemButtom.Size = new System.Drawing.Size(82, 26);
            this.AddItemButtom.TabIndex = 2;
            this.AddItemButtom.Text = "Add";
            this.AddItemButtom.UseVisualStyleBackColor = true;
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
            this.label2.Location = new System.Drawing.Point(215, 7);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(255, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(221, 102);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(332, 59);
            this.textBox3.TabIndex = 10;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ItemsTab;
        private System.Windows.Forms.TabPage CustomersTab;
        private System.Windows.Forms.Button DeleteItemButton;
        private System.Windows.Forms.Button AddItemButtom;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

