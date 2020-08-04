using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsEcommerceWork.Models.Business_Side;

namespace WindowsFormsEcommerceWork.Reprository.Business_Side
{
    public class Product_Repository
    {
        public static string _conString => @"Server = DESKTOP-AK2N3HV\SAZZADSQL; Database = EcommerceDB; Integrated Security = True;";
        SqlConnection _conn = new SqlConnection(_conString);

        public int SetProductId(string sqValue)
        {
            if (string.IsNullOrEmpty(sqValue))
            {
                throw new Exception("Empty Id");
            }
            string query = $@"SELECT NEXT VALUE FOR {sqValue}";
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
                throw new Exception("Null Detected");
            }
        }

        public bool SaveChanges(SqlCommand command)
        {
            _conn.Open();
            var rowAffected = command.ExecuteNonQuery();
            _conn.Close();

            if(rowAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Save(Product product)
        {
            string query = $@"Insert into Products (Id, Name, SKU, CategoryId) Values (@P_Id, @P_Name, @P_SKU, @P_CatId)";
            SqlCommand command = new SqlCommand(query, _conn);
            command.Parameters.AddWithValue("@P_Id", product.Id);
            command.Parameters.AddWithValue("@P_Name", product.Name);
            command.Parameters.AddWithValue("@P_SKU", product.SKU);
            command.Parameters.AddWithValue("@P_CatId", product.CategoryId);
            var isSave = SaveChanges(command);
            return isSave;
        }

        public List<Product> GetProducts()
        {
            string query = @"Select * From Products";
            SqlCommand command = new SqlCommand(query, _conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            _conn.Open();
            adapter.Fill(dt);
            _conn.Close();

            List<Product> products = new List<Product>();
            foreach (DataRow dr in dt.Rows)
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Name = dr["Name"].ToString(),
                    SKU = dr["SKU"].ToString(),
                    CategoryId = Convert.ToInt32(dr["CategoryId"]),
                };
                products.Add(product);
            }
            if (products != null)
            {
                return products;
            }
            else
            {
                return null;
            }
        }

        
    }
}
