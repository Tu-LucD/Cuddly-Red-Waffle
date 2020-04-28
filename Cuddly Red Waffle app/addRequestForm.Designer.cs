namespace Cuddly_Red_Waffle_app
{
    partial class addRequestForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.clientLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.completionStatusLabel = new System.Windows.Forms.Label();
            this.paymentStatusLabel = new System.Windows.Forms.Label();
            this.productsTextBox = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.clientNumberTextBox = new System.Windows.Forms.TextBox();
            this.paymentStatusComboBox = new System.Windows.Forms.ComboBox();
            this.completionComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(93, 226);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
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
            this.cancelButton.Location = new System.Drawing.Point(184, 226);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(35, 40);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(36, 13);
            this.clientLabel.TabIndex = 2;
            this.clientLabel.Text = "Client:";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Location = new System.Drawing.Point(35, 65);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(52, 13);
            this.productsLabel.TabIndex = 3;
            this.productsLabel.Text = "Products:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(35, 90);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(69, 13);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Date Placed:";
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(35, 115);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(41, 13);
            this.priorityLabel.TabIndex = 5;
            this.priorityLabel.Text = "Priority:";
            // 
            // completionStatusLabel
            // 
            this.completionStatusLabel.AutoSize = true;
            this.completionStatusLabel.Location = new System.Drawing.Point(35, 140);
            this.completionStatusLabel.Name = "completionStatusLabel";
            this.completionStatusLabel.Size = new System.Drawing.Size(95, 13);
            this.completionStatusLabel.TabIndex = 6;
            this.completionStatusLabel.Text = "Completion Status:";
            // 
            // paymentStatusLabel
            // 
            this.paymentStatusLabel.AutoSize = true;
            this.paymentStatusLabel.Location = new System.Drawing.Point(35, 165);
            this.paymentStatusLabel.Name = "paymentStatusLabel";
            this.paymentStatusLabel.Size = new System.Drawing.Size(84, 13);
            this.paymentStatusLabel.TabIndex = 7;
            this.paymentStatusLabel.Text = "Payment Status:";
            // 
            // productsTextBox
            // 
            this.productsTextBox.Location = new System.Drawing.Point(131, 62);
            this.productsTextBox.Name = "productsTextBox";
            this.productsTextBox.Size = new System.Drawing.Size(123, 20);
            this.productsTextBox.TabIndex = 9;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.MinimumSize = new System.Drawing.Size(285, 20);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(285, 20);
            this.headerLabel.TabIndex = 16;
            this.headerLabel.Text = "Input the request\'s information here!";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientNumberTextBox
            // 
            this.clientNumberTextBox.Location = new System.Drawing.Point(131, 37);
            this.clientNumberTextBox.Name = "clientNumberTextBox";
            this.clientNumberTextBox.Size = new System.Drawing.Size(123, 20);
            this.clientNumberTextBox.TabIndex = 12;
            // 
            // paymentStatusComboBox
            // 
            this.paymentStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentStatusComboBox.FormattingEnabled = true;
            this.paymentStatusComboBox.Items.AddRange(new object[] {
            "Paid ",
            "Not Paid"});
            this.paymentStatusComboBox.Location = new System.Drawing.Point(131, 162);
            this.paymentStatusComboBox.Name = "paymentStatusComboBox";
            this.paymentStatusComboBox.Size = new System.Drawing.Size(123, 21);
            this.paymentStatusComboBox.TabIndex = 17;
            // 
            // completionComboBox
            // 
            this.completionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.completionComboBox.FormattingEnabled = true;
            this.completionComboBox.Items.AddRange(new object[] {
            "Complete",
            "Not complete"});
            this.completionComboBox.Location = new System.Drawing.Point(131, 137);
            this.completionComboBox.Name = "completionComboBox";
            this.completionComboBox.Size = new System.Drawing.Size(123, 21);
            this.completionComboBox.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 87);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 4, 27, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.priorityComboBox.Location = new System.Drawing.Point(131, 113);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(123, 21);
            this.priorityComboBox.TabIndex = 20;
            // 
            // addRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.priorityComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.completionComboBox);
            this.Controls.Add(this.paymentStatusComboBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.clientNumberTextBox);
            this.Controls.Add(this.productsTextBox);
            this.Controls.Add(this.paymentStatusLabel);
            this.Controls.Add(this.completionStatusLabel);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Name = "addRequestForm";
            this.Text = "Add Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label completionStatusLabel;
        private System.Windows.Forms.Label paymentStatusLabel;
        private System.Windows.Forms.TextBox productsTextBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox clientNumberTextBox;
        private System.Windows.Forms.ComboBox paymentStatusComboBox;
        private System.Windows.Forms.ComboBox completionComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox priorityComboBox;
    }
}