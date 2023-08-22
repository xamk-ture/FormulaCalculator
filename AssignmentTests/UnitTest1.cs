using FormulaCalculator;

namespace AssignmentTests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(3, 2, 5)]
        [InlineData(-3, 2, -1)]
        [InlineData(3, -2, 1)]
        [InlineData(-3, -2, -5)]
        public void Sum_ShouldReturnCorrectResult(decimal a, decimal b, decimal expected)
        {
            var result = Calculator.Sum(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(-6, 3, -2)]
        [InlineData(6, -3, -2)]
        [InlineData(-6, -3, 2)]
        public void Divide_ShouldReturnCorrectResult(decimal a, decimal b, decimal expected)
        {
            var result = Calculator.Divide(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, 3, 18)]
        [InlineData(-6, 3, -18)]
        [InlineData(6, -3, -18)]
        [InlineData(-6, -3, 18)]
        public void Multiply_ShouldReturnCorrectResult(decimal a, decimal b, decimal expected)
        {
            var result = Calculator.Multiply(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, 3, 3)]
        [InlineData(-6, 3, -9)]
        [InlineData(6, -3, 9)]
        [InlineData(-6, -3, -3)]
        public void Subtract_ShouldReturnCorrectResult(decimal a, decimal b, decimal expected)
        {
            var result = Calculator.Subtract(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1 + 2", 3)]
        [InlineData("1 - 2", -1)]
        [InlineData("3 * 4", 12)]
        [InlineData("8 / 2", 4)]
        public void CalculateFormula_ValidFormulas_ReturnsExpectedResult(string formula, decimal expectedResult)
        {
            decimal result = Calculator.CalculateFormula(formula);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1 / 0")]  // Division by zero
        [InlineData("1 & 2")]  // Invalid operator
        [InlineData("a + 2")]  // Invalid number
        [InlineData("1 + b")]  // Invalid number
        [InlineData("1 2 3")]  // Missing operator
        [InlineData("1 +")]    // Missing second operand
        public void CalculateFormula_InvalidFormulas_ThrowsException(string formula)
        {
            Assert.ThrowsAny<Exception>(() => Calculator.CalculateFormula(formula));
        }

    }
}