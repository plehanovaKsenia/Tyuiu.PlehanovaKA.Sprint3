using Tyuiu.PlehanovaKA.Sprint3.Task1.V12.Lib;
namespace Tyuiu.PlehanovaKA.Sprint3.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 2;
            double wait = 1.25;
            var res = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
