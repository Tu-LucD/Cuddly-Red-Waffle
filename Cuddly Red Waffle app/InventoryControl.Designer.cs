namespace Cuddly_Red_Waffle_app
{
    partial class InventoryControl
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
            System.Windows.Forms.Label preferential_Price_With_TaxesLabel;
            System.Windows.Forms.Label retail_Price_With_TaxLabel;
            System.Windows.Forms.Label health_CategoryLabel;
            System.Windows.Forms.Label vVPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryControl));
            this.productsLabel = new System.Windows.Forms.Label();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.productInfoBox = new System.Windows.Forms.GroupBox();
            this.vVPLabel1 = new System.Windows.Forms.Label();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uSANA_DBDataSet = new Cuddly_Red_Waffle_app.USANA_DBDataSet();
            this.health_CategoryLabel2 = new System.Windows.Forms.Label();
            this.retail_Price_With_TaxLabel1 = new System.Windows.Forms.Label();
            this.preferential_Price_With_TaxesLabel1 = new System.Windows.Forms.Label();
            this.restockDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.notesLabel = new System.Windows.Forms.Label();
            this.restockLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.productPicture = new System.Windows.Forms.PictureBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.productsTableAdapter = new Cuddly_Red_Waffle_app.USANA_DBDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new Cuddly_Red_Waffle_app.USANA_DBDataSetTableAdapters.TableAdapterManager();
            this.removeBtn = new System.Windows.Forms.Button();
            preferential_Price_With_TaxesLabel = new System.Windows.Forms.Label();
            retail_Price_With_TaxLabel = new System.Windows.Forms.Label();
            health_CategoryLabel = new System.Windows.Forms.Label();
            vVPLabel = new System.Windows.Forms.Label();
            this.productInfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSANA_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // preferential_Price_With_TaxesLabel
            // 
            preferential_Price_With_TaxesLabel.AutoSize = true;
            preferential_Price_With_TaxesLabel.Location = new System.Drawing.Point(3, 202);
            preferential_Price_With_TaxesLabel.Name = "preferential_Price_With_TaxesLabel";
            preferential_Price_With_TaxesLabel.Size = new System.Drawing.Size(131, 13);
            preferential_Price_With_TaxesLabel.TabIndex = 10;
            preferential_Price_With_TaxesLabel.Text = "Preferential Price + Taxes:";
            // 
            // retail_Price_With_TaxLabel
            // 
            retail_Price_With_TaxLabel.AutoSize = true;
            retail_Price_With_TaxLabel.Location = new System.Drawing.Point(3, 226);
            retail_Price_With_TaxLabel.Name = "retail_Price_With_TaxLabel";
            retail_Price_With_TaxLabel.Size = new System.Drawing.Size(94, 13);
            retail_Price_With_TaxLabel.TabIndex = 11;
            retail_Price_With_TaxLabel.Text = "Retail Price + Tax:";
            // 
            // health_CategoryLabel
            // 
            health_CategoryLabel.AutoSize = true;
            health_CategoryLabel.Location = new System.Drawing.Point(3, 255);
            health_CategoryLabel.Name = "health_CategoryLabel";
            health_CategoryLabel.Size = new System.Drawing.Size(86, 13);
            health_CategoryLabel.TabIndex = 12;
            health_CategoryLabel.Text = "Health Category:";
            // 
            // vVPLabel
            // 
            vVPLabel.AutoSize = true;
            vVPLabel.Location = new System.Drawing.Point(6, 279);
            vVPLabel.Name = "vVPLabel";
            vVPLabel.Size = new System.Drawing.Size(31, 13);
            vVPLabel.TabIndex = 13;
            vVPLabel.Text = "VVP:";
            // 
            // productsLabel
            // 
            this.productsLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.productsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.ForeColor = System.Drawing.Color.White;
            this.productsLabel.Location = new System.Drawing.Point(30, 29);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(153, 27);
            this.productsLabel.TabIndex = 1;
            this.productsLabel.Text = "My Products";
            this.productsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.productsLabel.Click += new System.EventHandler(this.productsLabel_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addProductBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.addProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.ForeColor = System.Drawing.Color.White;
            this.addProductBtn.Location = new System.Drawing.Point(30, 359);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(153, 31);
            this.addProductBtn.TabIndex = 2;
            this.addProductBtn.Text = "Add New Product";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // productInfoBox
            // 
            this.productInfoBox.BackColor = System.Drawing.Color.White;
            this.productInfoBox.Controls.Add(vVPLabel);
            this.productInfoBox.Controls.Add(this.vVPLabel1);
            this.productInfoBox.Controls.Add(this.health_CategoryLabel2);
            this.productInfoBox.Controls.Add(health_CategoryLabel);
            this.productInfoBox.Controls.Add(retail_Price_With_TaxLabel);
            this.productInfoBox.Controls.Add(this.retail_Price_With_TaxLabel1);
            this.productInfoBox.Controls.Add(preferential_Price_With_TaxesLabel);
            this.productInfoBox.Controls.Add(this.preferential_Price_With_TaxesLabel1);
            this.productInfoBox.Controls.Add(this.restockDateTimePicker);
            this.productInfoBox.Controls.Add(this.quantityNumericUpDown);
            this.productInfoBox.Controls.Add(this.notesLabel);
            this.productInfoBox.Controls.Add(this.restockLabel);
            this.productInfoBox.Controls.Add(this.quantityLabel);
            this.productInfoBox.Controls.Add(this.productPicture);
            this.productInfoBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productInfoBox.Location = new System.Drawing.Point(235, 29);
            this.productInfoBox.Name = "productInfoBox";
            this.productInfoBox.Size = new System.Drawing.Size(247, 327);
            this.productInfoBox.TabIndex = 3;
            this.productInfoBox.TabStop = false;
            // 
            // vVPLabel1
            // 
            this.vVPLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource1, "VVP", true));
            this.vVPLabel1.Location = new System.Drawing.Point(140, 279);
            this.vVPLabel1.Name = "vVPLabel1";
            this.vVPLabel1.Size = new System.Drawing.Size(100, 13);
            this.vVPLabel1.TabIndex = 14;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.uSANA_DBDataSet;
            // 
            // uSANA_DBDataSet
            // 
            this.uSANA_DBDataSet.DataSetName = "USANA_DBDataSet";
            this.uSANA_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // health_CategoryLabel2
            // 
            this.health_CategoryLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource1, "Health Category", true));
            this.health_CategoryLabel2.Location = new System.Drawing.Point(140, 255);
            this.health_CategoryLabel2.Name = "health_CategoryLabel2";
            this.health_CategoryLabel2.Size = new System.Drawing.Size(100, 13);
            this.health_CategoryLabel2.TabIndex = 13;
            // 
            // retail_Price_With_TaxLabel1
            // 
            this.retail_Price_With_TaxLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource1, "Retail Price With Tax", true));
            this.retail_Price_With_TaxLabel1.Location = new System.Drawing.Point(140, 226);
            this.retail_Price_With_TaxLabel1.Name = "retail_Price_With_TaxLabel1";
            this.retail_Price_With_TaxLabel1.Size = new System.Drawing.Size(100, 17);
            this.retail_Price_With_TaxLabel1.TabIndex = 12;
            // 
            // preferential_Price_With_TaxesLabel1
            // 
            this.preferential_Price_With_TaxesLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource1, "Preferential Price With Taxes", true));
            this.preferential_Price_With_TaxesLabel1.Location = new System.Drawing.Point(140, 202);
            this.preferential_Price_With_TaxesLabel1.Name = "preferential_Price_With_TaxesLabel1";
            this.preferential_Price_With_TaxesLabel1.Size = new System.Drawing.Size(100, 18);
            this.preferential_Price_With_TaxesLabel1.TabIndex = 11;
            // 
            // restockDateTimePicker
            // 
            this.restockDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource1, "restock", true));
            this.restockDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.restockDateTimePicker.Location = new System.Drawing.Point(99, 154);
            this.restockDateTimePicker.Name = "restockDateTimePicker";
            this.restockDateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.restockDateTimePicker.TabIndex = 10;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource1, "Quantity", true));
            this.quantityNumericUpDown.Location = new System.Drawing.Point(159, 128);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(35, 20);
            this.quantityNumericUpDown.TabIndex = 9;
            this.quantityNumericUpDown.ValueChanged += new System.EventHandler(this.quantityNumericUpDown_ValueChanged);
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.Location = new System.Drawing.Point(76, 184);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(40, 13);
            this.notesLabel.TabIndex = 5;
            this.notesLabel.Text = "Notes";
            // 
            // restockLabel
            // 
            this.restockLabel.AutoSize = true;
            this.restockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restockLabel.Location = new System.Drawing.Point(6, 154);
            this.restockLabel.Name = "restockLabel";
            this.restockLabel.Size = new System.Drawing.Size(75, 13);
            this.restockLabel.TabIndex = 3;
            this.restockLabel.Text = "Restocking:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(6, 130);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(110, 13);
            this.quantityLabel.TabIndex = 1;
            this.quantityLabel.Text = "Quantity In Stock:";
            // 
            // productPicture
            // 
            this.productPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("productPicture.BackgroundImage")));
            this.productPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.productPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("productPicture.InitialImage")));
            this.productPicture.Location = new System.Drawing.Point(40, 19);
            this.productPicture.Name = "productPicture";
            this.productPicture.Size = new System.Drawing.Size(124, 103);
            this.productPicture.TabIndex = 0;
            this.productPicture.TabStop = false;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.uSANA_DBDataSet;
            // 
            // productsListBox
            // 
            this.productsListBox.DataSource = this.productsBindingSource1;
            this.productsListBox.DisplayMember = "Product Name";
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.Location = new System.Drawing.Point(30, 60);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(153, 290);
            this.productsListBox.TabIndex = 4;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.HealthCategoryTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.RequestTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cuddly_Red_Waffle_app.USANA_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(235, 359);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(153, 31);
            this.removeBtn.TabIndex = 5;
            this.removeBtn.Text = "Remove Product";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // InventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.productsListBox);
            this.Controls.Add(this.productInfoBox);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.productsLabel);
            this.Name = "InventoryControl";
            this.Size = new System.Drawing.Size(591, 456);
            this.Load += new System.EventHandler(this.InventoryControl_Load);
            this.productInfoBox.ResumeLayout(false);
            this.productInfoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSANA_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.GroupBox productInfoBox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Label restockLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.PictureBox productPicture;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private USANA_DBDataSet uSANA_DBDataSet;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private USANA_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker restockDateTimePicker;
        public System.Windows.Forms.ListBox productsListBox;
        public USANA_DBDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label retail_Price_With_TaxLabel1;
        private System.Windows.Forms.Label preferential_Price_With_TaxesLabel1;
        private System.Windows.Forms.Label health_CategoryLabel2;
        private System.Windows.Forms.Label vVPLabel1;
    }
}
