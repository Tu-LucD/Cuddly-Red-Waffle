namespace MenuInheritance
{
    partial class MenuForm
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.pagesPanel = new System.Windows.Forms.Panel();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.ordersLabel = new System.Windows.Forms.Label();
            this.archiveLabel = new System.Windows.Forms.Label();
            this.requestLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.usanaLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.settingsPictureBox = new System.Windows.Forms.PictureBox();
            this.usanaPictureBox = new System.Windows.Forms.PictureBox();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.menuPanel.SuspendLayout();
            this.pagesPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usanaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Gray;
            this.menuPanel.Controls.Add(this.searchBox);
            this.menuPanel.Controls.Add(this.pagesPanel);
            this.menuPanel.Location = new System.Drawing.Point(0, 40);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(180, 402);
            this.menuPanel.TabIndex = 1;
            // 
            // pagesPanel
            // 
            this.pagesPanel.Controls.Add(this.aboutLabel);
            this.pagesPanel.Controls.Add(this.clientLabel);
            this.pagesPanel.Controls.Add(this.ordersLabel);
            this.pagesPanel.Controls.Add(this.archiveLabel);
            this.pagesPanel.Controls.Add(this.requestLabel);
            this.pagesPanel.Controls.Add(this.inventoryLabel);
            this.pagesPanel.Controls.Add(this.usanaLabel);
            this.pagesPanel.Location = new System.Drawing.Point(20, 60);
            this.pagesPanel.Name = "pagesPanel";
            this.pagesPanel.Size = new System.Drawing.Size(120, 294);
            this.pagesPanel.TabIndex = 3;
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.ForeColor = System.Drawing.Color.White;
            this.aboutLabel.Location = new System.Drawing.Point(5, 260);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(52, 20);
            this.aboutLabel.TabIndex = 9;
            this.aboutLabel.Text = "About";
            this.aboutLabel.Click += new System.EventHandler(this.aboutLabel_Click);
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.Color.White;
            this.clientLabel.Location = new System.Drawing.Point(5, 20);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(49, 20);
            this.clientLabel.TabIndex = 3;
            this.clientLabel.Text = "Client";
            this.clientLabel.Click += new System.EventHandler(this.clientLabel_Click);
            // 
            // ordersLabel
            // 
            this.ordersLabel.AutoSize = true;
            this.ordersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersLabel.ForeColor = System.Drawing.Color.White;
            this.ordersLabel.Location = new System.Drawing.Point(5, 140);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new System.Drawing.Size(57, 20);
            this.ordersLabel.TabIndex = 6;
            this.ordersLabel.Text = "Orders";
            this.ordersLabel.Click += new System.EventHandler(this.contactLabel_Click);
            // 
            // archiveLabel
            // 
            this.archiveLabel.AutoSize = true;
            this.archiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archiveLabel.ForeColor = System.Drawing.Color.White;
            this.archiveLabel.Location = new System.Drawing.Point(5, 180);
            this.archiveLabel.Name = "archiveLabel";
            this.archiveLabel.Size = new System.Drawing.Size(61, 20);
            this.archiveLabel.TabIndex = 7;
            this.archiveLabel.Text = "Archive";
            this.archiveLabel.Click += new System.EventHandler(this.archiveLabel_Click);
            // 
            // requestLabel
            // 
            this.requestLabel.AutoSize = true;
            this.requestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestLabel.ForeColor = System.Drawing.Color.White;
            this.requestLabel.Location = new System.Drawing.Point(5, 100);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(78, 20);
            this.requestLabel.TabIndex = 5;
            this.requestLabel.Text = "Requests";
            this.requestLabel.Click += new System.EventHandler(this.requestLabel_Click);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.ForeColor = System.Drawing.Color.White;
            this.inventoryLabel.Location = new System.Drawing.Point(5, 60);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(74, 20);
            this.inventoryLabel.TabIndex = 4;
            this.inventoryLabel.Text = "Inventory";
            this.inventoryLabel.Click += new System.EventHandler(this.inventoryLabel_Click);
            // 
            // usanaLabel
            // 
            this.usanaLabel.AutoSize = true;
            this.usanaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usanaLabel.ForeColor = System.Drawing.Color.White;
            this.usanaLabel.Location = new System.Drawing.Point(5, 220);
            this.usanaLabel.Name = "usanaLabel";
            this.usanaLabel.Size = new System.Drawing.Size(56, 20);
            this.usanaLabel.TabIndex = 8;
            this.usanaLabel.Text = "Usana";
            this.usanaLabel.Click += new System.EventHandler(this.usanaLabel_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.headerPanel.Controls.Add(this.settingsPictureBox);
            this.headerPanel.Controls.Add(this.usanaPictureBox);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(784, 40);
            this.headerPanel.TabIndex = 2;
            // 
            // settingsPictureBox
            // 
            this.settingsPictureBox.Image = global::MenuInheritance.Properties.Resources.settingsIcon;
            this.settingsPictureBox.Location = new System.Drawing.Point(720, 5);
            this.settingsPictureBox.Name = "settingsPictureBox";
            this.settingsPictureBox.Size = new System.Drawing.Size(30, 30);
            this.settingsPictureBox.TabIndex = 1;
            this.settingsPictureBox.TabStop = false;
            // 
            // usanaPictureBox
            // 
            this.usanaPictureBox.Image = global::MenuInheritance.Properties.Resources.USANA_logo;
            this.usanaPictureBox.Location = new System.Drawing.Point(20, 0);
            this.usanaPictureBox.Name = "usanaPictureBox";
            this.usanaPictureBox.Size = new System.Drawing.Size(178, 40);
            this.usanaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.usanaPictureBox.TabIndex = 0;
            this.usanaPictureBox.TabStop = false;
            this.usanaPictureBox.Click += new System.EventHandler(this.usanaPictureBox_Click);
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Location = new System.Drawing.Point(177, 40);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(607, 402);
            this.controlGroupBox.TabIndex = 3;
            this.controlGroupBox.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Search"});
            this.searchBox.Location = new System.Drawing.Point(20, 34);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(120, 20);
            this.searchBox.TabIndex = 4;
            this.searchBox.Text = "Search";
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchOnEnter);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.pagesPanel.ResumeLayout(false);
            this.pagesPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usanaPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox settingsPictureBox;
        private System.Windows.Forms.Panel pagesPanel;
        public System.Windows.Forms.Label archiveLabel;
        public System.Windows.Forms.Label usanaLabel;
        public System.Windows.Forms.Label ordersLabel;
        public System.Windows.Forms.Label requestLabel;
        public System.Windows.Forms.Label clientLabel;
        public System.Windows.Forms.Label inventoryLabel;
        public System.Windows.Forms.Label aboutLabel;
        public System.Windows.Forms.GroupBox controlGroupBox;
        public System.Windows.Forms.PictureBox usanaPictureBox;
        public System.Windows.Forms.TextBox searchBox;
    }
}

