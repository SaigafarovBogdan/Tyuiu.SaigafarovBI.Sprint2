using Tyuiu.SaigafarovBI.Sprint2.Task5.V9.Lib;
namespace Tyuiu.SaigafarovBI.Sprint2.Task5.V9.Test
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
                ds.FindDateOfNextDay(13,1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(-1, 1);
            });
        }
    }
}