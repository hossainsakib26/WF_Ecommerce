using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsEcommerceWork.Models.Business_Side;

namespace WindowsFormsEcommerceWork.Reprository.Business_Side
{
    public class ProductDetails_Repository
    {
        private static string _conString => @"Server = DESKTOP-AK2N3HV\SAZZADSQL; Database = EcommerceDB; Integrated Security = True;";
        private SqlConnection _conn = new SqlConnection(_conString);

        private bool SaveChange(SqlCommand _command)
        {
            _conn.Open();
            var affectRows = _command.ExecuteNonQuery();
            _conn.Close();
            if (affectRows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int SetDetailsId(string sqValue)
        {
            if (string.IsNullOrEmpty(sqValue))
            {
                throw new Exception("Id is empty!");
            }
            var query = $@"SELECT NEXT VALUE FOR {sqValue}";
            var command = new SqlCommand(query, _conn);
            _conn.Open();
            var id = command.ExecuteScalar();
            _conn.Close();

            if (id != null)
            {
                return Convert.ToInt32(id);
            }
            else
            {
                throw new Exception("Null detected!");
            }
        }

        public bool Add(ProductDetails details)
        {
            string query = $@"INSERT INTO ProductDetails (Id, ProductId, CategoryId, Quantity, TotalPrice, SinglePrice) VALUES (@Id, @ProductId, @CategoryId, @Quantity, @TotalPrice, @SinglePrice)";
            SqlCommand command = new SqlCommand(query, _conn);
            command.Parameters.AddWithValue("@Id", details.Id);
            command.Parameters.AddWithValue("@ProductId", details.ProductId);
            command.Parameters.AddWithValue("@CategoryId", details.CategoryId);
            command.Parameters.AddWithValue("@Quantity", details.Quantity);
            command.Parameters.AddWithValue("@TotalPrice", details.TotalPrice);
            command.Parameters.AddWithValue("@SinglePrice", details.SinglePrice);

            var isSave = SaveChange(command);
            if (isSave)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<ProductDetails> GetAllDetails()
        {
            string query = "Select * From ProductDetails";
            SqlCommand command = new SqlCommand(query, _conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            _conn.Open();
            adapter.Fill(dt);
            _conn.Close();

            List<ProductDetails> details = new List<ProductDetails>();
            foreach (DataRow row in dt.Rows)
            {
                var pdetail = new ProductDetails 
                {
                    Id = Convert.ToInt32(row["Id"]),
                    CategoryId = Convert.ToInt32(row["CategoryId"]),
                    ProductId = Convert.ToInt32(row["ProductId"]),
                    Quantity = Convert.ToInt32(row["Quantity"]),
                    TotalPrice = Convert.ToDouble(row["TotalPrice"]),
                    SinglePrice = Convert.ToDouble(row["SinglePrice"])
                };
                details.Add(pdetail);
            }
            if (details != null)
            {
                return details;
            }
            else
            {
                return null;
            }
        }
    }
}
