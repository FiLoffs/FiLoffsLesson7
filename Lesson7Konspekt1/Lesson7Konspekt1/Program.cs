using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lesson7Konspekt1.Program;

namespace Lesson7Konspekt1
{
    class Program
    {
        public interface ICar
        {
            int Speed { get; set; }
            void GetInfo();
        }

        public interface ILuxury
        {
            int Price { get; set; }
            void GetInfo();
        }

        public class ferrari : ICar, ILuxury
        {
            private int spd; //скорость
            private int prc; //цена
            public int Speed
            {
                get
                {
                    return spd;
                }
                set
                {
                    spd = value;
                }
            }
            //public void GetInfo()
            //{
            //    Console.WriteLine("Это суперкар Ferrari");
            //}
            void ICar.GetInfo()
            {
                Console.WriteLine("Это суперкар Ferrari ");
            }
            void ILuxury.GetInfo()
            {
                Console.WriteLine("Эта Ferrari стоит кучу денег!");
            }
            public int Price
            {
                get
                {
                    return prc;
                }
                set
                {
                    prc = value;
                }
            }
        }

        static void Main(string[] args)
        {
            ferrari c = new ferrari();
            c.Price = 1000000;
            c.Speed = 450;
            if (c is ICar)
            {
                ICar tmp = (ICar)c;
                tmp.GetInfo();
            }
            if (c is ILuxury)
            {
                ILuxury tmp2 = (ILuxury)c;
                tmp2.GetInfo();
            }
            Console.ReadLine();
        }
    }
}
