using Tyuiu.PlehanovaKA.Sprint3.Task7.V10.Lib;
namespace Tyuiu.PlehanovaKA.Sprint3.Task7.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #3 | Выполнила: Плеханова К. А. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание#6                                                               *");
            Console.WriteLine("* Вариант#17                                                              *");
            Console.WriteLine("* Выполнила: Плеханова Ксения Анатольевна | СМАРТб-26-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("* на заданном диапазоне [-5;5] с шагом 1.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Начальное значение " + startValue);
            Console.WriteLine("Конечное значение " + stopValue);
            double[] res = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
        }
    }
}
