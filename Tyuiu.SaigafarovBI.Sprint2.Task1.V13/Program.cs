using Tyuiu.SaigafarovBI.Sprint2.Task1.V13.Lib;
namespace Tyuiu.SaigafarovBI.Sprint2.Task1.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
