using System;

namespace CoreySutton.Utilities
{
    public class DateTimeUtil
    {
        public static DateTime GetMondayOfThisWeek()
        {
            int dayOfWeek = (int)DateTime.Today.DayOfWeek;

            switch (dayOfWeek)
            {
                // Monday
                case 1:
                    return DateTime.Today;
                // Sunday
                case 0:
                    return DateTime.Today.AddDays(1);
                // Every other day
                default:
                    return DateTime.Today.AddDays(-(dayOfWeek - 1));
            }
        }
    }
}
