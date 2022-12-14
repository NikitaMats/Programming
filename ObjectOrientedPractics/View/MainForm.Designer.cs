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
            this.itemsTabControl = new ObjectOrientedPractics.View.Tabs.ItemsTabControl();
            this.CustomersTab = new System.Windows.Forms.TabPage();
            this.customersTabControl1 = new ObjectOrientedPractics.View.Tabs.CustomersTabControl();
            this.address1 = new ObjectOrientedPractics.View.Tabs.AddressControl();
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
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(756, 458);
            this.TabControl.TabIndex = 0;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Controls.Add(this.itemsTabControl);
            this.ItemsTab.Location = new System.Drawing.Point(4, 25);
            this.ItemsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemsTab.Size = new System.Drawing.Size(748, 429);
            this.ItemsTab.TabIndex = 0;
            this.ItemsTab.Text = "Items";
            this.ItemsTab.UseVisualStyleBackColor = true;
            // 
            // itemsTabControl
            // 
            this.itemsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTabControl.Location = new System.Drawing.Point(3, 2);
            this.itemsTabControl.Margin = new System.Windows.Forms.Padding(5);
            this.itemsTabControl.Name = "itemsTabControl";
            this.itemsTabControl.Size = new System.Drawing.Size(742, 425);
            this.itemsTabControl.TabIndex = 0;
            // 
            // CustomersTab
            // 
            this.CustomersTab.Controls.Add(this.address1);
            this.CustomersTab.Controls.Add(this.customersTabControl1);
            this.CustomersTab.Location = new System.Drawing.Point(4, 25);
            this.CustomersTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomersTab.Size = new System.Drawing.Size(748, 429);
            this.CustomersTab.TabIndex = 1;
            this.CustomersTab.Text = "Customers";
            this.CustomersTab.UseVisualStyleBackColor = true;
            // 
            // customersTabControl1
            // 
            this.customersTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTabControl1.Location = new System.Drawing.Point(3, 2);
            this.customersTabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.customersTabControl1.Name = "customersTabControl1";
            this.customersTabControl1.Size = new System.Drawing.Size(742, 425);
            this.customersTabControl1.TabIndex = 0;
            // 
            // address1
            // 
            this.address1.Location = new System.Drawing.Point(278, 100);
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(474, 189);
            this.address1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 458);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.TabControl.ResumeLayout(false);
            this.ItemsTab.ResumeLayout(false);
            this.CustomersTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ItemsTab;
        private System.Windows.Forms.TabPage CustomersTab;
        private View.Tabs.ItemsTabControl itemsTabControl;
        private View.Tabs.CustomersTabControl customersTabControl1;
        private View.Tabs.AddressControl address1;
    }
}

