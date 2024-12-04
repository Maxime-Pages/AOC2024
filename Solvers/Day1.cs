namespace AOC.Solvers;

public class Day1 : Day
{
    public override string SolvePart1(string input)
    {
        (IEnumerable<int> numbers1, IEnumerable<int> numbers2) = ParseInput(input);
        numbers1 = numbers1.Order();
        numbers2 = numbers2.Order();
        return numbers1.Zip(numbers2, (a, b) => Math.Abs(a-b)).Sum().ToString();
    }
    public override string SolvePart2(string input)
    {
        Dictionary<int, int> Values = [];
        (IEnumerable<int> numbers1, IEnumerable<int> numbers2) = ParseInput(input);
        foreach (int item in numbers2)
        {
            if (Values.ContainsKey(item)) Values[item]++;
            else Values[item] = 1;
        }
        return numbers1.Sum(i => i * (Values.TryGetValue(i, out int j) ? j : 0)).ToString();
    }

    public static (IEnumerable<int>, IEnumerable<int>) ParseInput(string input)
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
