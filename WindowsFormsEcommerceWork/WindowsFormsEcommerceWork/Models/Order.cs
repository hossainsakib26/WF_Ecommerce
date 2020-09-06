using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsEcommerceWork.Models
{
    public class Order
    {
        public int Sl { get; set; }
        public long ProductId { get; set; }
        public string ProdctName { get; set; }
        public int Quantity { get; set; }
        public double SinglePrice { get; set; }
        public double TotalPrice { get; set; }  

    }
}
