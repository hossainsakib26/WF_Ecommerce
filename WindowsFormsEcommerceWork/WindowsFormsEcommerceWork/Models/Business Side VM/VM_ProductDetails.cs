using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsEcommerceWork.Models.Business_Side_VM
{
    public class VM_ProductDetails
    {
        public long Id { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }

        public string Category { get; set; }
        public string Product { get; set; }
    }
}
