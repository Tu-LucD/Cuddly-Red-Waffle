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
            this.SuspendLayout();
            // 
            // requestsListBox
            // 
            this.requestsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestsListBox.FormattingEnabled = true;
            this.requestsListBox.ItemHeight = 20;
            this.requestsListBox.Location = new System.Drawing.Point(16, 20);
            this.requestsListBox.Name = "requestsListBox";
            this.requestsListBox.Size = new System.Drawing.Size(235, 364);
            this.requestsListBox.TabIndex = 0;
            // 
            // requestItemsListBox
            // 
            this.requestItemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestItemsListBox.FormattingEnabled = true;
            this.requestItemsListBox.ItemHeight = 20;
            this.requestItemsListBox.Location = new System.Drawing.Point(307, 127);
            this.requestItemsListBox.Name = "requestItemsListBox";
            this.requestItemsListBox.Size = new System.Drawing.Size(235, 224);
            this.requestItemsListBox.TabIndex = 1;
            // 
            // requestTitleLabel
            // 
            this.requestTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestTitleLabel.Location = new System.Drawing.Point(303, 39);
            this.requestTitleLabel.Name = "requestTitleLabel";
            this.requestTitleLabel.Size = new System.Drawing.Size(235, 72);
            this.requestTitleLabel.TabIndex = 2;
            this.requestTitleLabel.Text = "Insert request info";
            this.requestTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.requestTitleLabel);
            this.Controls.Add(this.requestItemsListBox);
            this.Controls.Add(this.requestsListBox);
            this.Name = "Requests";
            this.Size = new System.Drawing.Size(545, 397);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox requestsListBox;
        private System.Windows.Forms.ListBox requestItemsListBox;
        private System.Windows.Forms.Label requestTitleLabel;
    }
}
