using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Geometry;

public class Point : IMoveable
{
    private double _x;
    private double _y;

    public double X => _x;
    public double Y => _y;

    public Point() => _x = _y = 0;

    public Point(double a) => _x = _y = a;

    public Point(double x, double y) => (_x, _y) = (x, y);

    public void Move(double x, double y)
    {
        _x += x;
        _y += y;
    }

    public virtual double Distance() => Math.Sqrt(X * X + Y * Y);
}

public class Segment
{
    private Point _start;
    private Point _end;

    public Point Start => _start;
    public Point End => _end;

    public Segment(Point start, Point end)
    {
        _start = start;
        _end = end;
    }

    public virtual double Length =>
        Math.Sqrt(Math.Pow(_start.X - _end.X, 2) + Math.Pow(_start.Y - _end.Y, 2));
}

public class PolygonalChain : Segment, IMoveable
{
    private List<Point> _midpoints = new List<Point>();

    public PolygonalChain(Point start, Point end) : base(start, end) { }

    public void AddMidpoint(Point midpoint) => _midpoints.Add(midpoint);

    public override double Length
    {
        get
        {
            var allPoints = new List<Point>();
            allPoints.Add(Start);
            allPoints.AddRange(_midpoints);
            allPoints.Add(End);

            var totalLength = 0.0;

            for (var i = 0; i < allPoints.Count - 1; i++)
            {
                var start = allPoints[i];
                var end = allPoints[i + 1];

                totalLength += new Segment(start, end).Length;
            }

            return totalLength;
        }
    }

    public void Move(double x, double y)
    {
        Start.Move(x,y);
        End.Move(x,y);

        foreach (var midpoint in _midpoints)
            midpoint.Move(x,y);
    }

    public override string ToString()
    {
        var result = $"({Start.X},{Start.Y})";

        foreach (var midpoint in _midpoints) 
            result += $",({midpoint.X},{midpoint.Y})";

        result += $",({End.X},{End.Y})";

        return result;
    }
}

public interface IMoveable
{
    void Move(double x, double y);
}