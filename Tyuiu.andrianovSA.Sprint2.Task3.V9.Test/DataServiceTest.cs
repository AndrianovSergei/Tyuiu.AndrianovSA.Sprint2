using Tyuiu.AndrianovSA.Sprint2.Task1.V9.Lib;

namespace Tyuiu.AndrianovSA.Sprint2.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1.0;

            Assert.AreEqual(wait, res);
        }
    }
}