namespace Cuddly_Red_Waffle_app
{
    partial class RequestsUserControl
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
            System.Windows.Forms.Label requestIDLabel;
            System.Windows.Forms.Label date_PlacedLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label completedLabel;
            System.Windows.Forms.Label clientLabel;
            System.Windows.Forms.Label productsLabel;
            System.Windows.Forms.Label payedLabel;
            this.requestsListBox = new System.Windows.Forms.ListBox();
            this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSANA_DBDataSet = new Cuddly_Red_Waffle_app.USANA_DBDataSet();
            this.requestTitleLabel = new System.Windows.Forms.Label();
            this.myRequestsLabel = new System.Windows.Forms.Label();
            this.addRequestButton = new System.Windows.Forms.Button();
            this.requestTableAdapter = new Cuddly_Red_Waffle_app.USANA_DBDataSetTableAdapters.RequestTableAdapter();
            this.requestGroupBox = new System.Windows.Forms.GroupBox();
            this.legendLabel = new System.Windows.Forms.Label();
            this.payedCheckBox = new System.Windows.Forms.CheckBox();
            this.requestIDTextBox = new System.Windows.Forms.TextBox();
            this.date_PlacedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.completedCheckBox = new System.Windows.Forms.CheckBox();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.productsTextBox = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new Cuddly_Red_Waffle_app.USANA_DBDataSetTableAdapters.TableAdapterManager();
            this.refreshButton = new System.Windows.Forms.Button();
            requestIDLabel = new System.Windows.Forms.Label();
            date_PlacedLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            completedLabel = new System.Windows.Forms.Label();
            clientLabel = new System.Windows.Forms.Label();
            productsLabel = new System.Windows.Forms.Label();
            payedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSANA_DBDataSet)).BeginInit();
            this.requestGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestIDLabel
            // 
            requestIDLabel.AutoSize = true;
            requestIDLabel.Location = new System.Drawing.Point(20, 40);
            requestIDLabel.Name = "requestIDLabel";
            requestIDLabel.Size = new System.Drawing.Size(64, 13);
            requestIDLabel.TabIndex = 0;
            requestIDLabel.Text = "Request ID:";
            // 
            // date_PlacedLabel
            // 
            date_PlacedLabel.AutoSize = true;
            date_PlacedLabel.Location = new System.Drawing.Point(20, 67);
            date_PlacedLabel.Name = "date_PlacedLabel";
            date_PlacedLabel.Size = new System.Drawing.Size(69, 13);
            date_PlacedLabel.TabIndex = 2;
            date_PlacedLabel.Text = "Date Placed:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new System.Drawing.Point(20, 92);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(41, 13);
            priorityLabel.TabIndex = 4;
            priorityLabel.Text = "Priority:";
            // 
            // completedLabel
            // 
            completedLabel.AutoSize = true;
            completedLabel.Location = new System.Drawing.Point(20, 120);
            completedLabel.Name = "completedLabel";
            completedLabel.Size = new System.Drawing.Size(60, 13);
            completedLabel.TabIndex = 6;
            completedLabel.Text = "Completed:";
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.Location = new System.Drawing.Point(20, 178);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new System.Drawing.Size(36, 13);
            clientLabel.TabIndex = 10;
            clientLabel.Text = "Client:";
            // 
            // productsLabel
            // 
            productsLabel.AutoSize = true;
            productsLabel.Location = new System.Drawing.Point(20, 204);
            productsLabel.Name = "productsLabel";
            productsLabel.Size = new System.Drawing.Size(52, 13);
            productsLabel.TabIndex = 12;
            productsLabel.Text = "Products:";
            // 
            // payedLabel
            // 
            payedLabel.AutoSize = true;
            payedLabel.Location = new System.Drawing.Point(20, 150);
            payedLabel.Name = "payedLabel";
            payedLabel.Size = new System.Drawing.Size(40, 13);
            payedLabel.TabIndex = 13;
            payedLabel.Text = "Payed:";
            // 
            // requestsListBox
            // 
            this.requestsListBox.DataSource = this.requestBindingSource;
            this.requestsListBox.DisplayMember = "RequestID";
            this.requestsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestsListBox.FormattingEnabled = true;
            this.requestsListBox.ItemHeight = 16;
            this.requestsListBox.Location = new System.Drawing.Point(55, 53);
            this.requestsListBox.Name = "requestsListBox";
            this.requestsListBox.Size = new System.Drawing.Size(190, 276);
            this.requestsListBox.TabIndex = 0;
            // 
            // requestBindingSource
            // 
            this.requestBindingSource.DataMember = "Request";
            this.requestBindingSource.DataSource = this.uSANA_DBDataSet;
            // 
            // uSANA_DBDataSet
            // 
            this.uSANA_DBDataSet.DataSetName = "USANA_DBDataSet";
            this.uSANA_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestTitleLabel
            // 
            this.requestTitleLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.requestTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requestTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.requestTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestTitleLabel.ForeColor = System.Drawing.Color.White;
            this.requestTitleLabel.Location = new System.Drawing.Point(310, 23);
            this.requestTitleLabel.Name = "requestTitleLabel";
            this.requestTitleLabel.Size = new System.Drawing.Size(240, 30);
            this.requestTitleLabel.TabIndex = 2;
            this.requestTitleLabel.Text = "Request Details";
            this.requestTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myRequestsLabel
            // 
            this.myRequestsLabel.AutoSize = true;
            this.myRequestsLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.myRequestsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myRequestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myRequestsLabel.ForeColor = System.Drawing.Color.White;
            this.myRequestsLabel.Location = new System.Drawing.Point(55, 23);
            this.myRequestsLabel.MinimumSize = new System.Drawing.Size(190, 30);
            this.myRequestsLabel.Name = "myRequestsLabel";
            this.myRequestsLabel.Size = new System.Drawing.Size(190, 30);
            this.myRequestsLabel.TabIndex = 3;
            this.myRequestsLabel.Text = "My Requests";
            this.myRequestsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addRequestButton
            // 
            this.addRequestButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addRequestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRequestButton.ForeColor = System.Drawing.Color.White;
            this.addRequestButton.Location = new System.Drawing.Point(55, 329);
            this.addRequestButton.Name = "addRequestButton";
            this.addRequestButton.Size = new System.Drawing.Size(190, 30);
            this.addRequestButton.TabIndex = 4;
            this.addRequestButton.Text = "Add Request";
            this.addRequestButton.UseVisualStyleBackColor = false;
            this.addRequestButton.Click += new System.EventHandler(this.addRequestButton_Click);
            // 
            // requestTableAdapter
            // 
            this.requestTableAdapter.ClearBeforeFill = true;
            // 
            // requestGroupBox
            // 
            this.requestGroupBox.BackColor = System.Drawing.Color.White;
            this.requestGroupBox.Controls.Add(this.legendLabel);
            this.requestGroupBox.Controls.Add(payedLabel);
            this.requestGroupBox.Controls.Add(this.payedCheckBox);
            this.requestGroupBox.Controls.Add(requestIDLabel);
            this.requestGroupBox.Controls.Add(this.requestIDTextBox);
            this.requestGroupBox.Controls.Add(date_PlacedLabel);
            this.requestGroupBox.Controls.Add(this.date_PlacedDateTimePicker);
            this.requestGroupBox.Controls.Add(priorityLabel);
            this.requestGroupBox.Controls.Add(this.priorityTextBox);
            this.requestGroupBox.Controls.Add(completedLabel);
            this.requestGroupBox.Controls.Add(this.completedCheckBox);
            this.requestGroupBox.Controls.Add(clientLabel);
            this.requestGroupBox.Controls.Add(this.clientTextBox);
            this.requestGroupBox.Controls.Add(productsLabel);
            this.requestGroupBox.Controls.Add(this.productsTextBox);
            this.requestGroupBox.Location = new System.Drawing.Point(310, 53);
            this.requestGroupBox.Name = "requestGroupBox";
            this.requestGroupBox.Size = new System.Drawing.Size(240, 306);
            this.requestGroupBox.TabIndex = 5;
            this.requestGroupBox.TabStop = false;
            // 
            // legendLabel
            // 
            this.legendLabel.AutoSize = true;
            this.legendLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.legendLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.legendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legendLabel.ForeColor = System.Drawing.Color.White;
            this.legendLabel.Location = new System.Drawing.Point(0, 270);
            this.legendLabel.MinimumSize = new System.Drawing.Size(240, 30);
            this.legendLabel.Name = "legendLabel";
            this.legendLabel.Size = new System.Drawing.Size(240, 34);
            this.legendLabel.TabIndex = 6;
            this.legendLabel.Text = "Priority\r\n0 = Low 1 = Medium 2 = High\r\n";
            this.legendLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payedCheckBox
            // 
            this.payedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.requestBindingSource, "Payed", true));
            this.payedCheckBox.Location = new System.Drawing.Point(98, 145);
            this.payedCheckBox.Name = "payedCheckBox";
            this.payedCheckBox.Size = new System.Drawing.Size(79, 24);
            this.payedCheckBox.TabIndex = 14;
            this.payedCheckBox.UseVisualStyleBackColor = true;
            // 
            // requestIDTextBox
            // 
            this.requestIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestBindingSource, "RequestID", true));
            this.requestIDTextBox.Location = new System.Drawing.Point(98, 37);
            this.requestIDTextBox.Name = "requestIDTextBox";
            this.requestIDTextBox.Size = new System.Drawing.Size(124, 20);
            this.requestIDTextBox.TabIndex = 1;
            // 
            // date_PlacedDateTimePicker
            // 
            this.date_PlacedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.requestBindingSource, "Date Placed", true));
            this.date_PlacedDateTimePicker.Location = new System.Drawing.Point(98, 63);
            this.date_PlacedDateTimePicker.Name = "date_PlacedDateTimePicker";
            this.date_PlacedDateTimePicker.Size = new System.Drawing.Size(124, 20);
            this.date_PlacedDateTimePicker.TabIndex = 3;
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestBindingSource, "Priority", true));
            this.priorityTextBox.Location = new System.Drawing.Point(98, 89);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(124, 20);
            this.priorityTextBox.TabIndex = 5;
            // 
            // completedCheckBox
            // 
            this.completedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.requestBindingSource, "Completed", true));
            this.completedCheckBox.Location = new System.Drawing.Point(98, 115);
            this.completedCheckBox.Name = "completedCheckBox";
            this.completedCheckBox.Size = new System.Drawing.Size(124, 24);
            this.completedCheckBox.TabIndex = 7;
            this.completedCheckBox.UseVisualStyleBackColor = true;
            // 
            // clientTextBox
            // 
            this.clientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestBindingSource, "Client", true));
            this.clientTextBox.Location = new System.Drawing.Point(98, 175);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.Size = new System.Drawing.Size(124, 20);
            this.clientTextBox.TabIndex = 11;
            // 
            // productsTextBox
            // 
            this.productsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestBindingSource, "Products", true));
            this.productsTextBox.Location = new System.Drawing.Point(98, 201);
            this.productsTextBox.Name = "productsTextBox";
            this.productsTextBox.Size = new System.Drawing.Size(124, 20);
            this.productsTextBox.TabIndex = 13;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.HealthCategoryTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RequestTableAdapter = this.requestTableAdapter;
            this.tableAdapterManager.UpdateOrder = Cuddly_Red_Waffle_app.USANA_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // RequestsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.requestGroupBox);
            this.Controls.Add(this.addRequestButton);
            this.Controls.Add(this.myRequestsLabel);
            this.Controls.Add(this.requestTitleLabel);
            this.Controls.Add(this.requestsListBox);
            this.Name = "RequestsUserControl";
            this.Size = new System.Drawing.Size(602, 391);
            this.Load += new System.EventHandler(this.RequestsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSANA_DBDataSet)).EndInit();
            this.requestGroupBox.ResumeLayout(false);
            this.requestGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox requestsListBox;
        private System.Windows.Forms.Label requestTitleLabel;
        private System.Windows.Forms.Label myRequestsLabel;
        private System.Windows.Forms.Button addRequestButton;
        private System.Windows.Forms.BindingSource requestBindingSource;
        private USANA_DBDataSet uSANA_DBDataSet;
        private USANA_DBDataSetTableAdapters.RequestTableAdapter requestTableAdapter;
        private System.Windows.Forms.GroupBox requestGroupBox;
        private System.Windows.Forms.TextBox requestIDTextBox;
        private System.Windows.Forms.DateTimePicker date_PlacedDateTimePicker;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.CheckBox completedCheckBox;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.TextBox productsTextBox;
        private USANA_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label legendLabel;
        private System.Windows.Forms.CheckBox payedCheckBox;
        private System.Windows.Forms.Button refreshButton;
    }
}
