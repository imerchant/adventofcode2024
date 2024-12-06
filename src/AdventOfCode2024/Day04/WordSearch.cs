namespace AdventOfCode2024.Day04;

public class WordSearch
{
    public List<string> Content { get; }

    public WordSearch(string input)
    {
        Content = [.. input.SplitLines()];
    }
}