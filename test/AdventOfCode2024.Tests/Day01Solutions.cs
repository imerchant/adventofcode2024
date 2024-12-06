using AdventOfCode2024.Day01;

namespace AdventOfCode2024.Tests;

public class Day01Solutions
{
    [Fact]
    public void Puzzle1_SumsDistanceDifferences()
    {
        var locations = new Locations(Input.Day01);
        locations.Distances.Should().Be(1666427);
        locations.SimilarityScore.Should().Be(24316233L);
    }

    public const string Example1 = @"3   4
4   3
2   5
1   3
3   9
3   3";

    [Fact]
    public void Example1_SumsDistanceDifferences()
    {
        var locations = new Locations(Example1);
        locations.Distances.Should().Be(11);
        locations.SimilarityScore.Should().Be(31);
    }
}