//using Geometry;

//var p1 = new Point();
//var p2 = new Point(4);
//var p3 = new Point(5,6);

//Console.WriteLine($"{p1.X},{p1.Y}");
//Console.WriteLine($"{p2.X},{p2.Y}");
//Console.WriteLine($"{p3.X},{p3.Y}");

//p3.Move(2,7);
//Console.WriteLine($"{p3.X},{p3.Y}");

//var s1 = new Segment(p2, new Point(1,100));

//var p4 = new Point(3,4);
//Console.WriteLine(p4.Distance());

//var s2 = new Segment(new Point(0,0), new Point(3,4));
//Console.WriteLine(s2.Length);

//var pc1 = new PolygonalChain(new Point(8,-1), new Point(-10,5));
//pc1.AddMidpoint(new Point(5,1));
//pc1.AddMidpoint(new Point(-1,1.6));
//pc1.AddMidpoint(new Point(1.6, 9));

//var pc2 = new PolygonalChain(new Point(0,0), new Point(1,1));
//Console.WriteLine(pc2.Length);
//pc2.AddMidpoint(new Point(1,0));
//Console.WriteLine(pc2.Length);


//pc2.Move(10, -10);
//Console.WriteLine(pc2.Length);

//Console.WriteLine(pc2);

using Utilities;

Console.WriteLine(StringUtilities.ToWords("Marcin Jagieła"));
Console.WriteLine(StringUtilities.ToWords("The lord of the rings"));

Console.WriteLine(StringUtilities.ToSentence("maRCin JAgieŁa"));
Console.WriteLine(StringUtilities.ToSentence("tHe lORD of tHE rInGs"));

Console.WriteLine(StringUtilities.ToCamelCase("maRCin JAgieŁa"));
Console.WriteLine(StringUtilities.ToCamelCase("tHe lORD of tHE rInGs"));