using System;
using Tyuiu.GnidenkoPA.Sprint4.Task3.V8.Lib;
namespace Tyuiu.GnidenkoPA.Sprint4.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный массив 5x5, заполненный значениями от 2 до 8.             *");
            Console.WriteLine("* Найти минимальный элемент в четвертом столбце массива.                  *");
            Console.WriteLine("***************************************************************************");

            int[,] array = {
                { 4, 8, 3, 4, 8 },
                { 5, 3, 5, 7, 8 },
                { 3, 7, 2, 7, 7 },
                { 5, 2, 4, 6, 4 },
                { 4, 4, 6, 7, 2 }
            };

            Console.WriteLine("\nИсходный массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int result = ds.Calculate(array);

            Console.WriteLine("\nМинимальный элемент в четвёртом столбце = " + result);
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}