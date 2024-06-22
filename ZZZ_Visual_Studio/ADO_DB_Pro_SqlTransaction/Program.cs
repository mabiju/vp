using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DB_Pro_SqlTransaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Program().MySQLTransaction();
            Console.ReadLine();
        }

        public void MySQLTransaction()
        {
            SqlConnection conn = new SqlConnection("Data Source=vjmalla; Initial Catalog=db_sqldemo; Integrated Security=True");
            SqlTransaction myTrans;
            conn.Open();
            myTrans = conn.BeginTransaction();
            try
            {

                new SqlCommand("INSERT INTO tbl_students(fullname,address,email)VALUES('Hari Sharan Adhikari','Dhulikhel','hariahri@yahoo.com')", conn, myTrans).ExecuteNonQuery();
                myTrans.Commit();
                Console.WriteLine("Data inserted sucessfully");
            }
            catch (SqlException e)
            {
                myTrans.Rollback();
                Console.WriteLine("Something went wrong." + e);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
