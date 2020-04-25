namespace Cuddly_Red_Waffle_app
{
    partial class OrderPage
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
            this.orderList = new System.Windows.Forms.ListBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.clientName = new System.Windows.Forms.Label();
            this.orderInfoTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.orderProductList = new System.Windows.Forms.ListBox();
            this.totalPoints = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.estimatedDeliveryDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.orderDeliveredDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.orderSentDate = new System.Windows.Forms.Label();
            this.orderPlacedDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.orderInfoTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // orderList
            // 
            this.orderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderList.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderList.FormattingEnabled = true;
            this.orderList.HorizontalScrollbar = true;
            this.orderList.ItemHeight = 31;
            this.orderList.Items.AddRange(new object[] {
            "Order #1",
            "Order #2",
            "Order #3",
            "Order #4",
            "Order #5"});
            this.orderList.Location = new System.Drawing.Point(57, 54);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(194, 248);
            this.orderList.Sorted = true;
            this.orderList.TabIndex = 0;
            this.orderList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // addOrderButton
            // 
            this.addOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.addOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.addOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addOrderButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrderButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addOrderButton.Location = new System.Drawing.Point(57, 303);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(193, 35);
            this.addOrderButton.TabIndex = 1;
            this.addOrderButton.Text = "Add Order";
            this.addOrderButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(101, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Orders";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.pictureBox1.Location = new System.Drawing.Point(57, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 30);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.pictureBox2.Location = new System.Drawing.Point(316, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 30);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // clientName
            // 
            this.clientName.AutoSize = true;
            this.clientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.clientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clientName.Location = new System.Drawing.Point(370, 31);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(102, 16);
            this.clientName.TabIndex = 5;
            this.clientName.Text = "[Client Name]";
            // 
            // orderInfoTab
            // 
            this.orderInfoTab.Controls.Add(this.tabPage1);
            this.orderInfoTab.Controls.Add(this.tabPage2);
            this.orderInfoTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderInfoTab.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderInfoTab.Location = new System.Drawing.Point(316, 54);
            this.orderInfoTab.Name = "orderInfoTab";
            this.orderInfoTab.SelectedIndex = 0;
            this.orderInfoTab.Size = new System.Drawing.Size(222, 268);
            this.orderInfoTab.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.orderProductList);
            this.tabPage1.Controls.Add(this.totalPoints);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(214, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // orderProductList
            // 
            this.orderProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderProductList.FormattingEnabled = true;
            this.orderProductList.ItemHeight = 18;
            this.orderProductList.Items.AddRange(new object[] {
            "- Vita Antioxidant |45pts",
            "- HealthPak |25pts",
            "- CoQuinone 30 |15pts",
            "- Visionex DS |65pts"});
            this.orderProductList.Location = new System.Drawing.Point(0, 0);
            this.orderProductList.Name = "orderProductList";
            this.orderProductList.Size = new System.Drawing.Size(214, 198);
            this.orderProductList.TabIndex = 0;
            // 
            // totalPoints
            // 
            this.totalPoints.AutoSize = true;
            this.totalPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.totalPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalPoints.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPoints.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.totalPoints.Location = new System.Drawing.Point(38, 210);
            this.totalPoints.Name = "totalPoints";
            this.totalPoints.Size = new System.Drawing.Size(121, 16);
            this.totalPoints.TabIndex = 8;
            this.totalPoints.Text = "Total points: 150";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.pictureBox3.Location = new System.Drawing.Point(-2, 206);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(218, 30);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.estimatedDeliveryDate);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.orderDeliveredDate);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.orderSentDate);
            this.tabPage2.Controls.Add(this.orderPlacedDate);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(214, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order Status";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // estimatedDeliveryDate
            // 
            this.estimatedDeliveryDate.AutoSize = true;
            this.estimatedDeliveryDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.estimatedDeliveryDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estimatedDeliveryDate.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimatedDeliveryDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.estimatedDeliveryDate.Location = new System.Drawing.Point(51, 214);
            this.estimatedDeliveryDate.Name = "estimatedDeliveryDate";
            this.estimatedDeliveryDate.Size = new System.Drawing.Size(76, 14);
            this.estimatedDeliveryDate.TabIndex = 11;
            this.estimatedDeliveryDate.Text = "May 1st 2020";
            this.estimatedDeliveryDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(17, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 14);
            this.label10.TabIndex = 10;
            this.label10.Text = "Estimated Delivery Date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.pictureBox4.Location = new System.Drawing.Point(-4, 196);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(218, 39);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Order Delivered";
            // 
            // orderDeliveredDate
            // 
            this.orderDeliveredDate.AutoSize = true;
            this.orderDeliveredDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDeliveredDate.Location = new System.Drawing.Point(6, 165);
            this.orderDeliveredDate.Name = "orderDeliveredDate";
            this.orderDeliveredDate.Size = new System.Drawing.Size(93, 16);
            this.orderDeliveredDate.TabIndex = 4;
            this.orderDeliveredDate.Text = "May 1st 2020";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Order Sent";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // orderSentDate
            // 
            this.orderSentDate.AutoSize = true;
            this.orderSentDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSentDate.Location = new System.Drawing.Point(6, 97);
            this.orderSentDate.Name = "orderSentDate";
            this.orderSentDate.Size = new System.Drawing.Size(104, 16);
            this.orderSentDate.TabIndex = 2;
            this.orderSentDate.Text = "April 27th 2020";
            // 
            // orderPlacedDate
            // 
            this.orderPlacedDate.AutoSize = true;
            this.orderPlacedDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPlacedDate.Location = new System.Drawing.Point(6, 26);
            this.orderPlacedDate.Name = "orderPlacedDate";
            this.orderPlacedDate.Size = new System.Drawing.Size(104, 16);
            this.orderPlacedDate.TabIndex = 1;
            this.orderPlacedDate.Text = "April 20th 2020";
            this.orderPlacedDate.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Order Placed";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderInfoTab);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.orderList);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OrderPage";
            this.Size = new System.Drawing.Size(602, 391);
            this.Load += new System.EventHandler(this.OrderPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.orderInfoTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox orderList;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label clientName;
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
        private System.Windows.Forms.Label totalPoints;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label estimatedDeliveryDate;
    }
}
