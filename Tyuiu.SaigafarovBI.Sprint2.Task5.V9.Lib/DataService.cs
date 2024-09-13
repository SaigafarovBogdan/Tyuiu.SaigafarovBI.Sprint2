using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SaigafarovBI.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            string result = "";
            string month = "";
            switch(m)
            {
                case 1:
                {
                        month = "Январь";
                        break;
                }
                case 2:
                {
                        month = "Февраль";
                        break;
                }
                case 3:
                {
                        month = "Март";
                        break;
                }
                case 4:
                {
                        month = "Апрель";
                        break;
                }
                case 5:
                {
                        month = "Январь";
                        break;
                }
                case 6:
                {
                        month = "Январь";
                        break;
                }
                case 7:
                {
                        month = "Январь";
                        break;
                }
                case 8:
                {
                        month = "Январь";
                        break;
                }
                case 9:
                {
                        month = "Январь";
                        break;
                }
                case 10:
                {
                        month = "Январь";
                        break;
                }
                case 11:
                {
                        month = "Январь";
                        break;
                }
                case 12:
                {
                        month = "Январь";
                        break;
                }
                default:
                {
                        throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
                }

            }
            return result;
        }
    }
}
