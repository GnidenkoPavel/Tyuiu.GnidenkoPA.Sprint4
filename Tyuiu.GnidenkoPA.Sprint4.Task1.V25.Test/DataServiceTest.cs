using Tyuiu.GnidenkoPA.Sprint4.Task1.V25.Lib;
namespace Tyuiu.GnidenkoPA.Sprint4.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 6, 3, 6, 4, 7, 4, 6, 5, 2, 3, 6, 3, 6, 2 };

            int result = ds.Calculate(array);
            int expected = 42;

            Assert.AreEqual(expected, result);
        }
    }
}
