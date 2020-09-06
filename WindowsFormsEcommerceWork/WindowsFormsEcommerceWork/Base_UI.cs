using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsEcommerceWork.User_Interface.Business_Side.Products_Related;

namespace WindowsFormsEcommerceWork
{
    public partial class Base_UI : Form
    {
        public Base_UI()
        {
            InitializeComponent();
        }

        private void SellerButton_Click(object sender, EventArgs e)
        {
            Category_UI _catUI = new Category_UI();
            _catUI.Show();
        }
    }
}
