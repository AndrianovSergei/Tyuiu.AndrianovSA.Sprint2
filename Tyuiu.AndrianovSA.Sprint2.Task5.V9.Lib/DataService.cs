using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AndrianovSA.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int daysInMonth;

            switch (m)
            {
                case 1:  // Январь
                case 3:  // Март
                case 5:  // Май
                case 7:  // Июль
                case 8:  // Август
                case 10: // Октябрь
                case 12: // Декабрь
                    daysInMonth = 31;
                    break;
                case 4:  // Апрель
                case 6:  // Июнь
                case 9:  // Сентябрь
                case 11: // Ноябрь
                    daysInMonth = 30;
                    break;
                case 2:  // Февраль (в обычном году)
                    daysInMonth = 28;
                    break;
                default:
                    throw new ArgumentException("Неверный номер месяца.");
            }

            if (n < daysInMonth)
            {
                n++;
            }
            else
            {
                n = 1;
                m++;
            }

            string monthStr = m < 10 ? $"0{m}" : $"{m}";
            string dayStr = n < 10 ? $"0{n}" : $"{n}";

            return $"{dayStr}.{monthStr}";
        }
    }
}