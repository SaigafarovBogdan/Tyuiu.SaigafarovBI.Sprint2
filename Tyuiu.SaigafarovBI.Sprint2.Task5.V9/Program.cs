using Tyuiu.SaigafarovBI.Sprint2.Task5.V9.Lib;
namespace Tyuiu.SaigafarovBI.Sprint2.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите порядковый номер месяца: ");

            DataService dataService = new DataService();
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число: ");
            int y = Convert.ToInt32(Console.ReadLine());

            string res;
            if((x < 1) || (x > 12))
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
