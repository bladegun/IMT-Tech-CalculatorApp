namespace DoubleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A calculator for System.Double values.");

            Calculator calculator = new();

            Console.WriteLine("{0} + {1} = {2}", 10d, 5d, calculator.Add(10d, 5d));
            Console.WriteLine("{0} - {1} = {2}", 10d, 5d, calculator.Subtract(10d, 5d));
            Console.WriteLine("{0} * {1} = {2}", 10d, 5d, calculator.Multiply(10d, 5d));
            Console.WriteLine("{0} / {1} = {2}", 10d, 5d, calculator.Divide(10d, 5d));
        }
    }
}
