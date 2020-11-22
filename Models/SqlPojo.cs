using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExamVoid.Models
{
    public class SqlPojo
    {
        private static SqlConnection con = new SqlConnection(LoadConString());
        private static SqlCommand cmd = null;
        private static SqlDataReader rdr = null;
        private static string INSERT_QUERY = "INSERT INTO items VALUES (@name,@category,@price,@avail)";
        private static string SELECT_QUERY = "SELECT * FROM items";
        private static string DELETE_QUERY = "DELETE FROM items WHERE id = @id";
        private static string UPDATE_QUERY = "UPDATE items set name= @name,category = @category,price= @price,avail=@avail WHERE id = @id";

        public static int insertFood(string name,string category,string price,string avail)
        {
            con.Open();
            cmd = new SqlCommand(INSERT_QUERY,con);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("category", category);
            cmd.Parameters.AddWithValue("price", price);
            cmd.Parameters.AddWithValue("avail", avail);
            int noro = cmd.ExecuteNonQuery();
            con.Close();
            return noro;
        }
        public static List<Food> getAllFoodItemsInDb()
        {
            List<Food> ls = new List<Food>();
            con.Open();
            cmd = new SqlCommand(SELECT_QUERY, con);
            rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                ls.Add(new Food { id = Convert.ToInt32(rdr["id"].ToString()), name = rdr["name"].ToString(),category = rdr["category"].ToString() ,price=rdr["price"].ToString(),avail = rdr["avail"].ToString()});
            }
            con.Close();
            return ls;
        }

        public static int DeleteTheItem(string id)
        {
            con.Open();
            cmd = new SqlCommand(DELETE_QUERY, con);
            cmd.Parameters.AddWithValue("id",id);
            int noro = cmd.ExecuteNonQuery();
            con.Close();
            return noro;
        }

        public static int UpdateTheItem(string id,string name,string category,string price,string avail)
        {
            con.Open();
            cmd = new SqlCommand(UPDATE_QUERY,con);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("category", category);
            cmd.Parameters.AddWithValue("price", price);
            cmd.Parameters.AddWithValue("avail", avail);
            int noro = cmd.ExecuteNonQuery();
            con.Close();
            return noro;
        }
        public static string LoadConString()
        {
            return ConfigurationManager.ConnectionStrings["mycon"].ConnectionString.ToString();
        }
    }
}