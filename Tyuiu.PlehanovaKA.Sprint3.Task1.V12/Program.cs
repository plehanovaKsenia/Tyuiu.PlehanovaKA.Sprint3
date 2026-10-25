using Tyuiu.PlehanovaKA.Sprint3.Task1.V12.Lib;

namespace Tyuiu.PlehanovaKA.Sprint3.Task1.V12
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
            Console.WriteLine("* Задание#1                                                               *");
            Console.WriteLine("* Вариант#12                                                              *");
            Console.WriteLine("* Выполнила: Плеханова Ксения Анатольевна | СМАРТб-26-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, используя цикл while, которая вычисляет             *");
            Console.WriteLine("* сумму ряда по формуле при n=5                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int value = 5;
            int startValue = 1;
            int stopValue = 10;
            Console.WriteLine("Переменная n = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага" + stopValue);
            double res = ds.GetSumSeries(value, startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
        }
    }
}
