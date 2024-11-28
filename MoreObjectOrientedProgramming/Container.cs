public abstract class Container
{
    protected readonly int _capacity;
    protected int _liquidLevel;

    public Container(int capacity)
    {
        if (capacity < 0)
            throw new ArgumentException("Capacity must not be negative", nameof(capacity));

        _capacity = capacity;
    }

    public virtual void Add(int amount)
    {
        if (amount < 0)
            throw new ArgumentException("Amount must not be negative", nameof(amount));

        LiquidLevel += amount;
    }

    public virtual void Pour(int amount)
    {
        if (amount < 0)
            throw new ArgumentException("Amount must not be negative", nameof(amount));

        LiquidLevel -= amount;
    }

    public int LiquidLevel
    {
        get => _liquidLevel;
        protected set => _liquidLevel = Math.Clamp(value, 0, _capacity);
    }
}