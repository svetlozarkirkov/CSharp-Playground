namespace ReverseWordsInSentence
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Write a sentence: ");
            string[] input = Regex.Split(Console.ReadLine().ToLower(), "\\W+");
            StringBuilder result = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (i == input.Length - 1)
                {
                    result.Append(char.ToUpper(input[i][0]) + input[i].Substring(1));
                }
                else
                {
                    result.Append(input[i]);
                }

                if (i > 0)
                {
                    result.Append(" ");
                }
            }
            Console.WriteLine("Reversed words: {0}", result);
        }
    }
}