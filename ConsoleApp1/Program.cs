using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 2
            Console.WriteLine("введите число  b ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число  a ");
            double a = Convert.ToDouble(Console.ReadLine());
            double a1 = 1;
            double b1 = 12;
            for (int i = 1; a > b; i++)
            {
                a = i * (a1 * b1);
            }
            Console.WriteLine("Ответ"  +  a);
            Console.ReadKey();
        }
    }
}
