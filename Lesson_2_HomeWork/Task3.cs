using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Task3
{
    public void LoginPass()
    {
        string loginTrue = "admin";
        string passTrue = "root";
        bool control = false;
        int i = 0;

        Console.WriteLine("Введите лоигн 'admin' и пароль 'root' чтобы войти в систему");

        do
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Введите логин:");
            string log = Console.ReadLine();

            Console.Write("Введите пароль:");
            string pass = Console.ReadLine();
            i++;

            if (log == loginTrue && pass == passTrue)
            {
                control = true;
                break;
            }
            else
            {
                if (i < 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный пароль, Access blocked! ");
                }

            }
        }

        while (i < 3);

        if (control)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Доступ разрешён, Вы в системе."); 

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ввели больше 3 попыток, система самоликвидированна!"); 

        }
    }
}

