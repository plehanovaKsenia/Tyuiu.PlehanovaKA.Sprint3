using Tyuiu.PlehanovaKA.Sprint3.Task4.V28.Lib;
namespace Tyuiu.PlehanovaKA.Sprint3.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -1;
            int stopValue = 1;
            double wait = 0.301;
            double res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
