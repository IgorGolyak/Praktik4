using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_Работа_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // задание 1
            Console.WriteLine("введите первое число");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите второе число");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("название дня 1-понедельник 2-вторник 3 4 5 6 7 ");
            double z = Convert.ToDouble(Console.ReadLine());
            double c = 0;
            switch (z)
            {
                case 1:
                    {
                        c = x + y;
                        break;
                    }
                case 2:
                    {
                        c = x - y;
                        break;
                    }
                case 3:
                    {
                        c = x * y;
                        break;
                    }
                case 4:
                    {
                        c = x / y;
                        break;
                    }
                case 5:
                    {
                        c = x + y;
                        break;
                    }
                case 6:
                    {
                        c = x - y;
                        break;
                    }
                case 7:
                    {
                        c = x * y;
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Ошибка выбора оператора ");
                        break;
                    }
            }
            Console.WriteLine("Ответ:" + c);
            Console.ReadKey();

        }
    }
}
