using AdventOfCode2024.Day04;

namespace AdventOfCode2024.Tests;

public class Day04Solutions
{
    [Fact]
    public void Puzzle1_CountsXmas()
    {
        var wordSearch = new WordSearch(Input.Day04);
        wordSearch.XmasCount.Should().Be(2496);
    }

    public const string Example1 =
@"MMMSXXMASM
MSAMXMSMSA
AMXSXMAAMM
MSAMASMSMX
XMASAMXAMM
XXAMMXXAMA
SMSMSASXSS
SAXAMASAAA
MAMMMXMMMM
MXMXAXMASX";

    [Fact]
    public void Example1_CountsXmas()
    {
        var wordSearch = new WordSearch(Example1);
        wordSearch.XmasCount.Should().Be(18);
    }
}