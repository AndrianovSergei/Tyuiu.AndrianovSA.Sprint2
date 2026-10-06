using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AndrianovSA.Sprint2.Task0.V5.Lib
{
    public class DataService : ISprint2Task1V5
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d);     // True  (False | True)
            res[1] = (a > b) & (c < d);     // False (False & True)
            res[2] = (a > b) || (c > d);    // False (False || False)
            res[3] = (a < b) && (c > d);    // False (True && False)
            res[4] = !(a > b);              // True  (!False)
            res[5] = (a < b) ^ (c < d);     // False (True ^ True)

            return res;
        }
    }
}