namespace CountConsecutiveDigits
{
    using System;
    using System.Linq;
    using System.Text;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter digits: ");
            int[] digits = Console.ReadLine().Select(d => int.Parse(d.ToString())).ToArray();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < digits.Length;)
            {
                int current = digits[i];
                int count = 1;
                while (i < digits.Length - 1 && digits[i + 1] == current)
                {
                    count++;
                    i++;
                }

                result.Append(count + string.Empty + current);
                i++;
            }

            Console.WriteLine(result);
        }
    }
}