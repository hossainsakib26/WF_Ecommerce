using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsEcommerceWork.Models.Business_Side;

namespace WindowsFormsEcommerceWork.Reprository.Business_Side
{
    public class ComboBox_Repository
    {
        public static string _conString => @"Server = DESKTOP-AK2N3HV\SAZZADSQL; Database = EcommerceDB; Integrated Security = True;";
        SqlConnection _conn = new SqlConnection(_conString);

        public List<Product> GetByCatID(int catId)
        {
            string query = $@"select * From Products AS P Where p.CategoryId = {catId}";
            SqlCommand command = new SqlCommand(query, _conn);
            _conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                var product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    SKU = reader["SKU"].ToString(),
                    CategoryId = Convert.ToInt32(reader["CategoryId"]),
                };
                products.Add(product);
            }
            _conn.Close();
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
