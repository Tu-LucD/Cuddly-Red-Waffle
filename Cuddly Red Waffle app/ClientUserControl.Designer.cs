namespace Cuddly_Red_Waffle_app
{
    partial class ClientUserControl
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
            this.clientIDLabel = new System.Windows.Forms.Label();
            this.first_NameLabel = new System.Windows.Forms.Label();
            this.last_NameLabel = new System.Windows.Forms.Label();
            this.email_AddressLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.healthIDLabel = new System.Windows.Forms.Label();
            this.PersonalInfo = new System.Windows.Forms.GroupBox();
            this.clientIDTextBox = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSANA_DBDataSet = new Cuddly_Red_Waffle_app.USANA_DBDataSet();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.email_AddressTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.healthIDTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.clientListBox = new System.Windows.Forms.ListBox();
            this.uSANADBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Cuddly_Red_Waffle_app.USANA_DBDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new Cuddly_Red_Waffle_app.USANA_DBDataSetTableAdapters.TableAdapterManager();
            this.label6 = new System.Windows.Forms.Label();
            this.addClientButton = new System.Windows.Forms.Button();
            this.myClientsLabel = new System.Windows.Forms.Label();
            this.clientDetailsLabel = new System.Windows.Forms.Label();
            this.clientSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.updateClient = new System.Windows.Forms.Button();
            this.PersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSANA_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSANADBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clientIDLabel
            // 
            this.clientIDLabel.AutoSize = true;
            this.clientIDLabel.Location = new System.Drawing.Point(26, 39);
            this.clientIDLabel.Name = "clientIDLabel";
            this.clientIDLabel.Size = new System.Drawing.Size(50, 13);
            this.clientIDLabel.TabIndex = 0;
            this.clientIDLabel.Text = "Client ID:";
            // 
            // first_NameLabel
            // 
            this.first_NameLabel.AutoSize = true;
            this.first_NameLabel.Location = new System.Drawing.Point(26, 65);
            this.first_NameLabel.Name = "first_NameLabel";
            this.first_NameLabel.Size = new System.Drawing.Size(60, 13);
            this.first_NameLabel.TabIndex = 2;
            this.first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            this.last_NameLabel.AutoSize = true;
            this.last_NameLabel.Location = new System.Drawing.Point(26, 91);
            this.last_NameLabel.Name = "last_NameLabel";
            this.last_NameLabel.Size = new System.Drawing.Size(61, 13);
            this.last_NameLabel.TabIndex = 4;
            this.last_NameLabel.Text = "Last Name:";
            // 
            // email_AddressLabel
            // 
            this.email_AddressLabel.AutoSize = true;
            this.email_AddressLabel.Location = new System.Drawing.Point(26, 117);
            this.email_AddressLabel.Name = "email_AddressLabel";
            this.email_AddressLabel.Size = new System.Drawing.Size(76, 13);
            this.email_AddressLabel.TabIndex = 6;
            this.email_AddressLabel.Text = "Email Address:";
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Location = new System.Drawing.Point(26, 143);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(42, 13);
            this.adressLabel.TabIndex = 8;
            this.adressLabel.Text = "Adress:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(26, 169);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "Phone:";
            // 
            // healthIDLabel
            // 
            this.healthIDLabel.AutoSize = true;
            this.healthIDLabel.Location = new System.Drawing.Point(26, 195);
            this.healthIDLabel.Name = "healthIDLabel";
            this.healthIDLabel.Size = new System.Drawing.Size(86, 13);
            this.healthIDLabel.TabIndex = 12;
            this.healthIDLabel.Text = "Health Category:";
            // 
            // PersonalInfo
            // 
            this.PersonalInfo.BackColor = System.Drawing.Color.White;
            this.PersonalInfo.Controls.Add(this.updateClient);
            this.PersonalInfo.Controls.Add(this.clientIDLabel);
            this.PersonalInfo.Controls.Add(this.clientIDTextBox);
            this.PersonalInfo.Controls.Add(this.first_NameLabel);
            this.PersonalInfo.Controls.Add(this.first_NameTextBox);
            this.PersonalInfo.Controls.Add(this.last_NameLabel);
            this.PersonalInfo.Controls.Add(this.last_NameTextBox);
            this.PersonalInfo.Controls.Add(this.email_AddressLabel);
            this.PersonalInfo.Controls.Add(this.email_AddressTextBox);
            this.PersonalInfo.Controls.Add(this.adressLabel);
            this.PersonalInfo.Controls.Add(this.adressTextBox);
            this.PersonalInfo.Controls.Add(this.phoneLabel);
            this.PersonalInfo.Controls.Add(this.phoneTextBox);
            this.PersonalInfo.Controls.Add(this.healthIDLabel);
            this.PersonalInfo.Controls.Add(this.healthIDTextBox);
            this.PersonalInfo.Location = new System.Drawing.Point(310, 53);
            this.PersonalInfo.Name = "PersonalInfo";
            this.PersonalInfo.Size = new System.Drawing.Size(240, 276);
            this.PersonalInfo.TabIndex = 1;
            this.PersonalInfo.TabStop = false;
            // 
            // clientIDTextBox
            // 
            this.clientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientID", true));
            this.clientIDTextBox.Location = new System.Drawing.Point(118, 36);
            this.clientIDTextBox.Name = "clientIDTextBox";
            this.clientIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientIDTextBox.TabIndex = 1;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.uSANA_DBDataSet;
            // 
            // uSANA_DBDataSet
            // 
            this.uSANA_DBDataSet.DataSetName = "USANA_DBDataSet";
            this.uSANA_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "First Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(118, 62);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_NameTextBox.TabIndex = 3;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Last Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(118, 88);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.last_NameTextBox.TabIndex = 5;
            // 
            // email_AddressTextBox
            // 
            this.email_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Email Address", true));
            this.email_AddressTextBox.Location = new System.Drawing.Point(118, 114);
            this.email_AddressTextBox.Name = "email_AddressTextBox";
            this.email_AddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.email_AddressTextBox.TabIndex = 7;
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(118, 140);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(100, 20);
            this.adressTextBox.TabIndex = 9;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(118, 166);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 11;
            // 
            // healthIDTextBox
            // 
            this.healthIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "HealthID", true));
            this.healthIDTextBox.Location = new System.Drawing.Point(118, 192);
            this.healthIDTextBox.Name = "healthIDTextBox";
            this.healthIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.healthIDTextBox.TabIndex = 13;
            // 
            // clientListBox
            // 
            this.clientListBox.BackColor = System.Drawing.Color.White;
            this.clientListBox.DataSource = this.clientBindingSource;
            this.clientListBox.DisplayMember = "First Name";
            this.clientListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientListBox.FormattingEnabled = true;
            this.clientListBox.ItemHeight = 16;
            this.clientListBox.Location = new System.Drawing.Point(55, 53);
            this.clientListBox.Name = "clientListBox";
            this.clientListBox.Size = new System.Drawing.Size(190, 276);
            this.clientListBox.TabIndex = 12;
            // 
            // uSANADBDataSetBindingSource
            // 
            this.uSANADBDataSetBindingSource.DataSource = this.uSANA_DBDataSet;
            this.uSANADBDataSetBindingSource.Position = 0;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.HealthCategoryTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RequestTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cuddly_Red_Waffle_app.USANA_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 13;
            // 
            // addClientButton
            // 
            this.addClientButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addClientButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.addClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addClientButton.Location = new System.Drawing.Point(55, 329);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(190, 28);
            this.addClientButton.TabIndex = 12;
            this.addClientButton.Text = "Add Client";
            this.addClientButton.UseVisualStyleBackColor = false;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // myClientsLabel
            // 
            this.myClientsLabel.AutoSize = true;
            this.myClientsLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.myClientsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myClientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myClientsLabel.ForeColor = System.Drawing.Color.White;
            this.myClientsLabel.Location = new System.Drawing.Point(55, 23);
            this.myClientsLabel.MinimumSize = new System.Drawing.Size(190, 30);
            this.myClientsLabel.Name = "myClientsLabel";
            this.myClientsLabel.Size = new System.Drawing.Size(190, 30);
            this.myClientsLabel.TabIndex = 14;
            this.myClientsLabel.Text = "My Clients";
            this.myClientsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientDetailsLabel
            // 
            this.clientDetailsLabel.AutoSize = true;
            this.clientDetailsLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.clientDetailsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientDetailsLabel.ForeColor = System.Drawing.Color.White;
            this.clientDetailsLabel.Location = new System.Drawing.Point(310, 23);
            this.clientDetailsLabel.MinimumSize = new System.Drawing.Size(240, 30);
            this.clientDetailsLabel.Name = "clientDetailsLabel";
            this.clientDetailsLabel.Size = new System.Drawing.Size(240, 30);
            this.clientDetailsLabel.TabIndex = 15;
            this.clientDetailsLabel.Text = "Client Details";
            this.clientDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientSearch
            // 
            this.clientSearch.Location = new System.Drawing.Point(310, 329);
            this.clientSearch.Multiline = true;
            this.clientSearch.Name = "clientSearch";
            this.clientSearch.Size = new System.Drawing.Size(144, 20);
            this.clientSearch.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(460, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 20);
            this.button1.TabIndex = 17;
            this.button1.Text = "Search a Client";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateClient
            // 
            this.updateClient.BackColor = System.Drawing.SystemColors.Highlight;
            this.updateClient.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.updateClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateClient.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.updateClient.Location = new System.Drawing.Point(29, 236);
            this.updateClient.Name = "updateClient";
            this.updateClient.Size = new System.Drawing.Size(73, 22);
            this.updateClient.TabIndex = 18;
            this.updateClient.Text = "Update";
            this.updateClient.UseVisualStyleBackColor = false;
            this.updateClient.Click += new System.EventHandler(this.updateClient_Click);
            // 
            // ClientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientSearch);
            this.Controls.Add(this.clientDetailsLabel);
            this.Controls.Add(this.myClientsLabel);
            this.Controls.Add(this.clientListBox);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PersonalInfo);
            this.Name = "ClientUserControl";
            this.Size = new System.Drawing.Size(602, 391);
            this.Load += new System.EventHandler(this.ClientUserControl_Load);
            this.PersonalInfo.ResumeLayout(false);
            this.PersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSANA_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSANADBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PersonalInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;


        private System.Windows.Forms.ListBox clientListBox;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private USANA_DBDataSet uSANA_DBDataSet;
        private System.Windows.Forms.BindingSource uSANADBDataSetBindingSource;
        private USANA_DBDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.TextBox clientIDTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox email_AddressTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox healthIDTextBox;
        private USANA_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Label clientIDLabel;
        private System.Windows.Forms.Label first_NameLabel;
        private System.Windows.Forms.Label last_NameLabel;
        private System.Windows.Forms.Label email_AddressLabel;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label healthIDLabel;
        private System.Windows.Forms.Label myClientsLabel;
        private System.Windows.Forms.Label clientDetailsLabel;
        private System.Windows.Forms.TextBox clientSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updateClient;
    }
}
