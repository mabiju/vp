using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_DB_Pro_StoredProcedure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dc = new SqlConnection("Data source=vjmalla;Initial Catalog=db_sms;Integrated Security=True");
            using (SqlCommand cmd = new SqlCommand("userProcess", dc))
            {
                string val;
                Console.Write("Enter username:");
                val = Console.ReadLine();
                string a = Convert.ToString(val);
                Console.WriteLine("Your input is {0}", a);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", a.ToString());
                dc.Open();

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    Console.WriteLine("Record not found");
                }
                else
                {
                    string b = Convert.ToString(val);
                    b = dr[1].ToString();
                    Console.WriteLine("Your password is {0}", b.ToString());
                    Console.ReadLine();
                }
                dc.Close();
            }
        }
    }
}
