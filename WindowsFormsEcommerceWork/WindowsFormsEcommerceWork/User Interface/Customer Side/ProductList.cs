using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsEcommerceWork.Models;
using WindowsFormsEcommerceWork.Models.Business_Side;
using WindowsFormsEcommerceWork.Models.Business_Side_VM;
using WindowsFormsEcommerceWork.Models.Buyer_Side_VM;
using WindowsFormsEcommerceWork.Reprository.Business_Side;
using WindowsFormsEcommerceWork.Reprository.BuyerSide_repository;   

namespace WindowsFormsEcommerceWork.User_Interface.Customer_Side
{
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
            LoadData();
        }

        BuyerSideRepository db;
        ComboBox_Repository db_combobox;
        public VW_AllDetails orderDetail = new VW_AllDetails();
        List<VW_AllDetails> orderDetails = new List<VW_AllDetails>();
        
        List<Order> orders = new List<Order>();
        double _price;

        void LoadData()
        {
            db = new BuyerSideRepository();
            db_combobox = new ComboBox_Repository();

            categoryBindingSource.DataSource = null;
            categoryBindingSource.DataSource = db_combobox.GetCat();
        }

        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow row = ProductDataGridView.Rows[e.RowIndex];
            if (ProductDataGridView.Rows.Count != 0)
            {
                orderDetail.CategoryId = Convert.ToInt64(row.Cells[0].Value);
                orderDetail.ProductId = Convert.ToInt64(row.Cells[1].Value);
                orderDetail.ProductDetailsId = Convert.ToInt64(row.Cells[2].Value);
                orderDetail.Category = row.Cells[3].Value.ToString();
                orderDetail.Product = row.Cells[4].Value.ToString();
                orderDetail.SalePrice = Convert.ToDouble(row.Cells[5].Value);
                _price = orderDetail.SalePrice;

                categoryLabel.Text = orderDetail.Category;
                ProductLabel.Text = orderDetail.Product;
                priceLabel.Text = $"{_price}";
                quantityTextBox.Text = "1";
            }
            else if (ProductDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Empty Row Selected!");
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCat = CategoryComboBox.SelectedItem as Category;

            if (selectedCat != null)
            {
                var products = new List<Product>();
                products = db_combobox.GetByCatID(selectedCat.Id);
                if (products != null)
                {
                    productBindingSource.DataSource = null;
                    productBindingSource.DataSource = products;
                }
            }
        }

        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new BuyerSideRepository();
            var selectedProduct = ProductComboBox.SelectedItem as Product;

            if (selectedProduct != null)
            {
                var productVWs = new List<VW_AllDetails>();
                productVWs.Add(db.GetByID(selectedProduct.Id));

                if (productVWs != null)
                {
                    vWAllDetailsBindingSource.DataSource = null;
                    vWAllDetailsBindingSource.DataSource = productVWs;
                }
            }
        }

        private void CartButton_Click(object sender, EventArgs e)
        {            
            if (orderDetail != null)
            {
                var order = new Order
                {
                    Sl = orders.Count + 1,
                    ProductId = orderDetail.ProductId,
                    ProdctName = orderDetail.Product,
                    SinglePrice = orderDetail.SalePrice,
                    Quantity = Convert.ToInt32(quantityTextBox.Text),
                    TotalPrice = orderDetail.SalePrice * Convert.ToInt32(quantityTextBox.Text),
                };

                if (order.ProductId > 0 )
                {
                    for (int i = 0; i < orders.Count; i++)
                    {
                        if (orders[i].ProductId == order.ProductId)
                        {
                            orders[i].Quantity = orders[i].Quantity + order.Quantity;
                            orders[i].TotalPrice = orders[i].SinglePrice * orders[i].Quantity;

                            orderBindingSource.DataSource = null;
                            orderBindingSource.DataSource = orders;

                            categoryLabel.Text = "";
                            ProductLabel.Text = "";
                            priceLabel.Text = "";
                            quantityTextBox.Text = "0";

                            return;
                        }
                    }
                    
                    orders.Add(order);
                    orderBindingSource.DataSource = null;
                    orderBindingSource.DataSource = orders;
                }
            }
            else
            {
                MessageBox.Show("Orders is null");
            }
            categoryLabel.Text = "";
            ProductLabel.Text = "";
            priceLabel.Text = "";
            quantityTextBox.Text = "0";
        }

        int quantity = 0;
        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            //int qty = Convert.ToInt32(quantityTextBox.Text);
            if (quantityTextBox.Text == "")
            {
                msgLabel.Text = "Quantity is less then 1";
                CartButton.Visible = false;
                return;
            }
            else if(quantityTextBox.Text != null)
            {
                msgLabel.Text = "";
                int qty = Convert.ToInt32(quantityTextBox.Text);
                quantity = qty;
                double sale = _price * quantity;
                priceLabel.Text = sale.ToString();
                CartButton.Visible = true;
            }
        }
    }
}
