using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
            {
                Console.WriteLine("Введите число");
                var a = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                Console.WriteLine("Введите число");
                var b = Convert.ToDouble(Console.ReadLine());


                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"Сумма чисел {a} и {b} = {a + b:.00}"); //повесил маску с двумя нулями.
                Console.ReadLine();
            }
        }
    }
