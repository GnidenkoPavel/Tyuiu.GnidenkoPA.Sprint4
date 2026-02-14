
using Tyuiu.GnidenkoPA.Sprint4.Task0.V15.Lib;
namespace Tyuiu.GnidenkoPA.Sprint4.Task0.V15.Test
{
    [TestClass]  
    public class DataServiceTest
    {
        [TestMethod]  
        public void ValidGetMultOddArrE()
        {
            DataService ds = new DataService();
            int[] numsArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int res = ds.(numsArray);
            int waitArray = 138915;
            Assert.AreEqual(waitArray, res);
        }
    }
}
