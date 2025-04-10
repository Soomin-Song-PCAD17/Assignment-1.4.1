var P1 = new Point(2.0, 3.0);
var P2 = new Point(5.0, 8.0);

Console.WriteLine(P1);
Console.WriteLine(P2);

// is if...else cleaner maybe?
switch (P1.X==P2.X)
{
    case true:
        Console.WriteLine("The two points have the same X.");
        break;
    case false:
        Console.WriteLine(P1.X>P2.X?"P1 is to the right.":"P2 is to the right.");
        break;
}


public struct Point
{
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    public double X { get; set; }
    public double Y { get; set; }

    public override string ToString() => $"({X}, {Y})";
}
