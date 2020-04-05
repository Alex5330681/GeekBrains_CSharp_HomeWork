using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string numbers = "";
            while (true)
            {
                Console.Write("Введите число: ");
                number = Check();
                if (number % 2 != 0 && number > 0)
                {
                    numbers = numbers + number + ".";
                }
                if (number == 0)
                {
                    outputString(ref numbers);
                    break;
                }
            }

            Console.ReadKey();
        }

        public static int Check()
        {
            string temp;
            bool flag = false;
            int numb = 0;
            while (!flag)
            {
                temp = Console.ReadLine();
                exceptionChecking(ref temp, ref flag, ref numb);
            }

            return numb;
        }

        public static bool exceptionChecking(ref string temp, ref bool flag, ref int numb)
        {
            try
            {
                numb = Int32.Parse(temp);
                flag = true;
            }
            catch
            {
                Console.Write("Неверный формат ввода. Введите целое число: ");
                flag = false;
            }
            return flag;
        }

        public static void outputString(ref string str)
        {
            string[] numbs = str.Split('.');
            bool flag;
            int temp, result = 0;

            if (numbs.Length == 1)
                Console.WriteLine("Нет нечетных положительных чисел");
            else
            {
                for (int i = 0; i < numbs.Length; i++)
                {
                    flag = int.TryParse(numbs[i].ToString(), out temp);
                    if (flag)
                    {
                        Console.WriteLine("Нечетное положительное число: " + temp);
                        result = result + temp;
                    }
                }
                Console.WriteLine("Сумма всех нечетных положительных чисел: " + result);
            }
        }

    }
}