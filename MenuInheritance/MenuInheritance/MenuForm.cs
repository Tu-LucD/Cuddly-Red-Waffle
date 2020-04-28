using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuInheritance
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void clientLabel_Click(object sender, EventArgs e)
        {
            foreach (Label label in pagesPanel.Controls)
            {
                label.ForeColor = Color.White;
            }

            clientLabel.ForeColor = Color.Black;
        }

        private void inventoryLabel_Click(object sender, EventArgs e)
        {
            foreach (Label label in pagesPanel.Controls)
            {
                label.ForeColor = Color.White;
            }
           
            inventoryLabel.ForeColor = Color.Black;

        }

        private void requestLabel_Click(object sender, EventArgs e)
        {
            foreach (Label label in pagesPanel.Controls)
            {
                label.ForeColor = Color.White;
            }

            requestLabel.ForeColor = Color.Black;
        }

        private void contactLabel_Click(object sender, EventArgs e)
        {
            foreach (Label label in pagesPanel.Controls)
            {
                label.ForeColor = Color.White;
            }

            ordersLabel.ForeColor = Color.Black;
        }

        private void archiveLabel_Click(object sender, EventArgs e)
        {
            foreach (Label label in pagesPanel.Controls)
            {
                label.ForeColor = Color.White;
            }

            archiveLabel.ForeColor = Color.Black;
        }


        private void usanaLabel_Click(object sender, EventArgs e)
        {
            foreach (Label label in pagesPanel.Controls)
            {
                label.ForeColor = Color.White;
            }

            usanaLabel.ForeColor = Color.Black;
        }

        private void aboutLabel_Click(object sender, EventArgs e)
        {
            foreach (Label label in pagesPanel.Controls)
            {
                label.ForeColor = Color.White;
            }

            aboutLabel.ForeColor = Color.Black;
        }

        private void usanaPictureBox_Click(object sender, EventArgs e)
        {
            foreach (Label label in pagesPanel.Controls)
            {
                label.ForeColor = Color.White;
            }

        }

        private void searchOnEnter(object sender, KeyPressEventArgs e)
        {

        }

        private void refreshPictureBox_Click(object sender, EventArgs e)
        {
           
        }
    }
}
