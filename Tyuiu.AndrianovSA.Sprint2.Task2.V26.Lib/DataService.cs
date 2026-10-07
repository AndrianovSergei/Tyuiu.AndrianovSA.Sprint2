using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AndrianovSA.Sprint2.Task2.V26.Lib
{
    public class DataService : ISprint2Task2V26
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = (y == 3 && ((x >= 3 && x <= 5) || (x >= 9 && x <= 13))) ||
                       (y == 4 && ((x >= 3 && x <= 5) || (x >= 9 && x <= 10))) ||
                       (y == 5 && (x >= 3 && x <= 10)) ||
                       ((y == 6 || y == 7) && (x >= 3 && x <= 14)) ||
                       (y == 8 && (x >= 6 && x <= 14)) ||
                       ((y == 9 || y == 10) && (x >= 6 && x <= 10)) ||
                       (y == 11 && (x >= 3 && x <= 13)) ||
                       (y == 12 && (x >= 7 && x <= 13)) ||
                       (y == 13 && (x >= 9 && x <= 10));

            return res;
        }
    }
}