using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SaigafarovBI.Sprint2.Task4.V11.Lib
{
    public class DataService : ISprint2Task4V11
    {
        public double Calculate(double x, double y)
        {
            double res = x - 40.0 < y / 4.0 ? Math.Pow(3 + (8 / (x * x)), y) : (y - Math.Pow((x + 1) / (y + 2), x));
            return Math.Round(res,3);
        }
    }
}
