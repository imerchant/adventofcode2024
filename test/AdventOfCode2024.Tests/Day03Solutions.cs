using AdventOfCode2024.Day03;

namespace AdventOfCode2024.Tests;

public class Day03Solutions
{
    [Fact]
    public void Puzzle1_SumMuls()
    {
        var memory = new Memory(Input.Day03);
        memory.SumOfMuls.Should().Be(173419328L);
        memory.SumOfMulsWithConditionals.Should().Be(90669332L);
    }

    [Fact]
    public void Example1_SumsMuls()
    {
        var memory = new Memory(@"xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))");
        memory.SumOfMuls.Should().Be(161L);
    }

    [Fact]
    public void Example2_SumsMuls_WithConditionals()
    {
        var memory = new Memory(@"xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))");
        memory.SumOfMulsWithConditionals.Should().Be(48);
    }
}