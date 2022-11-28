using System.Text;

namespace RomanNumeralConverter
{
    public static class ConversionService
    {
        private readonly static Dictionary<int, string> numberRomanNumerals = new Dictionary<int, string>
        {
            { 1000, "M" },
            { 900,  "CM" },
            { 500,  "D" },
            { 400,  "CD" },
            { 100,  "C" },
            { 90,   "XC" },
            { 50,   "L" },
            { 40,   "XL" },
            { 10,   "X" },
            { 9,    "IX" },
            { 5,    "V" },
            { 4,    "IV" },
            { 1,    "I" },
        };

        public static bool ToRomanNumeral(this int input, out string result)
        {
            var builder = new StringBuilder();

            try
            {
                foreach (var kvp in numberRomanNumerals)
                {
                    while (input >= kvp.Key)
                    {
                        input -= kvp.Key;
                        builder.Append(kvp.Value);
                    }
                }

                result = builder.ToString();
            }
            catch
            {
                result = string.Empty;
                return false;
            }

            return true;
        }
    }
}
