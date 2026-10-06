using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AndrianovSA.Sprint2.Task0.V5.Lib
{
    public class DataService : ISprint2Task0V5
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 9 == y; // True  (154 + 9 == 163)
            res[1] = x != x;     // False (154 != 154)
            res[2] = y < x;      // False (163 < 154)
            res[3] = x > y;      // False (154 > 163)
            res[4] = x <= y;     // True  (154 <= 163)
            res[5] = x >= y;     // False (154 >= 163)

            return res;
        }
    }
}