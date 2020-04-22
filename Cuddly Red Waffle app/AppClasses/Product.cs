using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuddly_Red_Waffle_app.AppClasses
{
    class Product
    {
        private int productID;
        private string productName;
        private int vvp;
        private double prefPrice;
        private double prefPriceTax;
        private double retailPrice;
        private double retailPriceTax;
        private int quantity =1;
        private int healthCategory;
        private string notes;
        private Image image;
        private DateTime restockDate;
        //Quebec Tax. Hard coded because client works under Quebec tax policies
        private double tax = 1.15;

        public USANA_DBDataSetTableAdapters.ProductsTableAdapter productsTable =
                new USANA_DBDataSetTableAdapters.ProductsTableAdapter();

        public Product(string productName, int healthCategory, double retailPrice, double prefPrice, int vvp)
        {
            ProductName = productName;
            Vvp = vvp;
            PrefPrice = prefPrice;
            PrefPriceTax = prefPrice * tax;
            RetailPrice = retailPrice;
            RetailPriceTax = retailPrice* tax;
            HealthCategory = healthCategory;
        }

        //Creates a new row into the product table
        public void CreateProductRow()
        {
            productsTable.InsertIntoProduct(ProductName, Vvp, (decimal)PrefPrice,
                (decimal)PrefPriceTax, (decimal)RetailPrice, (decimal)RetailPriceTax, HealthCategory, Quantity);


            productsTable.Update(productsTable.GetData());

        }


        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int Vvp { get => vvp; set => vvp = value; }
        public double PrefPrice { get => prefPrice; set => prefPrice = value; }
        public double PrefPriceTax { get => prefPriceTax; set => prefPriceTax = value; }
        public double RetailPrice { get => retailPrice; set => retailPrice = value; }
        public double RetailPriceTax { get => retailPriceTax; set => retailPriceTax = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int HealthCategory { get => healthCategory; set { if (value >= 0 && value < 10)
                    healthCategory = value;
                else
                    healthCategory = 1;
            }  }
        public string Notes { get => notes; set => notes = value; }
        public Image Image { get => image; set => image = value; }
        public DateTime RestockDate { get => restockDate; set => restockDate = value; }
    }
}
