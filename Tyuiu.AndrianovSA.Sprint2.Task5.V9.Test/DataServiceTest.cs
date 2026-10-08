using Tyuiu.AndrianovSA.Sprint2.Task5.V9.Lib;

namespace Tyuiu.AndrianovSA.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDayMiddleOfMonth()
        {
            DataService ds = new DataService();

            int m = 5;
            int n = 15;

            string res = ds.FindDateOfNextDay(m, n);
            string wait = "16.05";

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDateOfNextDayEndOfMonth()
        {
            DataService ds = new DataService();

            int m = 4;
            int n = 30;

            string res = ds.FindDateOfNextDay(m, n);
            string wait = "01.05";

            Assert.AreEqual(wait, res);
        }
    }
}