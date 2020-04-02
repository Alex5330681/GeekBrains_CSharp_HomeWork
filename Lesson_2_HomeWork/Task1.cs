using System;
using static Task1;

public class Task1
{
    public void DiffNumber()
        {
        Console.WriteLine("Введите Первое число");
        int num1 = Convert.ToInt32(Console.ReadLine());  
        
        Console.WriteLine("Введите Второе число");
        int num2 = Convert.ToInt32(Console.ReadLine());  
        
        Console.WriteLine("Введите Третье число");
        int num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine ("----------------------");

        int maxNumber = 0;
        int minNumber = 0;
        int amoNumber = 0;

        //проверочка
        if (num1 == num2 || num2 == num3 || num1 == num3)
        {
            Console.WriteLine("Числа равны и сравнить их неудается =( ");
            return;
        }


        
        if (num1 > num2 && num1 > num3)
        {
            maxNumber = num1;
            if (num2 > num3)
            {
                amoNumber = num2;
                minNumber = num3;
            }
            else
            {
                amoNumber = num3;
                minNumber = num2;
            }
        }

        if (num2 > num3 && num2 > num1)
        {
            maxNumber = num2;
            if (num3 > num1)
            {
                amoNumber = num3;
                minNumber = num1;
            }
            else
            {
                amoNumber = num1;
                minNumber = num3;
            }
        }

        if (num3 > num1 && num3 > num2)
        {
            maxNumber = num3;
            if (num1 > num2)
            {
                amoNumber = num1;
                minNumber = num2;
            }
            else
            {
                amoNumber = num2;
                minNumber = num1;
            }
        }

        Console.WriteLine($"Максимальное из чисел: {maxNumber} \nсреднее из чисел: {amoNumber} \nНаименьшее из чисел: {minNumber}");

    }

}


