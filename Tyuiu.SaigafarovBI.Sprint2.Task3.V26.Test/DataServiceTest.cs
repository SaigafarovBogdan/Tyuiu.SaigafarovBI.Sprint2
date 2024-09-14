using Tyuiu.SaigafarovBI.Sprint2.Task3.V26.Lib;
namespace Tyuiu.SaigafarovBI.Sprint2.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            int x = 4;
            Assert.AreEqual(747.08, ds.Calculate(x));
        }

    }
}