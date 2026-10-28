using Tyuiu.PlehanovaKA.Sprint3.Task7.V10.Lib;
namespace Tyuiu.PlehanovaKA.Sprint3.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -1;
            int stopValue = 1;
            double[] wait = [-2.62,1.83,4.49];
            double[] res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
