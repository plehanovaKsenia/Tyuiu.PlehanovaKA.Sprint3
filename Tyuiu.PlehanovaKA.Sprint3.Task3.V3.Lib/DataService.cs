using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PlehanovaKA.Sprint3.Task3.V3.Lib
{
    public class DataService : ISprint3Task3V3
    {
        public int GetMinCharCount(string value, char item)
        {
            int minCount = int.MaxValue;
            int currentCount = 0;
            foreach (char c in value + " ")
            {
                if (c == item)
                {
                    currentCount ++;
                }
                else
                {
                    if ((currentCount>1) && (currentCount < minCount))
                    {
                        minCount = currentCount;
                    }
                    currentCount = 0;
                }
                
            }
            return minCount;
        }
    }
}
