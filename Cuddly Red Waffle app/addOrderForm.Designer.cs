namespace Cuddly_Red_Waffle_app
{
    partial class addOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.headerLabel = new System.Windows.Forms.Label();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.productsLabel = new System.Windows.Forms.Label();
            this.totalPointsLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.arrivalDateLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.totalPointsTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.arrivalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ordersTableAdapter1 = new Cuddly_Red_Waffle_app.USANA_DBDataSetTableAdapters.OrdersTableAdapter();
            this.usanA_DBDataSet1 = new Cuddly_Red_Waffle_app.USANA_DBDataSet();
            this.tableAdapterManager1 = new Cuddly_Red_Waffle_app.USANA_DBDataSetTableAdapters.TableAdapterManager();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usanA_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.MinimumSize = new System.Drawing.Size(380, 25);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(380, 25);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Input your order\'s information here!";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productsListBox
            // 
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.ItemHeight = 16;
            this.productsListBox.Location = new System.Drawing.Point(147, 46);
            this.productsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(192, 84);
            this.productsListBox.TabIndex = 1;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Location = new System.Drawing.Point(40, 49);
            this.productsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(68, 17);
            this.productsLabel.TabIndex = 2;
            this.productsLabel.Text = "Products:";
            // 
            // totalPointsLabel
            // 
            this.totalPointsLabel.AutoSize = true;
            this.totalPointsLabel.Location = new System.Drawing.Point(40, 148);
            this.totalPointsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalPointsLabel.Name = "totalPointsLabel";
            this.totalPointsLabel.Size = new System.Drawing.Size(87, 17);
            this.totalPointsLabel.TabIndex = 3;
            this.totalPointsLabel.Text = "Total Points:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(40, 178);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(52, 17);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status:";
            // 
            // arrivalDateLabel
            // 
            this.arrivalDateLabel.AutoSize = true;
            this.arrivalDateLabel.Location = new System.Drawing.Point(40, 209);
            this.arrivalDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arrivalDateLabel.Name = "arrivalDateLabel";
            this.arrivalDateLabel.Size = new System.Drawing.Size(86, 17);
            this.arrivalDateLabel.TabIndex = 5;
            this.arrivalDateLabel.Text = "Arrival Date:";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(108, 247);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 28);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(231, 247);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // totalPointsTextBox
            // 
            this.totalPointsTextBox.Location = new System.Drawing.Point(148, 144);
            this.totalPointsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalPointsTextBox.Name = "totalPointsTextBox";
            this.totalPointsTextBox.Size = new System.Drawing.Size(191, 22);
            this.totalPointsTextBox.TabIndex = 8;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Pending",
            "Ordered",
            "Shipped ",
            "Delivered"});
            this.statusComboBox.Location = new System.Drawing.Point(147, 175);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(192, 24);
            this.statusComboBox.TabIndex = 9;
            // 
            // arrivalDateTimePicker
            // 
            this.arrivalDateTimePicker.Location = new System.Drawing.Point(147, 208);
            this.arrivalDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.arrivalDateTimePicker.Name = "arrivalDateTimePicker";
            this.arrivalDateTimePicker.Size = new System.Drawing.Size(192, 22);
            this.arrivalDateTimePicker.TabIndex = 10;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // usanA_DBDataSet1
            // 
            this.usanA_DBDataSet1.DataSetName = "USANA_DBDataSet";
            this.usanA_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClientTableAdapter = null;
            this.tableAdapterManager1.HealthCategoryTableAdapter = null;
            this.tableAdapterManager1.OrdersTableAdapter = this.ordersTableAdapter1;
            this.tableAdapterManager1.PaymentTableAdapter = null;
            this.tableAdapterManager1.ProductsTableAdapter = null;
            this.tableAdapterManager1.RequestTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Cuddly_Red_Waffle_app.USANA_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = this.usanA_DBDataSet1;
            this.orderBindingSource.Position = 0;
            // 
            // addOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 290);
            this.Controls.Add(this.arrivalDateTimePicker);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.totalPointsTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.arrivalDateLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.totalPointsLabel);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.productsListBox);
            this.Controls.Add(this.headerLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "addOrderForm";
            this.Text = "Add Order";
            ((System.ComponentModel.ISupportInitialize)(this.usanA_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ListBox productsListBox;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Label totalPointsLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label arrivalDateLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox totalPointsTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.DateTimePicker arrivalDateTimePicker;
        private USANA_DBDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private USANA_DBDataSet usanA_DBDataSet1;
        private USANA_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource orderBindingSource;
    }
}