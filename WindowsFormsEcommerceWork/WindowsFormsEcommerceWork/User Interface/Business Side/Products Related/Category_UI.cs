using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsEcommerceWork.Models.Business_Side;
using WindowsFormsEcommerceWork.Reprository.Business_Side;

namespace WindowsFormsEcommerceWork.User_Interface.Business_Side.Products_Related
{
    public partial class Category_UI : Form
    {
        public Category_UI()
        {
            InitializeComponent();
            DeletePictureBox.Visible = false;
            LoadData();
        }
        //REPOSITORY DECLATION
        private Category_Repository db;

        //CLASS OBJECT DECLARATION
        private Category category;

        //declare needed variable
        int id = 0;

        private void ProductButton_Click(object sender, EventArgs e)
        {
            var product = new Product_UI();
            product.Show();
            this.Hide();
            
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            db = new Category_Repository();
            var name = nameTextBox.Text;
            var code = codeTextBox.Text;

            category = new Category();
            if (name == "" || name == null)
            {
                return;
            }
            else
            {
                if (name.Length > 4)
                {
                    category.Name = name;
                }
                else
                {
                    ErrorLabel.Text = $"name length must higher then 4";
                    return;
                }
            }

            if (code == "" || code == null)
            {
                return;
            }
            else
            {
                if (code.Length < 4)
                {
                    category.Code = code;
                }
                else
                {
                    ErrorLabel.Text = $"code length must smaller then 4";
                    return;
                }
            }
            category.Id = db.SetCategoryId("SQ_CategoryId");

            if (SaveButton.Text == "Save")
            {
                var isSave = db.AddCat(category);
                if (isSave)
                {
                    ErrorLabel.Text = $"{category.Name} is save successfully!";
                    LoadData();
                }
                else
                {
                    ErrorLabel.Text = $"{category.Name} is not save!";
                    LoadData();
                    return;
                }
            }
            else if (SaveButton.Text == "Update")
            {
                var isUpdate = db.Update(id, category);
                if (isUpdate)
                {
                    ErrorLabel.Text = $"{name} is updated";
                    LoadData();
                }
                else
                {
                    ErrorLabel.Text = $"{name} is not updated";
                    LoadData();
                    return;
                }
            }
        }

        private void LoadData()
        {
            db = new Category_Repository();
            categoryBindingSource.DataSource = null;
            categoryBindingSource.DataSource = db.GetCategories();
            Clear();
        }

        void Clear()
        {
            category = null;
            nameTextBox.Text = "";
            codeTextBox.Text = "";
        }

        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SaveButton.Text = "Update";
            DeletePictureBox.Visible = true;

            DataGridViewRow row = categoryDataGridView.Rows[e.RowIndex];
            id = Convert.ToInt32(row.Cells[0].Value);

            category = new Category();
            category = db.GetCatById(id);
            if (category != null)
            {
                nameTextBox.Text = category.Name;
                codeTextBox.Text = category.Code;
            }
        }

        private void DeletePictureBox_Click(object sender, EventArgs e)
        {
            db = new Category_Repository();
            if (id > 0)
            {
                MessageBox.Show($"Are you sure to delete this category?");
                var isDelete = db.Delete(id);

                if (isDelete)
                {
                    MessageBox.Show("Delete successfully!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Can not delete this. It has a relation with another field!");
                    LoadData();
                }
            }
        }
    }
}
