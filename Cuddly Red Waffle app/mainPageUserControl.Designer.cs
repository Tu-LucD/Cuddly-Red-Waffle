namespace Cuddly_Red_Waffle_app
{
    partial class mainPageUserControl
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
            System.Windows.Forms.Label completedLabel;
            System.Windows.Forms.Label date_PlacedLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.addClientButton = new System.Windows.Forms.Button();
            this.addRequestButton = new System.Windows.Forms.Button();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.oldestTab = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSANA_DBDataSet = new Cuddly_Red_Waffle_app.USANA_DBDataSet();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.newestPage = new System.Windows.Forms.TabPage();
            this.date_PlacedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.completedCheckBox = new System.Windows.Forms.CheckBox();
            this.requestIDTextBox = new System.Windows.Forms.TextBox();
            this.newestRequests = new System.Windows.Forms.ListBox();
            this.requestTabControl = new System.Windows.Forms.TabControl();
            this.uSANADBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestTableAdapter = new Cuddly_Red_Waffle_app.USANA_DBDataSetTableAdapters.RequestTableAdapter();
            this.tableAdapterManager = new Cuddly_Red_Waffle_app.USANA_DBDataSetTableAdapters.TableAdapterManager();
            this.refreshButton = new System.Windows.Forms.Button();
            requestIDLabel = new System.Windows.Forms.Label();
            completedLabel = new System.Windows.Forms.Label();
            date_PlacedLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.oldestTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSANA_DBDataSet)).BeginInit();
            this.newestPage.SuspendLayout();
            this.requestTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSANADBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // requestIDLabel
            // 
            requestIDLabel.AutoSize = true;
            requestIDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            requestIDLabel.Location = new System.Drawing.Point(113, 6);
            requestIDLabel.Name = "requestIDLabel";
            requestIDLabel.Size = new System.Drawing.Size(64, 13);
            requestIDLabel.TabIndex = 3;
            requestIDLabel.Text = "Request ID:";
            // 
            // completedLabel
            // 
            completedLabel.AutoSize = true;
            completedLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            completedLabel.Location = new System.Drawing.Point(113, 54);
            completedLabel.Name = "completedLabel";
            completedLabel.Size = new System.Drawing.Size(60, 13);
            completedLabel.TabIndex = 4;
            completedLabel.Text = "Completed:";
            // 
            // date_PlacedLabel
            // 
            date_PlacedLabel.AutoSize = true;
            date_PlacedLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            date_PlacedLabel.Location = new System.Drawing.Point(113, 76);
            date_PlacedLabel.Name = "date_PlacedLabel";
            date_PlacedLabel.Size = new System.Drawing.Size(69, 13);
            date_PlacedLabel.TabIndex = 5;
            date_PlacedLabel.Text = "Date Placed:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(114, 78);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 13);
            label1.TabIndex = 11;
            label1.Text = "Date Placed:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(114, 56);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 13);
            label2.TabIndex = 9;
            label2.Text = "Completed:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Location = new System.Drawing.Point(114, 8);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 13);
            label3.TabIndex = 7;
            label3.Text = "Request ID:";
            // 
            // addClientButton
            // 
            this.addClientButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addClientButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.addClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addClientButton.Location = new System.Drawing.Point(55, 115);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(190, 30);
            this.addClientButton.TabIndex = 0;
            this.addClientButton.Text = "Add Client";
            this.addClientButton.UseVisualStyleBackColor = false;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // addRequestButton
            // 
            this.addRequestButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addRequestButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.addRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addRequestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRequestButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addRequestButton.Location = new System.Drawing.Point(55, 163);
            this.addRequestButton.Name = "addRequestButton";
            this.addRequestButton.Size = new System.Drawing.Size(190, 30);
            this.addRequestButton.TabIndex = 1;
            this.addRequestButton.Text = "Add Request";
            this.addRequestButton.UseVisualStyleBackColor = false;
            this.addRequestButton.Click += new System.EventHandler(this.addRequestButton_Click);
            // 
            // addOrderButton
            // 
            this.addOrderButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addOrderButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.addOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrderButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addOrderButton.Location = new System.Drawing.Point(55, 212);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(190, 30);
            this.addOrderButton.TabIndex = 2;
            this.addOrderButton.Text = "Add Order";
            this.addOrderButton.UseVisualStyleBackColor = false;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // oldestTab
            // 
            this.oldestTab.BackColor = System.Drawing.SystemColors.Highlight;
            this.oldestTab.Controls.Add(label1);
            this.oldestTab.Controls.Add(this.dateTimePicker1);
            this.oldestTab.Controls.Add(label2);
            this.oldestTab.Controls.Add(this.checkBox1);
            this.oldestTab.Controls.Add(label3);
            this.oldestTab.Controls.Add(this.textBox1);
            this.oldestTab.Controls.Add(this.listBox1);
            this.oldestTab.Location = new System.Drawing.Point(4, 22);
            this.oldestTab.Name = "oldestTab";
            this.oldestTab.Padding = new System.Windows.Forms.Padding(3);
            this.oldestTab.Size = new System.Drawing.Size(231, 305);
            this.oldestTab.TabIndex = 1;
            this.oldestTab.Text = "Oldest Requests";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.requestBindingSource, "Date Placed", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker1.TabIndex = 13;
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
            // checkBox1
            // 
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.requestBindingSource, "Completed", true));
            this.checkBox1.Location = new System.Drawing.Point(180, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(20, 24);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestBindingSource, "RequestID", true));
            this.textBox1.Location = new System.Drawing.Point(114, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.DataSource = this.requestBindingSource;
            this.listBox1.DisplayMember = "RequestID";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(4, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(104, 288);
            this.listBox1.TabIndex = 8;
            // 
            // newestPage
            // 
            this.newestPage.AutoScroll = true;
            this.newestPage.BackColor = System.Drawing.SystemColors.Highlight;
            this.newestPage.Controls.Add(date_PlacedLabel);
            this.newestPage.Controls.Add(this.date_PlacedDateTimePicker);
            this.newestPage.Controls.Add(completedLabel);
            this.newestPage.Controls.Add(this.completedCheckBox);
            this.newestPage.Controls.Add(requestIDLabel);
            this.newestPage.Controls.Add(this.requestIDTextBox);
            this.newestPage.Controls.Add(this.newestRequests);
            this.newestPage.Location = new System.Drawing.Point(4, 22);
            this.newestPage.Name = "newestPage";
            this.newestPage.Padding = new System.Windows.Forms.Padding(3);
            this.newestPage.Size = new System.Drawing.Size(231, 305);
            this.newestPage.TabIndex = 0;
            this.newestPage.Text = "Newest Requests";
            // 
            // date_PlacedDateTimePicker
            // 
            this.date_PlacedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.requestBindingSource, "Date Placed", true));
            this.date_PlacedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_PlacedDateTimePicker.Location = new System.Drawing.Point(116, 101);
            this.date_PlacedDateTimePicker.Name = "date_PlacedDateTimePicker";
            this.date_PlacedDateTimePicker.Size = new System.Drawing.Size(94, 20);
            this.date_PlacedDateTimePicker.TabIndex = 6;
            // 
            // completedCheckBox
            // 
            this.completedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.requestBindingSource, "Completed", true));
            this.completedCheckBox.Location = new System.Drawing.Point(179, 49);
            this.completedCheckBox.Name = "completedCheckBox";
            this.completedCheckBox.Size = new System.Drawing.Size(20, 24);
            this.completedCheckBox.TabIndex = 5;
            this.completedCheckBox.UseVisualStyleBackColor = true;
            // 
            // requestIDTextBox
            // 
            this.requestIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestBindingSource, "RequestID", true));
            this.requestIDTextBox.Location = new System.Drawing.Point(113, 22);
            this.requestIDTextBox.Name = "requestIDTextBox";
            this.requestIDTextBox.Size = new System.Drawing.Size(112, 20);
            this.requestIDTextBox.TabIndex = 4;
            // 
            // newestRequests
            // 
            this.newestRequests.BackColor = System.Drawing.SystemColors.Window;
            this.newestRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newestRequests.DataSource = this.requestBindingSource;
            this.newestRequests.DisplayMember = "RequestID";
            this.newestRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newestRequests.FormattingEnabled = true;
            this.newestRequests.ItemHeight = 16;
            this.newestRequests.Location = new System.Drawing.Point(3, 6);
            this.newestRequests.Name = "newestRequests";
            this.newestRequests.Size = new System.Drawing.Size(104, 288);
            this.newestRequests.TabIndex = 3;
            // 
            // requestTabControl
            // 
            this.requestTabControl.Controls.Add(this.newestPage);
            this.requestTabControl.Controls.Add(this.oldestTab);
            this.requestTabControl.Location = new System.Drawing.Point(301, 26);
            this.requestTabControl.Name = "requestTabControl";
            this.requestTabControl.SelectedIndex = 0;
            this.requestTabControl.Size = new System.Drawing.Size(239, 331);
            this.requestTabControl.TabIndex = 4;
            // 
            // uSANADBDataSetBindingSource
            // 
            this.uSANADBDataSetBindingSource.DataSource = this.uSANA_DBDataSet;
            this.uSANADBDataSetBindingSource.Position = 0;
            // 
            // requestTableAdapter
            // 
            this.requestTableAdapter.ClearBeforeFill = true;
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
            this.refreshButton.Location = new System.Drawing.Point(117, 70);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(60, 20);
            this.refreshButton.TabIndex = 18;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // mainPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.requestTabControl);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.addRequestButton);
            this.Controls.Add(this.addClientButton);
            this.Name = "mainPageUserControl";
            this.Size = new System.Drawing.Size(602, 391);
            this.Load += new System.EventHandler(this.mainPageUserControl_Load);
            this.oldestTab.ResumeLayout(false);
            this.oldestTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSANA_DBDataSet)).EndInit();
            this.newestPage.ResumeLayout(false);
            this.newestPage.PerformLayout();
            this.requestTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uSANADBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button addRequestButton;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.TabPage oldestTab;
        private System.Windows.Forms.TabPage newestPage;
        private System.Windows.Forms.ListBox newestRequests;
        private System.Windows.Forms.TabControl requestTabControl;
        private System.Windows.Forms.TextBox requestIDTextBox;
        private System.Windows.Forms.BindingSource requestBindingSource;
        private USANA_DBDataSet uSANA_DBDataSet;
        private System.Windows.Forms.BindingSource uSANADBDataSetBindingSource;
        private USANA_DBDataSetTableAdapters.RequestTableAdapter requestTableAdapter;
        private USANA_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker date_PlacedDateTimePicker;
        private System.Windows.Forms.CheckBox completedCheckBox;
        private System.Windows.Forms.Button refreshButton;
    }
}
