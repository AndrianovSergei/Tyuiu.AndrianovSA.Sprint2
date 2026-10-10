using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AndrianovSA.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool inLeftArea = (x <= 0) && (y >= Math.Pow(x, 2)) && (y >= 2 - x);
            bool inRightArea = (y >= 0) && (y <= 2 - x) && (y <= Math.Pow(x, 2));

            return inLeftArea || inRightArea;
        }
    }
}