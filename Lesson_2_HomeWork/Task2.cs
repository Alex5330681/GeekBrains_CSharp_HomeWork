using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Task2
{ 
    public void IMT()
    {
        Console.WriteLine("Введите свой рост");
        double a = Convert.ToInt32(Console.ReadLine());
        double rost = a / 100;

        Console.WriteLine("Введите свой вес");
        double ves = Convert.ToInt32(Console.ReadLine());

        double imt = ves / (rost * rost);

        Console.WriteLine($"Ваш индекс массы тела: {imt}");

        if (imt <= 19)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Вес намного ниже нормы");
                }
        if (imt > 20 && imt <= 25)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Вес в пределах нормы");
                }
        if (imt > 26 && imt <= 29)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ваш вес выше нормы");
                }
        if (imt > 30 && imt <= 35)
                {

                     Console.ForegroundColor = ConsoleColor.Red; 
                     Console.WriteLine("Ожирение 1-й стадии");
                }
        if (imt > 36 && imt <= 39)
                {

                     Console.ForegroundColor = ConsoleColor.Red; 
                     Console.WriteLine("Ожирение 2-й стадии");
                }

        else if(imt > 40)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ВНИМАНИЕ, Вам надо прекратить есть! у Вас максимальное ожирение!");
        }

        Console.ReadLine();
    }
    }
    
