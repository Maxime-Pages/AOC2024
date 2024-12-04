namespace AOC.Solvers;

public class Day2 : Day
{
    public override string SolvePart1(string input) => ParseInput(input).Count(level => (level.SequenceEqual(level.Order()) || level.SequenceEqual(level.OrderDescending()))
                                     && level.Skip(1)
                                          .Zip(level, (e1, e2) => Math.Abs(e1 - e2) < 4 && Math.Abs(e1 - e2) > 0)
                                          .All(p => p)).ToString();
    public override string SolvePart2(string input) => ParseInput(input).Count(level => Enumerable.Range(0, level.Length).Any(i =>(level.Take(i).Concat(level.Skip(i + 1).Take(level.Length - i)).ToArray().SequenceEqual(level.Take(i).Concat(level.Skip(i + 1).Take(level.Length - i)).ToArray().Order()) || level.Take(i).Concat(level.Skip(i + 1).Take(level.Length - i)).ToArray().SequenceEqual(level.Take(i).Concat(level.Skip(i + 1).Take(level.Length - i)).ToArray().OrderDescending()))&& level.Take(i).Concat(level.Skip(i + 1).Take(level.Length - i)).ToArray().Skip(1).Zip(level.Take(i).Concat(level.Skip(i + 1).Take(level.Length - i)).ToArray(), (e1, e2) => Math.Abs(e1 - e2) < 4 && Math.Abs(e1 - e2) > 0).All(p => p))).ToString();

    public static int[][] ParseInput(string input)
    {
        string[] lines = input.Split("\n");
        int[][] numbers = new int[lines.Length][];
        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            int[] numbersLine;
            try
            {
                numbersLine = line.Split(" ").Select(int.Parse).ToArray();
            }
            catch
            {
                continue;
            }
            numbers[i] = numbersLine;
        }
        return numbers;
    }

}
