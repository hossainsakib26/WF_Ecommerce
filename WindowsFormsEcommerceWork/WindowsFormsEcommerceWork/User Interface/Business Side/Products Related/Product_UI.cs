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
    public partial class Product_UI : Form
    {
        public Product_UI()
        {
            InitializeComponent();
            LoadComboData();
            LoadData();
            DeletePictureBox.Visible = false;
        }

        //dal objects
        Category_Repository catDb;
        Product_Repository db;

        //class objects
        Product product;

        private void categoryButton_Click(object sender, EventArgs e)
        {
            var category = new Category_UI();
            category.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadComboData()
        {
            catDb = new Category_Repository();
            categoryBindingSource.DataSource = null;
            categoryBindingSource.DataSource = catDb.GetCategories();
        }

        void LoadData()
        {
            db = new Product_Repository();

            productBindingSource.DataSource = null;
            productBindingSource.DataSource = db.GetProducts();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var catObj = categoryComboBox.SelectedItem as Category;

            db = new Product_Repository();
            product = new Product();
            string name = nameTextBox.Text;
            string sku = skuTextBox.Text;
            if (name == null)
            {
                ErrorLabel.Text = "Empty field never allow!";
                return;
            }
            else
            {
                if (name != null)
                {
                    if (name.Length > 3)
                    {
                        product.Name = name;
                    }
                    else
                    {
                        ErrorLabel.Text = "Name contain minimum 3 letters";
                        return;
                    }
                }
            }

            if (sku == null)
            {
                ErrorLabel.Text = "Empty field never allow!";
                return;
            }
            else
            {
                if (sku != null)
                {
                    if (sku.Length > 2)
                    {
                        product.SKU = sku;
                    }
                    else
                    {
                        ErrorLabel.Text = "SKU contain minimum 3 letters";
                        return;
                    }
                }
            }

            product.CategoryId = catObj.Id;
            product.Id = db.SetProductId("SQ_ProductId");

            if (SaveButton.Text == "Save")
            {
                var isSave = db.Save(product);
                if (isSave)
                {
                    ErrorLabel.Text = "Product Save Successfully";
                    LoadData();
                }
                else
                {
                    ErrorLabel.Text = "Product not save.";
                    LoadData();
                    return;
                }
            }
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {

        }

        private void ProductListButton_Click(object sender, EventArgs e)
        {
            ProductDetails_UI prodetails = new ProductDetails_UI();
            prodetails.Show();
            this.Hide();
        }
    }
}
