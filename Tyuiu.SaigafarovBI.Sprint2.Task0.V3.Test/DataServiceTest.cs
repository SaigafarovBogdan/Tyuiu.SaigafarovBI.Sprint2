using Tyuiu.SaigafarovBI.Sprint2.Task0.V3.Lib;

namespace Tyuiu.SaigafarovBI.Sprint2.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 45;
            int y = 127;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[] { false, true, false, true, false, true };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}