using Tyuiu.SaigafarovBI.Sprint2.Task4.V11.Lib;
namespace Tyuiu.SaigafarovBI.Sprint2.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 20;
            Assert.AreEqual(3.5, ds.Calculate(x, y));
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 20;
            Assert.AreEqual(3.5, ds.Calculate(x, y));
        }
    }
}