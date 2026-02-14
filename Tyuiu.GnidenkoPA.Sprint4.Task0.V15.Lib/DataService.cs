using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GnidenkoPA.Sprint4.Task0.V15.Lib
{
    public class DataService : ISprint4Task0V15
    {
        public int GetMultOddArrEl(int[] array)
        {
            int product = 1;
            foreach (int num in array)
            {
                if (num % 2 != 0) 
                {
                    product *= num;
                }
            }
            return product;
        }
    }
}
