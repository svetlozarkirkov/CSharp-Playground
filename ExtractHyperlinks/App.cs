namespace ExtractHyperlinks
{
    using System;
    using System.Text;

    internal sealed class App
    {
        internal static void Main()
        {
            StringBuilder text = new StringBuilder();
            string currentLine = Console.ReadLine();
            while (!currentLine.Equals("END"))
            {
                text.Append(currentLine);
                currentLine = Console.ReadLine();
            }
        }
    }
}