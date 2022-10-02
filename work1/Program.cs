using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Data.Entity;

namespace work1
{
    internal class Program : DbContext
    {
        static void Main(string[] args)
        {
            string connectionString =
            "Data Source=localhost;Initial Catalog=prodyna_serbia;Integrated Security=True";

            var ctx = new prodyna_serbiaEntities2();
            var emoployee = ctx.employees.ToList();

            var emoployeeWithoutLead = (from s in ctx.employees
                           where s.team_leader_id == null
                           select s).ToList();

            foreach (var employee in emoployee)
            {
                Console.WriteLine(employee.ToString());
                

            }
            Console.WriteLine("\n --------------------------------------------------------");
            foreach (var employee in emoployeeWithoutLead)
            {

                Console.WriteLine(employee.ToString());


            }
         

        Console.ReadKey();
        }
    }
}
