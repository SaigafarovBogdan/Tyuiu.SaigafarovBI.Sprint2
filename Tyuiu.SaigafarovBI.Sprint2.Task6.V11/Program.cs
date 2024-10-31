using Tyuiu.SaigafarovBI.Sprint2.Task6.V11.Lib;
namespace Tyuiu.SaigafarovBI.Sprint2.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.Title = "Спринт #2 | Выполнил: Сайгафаров Б. И. | ПКТб-24-1";
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* Спринт #2                                                               *");
			Console.WriteLine("* Тема: Получение результата из switch                                    *");
			Console.WriteLine("* Задание #6                                                              *");
			Console.WriteLine("* Вариант #11                                                             *");
			Console.WriteLine("* Выполнил: Сайгафаров Богдан Ирекович | ПКТб-24-1                        *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                *");
			Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
			Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
			Console.WriteLine("*                                                                         *");
			Console.WriteLine("***************************************************************************");
			Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите год: ");

            DataService dataService = new DataService();
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите порядковый номер месяца: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите день: ");
            int z = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((y < 1) || (y > 12))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Дата следующего дня: " + dataService.FindDateOfNextDay(x,y,z);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
