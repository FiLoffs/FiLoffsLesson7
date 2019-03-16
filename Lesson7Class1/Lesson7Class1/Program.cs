using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();



            Console.WriteLine(student1.FIO);
            Console.WriteLine(student1.email);
            Console.WriteLine(student1.phone);
            Console.WriteLine(student1.age);
            Console.WriteLine(student1.registrationDate);
            Console.WriteLine(student1);

        }
    }
}
