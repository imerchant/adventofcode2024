namespace AdventOfCode2024.Day01;

public class Locations
{
    public int Distances { get; }

    public long SimilarityScore { get; }

    public Locations(string input)
    {
        var (list1, list2) = input
            .SplitLines()
            .Select(line =>
            {
                var locations = line.SplitOn(' ');
                return (int.Parse(locations[0]), int.Parse(locations[1]));
            })
            .Aggregate(
                (new List<int>(), new List<int>()),
                (lists, locations) => ([..lists.Item1, locations.Item1], [..lists.Item2, locations.Item2]),
                lists => (lists.Item1.OrderBy(x => x).ToList(), lists.Item2.OrderBy(x => x).ToList()));

        Distances = list1
            .Select((x, i) => (x, y: list2[i]))
            .Aggregate(0, (sum, locations) => sum + Math.Abs(locations.y - locations.x));

        SimilarityScore = list1
            .Select(x => x * list2.Count(y => y == x))
            .Aggregate(0L, (sum, location) => sum + location);
    }
}