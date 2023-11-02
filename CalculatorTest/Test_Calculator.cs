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
        //var result = calculator.Object.Add(x, y);
        var actual = new MyCalculator().Add(x, y);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2, 2, 1)]
    [InlineData(0, 2, 0)]
    public void Test_Divide(int x, int y, int expected)
    {
        //Arange
        var calculator = new Mock<ICalculator>();
        calculator.Setup(e => e.Divide(x, y)).Returns(expected);

        //Act
       // var result = calculator.Object.Divide(x, y);

        var actual = new MyCalculator().Divide(x,y);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2, 0)]
    [InlineData(0, 0)]
    public void Test_Divide_Zero_With_Exception(int x, int y)
    {
        //Arange
        var calculator = new Mock<ICalculator>();

        DivideByZeroException expected = new DivideByZeroException("на ноль делить нельзя");
        calculator.Setup(e => e.Divide(x, y)).Throws(expected);

        //Assert
        Assert.Throws<DivideByZeroException>(() => calculator.Object.Divide(x, y));

        Assert.Throws<DivideByZeroException>(() => new MyCalculatorNew().Divide(x, y));
    }

    [Theory]
    [InlineData(2, 0)]
    [InlineData(0, 0)]
    public void Test_Divide_Zero_With_Null(int x, int y)
    {
        //Arange
        var calculator = new Mock<ICalculator>();
        decimal? expected = null; 
        calculator.Setup(e => e.Divide(x, y)).Returns(expected);

        //Assert
        Assert.Equal(expected, calculator.Object.Divide(x, y));

       Assert.Equal(expected, new MyCalculator().Divide(x,y));
    }
}