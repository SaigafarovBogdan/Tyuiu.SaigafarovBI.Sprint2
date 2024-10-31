using Tyuiu.SaigafarovBI.Sprint2.Task1.V13.Lib;
namespace Tyuiu.SaigafarovBI.Sprint2.Task1.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.Title = "Спринт #2 | Выполнил: Сайгафаров Б. И. | ПКТб-24-1";
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* Спринт #2                                                               *");
			Console.WriteLine("* Тема: Логические операции                                               *");
			Console.WriteLine("* Задание #1                                                              *");
			Console.WriteLine("* Вариант #13                                                             *");
			Console.WriteLine("* Выполнил: Сайгафаров Богдан Ирекович | ПКТб-24-1                        *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                *");
			Console.WriteLine("* Написать программу из операций сравнений и логических операций,         *");
			Console.WriteLine("* а также арифметических выражений, которая вернет логическую             *");
			Console.WriteLine("* последовательность (True, True, True, True, True, False)                *");
			Console.WriteLine("***************************************************************************");
			DataService ds = new DataService();
            int a = 145;
            int b = 916;
            int c = 164;
            int d = 137;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a,b,c,d);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; ++i)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
