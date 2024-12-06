using AdventOfCode2024.Day02;

namespace AdventOfCode2024.Tests;

public class DayO2Solutions
{
    [Fact]
    public void Puzzle1_CountSafeReports()
    {
        var reports = new Reports(Input.Day02);
        reports.Count(x => x.IsSafe).Should().Be(421);
    }

    public const string Example1 = @"7 6 4 2 1
1 2 7 8 9
9 7 6 2 1
1 3 2 4 5
8 6 4 4 1
1 3 6 7 9";

    [Fact]
    public void Example1_CountSafeReports()
    {
        var reports = new Reports(Example1);
        reports.Count(x => x.IsSafe).Should().Be(2);
    }
}