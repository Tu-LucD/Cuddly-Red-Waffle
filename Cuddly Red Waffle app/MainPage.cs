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
    public partial class mainPage : MenuInheritance.MenuForm
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void inventoryLabel_Click(object sender, EventArgs e)
        {
            controlGroupBox.Controls.Clear();
            controlGroupBox.Controls.Add(new InventoryControl());
        }

        private void clientLabel_Click(object sender, EventArgs e)
        {

        }


        private void archiveLabel_Click(object sender, EventArgs e)
        {

        }

        private void requestLabel_Click(object sender, EventArgs e)
        {
            controlGroupBox.Controls.Clear();
            controlGroupBox.Controls.Add(new RequestsUserControl());
        }

        private void aboutLabel_Click(object sender, EventArgs e)
        {

        }

        private void usanaLabel_Click(object sender, EventArgs e)
        {

        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            controlGroupBox.Controls.Clear();
            controlGroupBox.Controls.Add(new mainPageUserControl());
        }

        private void ordersLabel_Click(object sender, EventArgs e)
        {
            controlGroupBox.Controls.Clear();
            controlGroupBox.Controls.Add(new OrderPage());
        }

        private void usanaPictureBox_Click(object sender, EventArgs e)
        {
            mainPage_Load(sender, e);
        }
    }
}
