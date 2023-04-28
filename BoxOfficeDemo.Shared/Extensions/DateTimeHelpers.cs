namespace BoxOfficeDemo.Shared.Extensions
{
    public static class DateTimeHelpers
    {
        public static string ToGeneralDateTime(this DateTime dateTime) => dateTime.ToString("G");
        public static string ToGeneralDate(this DateTime dateTime) => dateTime.ToString("d");
        public static string ToGeneralTime(this DateTime dateTime) => dateTime.ToString("T");
    }
}
