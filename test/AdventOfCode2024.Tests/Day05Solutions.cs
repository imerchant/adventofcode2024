using AdventOfCode2024.Day05;

namespace AdventOfCode2024.Tests;

public class Day05Solutions
{
    [Fact]
    public void Puzzle1_SumMiddles()
    {
        var printing = new Printing(Input.Day05);
        printing.MiddleSum.Should().Be(5991);
        printing.FixedUpdates().Sum(x => x.MiddlePage).Should().Be(5479);
    }

    public const string Example1 =
@"47|53
97|13
97|61
97|47
75|29
61|13
75|53
29|13
97|29
53|29
61|53
97|53
61|29
47|13
75|47
97|75
47|61
75|61
47|29
75|13
53|13

75,47,61,53,29
97,61,53,29,13
75,29,13
75,97,47,61,53
61,13,29
97,13,75,29,47";

    [Fact]
    public void Example1_SumsMiddles()
    {
        var printing = new Printing(Example1);
        printing.MiddleSum.Should().Be(143);
        printing.FixedUpdates().Sum(x => x.MiddlePage).Should().Be(123);
    }

    [Fact]
    public void FixUpdate_ActuallyFixesUpdates()
    {
        var printing = new Printing(Example1);

        printing.FixUpdate(new Update([75,97,47,61,53])).Pages.Should().Equal([97,75,47,61,53]);
        printing.FixUpdate(new Update([61,13,29])).Pages.Should().Equal([61,29,13]);
        printing.FixUpdate(new Update([97,13,75,29,47])).Pages.Should().Equal([97,75,47,29,13]);
    }
}