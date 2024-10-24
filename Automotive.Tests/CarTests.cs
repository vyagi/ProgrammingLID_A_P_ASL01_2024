using FluentAssertions;

namespace Automotive.Tests;

public class CarTests
{
    [Fact]
    public void Car_should_tank_properly()
    {
        var car = new Car("Opel", "Insignia", 60, 5.6);

        car.Tank(10);
        car.FuelLevel.Should().Be(10);

        car.Tank(15);
        car.FuelLevel.Should().Be(25);

        car.Tank(100);
        car.FuelLevel.Should().Be(60);
    }
}
