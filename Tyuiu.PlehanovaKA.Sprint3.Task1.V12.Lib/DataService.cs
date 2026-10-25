using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PlehanovaKA.Sprint3.Task1.V12.Lib
{
    public class DataService : ISprint3Task1V12
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            while (startValue<=stopValue)
            {
                SumSeries = SumSeries + Math.Pow(1.0 / Math.Pow(startValue, value), 2);
                startValue++;

            }
            return Math.Round(SumSeries, 3);
        }
    }
}
