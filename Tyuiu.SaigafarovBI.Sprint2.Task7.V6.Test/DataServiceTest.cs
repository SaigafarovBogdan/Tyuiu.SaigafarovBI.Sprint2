using Tyuiu.SaigafarovBI.Sprint2.Task7.V6.Lib;
namespace Tyuiu.SaigafarovBI.Sprint2.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInSharedArea()
        {
            DataService dataService = new DataService();
            double x = 0.7;
            double y = 1.0;
            Assert.AreEqual(dataService.CheckDotInShadedArea(x, y),true);

        }
    }
}