using ConsoleApp7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    delegate int Del(int x, int y);
    class Program
    {


         static int add(int x, int y)
        {
            return x + y;
        }
        static int subtract(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Del del = new Del(add);
            Console.WriteLine(del(12,13));
            del = new Del(delegate(int x, int y)
                {
                    return x + y;
                });
            del = new Del((x,y)=> 
            {
                return x + y;
            });

            BatchDbContext db = new BatchDbContext();
            var batches = db.Batches.ToList();  /// Read
            if (batches.Count == 0)
                Console.WriteLine("There is no record");
            else
            {
                foreach (var temp in batches)
                    Console.WriteLine(temp.Id + " " + temp.Name + " " + temp.Course);
            }

            Console.WriteLine("Enter Batch Name");
            string name = Console.ReadLine();
            Console.WriteLine("ENter Course Name");
            string course = Console.ReadLine();
            Console.WriteLine("ENter Size");
            int size = int.Parse(Console.ReadLine());
            Batch batch = new Batch() { Name = name, Course = course, Size = size };
            db.Batches.Add(batch);    // Insert
            db.SaveChanges();
            Console.WriteLine("Record is inserted");
            var data1 = (from temp in db.Batches
                         where temp.Course == "A"
                         select temp).FirstOrDefault() ;
            var data = db.Batches.FirstOrDefault(x => x.Course == "A");
            List<string> list = new List<string>()
            { };
            list.Where(x => x == "Aaa");

            int[] num = new int[] { 1, 2, 3, 4, 5 };
            var even = num.Select(x => x % 2 == 0);






        }
    }
}
