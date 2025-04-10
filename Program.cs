using Assignment141Point;

var P1 = new Point(2.0, 3.0);
var P2 = new Point(5.0, 8.0);

Console.WriteLine(P1);
Console.WriteLine(P2);

// is if...else cleaner maybe?
switch (P1.X==P2.X)
{
    case true:
        Console.WriteLine("Neither points is to the right.");
        break;
    case false:
        Console.WriteLine(P1.X>P2.X?"P1 is to the right.":"P2 is to the right.");
        break;
}

switch (P1.X - P2.X)
{
    case double n when n < 0:
        Console.WriteLine("P2 is to the right");
        break;
    case double n when n > 0:
        Console.WriteLine("P1 is to the right");
        break;
    case 0:
        Console.WriteLine("Neither points is to the right");
        break;
}

if (P1.X > P2.X) Console.WriteLine("P1 is to the right.");
else if (P1.X < P2.X) Console.WriteLine("P2 is to the right.");
else Console.WriteLine("Neither points is to the right.");
