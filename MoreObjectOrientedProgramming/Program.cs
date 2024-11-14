var shinyNewCup = new Container(200);
shinyNewCup.Add(100);
shinyNewCup.Add(150);
shinyNewCup.Pour(130);
Console.WriteLine(shinyNewCup.LiquidLevel);

var coffeMaker = new CoffeeMachine(1500, 1200);
coffeMaker.AddWater(1000);
coffeMaker.AddGrains(1000);
coffeMaker.MakeEspresso(shinyNewCup);

Console.WriteLine(shinyNewCup.LiquidLevel);