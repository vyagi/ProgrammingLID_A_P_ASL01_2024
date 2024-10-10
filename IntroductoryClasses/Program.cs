//Task 10c
var numbers = new List<int>();

for (var i = 0; i < 4; i++)
{
    Console.WriteLine($"Enter number {i + 1}");

    numbers.Add(int.Parse(Console.ReadLine()));
}

var sum = 0;

foreach(var number in numbers)
    sum += number;

var average = 1.0 * sum / numbers.Count;
Console.WriteLine($"The sum is {sum} and average is {average}");


//Task 10b
//var array = new int[4];

//for (var i = 0; i < array.Length; i++)
//{
//    Console.WriteLine($"Enter number {i + 1}");

//    array[i] = int.Parse(Console.ReadLine());
//}

//var sum = 0;

//for (var i = 0; i < array.Length; i++)
//    sum += array[i];

//var average = 1.0 * sum / array.Length;
//Console.WriteLine($"The sum is {sum} and average is {average}");

//Task 8
//Console.WriteLine("What is the first side?");
//var a = double.Parse(Console.ReadLine());

//Console.WriteLine("What is the second side?");
//var b = double.Parse(Console.ReadLine());

//Console.WriteLine("What is the third side?");
//var c = double.Parse(Console.ReadLine());

//var perimeter = a + b + c;

//var p = perimeter / 2;

//var area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

//Console.WriteLine($"The area is {area} and perimeter is {perimeter}");

//Task 5
//Console.WriteLine("What is the radius?");

//var radius = double.Parse(Console.ReadLine());

//var area = Math.PI * radius * radius;

//Console.WriteLine($"The area is {area}");

//Task 4
//Console.WriteLine("What is your name?");
//string name = Console.ReadLine();
//Console.WriteLine($"Hello {name}");

//Task 3d
//string name = "Marcin";
//Console.WriteLine($"Hello {name}");

//Task 3c
//string name = "Marcin";
//Console.WriteLine(string.Format("Hello {0}", name));

//Task 3b
//string name = "Marcin";
//Console.WriteLine("Hello " + name);

//Task 3a
//string name = "Marcin";

//Console.Write("Hello ");
//Console.WriteLine(name);

//Task 2
//string name = "Marcin";
//Console.WriteLine(name);

//Task 1
//Console.WriteLine("Hello");
