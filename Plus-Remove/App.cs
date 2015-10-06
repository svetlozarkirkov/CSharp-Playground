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
                int numberOfIterations = 0;
                int secondLineCounter = 0;
                int thirdLineCounter = 0;

                if (inputLines[i + 1].Length == inputLines[i].Length + 1)
                {
                    numberOfIterations = inputLines[i].Length;
                }
                else
                {
                    numberOfIterations = inputLines[i].Length - 1;
                }

                for (int j = 1; j < numberOfIterations; j++)
                {
                    secondLineCounter++;
                    thirdLineCounter++;

                    if (secondLineCounter == inputLines[i + 1].Length 
                        || thirdLineCounter == inputLines[i + 2].Length)
                    {
                        break;
                    }

                    try
                    {
                        if (char.ToLower(inputLines[i][j]).Equals(char.ToLower(inputLines[i + 1][j]))
                        && char.ToLower(inputLines[i][j]).Equals(char.ToLower(inputLines[i + 2][j]))
                        && char.ToLower(inputLines[i][j]).Equals(char.ToLower(inputLines[i + 1][j + 1]))
                        && char.ToLower(inputLines[i][j]).Equals(char.ToLower(inputLines[i + 1][j - 1])))
                        {
                            //Console.WriteLine("found");
                            result[i][j] = ' ';
                            result[i + 1][j] = ' ';
                            result[i + 2][j] = ' ';
                            result[i + 1][j + 1] = ' ';
                            result[i + 1][j - 1] = ' ';
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        //Console.WriteLine("i = " + i);
                        //Console.WriteLine("j = " + j);
                        throw;
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