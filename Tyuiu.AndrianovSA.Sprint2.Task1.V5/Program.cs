using Tyuiu.AndrianovSA.Sprint2.Task0.V5.Lib;

namespace Tyuiu.AndrianovSA.Sprint2.Task0.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 154;
            int b = 163;
            int c = 134;
            int d = 137;

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Андрианов С. А. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* СПРИНТ #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                              *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Андрианов Сергей Александрович | ИИПб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из логических операций, которая вернет логическую    *");
            Console.WriteLine("* последовательность: (True, False, False, False, True, False)             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine($"* a = {a}                                                                 *");
            Console.WriteLine($"* b = {b}                                                                 *");
            Console.WriteLine($"* c = {c}                                                                 *");
            Console.WriteLine($"* d = {d}                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"res[{i}] = {res[i]}");
            }

            Console.ReadKey();
        }
    }
}