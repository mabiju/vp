using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DB_Pro_SqlCommand{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Program().SqlSelectCommand();
            Console.ReadLine();
        }
        public void SqlSelectCommand()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=vjmalla; Initial Catalog=db_sqldemo; Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_students", conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["fullname"]+ " lives in " + sdr["address"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong" + e);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
