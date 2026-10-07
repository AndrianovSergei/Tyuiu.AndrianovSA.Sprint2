using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AndrianovSA.Sprint2.Task3.V9.Lib
{
    public class DataService : ISprint2Task3V9
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 0)
            {
                y = x * Math.Pow((x + 15) / (x - 7), x);
            }
            else if (x == 0)
            {
                y = (Math.Sin(x) + Math.Cos(x)) / (Math.Cos(x) - Math.Sin(x));
            }
            else if (x > -13)
            {
                y = Math.Pow(1 + 1 / (x * x), x);
            }
            else
            {
                y = x + 10 * x + (1 / x);
            }

            return Math.Round(y, 3);
        }
    }
}