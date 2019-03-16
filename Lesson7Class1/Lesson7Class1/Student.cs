using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Class1
{
    class Student
    {
        public String FIO;
        public String email;
        public String phone;
        public Byte age;
        public DateTime registrationDate;

        public Student()
        {
            FIO = "NoName";
            email = "@";
            registrationDate = DateTime.Now;
            Console.WriteLine(registrationDate);
        }

        public Student(String FIO, String email, String phone, Byte age, DateTime regDate)
        {
            //this.FIO;
            //this.email;
            //this.phone;
            //this.age;
            
        }
    }
}
