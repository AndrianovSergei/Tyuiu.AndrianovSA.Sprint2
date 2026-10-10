using Tyuiu.AndrianovSA.Sprint2.Task6.V15.Lib;

namespace Tyuiu.AndrianovSA.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            int k = 1; // 1 января — понедельник
            string res = ds.FindDayName(k);
            string wait = "понедельник";

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindDayNameSunday()
        {
            DataService ds = new DataService();

            int k = 7; // 7 день — воскресенье
            string res = ds.FindDayName(k);
            string wait = "воскресенье";

            Assert.AreEqual(wait, res);
        }
    }
}