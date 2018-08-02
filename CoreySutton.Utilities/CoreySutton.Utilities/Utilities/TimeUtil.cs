namespace CoreySutton.Utilities
{
    public static class TimeUtil
    {
        private const int DaysInAWeek = 7;
        private const int HoursInADay = 24;
        private const int MinutesInAHour = 60;
        private const int SecondsInAMinute = 60;
        private const int MillisecondsInASecond = 1000;

        #region To Milliseconds

        public static int ConvertHoursToMilliseconds(int timeInHours)
        {
            return timeInHours * MinutesInAHour * SecondsInAMinute * MillisecondsInASecond;
        }

        public static int ConvertMinutesToMilliseconds(int timeInMinutes)
        {
            return timeInMinutes * SecondsInAMinute * MillisecondsInASecond;
        }

        public static int ConvertSecondsToMilliseconds(int timeInSeconds)
        {
            return timeInSeconds * MillisecondsInASecond;
        }

        #endregion
    }
}
