using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp7
{
    class Class1
    {
        static void Main()
        {
            int[] num = new int[10];
            num[0] = 100;
            num[1] = 200;
            Console.WriteLine("Before inserting");
            for (int i = 0; i < num.Length; i++)
            { 
                Console.WriteLine(num[i]);
            }

            Console.WriteLine("After inserting");

            for (int i = 1; i <= 2; i++)

            {
                num[i + 1] = num[i];
                break;
            }
            num[1] = 300;

        
            for(int i=0;i<num.Length;i++)
            {
            
                Console.WriteLine(num[i]);
            }
            for (int i = 2; i >= 1; i--)

            {
                num[i - 1] = num[i];
                break;
            }
            num[2] = 0;
            for (int i = 0; i < num.Length; i++)
            {

                Console.WriteLine(num[i]);
            }
            //foreach(int temp in num)
            //{
            //   // temp = 100;
            //    Console.WriteLine(temp);
            //}

            //Console.WriteLine("ArrayList");
            //ArrayList list = new ArrayList();
            //list.Add(10);
            //list.Add(20);
            //list.Add(30);
            //list.Add("Ajay");
            //list.Add(12.4f);
            //list.Add(11);   // Boxing means converting value to reference type

            //foreach(var temp in list) // Unboxing means converting ref to value type
            //    Console.WriteLine(temp); 
            //list.Insert(1, 1000);
            //list.RemoveAt(0);

            //Console.WriteLine("Stack");
            //Stack stack = new Stack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Pop();
            //foreach (int temp in stack)
            //    Console.WriteLine(temp);

            //Console.WriteLine("Queue");
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Dequeue();
            //foreach (int temp in queue)
            //    Console.WriteLine(temp);

            //List<int> list1 = new List<int>();
            //list1.Add(1);
            //list1.Add(2);
            //List<string> list2 = new List<string>();
            //list2.Add("aaa");
            //foreach(int temp in list1)
            //{
            //    Console.WriteLine(temp);
            //}
            //foreach (string temp in list2)
            //{
            //    Console.WriteLine(temp);
            //}

            //Stack<int> stack1 = new Stack<int>();


            //Console.WriteLine("Enter Elemment to search");
            //int x = int.Parse(Console.ReadLine());
            //foreach(var temp in list)
            //{
            //    if (x == (int)temp) { }
            //}
            //// Serching in ArrayList, List, Stack is sequential
            //// Searching in Hashtable is random
            //Hashtable hs = new Hashtable();
            //hs[1] = 19;
            //hs[2] = 90;

            //Console.WriteLine(hs[2]);
            //hs["ajay"] = 90;

            //Dictionary<int, int> marks = new Dictionary<int, int>();
            //marks[1] = 90;
            //Dictionary<string, int> markList = new Dictionary<string, int>();
            //markList["ajay"] = 90;


        }
    }
}
