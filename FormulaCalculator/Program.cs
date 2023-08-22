namespace FormulaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FormulaCalculator:");
            Console.WriteLine("1 + 2 = " + Calculator.CalculateFormula("1 + 2"));
            Console.WriteLine("1 - 2 = " + Calculator.CalculateFormula("1 - 2"));
            Console.WriteLine("1 * 2 = " + Calculator.CalculateFormula("1 * 2"));
            Console.WriteLine("1 / 2 = " + Calculator.CalculateFormula("1 / 2"));

        }
    }
}