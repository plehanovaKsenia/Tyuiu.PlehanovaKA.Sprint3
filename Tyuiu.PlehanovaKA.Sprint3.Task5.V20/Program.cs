using Tyuiu.PlehanovaKA.Sprint3.Task5.V20.Lib;
namespace Tyuiu.PlehanovaKA.Sprint3.Task5.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();


            Console.Title = "Спринт #3 | Выполнила: Плеханова К. А. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание#5                                                               *");
            Console.WriteLine("* Вариант#20                                                              *");
            Console.WriteLine("* Выполнила: Плеханова Ксения Анатольевна | СМАРТб-26-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* вычислить значение выражение при х=5                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 5;
            int startValue1 = 1;
            int startValue2 = 3;
            int stopValue1 = 1;
            int stopValue2 = 6;
            Console.WriteLine("Значение Х " + x);
            Console.WriteLine("Начальное значение 1 " + startValue1);
            Console.WriteLine("Конечное значение 1 " + stopValue1);
            Console.WriteLine("Начальное значение 2 " + startValue2);
            Console.WriteLine("Конечное значение 2 " + stopValue2);
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
        }
    }
}
