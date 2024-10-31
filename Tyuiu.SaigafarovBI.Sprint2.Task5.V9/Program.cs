using Tyuiu.SaigafarovBI.Sprint2.Task5.V9.Lib;
namespace Tyuiu.SaigafarovBI.Sprint2.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.Title = "Спринт #2 | Выполнил: Сайгафаров Б. И. | ПКТб-24-1";
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* Спринт #2                                                               *");
			Console.WriteLine("* Тема: Оператор switch                                                   *");
			Console.WriteLine("* Задание #5                                                              *");
			Console.WriteLine("* Вариант #9                                                              *");
			Console.WriteLine("* Выполнил: Сайгафаров Богдан Ирекович | ПКТб-24-1                        *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                *");
			Console.WriteLine("* Написать программу, которая использует оператор switch                  *");
			Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
			Console.WriteLine("*                                                                         *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите номер дня: ");

            DataService dataService = new DataService();
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите порядковый номер месяца: ");
            int y = Convert.ToInt32(Console.ReadLine());

            string res;
            if((y < 1) || (y > 12))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Дата следующего дня: " + dataService.FindDateOfNextDay(x, y);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
