using Tyuiu.SaigafarovBI.Sprint2.Task6.V11.Lib;
namespace Tyuiu.SaigafarovBI.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(2000, -1,5);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(2000, 12,32);
            });
        }
    }
}