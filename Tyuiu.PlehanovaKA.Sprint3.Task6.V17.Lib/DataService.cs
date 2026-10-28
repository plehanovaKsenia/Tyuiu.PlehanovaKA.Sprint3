using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PlehanovaKA.Sprint3.Task6.V17.Lib
{
    public class DataService : ISprint3Task6V17
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            List<int> TheDivisors = new List<int>();
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 1;j<=startValue; j++)
                {
                    if (i%j==0)
                    {
                        TheDivisors.Add(j);
                    }
                    startValue++;

                
                }
            }
            return TheDivisors.Count;
        }
    }
}
