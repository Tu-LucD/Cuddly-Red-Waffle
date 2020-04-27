using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuddly_Red_Waffle_app
{
    public partial class OrderUserControl : UserControl
    {
        public OrderUserControl()
        {
            InitializeComponent();
        }


        private void OrderPage_Load(object sender, EventArgs e)
        {
            this.ordersTableAdapter.Fill(this.uSANA_DBDataSet.Orders);
        }

  
        

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            addOrderForm add = new addOrderForm();
            add.Show();
            //this.ordersTableAdapter.Fill(this.uSANA_DBDataSet.Orders);
        }

        private void orderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderProductList.Items.Clear();
            orderProductList.Items.Add(ordersTableAdapter.GetData().ElementAt<USANA_DBDataSet.OrdersRow>(this.orderListBox.SelectedIndex).Product_In_order);

            orderPlacedLabel.Visible = ordersTableAdapter.GetData().ElementAt<USANA_DBDataSet.OrdersRow>(this.orderListBox.SelectedIndex).Is_Placed;
            // orderPlacedDate.Visible = ordersTableAdapter.GetData().ElementAt<USANA_DBDataSet.OrdersRow>(this.orderListBox.SelectedIndex).Is_Placed;
            // orderPlacedDate.Text = ordersTableAdapter.GetData().ElementAt<USANA_DBDataSet.OrdersRow>(this.orderListBox.SelectedIndex).

            orderSentLabel.Visible = ordersTableAdapter.GetData().ElementAt<USANA_DBDataSet.OrdersRow>(this.orderListBox.SelectedIndex).Is_Shipped;
            // orderSentDate.Visible = ordersTableAdapter.GetData().ElementAt<USANA_DBDataSet.OrdersRow>(this.orderListBox.SelectedIndex).Is_Placed;
            // orderSentDate.Text = ordersTableAdapter.GetData().ElementAt<USANA_DBDataSet.OrdersRow>(this.orderListBox.SelectedIndex).

            orderDeliveredLabel.Visible = ordersTableAdapter.GetData().ElementAt<USANA_DBDataSet.OrdersRow>(this.orderListBox.SelectedIndex).Is_Delivered;
            // orderDeliveredDate.Visible = ordersTableAdapter.GetData().ElementAt<USANA_DBDataSet.OrdersRow>(this.orderListBox.SelectedIndex).Is_Placed;
            // orderDeliveredDate.Text = ordersTableAdapter.GetData().ElementAt<USANA_DBDataSet.OrdersRow>(this.orderListBox.SelectedIndex).

            totalPointsLabel.Text = "Total Points: " + ordersTableAdapter.GetData().ElementAt<USANA_DBDataSet.OrdersRow>(this.orderListBox.SelectedIndex).Total_Points;

            estimatedDeliveryDate.Text = (ordersTableAdapter.GetData().ElementAt<USANA_DBDataSet.OrdersRow>(this.orderListBox.SelectedIndex).Arrival_Date).ToString();
        }
    }
}
