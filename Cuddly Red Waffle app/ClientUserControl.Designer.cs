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
            this.PersonalInfo = new System.Windows.Forms.GroupBox();
            this.ageCenter = new System.Windows.Forms.TextBox();
            this.emailCenter = new System.Windows.Forms.TextBox();
            this.nameCenter = new System.Windows.Forms.TextBox();
            this.phoneCenter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.additionalCenter = new System.Windows.Forms.TextBox();
            this.additionalInfo = new System.Windows.Forms.Label();
            this.ClientsCenter = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PersonalInfo.SuspendLayout();
            this.ClientsCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonalInfo
            // 
            this.PersonalInfo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PersonalInfo.Controls.Add(this.additionalInfo);
            this.PersonalInfo.Controls.Add(this.additionalCenter);
            this.PersonalInfo.Controls.Add(this.ageCenter);
            this.PersonalInfo.Controls.Add(this.emailCenter);
            this.PersonalInfo.Controls.Add(this.nameCenter);
            this.PersonalInfo.Controls.Add(this.phoneCenter);
            this.PersonalInfo.Controls.Add(this.label4);
            this.PersonalInfo.Controls.Add(this.label3);
            this.PersonalInfo.Controls.Add(this.label2);
            this.PersonalInfo.Controls.Add(this.label1);
            this.PersonalInfo.Location = new System.Drawing.Point(221, 34);
            this.PersonalInfo.Name = "PersonalInfo";
            this.PersonalInfo.Size = new System.Drawing.Size(248, 258);
            this.PersonalInfo.TabIndex = 1;
            this.PersonalInfo.TabStop = false;
            this.PersonalInfo.Text = "personal info";
            // 
            // ageCenter
            // 
            this.ageCenter.Location = new System.Drawing.Point(205, 32);
            this.ageCenter.Name = "ageCenter";
            this.ageCenter.Size = new System.Drawing.Size(18, 20);
            this.ageCenter.TabIndex = 7;
            // 
            // emailCenter
            // 
            this.emailCenter.Location = new System.Drawing.Point(87, 90);
            this.emailCenter.Name = "emailCenter";
            this.emailCenter.Size = new System.Drawing.Size(100, 20);
            this.emailCenter.TabIndex = 6;
            // 
            // nameCenter
            // 
            this.nameCenter.Location = new System.Drawing.Point(73, 32);
            this.nameCenter.Name = "nameCenter";
            this.nameCenter.Size = new System.Drawing.Size(95, 20);
            this.nameCenter.TabIndex = 5;
            // 
            // phoneCenter
            // 
            this.phoneCenter.Location = new System.Drawing.Point(87, 64);
            this.phoneCenter.Name = "phoneCenter";
            this.phoneCenter.Size = new System.Drawing.Size(100, 20);
            this.phoneCenter.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "phone number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "email address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // additionalCenter
            // 
            this.additionalCenter.Location = new System.Drawing.Point(25, 148);
            this.additionalCenter.Name = "additionalCenter";
            this.additionalCenter.Size = new System.Drawing.Size(208, 20);
            this.additionalCenter.TabIndex = 8;
            // 
            // additionalInfo
            // 
            this.additionalInfo.AutoSize = true;
            this.additionalInfo.Location = new System.Drawing.Point(80, 132);
            this.additionalInfo.Name = "additionalInfo";
            this.additionalInfo.Size = new System.Drawing.Size(107, 13);
            this.additionalInfo.TabIndex = 9;
            this.additionalInfo.Text = "additional Information";
            // 
            // ClientsCenter
            // 
            this.ClientsCenter.Controls.Add(this.label5);
            this.ClientsCenter.Location = new System.Drawing.Point(3, 56);
            this.ClientsCenter.Name = "ClientsCenter";
            this.ClientsCenter.Size = new System.Drawing.Size(200, 236);
            this.ClientsCenter.TabIndex = 10;
            this.ClientsCenter.TabStop = false;
            this.ClientsCenter.Text = "Clients";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Client";
            // 
            // ClientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClientsCenter);
            this.Controls.Add(this.PersonalInfo);
            this.Name = "ClientUserControl";
            this.Size = new System.Drawing.Size(472, 354);
            this.PersonalInfo.ResumeLayout(false);
            this.PersonalInfo.PerformLayout();
            this.ClientsCenter.ResumeLayout(false);
            this.ClientsCenter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PersonalInfo;
        private System.Windows.Forms.TextBox ageCenter;
        private System.Windows.Forms.TextBox emailCenter;
        private System.Windows.Forms.TextBox nameCenter;
        private System.Windows.Forms.TextBox phoneCenter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label additionalInfo;
        private System.Windows.Forms.TextBox additionalCenter;
        private System.Windows.Forms.GroupBox ClientsCenter;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
    }
}
