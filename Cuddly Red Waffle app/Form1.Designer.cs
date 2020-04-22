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
            this.mainPageUserControl1 = new Cuddly_Red_Waffle_app.mainPageUserControl();
            this.SuspendLayout();
            // 
            // mainPageUserControl1
            // 
            this.mainPageUserControl1.Location = new System.Drawing.Point(180, 40);
            this.mainPageUserControl1.Name = "mainPageUserControl1";
            this.mainPageUserControl1.Size = new System.Drawing.Size(620, 402);
            this.mainPageUserControl1.TabIndex = 4;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.mainPageUserControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainPage";
            this.Text = "Main Page";
            this.Controls.SetChildIndex(this.mainPageUserControl1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private mainPageUserControl mainPageUserControl1;
    }
}

