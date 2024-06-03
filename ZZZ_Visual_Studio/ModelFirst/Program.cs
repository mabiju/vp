﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TeaModelContainer())
            {
                // creating and storing new Tea Records
                Console.WriteLine("Enter Tea ID:");
                var t_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Tea Name:");
                var t_name = Console.ReadLine();

                var tea = new Tea
                {
                    TeaId = t_id,
                    TeaName = t_name,
                };
                db.Teas.Add(tea);
                db.SaveChanges();

                var query = from t in db.Teas
                            orderby t.TeaName
                            select t;
                Console.WriteLine("Tea records in the database : ");

                foreach (var item in query)
                {
                    Console.WriteLine(item.TeaName);
                }
                Console.WriteLine("Press any key to exit......");
                Console.ReadKey();
            }
        }
    }
}
