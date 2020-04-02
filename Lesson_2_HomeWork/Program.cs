/**********************************************************************************************************
 * Produced by Aleksandr Dubrovsky.                  													   *
 * GeekBrains, GameDav.                         														   *
 ***********************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task1;
using static Task2;
using static Task3;
using static Task4;

namespace Lesson_2_HomeWork
{
    public class Program
    {

        #region Задача №1 (незакоммент. по умолчанию)
        // Условия:
        // Написать метод, возвращающий минимальное из трех чисел.
        // Разобрал каждое число по типу

        private static void Main()
        {
            Task1 task1 = new Task1();
            task1.DiffNumber();
            Console.ReadLine();
        }

        #endregion



        #region Задача 2(Раскомменьте для проверки)

        ////Условия:
        ////Написать программу, которая запрашивает массу и рост человека,
        ////вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;

        //private static void Main()
        //{
        //    Task2 task2 = new Task2();
        //    task2.IMT();
        //    Console.ReadLine();
        //}

        #endregion



        #region Задача 3(Раскомменьте для проверки)

        ////Реализовать метод проверки логина и пароля.
        ////На вход подается логин и пароль.На выходе истина, если прошел авторизацию,
        ////и ложь, если не прошел (Логин: root, Password: GeekBrains).
        ////Используя метод проверки логина и пароля, написать программу:
        ////пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        ////С помощью цикла do while ограничить ввод пароля тремя попытками.


        //private static void Main()
        //{
        //    Task3 task3 = new Task3();
        //    task3.LoginPass();
        //    Console.ReadLine();
        //}

        #endregion Задача 3



        #region Задача 4(Раскомменьте для проверки)

        ////С клавиатуры вводятся числа, пока не будет введен 0.
        ////Подсчитать сумму всех нечетных положительных чисел.

        //private static void Main()
        //{
        //    Task4 task4 = new Task4();
        //    task4.zerostop();
        //    Console.ReadLine();
        //}

        #endregion Задача 4

    }
}
