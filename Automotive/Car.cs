namespace Automotive;

public class Car
{
    private string _brand;
    private string _model;
    private int _tankCapacity;
    private double _fuelConsumption;
    private double _fuelLevel;
    private double _odometer;

    public Car(string brand, string model, int tankCapacity, double fuelConsumption)
    {
        if (string.IsNullOrWhiteSpace(brand))
            throw new ArgumentNullException(nameof(brand), "The brand cannot be empty");

        if (string.IsNullOrWhiteSpace(model))
            throw new ArgumentNullException(nameof(model), "The model cannot be empty");

        if (tankCapacity <= 0)
            throw new ArgumentException("The tankCapacity must be positive", nameof(tankCapacity));

        if (fuelConsumption <= 0)
            throw new ArgumentException("The fuelConsumption must be positive", nameof(fuelConsumption));

        _brand = brand;
        _model = model;
        _tankCapacity = tankCapacity;
        _fuelConsumption = fuelConsumption;
    }

    public void Drive(int distance)
    {
        var maximumDistance = _fuelLevel / _fuelConsumption * 100;

        if (maximumDistance > distance)
        {
            _odometer += distance;
            _fuelLevel -= _fuelConsumption * distance / 100;
        }
        else
        {
            _odometer += maximumDistance;
            _fuelLevel = 0;
        }
    }

    public void Tank(double amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be non-negative");

        _fuelLevel += amount;

        if (_fuelLevel > _tankCapacity)
            _fuelLevel = _tankCapacity;
    }

    public string Brand => _brand;
    public string Model => _model;
    public int TankCapacity => _tankCapacity;
    public double FuelConsumption => _fuelConsumption;

    public int FuelLevel => (int)_fuelLevel;
    public int Odometer => (int)_odometer;
}