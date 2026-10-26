using Tyuiu.PlehanovaKA.Sprint3.Task5.V20.Lib;
namespace Tyuiu.PlehanovaKA.Sprint3.Task5.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 1;
            int startValue1 = 1;
            int startValue2 = 2;
            int stopValue1 = 1;
            int stopValue2 = 2;
            double wait = 1.412;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Assert.AreEqual(wait, res);
        }
    }
}
