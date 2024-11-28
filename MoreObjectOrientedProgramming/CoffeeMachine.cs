using MoreObjectOrientedProgramming;

public class CoffeeMachine
{
    private readonly Container _coffeeGrainsContainer;
    private readonly Container _waterContainer;

    private int _espressosMade;

    public CoffeeMachine(int grainContainerCapacity, int waterContainerCapacity)
    {
        _coffeeGrainsContainer = new CoffeeGrainsContainer(grainContainerCapacity);
        _waterContainer = new WaterContainer(waterContainerCapacity, true);
    }

    public void AddGrains(int amount) => _coffeeGrainsContainer.Add(amount);

    public void AddWater(int amount) => _waterContainer.Add(amount);

    public void MakeEspresso(Container cup)
    {
        if (_waterContainer.LiquidLevel > 250 && _coffeeGrainsContainer.LiquidLevel > 50)
        {
            _waterContainer.Pour(18);
            _coffeeGrainsContainer.Pour(8);
            _espressosMade++;

            cup.Add(18);
        }
    }
}