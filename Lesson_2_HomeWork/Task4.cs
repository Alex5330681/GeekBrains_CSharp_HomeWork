using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Task4
{
    public void zerostop ()
    {

            int sum = 0;
            int num = 0;

        Console.WriteLine("Вводите любые цифры по порядку, цифра 0 остановит подсчет!");

            do
            {
                Console.Write("Цифра > ");
                num = int.Parse(Console.ReadLine());
                    if (num > 0 && num % 2 == 1) 
                    sum += num;

            } while (num != 0);

            Console.WriteLine("Если сложить все нечетные, получится: " + sum);
        
        Console.ReadLine();
    }
}
