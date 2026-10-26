using Tyuiu.PlehanovaKA.Sprint3.Task3.V3.Lib;
namespace Tyuiu.PlehanovaKA.Sprint3.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            DataService ds = new DataService();
            string value = "sdf esfawadwa asasaasd asaasaaaaaa";
            char item = 'a';
            int wait = 2;
            int res = ds.GetMinCharCount(value, item);
            Assert.AreEqual(wait, res);
        }
    }
}
