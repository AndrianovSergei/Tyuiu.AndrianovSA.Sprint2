using Tyuiu.AndrianovSA.Sprint2.Task0.V5.Lib;

namespace Tyuiu.AndrianovSA.Sprint2.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 154;
            int y = 163;

            bool[] res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, false, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}