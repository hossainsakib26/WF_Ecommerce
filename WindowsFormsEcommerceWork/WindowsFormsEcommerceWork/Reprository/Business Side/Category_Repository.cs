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
    public class Category_Repository
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

        public int SetCategoryId(string sqValue)
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

        public bool AddCat(Category cat)
        {
            string query = $@"INSERT INTO Categories (Id, Name, Code) VALUES (@P_Id, @P_Name, @P_Code)";
            SqlCommand command = new SqlCommand(query, _conn);
            //command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@P_Id", cat.Id);
            command.Parameters.AddWithValue("@P_Name", cat.Name);
            command.Parameters.AddWithValue("@P_Code", cat.Code);
            var isSave = SaveChange(command);
            return isSave;
        }

        public List<Category> GetCategories()
        {
            string query = $@"SELECT * FROM Categories";
            SqlCommand command = new SqlCommand(query, _conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            _conn.Open();
            adapter.Fill(dt);
            _conn.Close();

            var categories = new List<Category>();
            foreach (DataRow dr in dt.Rows)
            {
                var cat = new Category
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Name = dr["Name"].ToString(),
                    Code = dr["Code"].ToString(),
                };
                categories.Add(cat);
            }

            return categories;
        }

        public Category GetCatById(int id)
        {
            string query = $@"Select * From Categories Where Id = {id}";
            SqlCommand command = new SqlCommand(query, _conn);
            _conn.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var cat = new Category
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Code = reader["Code"].ToString(),
                };

                if (cat.Id > 0)
                {
                    _conn.Close();
                    return cat;
                }
            }
            _conn.Close();
            return null;
        }

        public bool Update(int id, Category cat)
        {
            string query = $@"Update Categories SET Name = (@P_Name), Code = (@P_Code) Where Id = {id}";
            SqlCommand command = new SqlCommand(query, _conn);

            command.Parameters.AddWithValue("@P_Name", cat.Name);
            command.Parameters.AddWithValue("@P_Code", cat.Code);

            var isSave = SaveChange(command);
            return isSave;
        }

        public bool Delete(int id)
        {
            var query = $@"DELETE FROM Categories WHERE Id = {id}";
            SqlCommand command = new SqlCommand(query, _conn);

            var isDelete = SaveChange(command);
            return isDelete;
        }
    }

}
