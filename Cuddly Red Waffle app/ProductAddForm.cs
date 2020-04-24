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
    public partial class ProductAddForm : Form
    {
        public ProductAddForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = productNameText.Text;
            int healthCategory = int.Parse(healthText.Text);
            double retailPrice = double.Parse(retailText.Text);
            double prefPrice = double.Parse(prefPriceText.Text);
            int vvp = int.Parse(vvpText.Text);

            Product newProduct = new Product(name, healthCategory, retailPrice, prefPrice, vvp);

            newProduct.CreateProductRow();

            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uSANA_DBDataSet);

            this.Close();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productNameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
