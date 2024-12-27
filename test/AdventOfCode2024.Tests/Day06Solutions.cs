using AdventOfCode2024.Day06;

namespace AdventOfCode2024.Tests;

public class Day06Solutions
{
    [Fact]
    public void Puzzle1_FindDistinctVisitedPositions()
    {
        var area = new PatrolArea(Input.Day06);

        area.TravelOutOfArea().Should().HaveCount(5080);
    }

    public const string Example1 =
@"....#.....
.........#
..........
..#.......
.......#..
..........
.#..^.....
........#.
#.........
......#...";

    [Fact]
    public void Example1_TravelsOutOfTheArea()
    {
        var area = new PatrolArea(Example1);

        var visited = area.TravelOutOfArea();
        visited.Should().HaveCount(41);
    }

    [Fact]
    public void Example1_FindsStartingPosition_AndFindsFirstObstruction()
    {
        var area = new PatrolArea(Example1);

        var (x, y) = area.GetStartingPos();
        var (obstruction, visited) = area.FindObstruction(x, y, Facing.Up);
        obstruction.Should().BeTrue();
        visited.Should().HaveCount(6);
    }

    [Fact]
    public void Example1_CanGoRight()
    {
        var area = new PatrolArea(Example1);

        var (x, y) = (1, 4);
        var (obstruction, visited) = area.FindObstruction(x, y, Facing.Right);
        obstruction.Should().BeTrue();
        visited.Should().HaveCount(5);
    }

    [Fact]
    public void Example1_CanGoDown()
    {
        var area = new PatrolArea(Example1);

        var (x, y) = (1, 8);
        var (obstruction, visited) = area.FindObstruction(x, y, Facing.Down);
        obstruction.Should().BeTrue();
        visited.Should().HaveCount(6);
    }

    [Fact]
    public void Example1_CanGoLeft()
    {
        var area = new PatrolArea(Example1);

        var (x, y) = (6, 8);
        var (obstruction, visited) = area.FindObstruction(x, y, Facing.Left);
        obstruction.Should().BeTrue();
        visited.Should().HaveCount(7);
    }
}