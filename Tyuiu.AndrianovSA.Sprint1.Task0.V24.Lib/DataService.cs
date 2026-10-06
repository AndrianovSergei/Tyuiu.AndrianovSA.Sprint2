using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AndrianovSA.Sprint2.Task0.V24.Lib
{
    public class DataService : ISprint2Task0V24
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 620 == y;   // 135 + 620 = 755 == 755 -> True
            res[1] = x != y;         // 135 != 755 -> True
            res[2] = y < x;          // 755 < 135 -> False
            res[3] = x > y;          // 135 > 755 -> False
            res[4] = x <= y;         // 135 <= 755 -> True
            res[5] = y >= x;         // 755 >= 135 -> True

            return res;
        }
    }
}