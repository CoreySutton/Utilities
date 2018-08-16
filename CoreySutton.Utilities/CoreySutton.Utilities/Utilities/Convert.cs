namespace CoreySutton.Utilities
{
    public static class Convert
    {
        private const int DaysInAWeek = 7;
        private const int HoursInADay = 24;
        private const int MinutesInAHour = 60;
        private const int SecondsInAMinute = 60;
        private const int MillisecondsInASecond = 1000;

        public static int HoursToMilliseconds(int timeInHours)
        {
            return timeInHours * MinutesInAHour * SecondsInAMinute * MillisecondsInASecond;
        }

        public static int MinutesToMilliseconds(int timeInMinutes)
        {
            return timeInMinutes * SecondsInAMinute * MillisecondsInASecond;
        }

        public static int SecondsToMilliseconds(int timeInSeconds)
        {
            return timeInSeconds * MillisecondsInASecond;
        }
    }
}
