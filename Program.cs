using AOC.Solvers;
using System;

namespace AOC;

class Runner
{
    const string BasePath = "../../.././Inputs/Day";
    static void Main()
    {
        Day2 day = new();
        Console.WriteLine(day.SolvePart2(GetInput(2)));
    }

    static string GetInput(int day)
    {
        return System.IO.File.ReadAllText($"{BasePath}{day}");
    }
}