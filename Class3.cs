using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{ 
    class Class3
    {static void Main()
        {
            int num;
            Console.WriteLine("ENter Num");
            //num = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine(num);


            //int x, y, res = 0;
            //try
            //{
            //    Console.WriteLine("Enter x");
            //    x = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter y");
            //    y = int.Parse(Console.ReadLine());
            //    res = x / y;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Res is " + res);
            //}
        }

    }
}
