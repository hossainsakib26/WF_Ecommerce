using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsEcommerceWork.Models.Business_Side
{
    public class ProductDetails
    {
        public long Id { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public double SinglePrice { get; set; }

        public int CategoryId { get; set; }
        public int ProductId { get; set; }
    }
}
