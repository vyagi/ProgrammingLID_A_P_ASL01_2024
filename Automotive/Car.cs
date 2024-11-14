namespace Automotive;

public class Car
{
    private string _brand;
    private string _model;
    private double _fuelConsumption;
    private double _odometer;
    private Container _tank;

    public Car(string brand, string model, int tankCapacity, double fuelConsumption)
    {
        if (string.IsNullOrWhiteSpace(brand))
            throw new ArgumentNullException(nameof(brand), "The brand cannot be empty");

        if (string.IsNullOrWhiteSpace(model))
            throw new ArgumentNullException(nameof(model), "The model cannot be empty");

        if (fuelConsumption <= 0)
            throw new ArgumentException("The fuelConsumption must be positive", nameof(fuelConsumption));

        _brand = brand;
        _model = model;
        _tank = new Container(tankCapacity);
        _fuelConsumption = fuelConsumption;
    }

    public void Drive(int distance)
    {
        var maximumDistance = _tank.LiquidLevel / _fuelConsumption * 100;

        if (maximumDistance > distance)
        {
            _odometer += distance;
            _tank.Pour((int)_fuelConsumption * distance / 100);
        }
        else
        {
            _odometer += maximumDistance;
            _tank.Pour(_tank.LiquidLevel);
        }
    }

    public void Tank(double amount) => _tank.Add((int)amount);

    public string Brand => _brand;
    public string Model => _model;
    //public int TankCapacity => _tank.;
    public double FuelConsumption => _fuelConsumption;

    public int FuelLevel => _tank.LiquidLevel;
    public int Odometer => (int)_odometer;
}