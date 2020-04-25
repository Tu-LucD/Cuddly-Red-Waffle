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
    public partial class addClientForm : Form
    {
        public addClientForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNametextBox.Text;
            string lastName = lastNameTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;
            int category = int.Parse(categoryTextBox.Text);

            Client newClient = new Client(firstName, lastName, email, address, phoneNumber, category);

            newClient.CreateClientRow();

            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uSANA_DBDataSet);
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uSANA_DBDataSet);

        }

        private void addClientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uSANA_DBDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.uSANA_DBDataSet.Client);

        }

        private void clientBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uSANA_DBDataSet);

        }

        private void addClientForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uSANA_DBDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.uSANA_DBDataSet.Client);

        }
    }
}
