using System;
using Tyuiu.GnidenkoPA.Sprint4.Task0.V15.Lib;
namespace Tyuiu.GnidenkoPA.Sprint4.Task0.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService(); 

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            
            Console.WriteLine("Сумма всех нечётных чисел массива: " + ds.GetMultOddArrEl(numsArray));

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}