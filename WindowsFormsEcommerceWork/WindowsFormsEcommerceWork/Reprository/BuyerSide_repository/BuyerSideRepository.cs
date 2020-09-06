using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsEcommerceWork.Models.Business_Side;
using WindowsFormsEcommerceWork.Models.Buyer_Side_VM;

namespace WindowsFormsEcommerceWork.Reprository.BuyerSide_repository
{
    public class BuyerSideRepository
    {
        private static string _conString => @"Server = DESKTOP-AK2N3HV\SAZZADSQL; Database = EcommerceDB; Integrated Security = True;";
        private SqlConnection _conn = new SqlConnection(_conString);

        public List<BuyerSideProductsVM> ProductList()
        {
            string query = @"Select Category, Product, [Sale Price], Id From VwBuyerSideProduct";
            SqlCommand command = new SqlCommand(query, _conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            _conn.Open();
            adapter.Fill(dt);
            _conn.Close();

            List<BuyerSideProductsVM> vmProducts = new List<BuyerSideProductsVM>();

            foreach (DataRow row in dt.Rows)
            {
                var vmProduct = new BuyerSideProductsVM
                {
                    Id = Convert.ToInt32(row["Id"]),
                    CategoryName = row["Category"].ToString(),
                    ProductName = row["Product"].ToString(),
                    SalePrice = Convert.ToInt32(row["Sale Price"]),
                };
                vmProducts.Add(vmProduct);
            }
            if (vmProducts != null)
            {
                return vmProducts;
            }
            else
            {
                return null;
            }
        }


        public VW_AllDetails GetByID(long productId)
        {
            string query = $@"Select Id, DetailsId, ProductId, Category, Product, SalePrice From VW_AllDetails Where ProductId = @P_ProductId";
            SqlCommand command = new SqlCommand(query, _conn);
            command.Parameters.AddWithValue("@P_ProductId", productId);
            _conn.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var details = new VW_AllDetails
                {
                    CategoryId = Convert.ToInt64(reader["Id"]),
                    ProductDetailsId = Convert.ToInt64(reader["DetailsId"]),
                    ProductId = Convert.ToInt64(reader["ProductId"]),
                    Category = reader["Category"].ToString(),
                    Product = reader["Product"].ToString(),
                    SalePrice = Convert.ToDouble(reader["SalePrice"]),
                };

                if (details.ProductId > 0)
                {
                    return details;
                }
                else
                {
                    _conn.Close();
                    return null;
                }
            }
            _conn.Close();
            return null;
        }
    }
}
