using System.Text;

namespace AdventOfCode2024.Day06;

public class PatrolArea
{
    public List<string> Map { get; }

    public PatrolArea(string input)
    {
        Map = [.. input.SplitLines()];
    }

    public ISet<(int X, int Y)> TravelOutOfArea()
    {
        (int x, int y) = GetStartingPos();
        HashSet<(int X, int Y)> traveled = [];
        var facing = Facing.Up;

        var count = 0;
        while (count++ < 10_000)
        {
            var (obstruction, visited) = FindObstruction(x, y, facing);
            traveled.UnionWith(visited);
            if (!obstruction) return traveled;
            (x, y) = visited.Last();
            facing = facing.Next();
        }
        return traveled;
    }

    public (int X, int Y) GetStartingPos()
    {
        for (var row = 0; row < Map.Count; ++row)
        {
            var col = Map[row].IndexOf('^');
            if (col >= 0) return (row, col);
        }
        return (-1, -1);
    }

    public (bool FoundObstruction, ISet<(int X, int Y)> Visited) FindObstruction(int x, int y, Facing facing)
    {
        var found = true;
        HashSet<(int X, int Y)> visited = [];
        if (facing is Facing.Up or Facing.Down)
        {
            var (start, count) = facing is Facing.Up ? (0, x + 1) : (x, Map.Count - x);
            var coords = Enumerable.Range(start, count).Select(nx => (x: nx, y));
            if (facing is Facing.Up) coords = coords.Reverse();

            var content = coords
                .Aggregate(new StringBuilder(),
                    (sb, pos) => sb.Append(Map[pos.x][pos.y]),
                    sb => sb.ToString());
            var obstruction = content.IndexOf('#');
            found = obstruction != -1;
            var distanceFromPos = obstruction == -1 ? content.Length : obstruction;
            var hit = coords.Where((pos, i) => i < distanceFromPos);
            visited.UnionWith(hit);
        }
        else if (facing is Facing.Right)
        {
            found = false;
            for (var col = y; col < Map[x].Length; ++col)
            {
                if (Map[x][col] is not '#')
                {
                    visited.Add((x, col));
                }
                else
                {
                    found = true;
                    break;
                }
            }
        }
        else if (facing is Facing.Left)
        {
            found = false;
            for (var col = y; col >= 0; --col)
            {
                if (Map[x][col] is not '#')
                {
                    visited.Add((x, col));
                }
                else
                {
                    found = true;
                    break;
                }
            }
        }

        return (found, visited);
    }
}

public enum Facing { Up, Right, Down, Left }

public static class FacingExtensions
{
    public static Facing Next(this Facing facing) =>
        facing switch
        {
            Facing.Up => Facing.Right,
            Facing.Right => Facing.Down,
            Facing.Down => Facing.Left,
            Facing.Left => Facing.Up,
            _ => throw new NotImplementedException()
        };
}