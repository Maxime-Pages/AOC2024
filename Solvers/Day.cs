namespace AOC.Solvers;

public abstract class Day
{
    public abstract string Solve(string input);

    public static (IEnumerable<int>, IEnumerable<int>) ParseInput2IntLists(string input)
    {
        string[] lines = input.Split("\n");
        IEnumerable<int> numbers1 = [];
        IEnumerable<int> numbers2 = [];
        foreach (string line in lines)
        {
            int[] numbers;
            try
            {
                numbers = line.Split("   ").Select(int.Parse).ToArray();
            }
            catch
            {
                continue;
            }
            if (numbers.Length != 2) continue;
            numbers1 = numbers1.Append(numbers[0]);
            numbers2 = numbers2.Append(numbers[1]);
        }
        return (numbers1, numbers2);
    }
}
