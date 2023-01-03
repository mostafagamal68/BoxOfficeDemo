namespace BoxOfficeDemo.Shared.Configurations
{
    public class GenerateNewID
    {
        public decimal GetNewID = decimal.Parse(RandomDigits(28)) / 100000000;
        private static string RandomDigits(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = string.Concat(s, random.Next(10).ToString());
            return s;
        }
    }
}
