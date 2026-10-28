using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PlehanovaKA.Sprint3.Task7.V10.Lib
{
    public class DataService : ISprint3Task7V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] f = new double[stopValue-startValue+1];
            int j = 0;
            for (int x = startValue;x<=stopValue;x++)
            {
                if ((Math.Sin(x)+3)!=0)
                {
                    f[j] = Math.Round(((5 * x + 2.5) / (Math.Sin(x) + 3)) + 2 * x + Math.Cos(x),2);

                }
                else
                {
                    continue;
                }
                j++;
                
            }
            return f;
        }
    }
}
