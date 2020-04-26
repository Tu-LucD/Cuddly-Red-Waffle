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
            this.addClientButton = new System.Windows.Forms.Button();
            this.addRequestButton = new System.Windows.Forms.Button();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.oldestTab = new System.Windows.Forms.TabPage();
            this.oldestRequests = new System.Windows.Forms.ListBox();
            this.newestPage = new System.Windows.Forms.TabPage();
            this.newestRequests = new System.Windows.Forms.ListBox();
            this.requestTabControl = new System.Windows.Forms.TabControl();
            this.oldestTab.SuspendLayout();
            this.newestPage.SuspendLayout();
            this.requestTabControl.SuspendLayout();
            this.SuspendLayout();
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
            this.oldestTab.Controls.Add(this.oldestRequests);
            this.oldestTab.Location = new System.Drawing.Point(4, 22);
            this.oldestTab.Name = "oldestTab";
            this.oldestTab.Padding = new System.Windows.Forms.Padding(3);
            this.oldestTab.Size = new System.Drawing.Size(231, 305);
            this.oldestTab.TabIndex = 1;
            this.oldestTab.Text = "Oldest Requests";
            // 
            // oldestRequests
            // 
            this.oldestRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oldestRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldestRequests.FormattingEnabled = true;
            this.oldestRequests.ItemHeight = 16;
            this.oldestRequests.Location = new System.Drawing.Point(0, 8);
            this.oldestRequests.Name = "oldestRequests";
            this.oldestRequests.Size = new System.Drawing.Size(231, 288);
            this.oldestRequests.TabIndex = 4;
            // 
            // newestPage
            // 
            this.newestPage.BackColor = System.Drawing.SystemColors.Highlight;
            this.newestPage.Controls.Add(this.newestRequests);
            this.newestPage.Location = new System.Drawing.Point(4, 22);
            this.newestPage.Name = "newestPage";
            this.newestPage.Padding = new System.Windows.Forms.Padding(3);
            this.newestPage.Size = new System.Drawing.Size(231, 305);
            this.newestPage.TabIndex = 0;
            this.newestPage.Text = "Newest Requests";
            // 
            // newestRequests
            // 
            this.newestRequests.BackColor = System.Drawing.SystemColors.Window;
            this.newestRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newestRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newestRequests.FormattingEnabled = true;
            this.newestRequests.ItemHeight = 16;
            this.newestRequests.Location = new System.Drawing.Point(0, 7);
            this.newestRequests.Name = "newestRequests";
            this.newestRequests.Size = new System.Drawing.Size(231, 288);
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
            // mainPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.requestTabControl);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.addRequestButton);
            this.Controls.Add(this.addClientButton);
            this.Name = "mainPageUserControl";
            this.Size = new System.Drawing.Size(602, 391);
            this.oldestTab.ResumeLayout(false);
            this.newestPage.ResumeLayout(false);
            this.requestTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button addRequestButton;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.TabPage oldestTab;
        private System.Windows.Forms.ListBox oldestRequests;
        private System.Windows.Forms.TabPage newestPage;
        private System.Windows.Forms.ListBox newestRequests;
        private System.Windows.Forms.TabControl requestTabControl;
    }
}
