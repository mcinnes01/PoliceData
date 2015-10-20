using Police.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Service();
            var crimes = service.GetCrimes();
            var count = crimes.Result.Count();

            Console.WriteLine($"Number of crimes {count}");

            var query = from c in crimes.Result
                        orderby c.Category
                        group c.Category by c.Category into grp
                        select new CategoryGroup { Category = grp.Key, Count = grp.Count() };
            
            foreach (var q in query)
            {
                Console.WriteLine($"Category: {q.Category} - Count: {q.Count}");
            }

            Console.ReadKey();       
        }
    }
}
