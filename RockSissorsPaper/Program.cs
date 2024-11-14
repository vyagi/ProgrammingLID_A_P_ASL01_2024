Console.WriteLine("Hello in the rock, scissors, paper game !");
Console.WriteLine("What is your name?");

var name = Console.ReadLine();

Console.WriteLine("What is your option?");
Console.WriteLine("1 - Rock");
Console.WriteLine("2 - Scissors");
Console.WriteLine("3 - Paper");

var playerChoice = (Choice)int.Parse(Console.ReadLine());

var randomizer = new Random();
var computerChoice = (Choice)randomizer.Next(1,4);

Console.WriteLine($"{name} chose {playerChoice} and computer chose {computerChoice}");

if (playerChoice == Choice.Rock && computerChoice == Choice.Scissors ||
    playerChoice == Choice.Scissors && computerChoice == Choice.Paper ||
    playerChoice == Choice.Paper && computerChoice == Choice.Rock)
{
    Console.WriteLine("The player won");
}
else if (playerChoice == computerChoice)
{
    Console.WriteLine("A draw");
}
else
{
    Console.WriteLine("The computer won");
}

public enum Choice
{
    Rock = 1,
    Scissors,
    Paper
}