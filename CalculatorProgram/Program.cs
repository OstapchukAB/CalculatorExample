using CalculatorLib;
class Program
{
    public static void Main()
    {

		try
		{
			var result = new MyCalculatorNew().Divide(1, 0);
            Console.WriteLine(result);
        }
		catch (DivideByZeroException ex)
		{

			Console.WriteLine("делить на ноль  нельзя!");
		}
        
       
        Console.ReadLine();
    }
}