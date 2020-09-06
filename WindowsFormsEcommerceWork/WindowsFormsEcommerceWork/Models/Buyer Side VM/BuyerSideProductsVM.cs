using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsEcommerceWork.Models.Buyer_Side_VM
{
    public class BuyerSideProductsVM
    {
        public long Id { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public double SalePrice { get; set; }

    }
}
