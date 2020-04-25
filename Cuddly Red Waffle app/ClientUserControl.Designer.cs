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
            System.Windows.Forms.Label clientIDLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label email_AddressLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label healthIDLabel;
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
            clientIDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            email_AddressLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            healthIDLabel = new System.Windows.Forms.Label();
            this.PersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSANA_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSANADBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clientIDLabel
            // 
            clientIDLabel.AutoSize = true;
            clientIDLabel.Location = new System.Drawing.Point(31, 39);
            clientIDLabel.Name = "clientIDLabel";
            clientIDLabel.Size = new System.Drawing.Size(50, 13);
            clientIDLabel.TabIndex = 0;
            clientIDLabel.Text = "Client ID:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(31, 65);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 2;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(31, 91);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 4;
            last_NameLabel.Text = "Last Name:";
            // 
            // email_AddressLabel
            // 
            email_AddressLabel.AutoSize = true;
            email_AddressLabel.Location = new System.Drawing.Point(31, 117);
            email_AddressLabel.Name = "email_AddressLabel";
            email_AddressLabel.Size = new System.Drawing.Size(76, 13);
            email_AddressLabel.TabIndex = 6;
            email_AddressLabel.Text = "Email Address:";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(31, 143);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(42, 13);
            adressLabel.TabIndex = 8;
            adressLabel.Text = "Adress:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(31, 169);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 10;
            phoneLabel.Text = "Phone:";
            // 
            // healthIDLabel
            // 
            healthIDLabel.AutoSize = true;
            healthIDLabel.Location = new System.Drawing.Point(31, 195);
            healthIDLabel.Name = "healthIDLabel";
            healthIDLabel.Size = new System.Drawing.Size(86, 13);
            healthIDLabel.TabIndex = 12;
            healthIDLabel.Text = "Health Category:";
            // 
            // PersonalInfo
            // 
            this.PersonalInfo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PersonalInfo.Controls.Add(clientIDLabel);
            this.PersonalInfo.Controls.Add(this.clientIDTextBox);
            this.PersonalInfo.Controls.Add(first_NameLabel);
            this.PersonalInfo.Controls.Add(this.first_NameTextBox);
            this.PersonalInfo.Controls.Add(last_NameLabel);
            this.PersonalInfo.Controls.Add(this.last_NameTextBox);
            this.PersonalInfo.Controls.Add(email_AddressLabel);
            this.PersonalInfo.Controls.Add(this.email_AddressTextBox);
            this.PersonalInfo.Controls.Add(adressLabel);
            this.PersonalInfo.Controls.Add(this.adressTextBox);
            this.PersonalInfo.Controls.Add(phoneLabel);
            this.PersonalInfo.Controls.Add(this.phoneTextBox);
            this.PersonalInfo.Controls.Add(healthIDLabel);
            this.PersonalInfo.Controls.Add(this.healthIDTextBox);
            this.PersonalInfo.Location = new System.Drawing.Point(272, 51);
            this.PersonalInfo.Name = "PersonalInfo";
            this.PersonalInfo.Size = new System.Drawing.Size(250, 258);
            this.PersonalInfo.TabIndex = 1;
            this.PersonalInfo.TabStop = false;
            // 
            // clientIDTextBox
            // 
            this.clientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientID", true));
            this.clientIDTextBox.Location = new System.Drawing.Point(123, 36);
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
            this.first_NameTextBox.Location = new System.Drawing.Point(123, 62);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_NameTextBox.TabIndex = 3;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Last Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(123, 88);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.last_NameTextBox.TabIndex = 5;
            // 
            // email_AddressTextBox
            // 
            this.email_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Email Address", true));
            this.email_AddressTextBox.Location = new System.Drawing.Point(123, 114);
            this.email_AddressTextBox.Name = "email_AddressTextBox";
            this.email_AddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.email_AddressTextBox.TabIndex = 7;
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(123, 140);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(100, 20);
            this.adressTextBox.TabIndex = 9;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(123, 166);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 11;
            // 
            // healthIDTextBox
            // 
            this.healthIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "HealthID", true));
            this.healthIDTextBox.Location = new System.Drawing.Point(123, 192);
            this.healthIDTextBox.Name = "healthIDTextBox";
            this.healthIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.healthIDTextBox.TabIndex = 13;
            // 
            // clientListBox
            // 
            this.clientListBox.DataSource = this.clientBindingSource;
            this.clientListBox.DisplayMember = "First Name";
            this.clientListBox.FormattingEnabled = true;
            this.clientListBox.Location = new System.Drawing.Point(58, 42);
            this.clientListBox.Name = "clientListBox";
            this.clientListBox.Size = new System.Drawing.Size(142, 238);
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
            this.addClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addClientButton.Location = new System.Drawing.Point(31, 301);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(180, 30);
            this.addClientButton.TabIndex = 12;
            this.addClientButton.Text = "Add Client";
            this.addClientButton.UseVisualStyleBackColor = false;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // ClientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
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

    }
}
