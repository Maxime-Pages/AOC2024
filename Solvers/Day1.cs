namespace AOC.Solvers;

public class Day1 : Day
{
    public override string Solve(string input)
    {
        (IEnumerable<int> numbers1, IEnumerable<int> numbers2) = Day.ParseInput2IntLists(input);
        numbers1 = numbers1.Order();
        numbers2 = numbers2.Order();
        return numbers1.Zip(numbers2, (a, b) => Math.Abs(a-b)).Sum().ToString();
    }
    
    
}
