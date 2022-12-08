using SimpleDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SimpleDataAccess.DataAccess
{
    public class ProductDbAccess : IDbAccess<Product, int>
    {
        SqlConnection Conn;
        SqlCommand Cmd;

        public ProductDbAccess()
        {
            Conn = new SqlConnection("Data Source=DJAIN-LAP-0087\\MSSQLSERVER01;Initial Catalog=eShoppingCodi;Integrated Security=SSPI");
        }
        Product IDbAccess<Product, int>.Create(Product entity)
        {
            try
            {
                
                Conn.Open();
                Cmd = Conn.CreateCommand();

                Cmd.CommandType = System.Data.CommandType.Text;
                Cmd.CommandText = "Insert into Product values(@ProductUniqueId,@ProductId,@ProductName, @Description, @Manufacturer, @Price, @CategoryId)";
                // Set Parmeters
                Cmd.Parameters.AddWithValue("@ProductUniqueId", entity.ProductUniqueId);
                Cmd.Parameters.AddWithValue("@ProductId", entity.ProductId);
                Cmd.Parameters.AddWithValue("@ProductName", entity.ProductName);
                Cmd.Parameters.AddWithValue("@Description", entity.Description);
                Cmd.Parameters.AddWithValue("@Manufacturer", entity.Manufacturer);
                Cmd.Parameters.AddWithValue("@Price", entity.Price);
                Cmd.Parameters.AddWithValue("@CategoryId", entity.CategoryId);
                // Execute

                int res = Cmd.ExecuteNonQuery();
                if (res == 0)

                    throw new Exception("No REcord Inserted");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return entity;
        }

        Product IDbAccess<Product, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Product IDbAccess<Product, int>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IDbAccess<Product, int>.GetAll()
        {
            throw new NotImplementedException();
        }

        Product IDbAccess<Product, int>.Update(int id, Product entity)
        {
            throw new NotImplementedException();
        }
    }
}