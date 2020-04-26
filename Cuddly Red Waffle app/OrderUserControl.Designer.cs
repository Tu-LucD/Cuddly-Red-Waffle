﻿namespace Cuddly_Red_Waffle_app
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
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.totalPointsLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.estimatedDeliveryDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.orderDeliveredDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.orderSentDate = new System.Windows.Forms.Label();
            this.orderPlacedDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ordersTableAdapter = new Cuddly_Red_Waffle_app.USANA_DBDataSetTableAdapters.OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSANA_DBDataSet)).BeginInit();
            this.orderInfoTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.orderListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(190, 276);
            this.orderListBox.Sorted = true;
            this.orderListBox.TabIndex = 0;
            this.orderListBox.ValueMember = "OrderID";
            this.orderListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            this.addOrderButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.myOrdersLabel.Click += new System.EventHandler(this.label1_Click);
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
            this.orderInfoTab.Location = new System.Drawing.Point(310, 53);
            this.orderInfoTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orderInfoTab.Name = "orderInfoTab";
            this.orderInfoTab.SelectedIndex = 0;
            this.orderInfoTab.Size = new System.Drawing.Size(240, 306);
            this.orderInfoTab.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.orderProductList);
            this.tabPage1.Controls.Add(this.totalPointsLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(232, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // orderProductList
            // 
            this.orderProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderProductList.DataSource = this.ordersBindingSource1;
            this.orderProductList.DisplayMember = "Product In order";
            this.orderProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderProductList.FormattingEnabled = true;
            this.orderProductList.ItemHeight = 16;
            this.orderProductList.Location = new System.Drawing.Point(1, 12);
            this.orderProductList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orderProductList.Name = "orderProductList";
            this.orderProductList.Size = new System.Drawing.Size(172, 112);
            this.orderProductList.TabIndex = 0;
            this.orderProductList.ValueMember = "Product In order";
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.uSANA_DBDataSet;
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
            this.totalPointsLabel.MinimumSize = new System.Drawing.Size(232, 30);
            this.totalPointsLabel.Name = "totalPointsLabel";
            this.totalPointsLabel.Size = new System.Drawing.Size(232, 30);
            this.totalPointsLabel.TabIndex = 8;
            this.totalPointsLabel.Text = "Total points: 150";
            this.totalPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.estimatedDeliveryDate);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.orderDeliveredDate);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.orderSentDate);
            this.tabPage2.Controls.Add(this.orderPlacedDate);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(232, 277);
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
            this.estimatedDeliveryDate.MinimumSize = new System.Drawing.Size(232, 20);
            this.estimatedDeliveryDate.Name = "estimatedDeliveryDate";
            this.estimatedDeliveryDate.Size = new System.Drawing.Size(232, 20);
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
            this.label10.Location = new System.Drawing.Point(-1, 236);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.MinimumSize = new System.Drawing.Size(232, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Estimated Delivery Date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Order Delivered";
            // 
            // orderDeliveredDate
            // 
            this.orderDeliveredDate.AutoSize = true;
            this.orderDeliveredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDeliveredDate.Location = new System.Drawing.Point(30, 165);
            this.orderDeliveredDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderDeliveredDate.Name = "orderDeliveredDate";
            this.orderDeliveredDate.Size = new System.Drawing.Size(85, 16);
            this.orderDeliveredDate.TabIndex = 4;
            this.orderDeliveredDate.Text = "May 1st 2020";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Order Sent";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // orderSentDate
            // 
            this.orderSentDate.AutoSize = true;
            this.orderSentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSentDate.Location = new System.Drawing.Point(30, 105);
            this.orderSentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderSentDate.Name = "orderSentDate";
            this.orderSentDate.Size = new System.Drawing.Size(93, 16);
            this.orderSentDate.TabIndex = 2;
            this.orderSentDate.Text = "April 27th 2020";
            // 
            // orderPlacedDate
            // 
            this.orderPlacedDate.AutoSize = true;
            this.orderPlacedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPlacedDate.Location = new System.Drawing.Point(30, 45);
            this.orderPlacedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderPlacedDate.Name = "orderPlacedDate";
            this.orderPlacedDate.Size = new System.Drawing.Size(93, 16);
            this.orderPlacedDate.TabIndex = 1;
            this.orderPlacedDate.Text = "April 20th 2020";
            this.orderPlacedDate.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Order Placed";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // OrderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderInfoTab);
            this.Controls.Add(this.orderDetailsLabel);
            this.Controls.Add(this.myOrdersLabel);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.orderListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrderUserControl";
            this.Size = new System.Drawing.Size(602, 391);
            this.Load += new System.EventHandler(this.OrderPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSANA_DBDataSet)).EndInit();
            this.orderInfoTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label orderDeliveredDate;
        private System.Windows.Forms.Label totalPointsLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label estimatedDeliveryDate;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private USANA_DBDataSet uSANA_DBDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private USANA_DBDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
    }
}