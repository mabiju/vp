using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DB_Pro_SqlConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Program().connectionDb();
            Console.ReadLine();
        }
        public void connectionDb()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=vjmalla; Initial Catalog=db_sqldemo; Integrated Security=True");
                conn.Open();
                Console.WriteLine("Connection established successfully.");
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
