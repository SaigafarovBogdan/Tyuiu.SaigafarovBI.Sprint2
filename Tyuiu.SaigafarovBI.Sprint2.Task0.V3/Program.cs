using Tyuiu.SaigafarovBI.Sprint2.Task0.V3.Lib;

namespace Tyuiu.SaigafarovBI.Sprint2.Task0.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.Title = "Спринт #2 | Выполнил: Сайгафаров Б. И. | ПКТб-24-1";
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* Спринт #2                                                               *");
			Console.WriteLine("* Тема: Операции сравнения                                                *");
			Console.WriteLine("* Задание #0                                                              *");
			Console.WriteLine("* Вариант #3                                                              *");
			Console.WriteLine("* Выполнил: Сайгафаров Богдан Ирекович | ПКТб-24-1                        *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                *");
			Console.WriteLine("* Написать программу из операций сравнений и арифметических выражений,    *");
			Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
			Console.WriteLine("* (False,True,False,True,False,True)                                      *");
			Console.WriteLine("***************************************************************************");
			DataService ds = new DataService();
            int x = 45;
            int y = 127;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);
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
