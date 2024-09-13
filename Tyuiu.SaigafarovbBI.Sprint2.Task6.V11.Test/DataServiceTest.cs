using Tyuiu.SaigafarovbBI.Sprint2.Task6.V11.Lib;
namespace Tyuiu.SaigafarovbBI.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindNextDate()
        {
            DataService ds = new DataService();

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(13, 1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(-1, 1);
            });
        }
    }
}