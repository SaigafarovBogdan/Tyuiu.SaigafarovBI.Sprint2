using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SaigafarovBI.Sprint2.Task3.V26.Lib
{
    public class DataService : ISprint2Task3V26
    {
        public double Calculate(double x)
        {
            if(x>0)
            {
                return Math.Round(x + Math.Pow((x + 1.0) / Math.Cos(x * x), x),3);
            }
            else if(x == 0)
            {
                return Math.Round((15.0 + x) / (9.0 - Math.Sin(x * x)),3);
            }
            else if((-30 < x)&&(x<0))
            {
                return Math.Round(Math.Pow((Math.Sin(x*x*x))/(x+5.0),x),3);
            }
            else if(x<-30)
            {
                return Math.Round(x + 7.0 * x - (1.0 / x),3);
            }
            return 0.0;
        
        }
    }
}
