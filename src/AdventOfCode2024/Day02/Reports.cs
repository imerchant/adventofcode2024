
namespace AdventOfCode2024.Day02;

public class Reports : IEnumerable<Report>
{
    private readonly List<Report> _reports;

    public Reports(string input)
    {
        _reports = [.. input.SplitLines().Select(x => new Report(x))];
    }

    public IEnumerator<Report> GetEnumerator() => _reports.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class Report
{
    public List<int> Levels { get; }
    public bool IsSafe { get; }
    public bool IsSafeWithDampener { get; }

    public Report(string input)
    {
        Levels = [.. input.SplitOn(' ').Select(int.Parse)];
        IsSafe = GetIsSafe(Levels);
        IsSafeWithDampener = IsSafe || GetIsSafeWithDampener(Levels);
    }

    private static bool GetIsSafeWithDampener(List<int> levels)
    {
        for (var k = 0; k < levels.Count; ++k)
        {
            var withoutK = levels.Without(k);
            if (GetIsSafe(withoutK))
                return true;
        }
        return false;
    }

    private static bool GetIsSafe(List<int> levels)
    {
        var diff = levels[0] - levels[1];
        if (diff == 0)
            return false;

        var decreasing = diff > 0;

        foreach (var (x, y) in levels.Zip(levels.Skip(1))) // pairwise, nice
        {
            if (decreasing && x <= y) return false;
            if (!decreasing && x >= y) return false;
            diff = Math.Abs(x - y);
            if (diff is < 1 or > 3) return false;
        }

        return true;
    }
}

internal static class Day02Extensions
{
    public static List<int> Without(this IEnumerable<int> ints, int index)
    {
        List<int> list = [..ints];
        list.RemoveAt(index);
        return list;
    }
}