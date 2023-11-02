namespace CalculatorLib;

public class MyCalculator : ICalculator
{
    public decimal Add(decimal num1, decimal num2)
    {
        return num1+num2;
    }

    public decimal? Divide(decimal num1, decimal num2)
    {
        if (num2 == 0)
            return null;
        return  num1  / num2;
    }

    public decimal Multiply(decimal num1, decimal num2)
    {
        return num1 * num2;
    }

    public decimal Substract(decimal num1, decimal num2)
    {
        return num1 - num2;
    }
}