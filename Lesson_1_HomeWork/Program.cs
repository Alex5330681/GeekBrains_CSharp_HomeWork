using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Собираем данные
            Console.WriteLine("Введите Имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Фамилию");
            string fname = Console.ReadLine();
            Console.WriteLine("Введите Возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Введите Город");
            string city = Console.ReadLine();
            Console.WriteLine("Введите Рост");
            string height = Console.ReadLine();
            Console.WriteLine("Введите Вес");
            string weight = Console.ReadLine();

            //Выводим в центр экрана анкету
            Console.SetCursorPosition(20, 10);

            //Одной строкой показатели выше:    
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Вас зовут: {name} {fname}; Город: {city}; Возраст: {age}; Рост: {height}; Вес: {weight} ");

            //Выводим в центр экрана ИМТ
            Console.SetCursorPosition(Console.WindowWidth / 3, Console.WindowHeight / 2);
            //Console.SetCursorPosition(30, 20);

            //Индекс массы тела:
            float num1 = Int32.Parse(weight);
            float num2 = Int32.Parse(height);

            float result = num1 / (num2 * num2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ваш индекс массы тела: {result}");


            Console.ForegroundColor = ConsoleColor.Green;

            //Мешалка переменных
            int a = 10;
            int b = 20;
            int c = 30;

            Console.WriteLine($"{a}-{b}-{c}");

            (a, b, c) = (b, c, a) = (c, b, a); // Мешалка переменных

            Console.WriteLine($"{a}-{b}-{c}");

            Console.ReadLine();
        }
    }
}

