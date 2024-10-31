using Tyuiu.SaigafarovBI.Sprint2.Task3.V26.Lib;
namespace Tyuiu.SaigafarovBI.Sprint2.Task3.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.Title = "Спринт #2 | Выполнил: Сайгафаров Б. И. | ПКТб-24-1";
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* Спринт #2                                                               *");
			Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
			Console.WriteLine("* Задание #3                                                              *");
			Console.WriteLine("* Вариант #26                                                             *");
			Console.WriteLine("* Выполнил: Сайгафаров Богдан Ирекович | ПКТб-24-1                        *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                *");
			Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
			Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит      *");
			Console.WriteLine("* значение переменной X с клавиатуры.                                     *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение переменной X:");
            double x = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции = " + ds.Calculate(x));
            Console.ReadKey();
        }
    }
}
