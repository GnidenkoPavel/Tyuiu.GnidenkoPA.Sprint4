using System;
using Tyuiu.GnidenkoPA.Sprint4.Task2.V21.Lib;
namespace Tyuiu.GnidenkoPA.Sprint4.Task2.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("* УСЛОВИЕ:Дан одномерный целочисленный массив на 15 элементов заполненный " +
                "случайными в диапазоне от 1 до 7 подсчитать произведение четных элементов массива.");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            int[] array = new int[15];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 8);
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + "\t");
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine(res);
        }
    }
}