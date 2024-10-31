using Tyuiu.SaigafarovBI.Sprint2.Task4.V11.Lib;
namespace Tyuiu.SaigafarovBI.Sprint2.Task4.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.Title = "Спринт #2 | Выполнил: Сайгафаров Б. И. | ПКТб-24-1";
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* Спринт #2                                                               *");
			Console.WriteLine("* Тема: Тернарный оператор                                                *");
			Console.WriteLine("* Задание #4                                                              *");
			Console.WriteLine("* Вариант #11                                                             *");
			Console.WriteLine("* Выполнил: Сайгафаров Богдан Ирекович | ПКТб-24-1                        *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                *");
			Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции с      *");
			Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение   *");
			Console.WriteLine("* значение переменных x,y с клавиатуры                                    *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение переменной X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции = " + ds.Calculate(x,y));

            Console.ReadKey();
        }
    }
}
