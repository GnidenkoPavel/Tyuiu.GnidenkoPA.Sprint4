using Tyuiu.GnidenkoPA.Sprint4.Task3.V8.Lib;
namespace Tyuiu.GnidenkoPA.Sprint4.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            int[,] array =
            {
                { 4, 8, 3, 4, 8 },
                { 5, 3, 5, 7, 8 },
                { 3, 7, 2, 7, 7 },
                { 5, 2, 4, 6, 4 },
                { 4, 4, 6, 7, 2 }
            };

            int result = ds.Calculate(array);         
            Assert.AreEqual(4, result);
        }
    }
}
