using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsEcommerceWork.User_Interface.Business_Side.Products_Related;
using WindowsFormsEcommerceWork.User_Interface.Customer_Side;

namespace WindowsFormsEcommerceWork
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Base_UI());
            Application.Run(new ProductList());
        }
    }
}
