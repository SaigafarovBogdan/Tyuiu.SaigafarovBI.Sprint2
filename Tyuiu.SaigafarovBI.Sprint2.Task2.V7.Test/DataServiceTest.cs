using Tyuiu.SaigafarovBI.Sprint2.Task2.V7.Lib;
namespace Tyuiu.SaigafarovBI.Sprint2.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 5;
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
          
        }
    }
}