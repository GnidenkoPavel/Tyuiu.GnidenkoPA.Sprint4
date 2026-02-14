using System;
using Tyuiu.GnidenkoPA.Sprint4.Task5.V7.Lib;
namespace Tyuiu.GnidenkoPA.Sprint4.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int len;
            Console.WriteLine("Введите размерность массива (5):");
            len = Convert.ToInt32(Console.ReadLine());
            int[,] numsArray = new int[len, len];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.WriteLine($"Введите элемент массива [{i + 1},{j + 1}] (от -7 до 7):");
                    numsArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.Write(numsArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int result = ds.Calculate(numsArray);
            Console.WriteLine("Количество отрицательных элементов массива:");
            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}