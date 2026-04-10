using NUnit.Framework;
using Module.Core;

namespace Module.Tests;

public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Add_ShouldReturnCorrectSum()
    {
        Assert.That(_calculator.Add(2, 3), Is.EqualTo(5));
    }

    [Test]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        Assert.That(_calculator.Subtract(5, 3), Is.EqualTo(2));
    }

    [Test]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        Assert.That(_calculator.Multiply(3, 5), Is.EqualTo(15));
    }

    [Test]
    public void Divide_ShouldReturnCorrectQuotient()
    {
        Assert.That(_calculator.Divide(6, 3), Is.EqualTo(2));
    }
}