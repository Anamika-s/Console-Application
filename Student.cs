using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Student
      {
        int rn;
        String name;
        static string batch;
        // Def const  (Cud be  only 1)
        public Student() { }
        // Para
       // Para cons cud be more than 1
        public Student(int rn, string name)
        {
        this.rn = rn;
        this.name = name;
        }
        public Student(int rn )
        {
            this.rn = rn;
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
        }
        // static con (Can be only one)
        static Student()
        {
         batch ="B001";
        }
         public void get() {
            Console.WriteLine("Enter RollNo");
            rn = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
        }
         public void show() {
            Console.WriteLine("RollNo is " + rn);
            Console.WriteLine("Name is " + name);
        }
}

    class Progarm2
    {
        static void Main()
        {
            Student student1 = new Student();
            student1.get();
            student1.show();
            Student student2 = new Student(2);
            Student student3 = new Student(3,"Deepak");
            student2.show();
            student3.show();
        }
    }
}
