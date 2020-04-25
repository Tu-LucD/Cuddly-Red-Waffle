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
    public partial class ClientUserControl : UserControl
    {
        public ClientUserControl()
        {
            InitializeComponent();
        }

        private void ClientUserControl_Load(object sender, EventArgs e)
        {
            this.clientTableAdapter.Fill(this.uSANA_DBDataSet.Client);
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            addClientForm add = new addClientForm();
            add.Show();
        }
    }
}
