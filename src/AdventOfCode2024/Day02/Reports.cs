
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

    public Report(string input)
    {
        Levels = [.. input.SplitOn(' ').Select(int.Parse)];
        IsSafe = GetIsSafe();
    }

    private bool GetIsSafe()
    {
        var diff = Levels[0] - Levels[1];
        if (diff == 0)
            return false;

        var decreasing = diff > 0;

        foreach (var (x, y) in Levels.Zip(Levels.Skip(1))) // pairwise, nice
        {
            if (decreasing && x <= y) return false;
            if (!decreasing && x >= y) return false;
            diff = Math.Abs(x - y);
            if (diff is < 1 or > 3) return false;
        }

        return true;
    }
}