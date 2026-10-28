using Tyuiu.PlehanovaKA.Sprint3.Task6.V17.Lib;
namespace Tyuiu.PlehanovaKA.Sprint3.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 4;
            int wait = 4;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
