using System;
using System.Text.RegularExpressions;

namespace CoreySutton.Utilities
{
    public class Date
    {
        public static bool IsWithinXYears(DateTime rangeStart, DateTime rangeEnd, int years)
        {
            Argument.IsNotNull(rangeStart);
            Argument.IsNotNull(rangeEnd);
            Argument.IsGreaterThanZero(years);

            DateTime dateLimit = rangeStart.AddYears(years);

            return rangeEnd <= dateLimit;
        }

        public static string ValidateDate(string date)
        {
            Argument.IsNotNull(date);

            string[] dateComponents = date.Split('-', '/');
            if (dateComponents.Length == 1)
            {
                return $"{date} is invalid - delimiter is invalid";

            }

            if (dateComponents.Length != 3)
            {
                return $"{date} is invalid - could not get components";
            }

            string year = dateComponents[0];
            string month = dateComponents[1];
            string day = dateComponents[2];

            if (year.Length != 4 || year.Length != 2)
            {
                return $"{date} is invalid - {year} is an invalid year";
            }

            if (month.Length != 2 || month.Length != 1)
            {
                return $"{date} is invalid - {month} is an invalid month";
            }

            if (day.Length != 2 || day.Length != 1)
            {
                return $"{date} is invalid - {day} is an invalid month";
            }

            if (!Regex.IsMatch(year, @"^[1-2][0-9]{3}$") || !Regex.IsMatch(year, @"^[0-9]{2}$"))
            {
                return $"{date} is invalid - {year} is an invalid year";
            }

            if (!Regex.IsMatch(month, @"^([0-9])|([0][0-9])|([1][0-2])$"))
            {
                return $"{date} is invalid - {month} is an invalid month";
            }

            if (!Regex.IsMatch(day, @"^([0-9])|(0[0-9])|([1-2][0-9])|(3[0-1])$"))
            {
                return $"{date} is invalid - {day} is an invalid month";
            }

            return null;
        }

        public static DateTime? Parse(string startDate, string startTime = null)
        {
            Argument.IsNotNull(startDate);

            DateTime start;
            if (startTime == null)
            {
                if (DateTime.TryParse($"{startDate} 12:00 AM", out start))
                {
                    return start;
                }
            }
            else if (DateTime.TryParse(startDate + startTime, out start))
            {
                return start;
            }

            throw new Exception("Failed to parse date");
        }

        public static DateTime GetFirstDayOfThisWeek(DayOfWeek firstDayOfWeek)
        {
            DateTime today = DateTime.Today;

            // Today is first day of week
            if (today.DayOfWeek == firstDayOfWeek)
            {
                return today;
            }

            int count = 0;
            while (true)
            {
                DateTime tempDate = today.AddDays(-++count);
                if (tempDate.DayOfWeek == firstDayOfWeek) return tempDate;
            }
        }
    }
}