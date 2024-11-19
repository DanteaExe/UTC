using CalculatorLib;
namespace UnitTesting;

public class UnitTest1
{
    // Arrange
    // The data to run the function
    // Act
    // Call the function to test
    // Assert
    // Compare the excpected vs the actual result
    // Edge cases
    // TDD -> Test Driven Development
    // dotnet new xunit
    [Fact]
    public void Add2and2()
    {
        // Arrange
        double a = 2;
        double b = 2;
        double expected = 4;
        // Act
        double actual = Calculator.Add(a, b);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Add3And2()
    {
        // Arrange
        double a = 3;
        double b = 2;
        double expected = 5;
        // Act
        double actual = Calculator.Add(a, b);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Subtract10And5()
    {
        // Arrange
        double a = 10;
        double b = 5;
        double expected = 5;
        // Act
        double actual = Calculator.Subtract(a, b);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Subtract250And25()
    {
        // Arrange
        double a = 25;
        double b = 250;
        double expected = -225;
        // Act
        double actual = Calculator.Subtract(a, b);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Multiply3And9()
    {
        // Arrange
        double a = 3;
        double b = 9;
        double expected = 27;
        // Act
        double actual = Calculator.Multiply(a, b);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Multiply9And12()
    {
        // Arrange
        double a = 9;
        double b = 12;
        double expected = 108;
        // Act
        double actual = Calculator.Multiply(a, b);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Divide10And2()
    {
        // Arrange
        double a = 10;
        double b = 2;
        double expected = 5;
        // Act
        double actual = Calculator.Divide(a, b);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Divide123And0()
    {
        // Arrange
        double a = 123;
        double b = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a, b));
    }
}
