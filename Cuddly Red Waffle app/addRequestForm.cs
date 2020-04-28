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
            int clientNumber;
            DateTime date;
            int priority;
            int products;
            bool completed;
            bool payed;
            if(int.TryParse(clientNumberTextBox.Text,out clientNumber) && int.TryParse(productsTextBox.Text, out products)
                && priorityComboBox.Text != "" && completionComboBox.Text != "" && paymentStatusComboBox.Text != "")
            {
                

                products = int.Parse(productsTextBox.Text);
                clientNumber = int.Parse(clientNumberTextBox.Text);
                date = dateTimePicker1.Value;

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
                this.Close();
            }

            else
            {
                MessageBox.Show("An invalid input was detected or was missing. Please, try again", "Invalid or Missing input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
