using System;

namespace Extender
{
    public static class StringExtensions
    {
        public static string Reverse(this string input, string addText)
        {
            var addedInput = input + addText;
            char[] chars = addedInput.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }


        public static string Reverse(this string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
