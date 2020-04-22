namespace Cuddly_Red_Waffle_app
{
    partial class mainPage
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
            this.SuspendLayout();
            // 
            // archiveLabel
            // 
            this.archiveLabel.Click += new System.EventHandler(this.archiveLabel_Click);
            // 
            // usanaLabel
            // 
            this.usanaLabel.Click += new System.EventHandler(this.usanaLabel_Click);
            // 
            // contactLabel
            // 
            this.contactLabel.Click += new System.EventHandler(this.contactLabel_Click);
            // 
            // requestLabel
            // 
            this.requestLabel.Click += new System.EventHandler(this.requestLabel_Click);
            // 
            // clientLabel
            // 
            this.clientLabel.Click += new System.EventHandler(this.clientLabel_Click);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.Click += new System.EventHandler(this.inventoryLabel_Click);
            // 
            // aboutLabel
            // 
            this.aboutLabel.Click += new System.EventHandler(this.aboutLabel_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Name = "mainPage";
            this.Text = "Main Page";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

