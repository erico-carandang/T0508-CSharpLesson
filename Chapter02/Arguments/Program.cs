using System;
using static System.Console;

namespace Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"There are {args.Length} arguments.");

            foreach (string arg in args)
            {  
                WriteLine(arg);
            } // Type "dotnet run firstarg second-arg third:arg "fourth arg"" in the terminal
        }
    }
}
