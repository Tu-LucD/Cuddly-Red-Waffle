using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Cuddly_Red_Waffle_app
{
    public partial class mainPageUserControl : UserControl
    {
        public mainPageUserControl()
        {
            InitializeComponent();
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            addClientForm add = new addClientForm();
            add.Show();
        }

        private void addRequestButton_Click(object sender, EventArgs e)
        {
            addRequestForm add = new addRequestForm();
            add.ShowDialog();
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            addOrderForm add = new addOrderForm();
            add.Show();
        }
    }
}
