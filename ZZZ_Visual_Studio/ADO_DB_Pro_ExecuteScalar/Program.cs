using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DB_Pro_ExecuteScalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string ConString = "Data Source=vjmalla;Initial Catalog=db_sqldemo;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(ConString))
                {
                    //creating SqlCommand Object
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(rollno) from tbl_students", conn);
                    //connection open
                    conn.Open();
                    //Executing the SQL Query
                    //Since the return type of ExecuteScalar() is object, we are type casting to int datatype
                    int TotalRows = (int)cmd.ExecuteScalar();
                    Console.WriteLine("The total number of rows in Student table is = " + TotalRows);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong." + e);
            }
            Console.ReadLine();
        }
    }
}
