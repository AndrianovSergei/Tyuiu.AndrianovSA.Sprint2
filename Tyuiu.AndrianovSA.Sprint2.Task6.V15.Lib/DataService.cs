using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AndrianovSA.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {
            int dayOfWeek = (k % 7 == 0) ? 7 : k % 7;

            return dayOfWeek switch
            {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                7 => "Воскресенье",
                _ => throw new ArgumentException("День недели должен быть в диапазоне от 1 до 365.")
            };
        }
    }
}