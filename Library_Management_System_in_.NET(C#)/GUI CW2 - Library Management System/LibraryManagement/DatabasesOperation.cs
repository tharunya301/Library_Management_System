using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace SqlOperations
{
    class SqlOperation
    {

        SqlConnection con;
        SqlDataAdapter adp;
        SqlCommand cmd;
        DataTable dt;

        public string conString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\LibraryManagement\LibraryManagement\library.mdf;Integrated Security=True";
        }

        public void insert(string querry)
        {
            con = new SqlConnection(conString());
            con.Open();
            cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable select(String querry)
        {
            con = new SqlConnection(conString());
            adp = new SqlDataAdapter();
            con.Open();
            dt = new DataTable();
            adp = new SqlDataAdapter(querry, con);
            adp.Fill(dt);
            con.Close();
            return dt;
        }

        public void update(string querry)
        {
            con = new SqlConnection(conString());
            con.Open();
            cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(string querry)
        {
            con = new SqlConnection(conString());
            cmd = new SqlCommand(querry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

