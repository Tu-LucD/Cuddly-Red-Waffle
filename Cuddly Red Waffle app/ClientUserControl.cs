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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                clientTableAdapter.SearchByName(this.uSANA_DBDataSet.Client,
                clientSearch.Text, clientSearch.Text);
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Unable to retrieve name from DB. Please input a valid name", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void updateClient_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clientBindingSource.EndEdit();
                this.clientTableAdapter.Update(this.uSANA_DBDataSet.Client);
            }
            catch(SystemException ex)
            {
                MessageBox.Show("Unable to Update, please check records and try again", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ClientUserControl_Load(sender, e);
        }
    }
}
