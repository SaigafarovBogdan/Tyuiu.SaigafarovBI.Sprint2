using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SaigafarovBI.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            string result = "";
            result = GetDay(n) + "." + GetMonth(m) + "." + Convert.ToString(g);
            return result;
        }
        private string GetDay(int n)
        {
            switch (n)
            {
                case 1: return "02";
                case 2: return "03";
                case 3: return "04";
                case 4: return "05";
                case 5: return "06";
                case 6: return "07";
                case 7: return "08";
                case 8: return "09";
                case 9: return "10";
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                case 31: return Convert.ToString(n+1);
                default:
                    {
                        throw new ArgumentException($"День должен быть от 1 до 31. Значение {n}");
                    }

            }
        }
        private string GetMonth(int m)
        {
            switch (m)
            {
                case 1: return "01";
                case 2: return "02";
                case 3: return "03";
                case 4: return "04";
                case 5: return "05";
                case 6: return "06";
                case 7: return "07";
                case 8: return "08";
                case 9: return "09";
                case 10: return "10";
                case 11: return "11";
                case 12: return "12";
                default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");

            }
        }
    }
}
