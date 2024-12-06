namespace AdventOfCode2024.Day04;

public class WordSearch
{
    public const string Xmas = "XMAS";
    public const string Samx = "SAMX";
    public const string Mas = "MAS";
    public const string Sam = "SAM";

    public List<string> Content { get; }
    public int XmasCount { get; }
    public int CrossMasCount { get; }

    public WordSearch(string input)
    {
        Content = [.. input.SplitLines()];

        for (var row = 0; row < Content.Count; ++row)
        {
            for (var col = 0; col < Content[0].Length; ++col)
            {
                if (Content[row][col] is 'X')
                {
                    var maybes = GetXmasMaybes(row, col);
                    XmasCount += maybes.Count(x => x is Xmas or Samx);
                }
                else if (Content[row][col] is 'A' && row > 0 && col > 0 && row < Content.Count - 1 && col < Content[0].Length - 1)
                {
                    var (down, up) = GetCrossMasMaybes(row, col);
                    if ((down is Sam or Mas) && (up is Mas or Sam))
                    {
                        CrossMasCount++;
                    }
                }
            }
        }
    }

    private (string Down, string Up) GetCrossMasMaybes(int row, int col)
    {
        var down = new string([Content[row - 1][col - 1], Content[row][col], Content[row + 1][col + 1]]);
        var up = new string([Content[row + 1][col - 1], Content[row][col], Content[row - 1][col + 1]]);
        return (down, up);
    }

    private IEnumerable<string> GetXmasMaybes(int row, int col)
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