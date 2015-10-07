namespace StringMatrixRotation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal sealed class App
    {
        internal static void Main()
        {
            string[] rotationInput = Console.ReadLine().Split('(', ')');
            int rotation = int.Parse(rotationInput.ElementAt(rotationInput.Length - 2));
            int numberOfRotations = rotation / 90;
            List<string> lines = new List<string>();
            string currentLine = Console.ReadLine();
            
            while (!currentLine.Equals("END"))
            {
                lines.Add(currentLine);
                currentLine = Console.ReadLine();
            }

            int longestLineLength = lines.OrderByDescending(s => s.Length).First().Length;

            char[,] matrix = new char[lines.Count, longestLineLength];

            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Length < longestLineLength)
                {
                    lines[i] = lines[i].PadRight(longestLineLength, ' ');
                }

                for (int j = 0; j < lines[i].Length; j++)
                {
                    matrix[i, j] = lines[i][j];
                }
            }

            for (int i = 0; i < numberOfRotations; i++)
            {
                matrix = RotateClockwise(matrix);
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0}", matrix[i, j]));
                }

                Console.WriteLine();
            }
        }

        internal static char[,] RotateClockwise(char[,] matrix)
        {
            int width = matrix.GetLength(0);
            int height = matrix.GetLength(1);
            char[,] rotated = new char[height, width];
            for (int i = 0; i < height; ++i) 
            {
                for (int j = 0; j < width; ++j) 
                {
                    rotated[i, j] = matrix[width - j - 1, i];
                }
            }

            return rotated;
        }
    }
}