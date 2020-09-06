using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsEcommerceWork.Models.Buyer_Side_VM
{
    public class VW_AllDetails
    {
        public long CategoryId { get; set; }
        public long ProductId { get; set; }
        public long ProductDetailsId { get; set; }
        public string Category { get; set; }
        public string Product { get; set; }
        public double SalePrice { get; set; }

    }
}
