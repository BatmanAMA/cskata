using System;

namespace kata
{
    public static class weekend
    {
        public static DateTime xthDay (int week, DayOfWeek patch, DateTime? month, DayOfWeek? pinTo)
        {
            if (!month.HasValue)
            {
                month = DateTime.Now;
            }
            DateTime _month = month.Value;
            DateTime first = new DateTime(_month.Year, _month.Month, 1);
            first = first.AddDays((week - 1) * 7);
            while (first.DayOfWeek != patch)
            {
                first = first.AddDays(1);
            }
            return first;
        }
    }
}