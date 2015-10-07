namespace Plus_Remove
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal sealed class App
    {
        internal static void Main()
        {
            List<string> inputLines = new List<string>();

            string currentInputLine = Console.ReadLine();

            while (!currentInputLine.Equals("END"))
            {
                inputLines.Add(currentInputLine);
                currentInputLine = Console.ReadLine();
            }

            List<char[]> result = inputLines.Select(line => line.ToCharArray()).ToList();

            if (inputLines.Count <= 2)
            {
                foreach (var line in inputLines)
                {
                    Console.WriteLine(line);
                }

                return;
            }

            for (int i = 0; i < inputLines.Count - 2; i++)
            {
                for (int j = 0; j < inputLines[i].Length;)
                {
                    try
                    {
                        char top = char.ToLower(inputLines[i][j]);
                        char left = char.ToLower(inputLines[i + 1][j - 1]);
                        char right = char.ToLower(inputLines[i + 1][j + 1]);
                        char middle = char.ToLower(inputLines[i + 1][j]);
                        char bottom = char.ToLower(inputLines[i + 2][j]);
                        
                        if (top == left && left == right && right == middle && middle == bottom)
                        {
                            result[i][j] = ' ';
                            result[i + 1][j] = ' ';
                            result[i + 2][j] = ' ';
                            result[i + 1][j + 1] = ' ';
                            result[i + 1][j - 1] = ' ';
                        }

                        j++;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        j++;
                    }
                }
            }

            foreach (var line in result)
            {
                foreach (var character in line)
                {
                    if (!character.Equals(' '))
                    {
                        Console.Write(character);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}