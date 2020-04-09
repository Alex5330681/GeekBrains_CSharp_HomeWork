using System;
using System.Collections.Generic;

   /*
   1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
    Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
    В данной задаче под парой подразумевается два подряд идущих элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
    
     Дубровский Александр.
   */

namespace Lesson_4_HomeWork
{
    class Program
    {
                static void Main(string[] args)
                {

                    int[] arr = new int[20];
                    Random rnd = new Random();

                    Console.Write("Рандомный массив: [");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = rnd.Next(-10_000, 10_001);
                        if (i == arr.Length - 1) Console.WriteLine("{0}]", arr[i]);
                        else
                            Console.Write("{0}, ", arr[i]);
                    }

                    int pairCount = 0;
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        if (arr[i] % 3 == 0 && arr[i + 1] % 3 != 0 ||
                            arr[i] % 3 != 0 && arr[i + 1] % 3 == 0)
                        {
                            pairCount++;
                        }
                    }
                    Console.WriteLine("Количество пар: {0}", pairCount);

                    Console.ReadLine();
                }
            }
        }