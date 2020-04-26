using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuddly_Red_Waffle_app
{
    public partial class mainPage : MenuInheritance.MenuForm
    {

       public readonly SqlConnection connection =
                new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\" +
                "USANA_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

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
            controlGroupBox.Controls.Clear();
            controlGroupBox.Controls.Add(new ClientUserControl());
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

            if(connection.State == ConnectionState.Closed)
                connection.Open();
        }

        private void ordersLabel_Click(object sender, EventArgs e)
        {
            controlGroupBox.Controls.Clear();
            controlGroupBox.Controls.Add(new OrderUserControl());
        }

        private void usanaPictureBox_Click(object sender, EventArgs e)
        {
            mainPage_Load(sender, e);
        }

        private void searchSection(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void searchSection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (searchBox.Text)
                {
                    case "Client":
                    case "client": clientLabel_Click(sender, e); break;
                    case "Home":
                    case "home": usanaPictureBox_Click(sender, e); break;
                    case "orders":
                    case "Orders": ordersLabel_Click(sender, e); break;
                    case "Requests": case "requests": requestLabel_Click(sender, e); break;
                    case "Inventory": case "inventory": inventoryLabel_Click(sender, e); break;
                    default:
                        MessageBox.Show("The section you are looking for can't be found", "Not found",
                   MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                }
            }
        }
    }
}
