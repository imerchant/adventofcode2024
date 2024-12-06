namespace AdventOfCode2024.Day03;

public class Memory
{
    public const string Do = "do()";
    public const string Dont = "don't()";
    public static readonly Regex MulRegex = new(@"mul\((?'x'\d{1,3}),(?'y'\d{1,3})\)", RegexOptions.Compiled);
    public static readonly Regex DoDontMulRegex = new(@"(?:do\(\))|(?:don't\(\))|(?:mul\((?'x'\d{1,3}),(?'y'\d{1,3})\))", RegexOptions.Compiled);

    public long SumOfMuls { get; }
    public long SumOfMulsWithConditionals { get; }

    public Memory(string input)
    {
        SumOfMuls = MulRegex
            .Matches(input)
            .Select(x => long.Parse(x.Groups["x"].Value) * long.Parse(x.Groups["y"].Value))
            .Sum();

        var @do = true;
        foreach (Match match in DoDontMulRegex.Matches(input))
        {
            if (match.Groups[0].Value is Do) @do = true;
            else if (match.Groups[0].Value is Dont) @do = false;
            else if (match.Groups[0].Value.Contains("mul") && @do)
            {
                SumOfMulsWithConditionals += long.Parse(match.Groups["x"].Value) * long.Parse(match.Groups["y"].Value);
            }
        }
    }
}