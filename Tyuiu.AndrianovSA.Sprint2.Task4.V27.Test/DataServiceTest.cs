using Tyuiu.AndrianovSA.Sprint2.Task4.V27.Lib;

namespace Tyuiu.AndrianovSA.Sprint2.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateConditionTrue()
        {
            DataService ds = new DataService();

            double x = 20;
            double y = 1;

            double res = ds.Calculate(x, y);
            double wait = 0.0; // 20 * ((1 + 2)/(20 - 1))^20

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateConditionFalse()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 5;

            double res = ds.Calculate(x, y);
            double wait = 24.0;

            Assert.AreEqual(wait, res);
        }
    }
}