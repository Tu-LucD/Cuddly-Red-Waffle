namespace Cuddly_Red_Waffle_app
{
    partial class Requests
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
            this.requestsListBox = new System.Windows.Forms.ListBox();
            this.requestItemsListBox = new System.Windows.Forms.ListBox();
            this.currentRequestLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // requestsListBox
            // 
            this.requestsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestsListBox.FormattingEnabled = true;
            this.requestsListBox.ItemHeight = 20;
            this.requestsListBox.Location = new System.Drawing.Point(201, 60);
            this.requestsListBox.Name = "requestsListBox";
            this.requestsListBox.Size = new System.Drawing.Size(265, 364);
            this.requestsListBox.TabIndex = 3;
            // 
            // requestItemsListBox
            // 
            this.requestItemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestItemsListBox.FormattingEnabled = true;
            this.requestItemsListBox.ItemHeight = 20;
            this.requestItemsListBox.Location = new System.Drawing.Point(509, 180);
            this.requestItemsListBox.Name = "requestItemsListBox";
            this.requestItemsListBox.Size = new System.Drawing.Size(265, 204);
            this.requestItemsListBox.TabIndex = 4;
            // 
            // currentRequestLabel
            // 
            this.currentRequestLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.currentRequestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentRequestLabel.Location = new System.Drawing.Point(509, 60);
            this.currentRequestLabel.Name = "currentRequestLabel";
            this.currentRequestLabel.Size = new System.Drawing.Size(265, 100);
            this.currentRequestLabel.TabIndex = 5;
            this.currentRequestLabel.Text = "Insert request info here";
            this.currentRequestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currentRequestLabel);
            this.Controls.Add(this.requestItemsListBox);
            this.Controls.Add(this.requestsListBox);
            this.Name = "Requests";
            this.Text = "Requests";
            this.Controls.SetChildIndex(this.requestsListBox, 0);
            this.Controls.SetChildIndex(this.requestItemsListBox, 0);
            this.Controls.SetChildIndex(this.currentRequestLabel, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox requestsListBox;
        private System.Windows.Forms.ListBox requestItemsListBox;
        private System.Windows.Forms.Label currentRequestLabel;
    }
}