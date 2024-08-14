namespace DecimalCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A calculator for System.Decimal values.");

            Calculator calculator = new();

            Console.WriteLine("{0} + {1} = {2}", 10m, 5m, calculator.Add(10m, 5m));
            Console.WriteLine("{0} - {1} = {2}", 10m, 5m, calculator.Subtract(10m, 5m));
            Console.WriteLine("{0} * {1} = {2}", 10m, 5m, calculator.Multiply(10m, 5m));
            Console.WriteLine("{0} / {1} = {2}", 10m, 5m, calculator.Divide(10m, 5m));
        }
    }
}
