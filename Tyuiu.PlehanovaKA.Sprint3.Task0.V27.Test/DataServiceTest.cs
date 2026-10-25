using Tyuiu.PlehanovaKA.Sprint3.Task0.V27.Lib;
namespace Tyuiu.PlehanovaKA.Sprint3.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries ()
        {
            DataService ds = new DataService();
            int value = 2;
            int startValue = 1;
            int stopValue = 2;
            double wait = 17;
            double res = ds.GetSumSeries (value, startValue, stopValue);
            Assert.AreEqual(wait, res);

        }
    }
}
