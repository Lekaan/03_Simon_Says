using System;
using System.Text;

namespace _03_Simon_Says
{
    internal class Simon
    {
        internal string Echo(string input)
        {
            return input.ToLower();
        }

        internal string Shout(string input)
        {
            return input.ToUpper();
        }

        internal string Repeat(string input)
        {
            return input + " " + input;
        }

        internal string Repeat(String input, int repeat)
        {
            StringBuilder result = new StringBuilder();

            for (int i = repeat; i > 0; i--)
            {
                result.Append(input).Append(" ");
            }

            result.AppendLine();

            return result.ToString().Trim();
        }

        internal string StartOfWord(string v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}