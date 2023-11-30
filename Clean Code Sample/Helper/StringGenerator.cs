using System;

namespace Clean_Code_Sample.Helper
{
    public static class StringGenerator
    {
        public static string GenerateRandomWord()
        {
            Random random = new();
            var allowedInNames = "abcdefghijklmnopqrstuvwxys1234567890_-%&/()?!.,;";
            var barcode = new string(Enumerable.Repeat(allowedInNames, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return barcode;
        }
    }
}
