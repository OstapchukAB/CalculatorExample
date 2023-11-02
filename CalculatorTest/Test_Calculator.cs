using CalculatorLib;
using Moq;

namespace CalculatorTest;

public class Test_Calculator
{
    [Theory]
    [InlineData(2,2,4)]
    public void Test_Addition(int x,int y, int expected)
    {
        //Arange
        var calculator = new Mock<ICalculator>();
        calculator.Setup(e => e.Add(x, y)).Returns(expected);

        //Act
        var result = calculator.Object.Add(x, y);

        //Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 2, 1)]
    public void Test_Divide(int x, int y, int expected)
    {
        //Arange
        var calculator = new Mock<ICalculator>();
        calculator.Setup(e => e.Divide(x, y)).Returns(expected);

        //Act
        var result = calculator.Object.Divide(x, y);

        //Assert
        Assert.Equal(expected, result);
    }
}