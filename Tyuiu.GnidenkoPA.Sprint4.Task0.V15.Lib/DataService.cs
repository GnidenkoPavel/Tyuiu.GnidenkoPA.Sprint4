using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GnidenkoPA.Sprint4.Task0.V15.Lib
{
    public class DataService : ISprint4Task0V15
    {

        public int GetMultOddArrEl(int[] array)
        {
            int res = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {

                }
                else
                {
                    res *= array[i];
                }
            }
            return res;
        }
    }
}
