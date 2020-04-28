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
    public partial class InventoryControl : UserControl
    {
        public InventoryControl()
        {
            InitializeComponent();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            ProductAddForm add = new ProductAddForm();

            add.ShowDialog();
        }

        private void productsLabel_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.Update(this.uSANA_DBDataSet.Products);
            InventoryControl_Load(sender, e);
        }

        private void InventoryControl_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.uSANA_DBDataSet.Products);

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.DeleteById(productsTableAdapter.GetData().ElementAt<USANA_DBDataSet.ProductsRow>
                                (this.productsListBox.SelectedIndex).ProductId);
                this.productsTableAdapter.Update(this.uSANA_DBDataSet.Products);
                InventoryControl_Load(sender, e);
            }
            catch (SystemException)
            {
                MessageBox.Show("Coudn't delete", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void quantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
           // this.productsTableAdapter.UpdateQuantity((int)quantityNumericUpDown.Value, productsTableAdapter.GetData().ElementAt<USANA_DBDataSet.ProductsRow>
            //    (this.productsListBox.SelectedIndex).ProductId);
            //this.productsTableAdapter.Update(this.uSANA_DBDataSet.Products);
            //InventoryControl_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.productsBindingSource.EndEdit();
                this.productsTableAdapter.Update(this.uSANA_DBDataSet.Products);
            }
            catch (SystemException)
            {
                MessageBox.Show("Coudn't update. Please check your values", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
