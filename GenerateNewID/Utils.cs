using System.Runtime.InteropServices;

namespace GenerateNewID
{
    public class Utils
    {
        [StructLayout(LayoutKind.Explicit)]
        struct DecimalGuidConverter
        {
            [FieldOffset(0)]
            public decimal Decimal;
            [FieldOffset(0)]
            public Guid Guid;
        }

        private static DecimalGuidConverter _converter;
        public static Guid DecimalToGuid(decimal dec)
        {
            _converter.Decimal = dec;
            return _converter.Guid;
        }
        public static decimal GuidToDecimal(Guid guid)
        {
            _converter.Guid = guid;
            return _converter.Decimal;
        }
        public static string RandomDigits(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;
        }
    }
}
