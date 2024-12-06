namespace AdventOfCode2024.Day05;

public class Printing
{
    public List<(int First, int Second)> Rules { get; }
    public List<Update> Updates { get; }

    public int MiddleSum { get; }

    public Printing(string input)
    {
        Rules = [];
        Updates = [];

        foreach (var line in input.SplitLines())
        {
            if (line.Contains('|'))
            {
                var rule = line.SplitOn('|');
                Rules.Add((int.Parse(rule[0]), int.Parse(rule[1])));
            }
            else
            {
                Updates.Add(new Update(line));
                if (Updates.Last().PassesAll(Rules))
                    MiddleSum += Updates.Last().MiddlePage;
            }
        }
    }

    public IEnumerable<Update> FixedUpdates()
    {
        return Updates.Where(x => !x.PassesAll(Rules)).Select(FixUpdate);
    }

    public Update FixUpdate(Update update)
    {
        List<int> pages = [.. update.Pages.OrderBy(x => x, new UseRulesComparer(Rules))]; // topological sort
        return new Update(pages);
    }

    class UseRulesComparer(List<(int First, int Second)> rules) : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            var rule = rules.SingleOrDefault(rule => (x, y) == rule || (y, x) == rule);
            if (rule is (0,0)) return 0;
            if (x == rule.First) return -1;
            return 1;
        }
    }
}

public class Update
{
    public List<int> Pages { get; }
    public int MiddlePage => Pages[(int)Math.Floor(Pages.Count / 2.0)];

    public Update(string input)
    {
        Pages = [.. input.Split(',').Select(int.Parse)];
    }

    public Update(List<int> pages)
    {
        Pages = pages;
    }

    public bool PassesAll(List<(int First, int Second)> rules)
    {
        return rules.All(rule => Passes(rule.First, rule.Second));

        bool Passes(int first, int second)
        {
            if (!Pages.Contains(first) || !Pages.Contains(second)) return true;
            return Pages.IndexOf(first) < Pages.IndexOf(second);
        }
    }
}