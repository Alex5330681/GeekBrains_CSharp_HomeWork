//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Console = System.Console;
//using ConsoleKey = System.ConsoleKey;
//using Encoding = System.Text.Encoding;
//using Environment = System.Environment;

////TASK_1
////Написал программу с использованием делегата, суть проги в том чтобы сообщать юзеру его график (использовал свое расписание).

//namespace Lesson_6
//{
//    class Program
//    {
//        delegate void WhatTime();       // Делаем делегат

//        static void Main(string[] args)
//        {
//            WhatTime whatTime = null;   // Создаем переменную делегата


//            // Присваиваем этой переменной адрес метода
//            if (DateTime.Now.Hour > 9 && DateTime.Now.Hour < 9.30)
//            {
//                whatTime = wakey;
//            }
//            if (DateTime.Now.Hour > 9.30 && DateTime.Now.Hour < 10)
//            {
//                whatTime = breakfast;
//            }
//            if (DateTime.Now.Hour > 10 && DateTime.Now.Hour < 14 ||
//                DateTime.Now.Hour > 15 && DateTime.Now.Hour < 18)
//            {
//                whatTime = workTime;
//            }
//            if (DateTime.Now.Hour > 14 && DateTime.Now.Hour < 15)
//            {
//                whatTime = lunch;
//            }
//            if (DateTime.Now.Hour > 18 && DateTime.Now.Hour < 19)
//            {
//                whatTime = dinner;
//            }
//            if (DateTime.Now.Hour > 19 && DateTime.Now.Hour < 23.30)
//            {
//                whatTime = learn;
//            }
//            if (DateTime.Now.Hour > 23.30 && DateTime.Now.Hour < 00.15)
//            {
//                whatTime = goSleep;
//            }


//            whatTime();                                 // Вызываем метод а он уже определяет что показать
//            Console.ReadKey();
//        }
//        private static void wakey()
//        {
//            Console.WriteLine("Доброе утро, сегодня будет отличный день!");
//        }
//        private static void breakfast()
//        {
//            Console.WriteLine("Сейчас время для завтрака");
//        }
//        private static void workTime()
//        {
//            Console.WriteLine("Сейчас рабочее время, не отвлекайся!");
//        }
//        private static void lunch()
//        {
//            Console.WriteLine("Время обеда, приятного аппетита");
//        }
//        private static void dinner()
//        {
//            Console.WriteLine("Время ужина, приятного аппетита");
//        }
//        private static void learn()
//        {
//            Console.WriteLine("Сейчас самое время заниматься обучением");
//        }
//        public static void goSleep()
//        {
//            Console.WriteLine("Пора спать! gogogo!");
//        }
//    }
//}

////////////////////////////////////////////////////////////////////////////////////////////////

//  Task_2
//  Я пытался сделать зацикленный список задач, который будет сохранятся в .TXT
//  Мы уже делали похожую программу, думал будет легко повторить, но что-то не вышло(((

////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Text;

class Test
{
    public static void Main()
    {
        string text = @"tasksList.txt";

        do
        {

            string[] Title = { "Сюда записывайте дела на день:" };
            File.WriteAllLines(text, Title, Encoding.UTF8);

            Console.Write(">");
            string appendText = Console.ReadLine() + Environment.NewLine;
            File.AppendAllText(text, appendText, Encoding.UTF8);

            string[] readText = File.ReadAllLines(text, Encoding.UTF8);
            foreach (string task in readText)
            {
                Console.ReadLine();
            }
        } while (Console.ReadKey().Key != ConsoleKey.Backspace);



        //using (StreamReader task = new StreamReader(text))
        //{
        //    Console.WriteLine(task.ReadToEnd());
        //}


    }
}