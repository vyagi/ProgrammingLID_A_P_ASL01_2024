public class Container
{
    private readonly int _capacity;
    private int _liquidLevel;

    public Container(int capacity)
    {
        if (capacity < 0)
            throw new ArgumentException("Capacity must not be negative", nameof(capacity));

        _capacity = capacity;
    }

    public void Add(int amount)
    {
        if (amount < 0)
            throw new ArgumentException("Amount must not be negative", nameof(amount));

        _liquidLevel += amount;

        if (_liquidLevel > _capacity)
            _liquidLevel = _capacity;
    }

    public void Pour(int amount)
    {
        if (amount < 0)
            throw new ArgumentException("Amount must not be negative", nameof(amount));

        _liquidLevel -= amount;

        if (_liquidLevel < 0)
            _liquidLevel = 0;
    }

    public int LiquidLevel => _liquidLevel;
}