using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cuddly_Red_Waffle_app.AppClasses;

namespace Cuddly_Red_Waffle_app
{
    public partial class addOrderForm : Form
    {
        public addOrderForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
                
                int productInOrder; // need to figure out how the user is supposed to input products in listbox
                int totalPoints;
                bool isPlaced;
                bool isShipped;
                bool isDelivered;
                DateTime arrivalDate;

                productInOrder = (int)productsListBox.SelectedValue;
                totalPoints = int.Parse(totalPointsTextBox.Text);
                arrivalDate = arrivalDateTimePicker.Value;
                switch (statusComboBox.SelectedItem.ToString())
                {
                    case "Ordered":
                        isPlaced = true;
                        isShipped = false;
                        isDelivered = false;
                        break;
                    case "Shipped":
                        isPlaced = true;
                        isShipped = true;
                        isDelivered = false;
                        break;
                    case "Delivered":
                        isPlaced = true;
                        isShipped = true;
                        isDelivered = true;
                        break;
                    default:
                        isPlaced = false;
                        isShipped = false;
                        isDelivered = false;
                        break;
                }

                Order newOrder = new Order(productInOrder, totalPoints, isPlaced, isShipped, isDelivered, arrivalDate);

                newOrder.CreateOrderRow();

                this.Validate();
                this.orderBindingSource.EndEdit();
                this.tableAdapterManager1.UpdateAll(this.usanA_DBDataSet1);

                this.Close();                        
        }

        private void addOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usanA_DBDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.usanA_DBDataSet1.Products);

        }
    }
}
