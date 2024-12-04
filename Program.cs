using AOC.Solvers;
using System;

namespace AOC;

class Runner
{
    const string BasePath = "../../.././Inputs/Day";
    static void Main()
    {
        Day1 day1 = new();
        Console.WriteLine(day1.Solve(GetInput(1)));
    }

    static string GetInput(int day)
    {
        return System.IO.File.ReadAllText($"{BasePath}{day}");
    }
}