using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PlehanovaKA.Sprint3.Task0.V27.Lib
{
    public class DataService : ISprint3Task0V27
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            for (int k = startValue; k <= stopValue; k++)
            {
                SumSeries=SumSeries+Math.Pow(4.0/Math.Pow(k,value),2);

            }
            return Math.Round(SumSeries,3);

        }
    }
}
