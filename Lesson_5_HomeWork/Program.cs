using System;
using Task2_messageClass;


/*
ЗАДАНИЕ №1
Создать программу, которая будет проверять корректность ввода логина.
Корректным логином будет строка от 2 до 10 символов, 
содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой
*/

//namespace Lesson_5_HomeWork
//{
//    class Program
//    {
//        static void Main()
//        {

          

//            bool b1;

//            Console.WriteLine(
//                "Придумайте логин и пароль, \n от 2 до 8 символов \n запрещено в начале использовать цифры ");
//            Console.Write("логин >");
//            string Login = Console.ReadLine();
//            Console.Write("пароль >");
//            string Pass = Console.ReadLine();

//            Regex RegNum = new Regex(@"[^A-Za-z]");

//            if (Login.Length < 2 || Pass.Length > 8)
//            {
//                Console.WriteLine("Неправльное количество символов");
//                b1 = false;
//            }

//            if (RegNum.IsMatch(Login.Substring(0, 1)) || RegNum.IsMatch(Pass.Substring(0, 1)))

//            {
//                b1 = false;
//                Console.WriteLine("Логин или пароль должен начинаться с буквы");
//            }

//            else
//            {
//                Console.WriteLine("Отличный пароль");
//                b1 = true;
//            }

//            Console.WriteLine($"Результат {b1}");
//            Console.ReadKey();
//        }
//    }


    /////////////////////////////////////////////////////////////////////////////////////////

    //    /*
    //        ЗАДАНИЕ №2
    //        Разработать класс Message, содержащий следующие статические методы для обработки
    //        текста:
    //        а) Вывести только те слова сообщения, которые содержат не более n букв.
    //        б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //        в) Найти самое длинное слово сообщения.
    //        г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //    */


    namespace Lesson_5_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Три кита как три кота держат землю не спроста" +
                          " Кот котан и кит с китенком, три, три, три на землю три ";

            Console.WriteLine($"Исходный текст:\n{text}");

            Console.WriteLine("\nа) Вывести только те слова сообщения, которые содержат не более 3 букв:");
            Message.CustomWord(text, 3);

            Console.WriteLine($"\nб) Удалить из сообщения все слова, которые заканчиваются " +
                              $"на заданный символ (а):\n{Message.WordRemove(text, 'а')}");

            Console.WriteLine($"\nв) Найти самое длинное слово сообщения:\n{Message.MaxWord(text)}");
            Console.WriteLine($"\nг) Сформировать строку с помощью StringBuilder из самых " +
                              $"длинных слов сообщения:\n{Message.MaxWordString(text)}");

            string[] array = { "кот", "кит", "три", "землю" };
            Console.WriteLine("\n***Создать метод, который производит частотный анализ текста:");

            Message.TextAnalysis(array, text);
            Console.ReadKey();

        }
    }
}





