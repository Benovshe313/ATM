using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Hw.Helpers
{
    enum Type
    {
        Alpha,
        Numeric,
        AlphaNumeric
    }
    internal static class RandomGenerator
    {
        private static readonly Random random = new Random();

        public static string GenerateString(int length,Type type)
        {
            string str = type switch
            {
                Type.Alpha => "abcdefghijklmnopqrstuvwxyz",
                Type.Numeric => "1234567890",
                Type.AlphaNumeric => "abcdefghijklmnopqrstuvwxyz1234567890",
                _=>throw new ArgumentException()
            };
            var result = string.Empty;
            for(int i = 0; i < length; i++)
            {
                result += str[random.Next(0, str.Length)];
            }
            return result;
        }
    }
}
