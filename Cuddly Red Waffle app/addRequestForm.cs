using Cuddly_Red_Waffle_app.AppClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuddly_Red_Waffle_app
{
    public partial class addRequestForm : Form
    {
        public addRequestForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                int clientNumber = int.Parse(clientNumberTextBox.Text);
                DateTime date = dateTimePicker1.Value;
                int priority;
                int products = int.Parse(productsTextBox.Text);
                bool completed;
                bool payed;

                switch (priorityComboBox.Text)
                {
                    case "Low":
                        priority = 0;
                        break;
                    case "Medium":
                        priority = 1;
                        break;
                    default:
                        priority = 2;
                        break;
                }

                switch (paymentStatusComboBox.Text)
                {
                    case "Paid":
                        payed = true;
                        break;
                    default:
                        payed = false;
                        break;
                }

                switch (completionComboBox.Text)
                {
                    case "Complete":
                        completed = true;
                        break;
                    default:
                        completed = false;
                        break;
                }

                Request request = new Request(clientNumber, 1, date, priority, completed, payed);
                request.CreateRequestRow();

                this.Validate();
                this.requestBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.uSANA_DBDataSet);

                this.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Please make sure to input valid values. Not empty values accepted", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                       
        }


        private void addRequestForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uSANA_DBDataSet.Request' table. You can move, or remove it, as needed.
            this.requestTableAdapter.Fill(this.uSANA_DBDataSet.Request);            
        }

        private void requestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requestBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uSANA_DBDataSet);

        }
    }
}
