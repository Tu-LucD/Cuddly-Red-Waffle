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
            this.requestsListBox = new System.Windows.Forms.ListBox();
            this.requestItemsListBox = new System.Windows.Forms.ListBox();
            this.requestTitleLabel = new System.Windows.Forms.Label();
            this.myRequestsLabel = new System.Windows.Forms.Label();
            this.addRequestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // requestsListBox
            // 
            this.requestsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestsListBox.FormattingEnabled = true;
            this.requestsListBox.ItemHeight = 20;
            this.requestsListBox.Location = new System.Drawing.Point(55, 53);
            this.requestsListBox.Name = "requestsListBox";
            this.requestsListBox.Size = new System.Drawing.Size(190, 264);
            this.requestsListBox.TabIndex = 0;
            // 
            // requestItemsListBox
            // 
            this.requestItemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestItemsListBox.FormattingEnabled = true;
            this.requestItemsListBox.ItemHeight = 20;
            this.requestItemsListBox.Location = new System.Drawing.Point(310, 53);
            this.requestItemsListBox.Name = "requestItemsListBox";
            this.requestItemsListBox.Size = new System.Drawing.Size(240, 284);
            this.requestItemsListBox.TabIndex = 1;
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
            this.addRequestButton.Location = new System.Drawing.Point(55, 316);
            this.addRequestButton.Name = "addRequestButton";
            this.addRequestButton.Size = new System.Drawing.Size(190, 30);
            this.addRequestButton.TabIndex = 4;
            this.addRequestButton.Text = "Add Request";
            this.addRequestButton.UseVisualStyleBackColor = false;
            // 
            // RequestsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addRequestButton);
            this.Controls.Add(this.myRequestsLabel);
            this.Controls.Add(this.requestTitleLabel);
            this.Controls.Add(this.requestItemsListBox);
            this.Controls.Add(this.requestsListBox);
            this.Name = "RequestsUserControl";
            this.Size = new System.Drawing.Size(602, 391);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox requestsListBox;
        private System.Windows.Forms.ListBox requestItemsListBox;
        private System.Windows.Forms.Label requestTitleLabel;
        private System.Windows.Forms.Label myRequestsLabel;
        private System.Windows.Forms.Button addRequestButton;
    }
}
