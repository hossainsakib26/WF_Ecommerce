using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsEcommerceWork.Models.Business_Side;
using WindowsFormsEcommerceWork.Reprository.Business_Side;

namespace WindowsFormsEcommerceWork.User_Interface.Business_Side.Products_Related
{
    public partial class ProductDetails_UI : Form
    {
        public ProductDetails_UI()
        {
            InitializeComponent();
            LoadComboData();
            quantityTextBox.Text = "0";
            totalPriceTextBox.Text = "0";
            costPriceTextBox.Text = "0";
            salePriceTextBox.Text = "0";
            DeletePictureBox.Visible = false;

            LoadData();
        }

        Category_Repository cat_db;
        ProductDetails_Repository db;
        ProductDetails details;
        ComboBox_Repository cbDB;

        int catId;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            db = new ProductDetails_Repository();
            details = new ProductDetails();

            Category catComboObj = categoryComboBox.SelectedItem as Category;
            var prodCombObj = productComboBox.SelectedItem as Product;

            int quantity = Convert.ToInt32(quantityTextBox.Text);
            double totalPrice = Convert.ToDouble(totalPriceTextBox.Text);
            double costPrice = Convert.ToDouble(costPriceTextBox.Text);
            double salePrice = Convert.ToDouble(salePriceTextBox.Text);

            catId = catComboObj.Id;
            details.CategoryId = catId;
            details.ProductId = prodCombObj.Id;
            if (quantity == 0)
            {
                ErrorLabel.Text = "Quantity never 0";
                return;
            }
            else
            {
                details.Quantity = quantity;
            }
            if (totalPrice == 0)
            {
                ErrorLabel.Text = "Total Price never 0";
                return;
            }
            else
            {
                details.TotalPrice = totalPrice;
            }
            if (costPrice == 0)
            {
                ErrorLabel.Text = "cost price never 0";
                return;
            }
            else
            {
                details.CostPrice = costPrice;
            }
            if (salePrice == 0)
            {
                ErrorLabel.Text = "Sale price never 0";
                return;
            }
            else
            {
                details.SalePrice = salePrice;
            }

            details.Id = db.SetDetailsId("SQ_ProductDetailsId");

            var isDataSave = db.Add(details);
            if (isDataSave)
            {
                ErrorLabel.Text = "New product details Save!";
                LoadData();
                Clear();
            }
            else
            {
                ErrorLabel.Text = "New product details not save!";
                LoadData();
            }
        }

        void LoadComboData()
        {
            cat_db = new Category_Repository();

            categoryBindingSource.DataSource = null;
            categoryBindingSource.DataSource = cat_db.GetCategories();
        }

        void LoadData()
        {
            db = new ProductDetails_Repository();

            vMProductDetailsBindingSource.DataSource = null;
            vMProductDetailsBindingSource.DataSource = db.GetAllDetails();
        }

        void Clear()
        {
            productBindingSource.DataSource = null;
            quantityTextBox.Text = "0";
            totalPriceTextBox.Text = "0";
            costPriceTextBox.Text = "0";
            salePriceTextBox.Text = "0";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Product_UI proUi = new Product_UI();
            //proUi.Show();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDB = new ComboBox_Repository();
            if (categoryComboBox.SelectedValue.ToString() != null)
            {
                catId = Convert.ToInt32(categoryComboBox.SelectedValue.ToString());
                productBindingSource.DataSource = null;
                productBindingSource.DataSource = cbDB.GetByCatID(catId);
            }
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            Product_UI pUi = new Product_UI();
            pUi.Show();
            this.Hide();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            Category_UI catUI = new Category_UI();
            catUI.Show();
            Hide();
        }
    }
}
