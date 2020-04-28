namespace Cuddly_Red_Waffle_app
{
    partial class OrderUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSANA_DBDataSet = new Cuddly_Red_Waffle_app.USANA_DBDataSet();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.myOrdersLabel = new System.Windows.Forms.Label();
            this.orderDetailsLabel = new System.Windows.Forms.Label();
            this.orderInfoTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.orderProductList = new System.Windows.Forms.ListBox();
            this.totalPointsLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.estimatedDeliveryDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.orderDeliveredLabel = new System.Windows.Forms.Label();
            this.orderDeliveredDate = new System.Windows.Forms.Label();
            this.orderSentLabel = new System.Windows.Forms.Label();
            this.orderSentDate = new System.Windows.Forms.Label();
            this.orderPlacedDate = new System.Windows.Forms.Label();
            this.orderPlacedLabel = new System.Windows.Forms.Label();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Cuddly_Red_Waffle_app.USANA_DBDataSetTableAdapters.OrdersTableAdapter();
            this.productsTableAdapter = new Cuddly_Red_Waffle_app.USANA_DBDataSetTableAdapters.ProductsTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSANA_DBDataSet)).BeginInit();
            this.orderInfoTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderListBox
            // 
            this.orderListBox.DataSource = this.ordersBindingSource;
            this.orderListBox.DisplayMember = "OrderID";
            this.orderListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.HorizontalScrollbar = true;
            this.orderListBox.ItemHeight = 16;
            this.orderListBox.Location = new System.Drawing.Point(55, 53);
            this.orderListBox.Margin = new System.Windows.Forms.Padding(2);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(190, 276);
            this.orderListBox.Sorted = true;
            this.orderListBox.TabIndex = 0;
            this.orderListBox.ValueMember = "OrderID";
            this.orderListBox.SelectedIndexChanged += new System.EventHandler(this.orderListBox_SelectedIndexChanged);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.uSANA_DBDataSet;
            // 
            // uSANA_DBDataSet
            // 
            this.uSANA_DBDataSet.DataSetName = "USANA_DBDataSet";
            this.uSANA_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addOrderButton
            // 
            this.addOrderButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.addOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrderButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addOrderButton.Location = new System.Drawing.Point(55, 329);
            this.addOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(190, 30);
            this.addOrderButton.TabIndex = 1;
            this.addOrderButton.Text = "Add Order";
            this.addOrderButton.UseVisualStyleBackColor = false;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // myOrdersLabel
            // 
            this.myOrdersLabel.AutoSize = true;
            this.myOrdersLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.myOrdersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myOrdersLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myOrdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myOrdersLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.myOrdersLabel.Location = new System.Drawing.Point(55, 23);
            this.myOrdersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.myOrdersLabel.MinimumSize = new System.Drawing.Size(190, 30);
            this.myOrdersLabel.Name = "myOrdersLabel";
            this.myOrdersLabel.Size = new System.Drawing.Size(190, 30);
            this.myOrdersLabel.TabIndex = 2;
            this.myOrdersLabel.Text = "My Orders";
            this.myOrdersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderDetailsLabel
            // 
            this.orderDetailsLabel.AutoSize = true;
            this.orderDetailsLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.orderDetailsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderDetailsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetailsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.orderDetailsLabel.Location = new System.Drawing.Point(310, 23);
            this.orderDetailsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderDetailsLabel.MinimumSize = new System.Drawing.Size(240, 30);
            this.orderDetailsLabel.Name = "orderDetailsLabel";
            this.orderDetailsLabel.Size = new System.Drawing.Size(240, 30);
            this.orderDetailsLabel.TabIndex = 5;
            this.orderDetailsLabel.Text = "Order Details";
            this.orderDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderInfoTab
            // 
            this.orderInfoTab.Controls.Add(this.tabPage1);
            this.orderInfoTab.Controls.Add(this.tabPage2);
            this.orderInfoTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderInfoTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderInfoTab.Location = new System.Drawing.Point(310, 52);
            this.orderInfoTab.Margin = new System.Windows.Forms.Padding(2);
            this.orderInfoTab.Name = "orderInfoTab";
            this.orderInfoTab.SelectedIndex = 0;
            this.orderInfoTab.Size = new System.Drawing.Size(240, 307);
            this.orderInfoTab.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.orderProductList);
            this.tabPage1.Controls.Add(this.totalPointsLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(232, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // orderProductList
            // 
            this.orderProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderProductList.FormattingEnabled = true;
            this.orderProductList.ItemHeight = 16;
            this.orderProductList.Location = new System.Drawing.Point(13, 27);
            this.orderProductList.Margin = new System.Windows.Forms.Padding(2);
            this.orderProductList.Name = "orderProductList";
            this.orderProductList.Size = new System.Drawing.Size(129, 64);
            this.orderProductList.TabIndex = 0;
            // 
            // totalPointsLabel
            // 
            this.totalPointsLabel.AutoSize = true;
            this.totalPointsLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.totalPointsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPointsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPointsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.totalPointsLabel.Location = new System.Drawing.Point(0, 247);
            this.totalPointsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPointsLabel.MinimumSize = new System.Drawing.Size(230, 30);
            this.totalPointsLabel.Name = "totalPointsLabel";
            this.totalPointsLabel.Size = new System.Drawing.Size(230, 30);
            this.totalPointsLabel.TabIndex = 8;
            this.totalPointsLabel.Text = "Total points: 150";
            this.totalPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.estimatedDeliveryDate);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.orderDeliveredLabel);
            this.tabPage2.Controls.Add(this.orderDeliveredDate);
            this.tabPage2.Controls.Add(this.orderSentLabel);
            this.tabPage2.Controls.Add(this.orderSentDate);
            this.tabPage2.Controls.Add(this.orderPlacedDate);
            this.tabPage2.Controls.Add(this.orderPlacedLabel);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(232, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order Status";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // estimatedDeliveryDate
            // 
            this.estimatedDeliveryDate.AutoSize = true;
            this.estimatedDeliveryDate.BackColor = System.Drawing.SystemColors.Highlight;
            this.estimatedDeliveryDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estimatedDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimatedDeliveryDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.estimatedDeliveryDate.Location = new System.Drawing.Point(1, 256);
            this.estimatedDeliveryDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.estimatedDeliveryDate.MinimumSize = new System.Drawing.Size(230, 20);
            this.estimatedDeliveryDate.Name = "estimatedDeliveryDate";
            this.estimatedDeliveryDate.Size = new System.Drawing.Size(230, 20);
            this.estimatedDeliveryDate.TabIndex = 11;
            this.estimatedDeliveryDate.Text = "May 1st 2020";
            this.estimatedDeliveryDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Highlight;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(1, 236);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.MinimumSize = new System.Drawing.Size(230, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Estimated Delivery Date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderDeliveredLabel
            // 
            this.orderDeliveredLabel.AutoSize = true;
            this.orderDeliveredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDeliveredLabel.Location = new System.Drawing.Point(27, 145);
            this.orderDeliveredLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderDeliveredLabel.Name = "orderDeliveredLabel";
            this.orderDeliveredLabel.Size = new System.Drawing.Size(119, 16);
            this.orderDeliveredLabel.TabIndex = 5;
            this.orderDeliveredLabel.Text = "Order Delivered";
            this.orderDeliveredLabel.Visible = false;
            // 
            // orderDeliveredDate
            // 
            this.orderDeliveredDate.AutoSize = true;
            this.orderDeliveredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDeliveredDate.Location = new System.Drawing.Point(47, 165);
            this.orderDeliveredDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderDeliveredDate.Name = "orderDeliveredDate";
            this.orderDeliveredDate.Size = new System.Drawing.Size(85, 16);
            this.orderDeliveredDate.TabIndex = 4;
            this.orderDeliveredDate.Text = "May 1st 2020";
            this.orderDeliveredDate.Visible = false;
            // 
            // orderSentLabel
            // 
            this.orderSentLabel.AutoSize = true;
            this.orderSentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSentLabel.Location = new System.Drawing.Point(27, 85);
            this.orderSentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderSentLabel.Name = "orderSentLabel";
            this.orderSentLabel.Size = new System.Drawing.Size(82, 16);
            this.orderSentLabel.TabIndex = 3;
            this.orderSentLabel.Text = "Order Sent";
            this.orderSentLabel.Visible = false;
            // 
            // orderSentDate
            // 
            this.orderSentDate.AutoSize = true;
            this.orderSentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSentDate.Location = new System.Drawing.Point(47, 105);
            this.orderSentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderSentDate.Name = "orderSentDate";
            this.orderSentDate.Size = new System.Drawing.Size(93, 16);
            this.orderSentDate.TabIndex = 2;
            this.orderSentDate.Text = "April 27th 2020";
            this.orderSentDate.Visible = false;
            // 
            // orderPlacedDate
            // 
            this.orderPlacedDate.AutoSize = true;
            this.orderPlacedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPlacedDate.Location = new System.Drawing.Point(47, 45);
            this.orderPlacedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderPlacedDate.Name = "orderPlacedDate";
            this.orderPlacedDate.Size = new System.Drawing.Size(93, 16);
            this.orderPlacedDate.TabIndex = 1;
            this.orderPlacedDate.Text = "April 20th 2020";
            this.orderPlacedDate.Visible = false;
            // 
            // orderPlacedLabel
            // 
            this.orderPlacedLabel.AutoSize = true;
            this.orderPlacedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPlacedLabel.Location = new System.Drawing.Point(27, 25);
            this.orderPlacedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderPlacedLabel.Name = "orderPlacedLabel";
            this.orderPlacedLabel.Size = new System.Drawing.Size(100, 16);
            this.orderPlacedLabel.TabIndex = 0;
            this.orderPlacedLabel.Text = "Order Placed";
            this.orderPlacedLabel.Visible = false;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.uSANA_DBDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.uSANA_DBDataSet;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(247, 176);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(60, 20);
            this.refreshButton.TabIndex = 18;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // OrderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.orderInfoTab);
            this.Controls.Add(this.orderDetailsLabel);
            this.Controls.Add(this.myOrdersLabel);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.orderListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderUserControl";
            this.Size = new System.Drawing.Size(602, 391);
            this.Load += new System.EventHandler(this.OrderPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSANA_DBDataSet)).EndInit();
            this.orderInfoTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Label myOrdersLabel;
        private System.Windows.Forms.Label orderDetailsLabel;
        private System.Windows.Forms.TabControl orderInfoTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox orderProductList;
        private System.Windows.Forms.Label orderSentDate;
        private System.Windows.Forms.Label orderPlacedDate;
        private System.Windows.Forms.Label orderPlacedLabel;
        private System.Windows.Forms.Label orderSentLabel;
        private System.Windows.Forms.Label orderDeliveredLabel;
        private System.Windows.Forms.Label orderDeliveredDate;
        private System.Windows.Forms.Label totalPointsLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label estimatedDeliveryDate;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private USANA_DBDataSet uSANA_DBDataSet;
        private USANA_DBDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private USANA_DBDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button refreshButton;
    }
}
