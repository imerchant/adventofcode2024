namespace AdventOfCode2024.Day04;

public class WordSearch
{
    public const string Xmas = "XMAS";
    public const string Samx = "SAMX";

    public List<string> Content { get; }
    public int XmasCount { get; }

    public WordSearch(string input)
    {
        Content = [.. input.SplitLines()];

        for (var row = 0; row < Content.Count; ++row)
        {
            for (var col = 0; col < Content[0].Length; ++col)
            {
                if (Content[row][col] is not 'X') continue;

                var maybes = GetMaybes(row, col);

                XmasCount += maybes.Count(x => x is Xmas or Samx);
            }
        }
    }

    private IEnumerable<string> GetMaybes(int row, int col)
    {
        // left
        if (col - 3 >= 0)
        {
            yield return new string([Content[row][col], Content[row][col - 1], Content[row][col - 2], Content[row][col - 3]]);
        }

        // right
        if (col + 3 < Content[0].Length)
        {
            yield return new string([Content[row][col], Content[row][col + 1], Content[row][col + 2], Content[row][col + 3]]);
        }

        // down
        if (row + 3 < Content.Count)
        {
            yield return new string([Content[row][col], Content[row + 1][col], Content[row + 2][col], Content[row + 3][col]]);
        }

        // up
        if (row - 3 >= 0)
        {
            yield return new string([Content[row][col], Content[row - 1][col], Content[row - 2][col], Content[row - 3][col]]);
        }

        // up left
        if (row - 3 >= 0 && col - 3 >= 0)
        {
            yield return new string([Content[row][col], Content[row - 1][col - 1], Content[row - 2][col - 2], Content[row - 3][col - 3]]);
        }

        // up right
        if (row - 3 >= 0 && col + 3 < Content[0].Length)
        {
            yield return new string([Content[row][col], Content[row - 1][col + 1], Content[row - 2][col + 2], Content[row - 3][col + 3]]);
        }

        // down left
        if (row + 3 < Content.Count && col - 3 >= 0)
        {
            yield return new string([Content[row][col], Content[row + 1][col - 1], Content[row + 2][col - 2], Content[row + 3][col - 3]]);
        }

        // down right
        if (row + 3 < Content.Count && col + 3 < Content[0].Length)
        {
            yield return new string([Content[row][col], Content[row + 1][col + 1], Content[row + 2][col + 2], Content[row + 3][col + 3]]);
        }
    } 
}