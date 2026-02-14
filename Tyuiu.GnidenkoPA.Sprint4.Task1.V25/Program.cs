using System;
using Tyuiu.GnidenkoPA.Sprint4.Task1.V25.Lib;
namespace Tyuiu.GnidenkoPA.Sprint4.Task1.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();          
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов,                    *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 1 до 7:              *");
            Console.WriteLine("* 6, 3, 6, 4, 7, 4, 6, 5, 2, 3, 6, 3, 6, 2                                *");
            Console.WriteLine("* Подсчитать сумму чётных элементов массива.                              *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[14];
            Console.WriteLine("Введите 14 целых чисел в диапазоне от 1 до 7:");

            for (int i = 0; i < 14; i++)
            {
                Console.Write($"Элемент [{i + 1}]: ");
                string input = Console.ReadLine();
                int value = int.Parse(input);


                if (value < 1 || value > 7)
                {
                    Console.WriteLine("Вне dungeon");
                    i--;
                    continue;
                }

                array[i] = value;
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1) Console.Write(", ");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int sumEven = ds.Calculate(array);

            Console.WriteLine("Сумма чётных элементов = " + sumEven);

            Console.ReadKey();
        }
    }
}