namespace Calculator
{
    using System;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter expression: ");
            string[] expression = Console.ReadLine().Split(' ');   
        }
    }
}
