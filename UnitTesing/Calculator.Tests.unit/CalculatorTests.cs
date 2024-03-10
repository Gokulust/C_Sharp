using CalculatorLibrarys;
using FluentAssertions;

namespace Calculator.Tests.unit
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(5, 5, 10)]
        [InlineData(-5,5, 0)]
        [InlineData(-15, -5, -20)]
        public void Add_ShouldTakeTwoIntegers_And_ReturnAnInteger(int firstNumber, int secondNumber, int expectedResult)
        {
            CalculatorClass calculator = new CalculatorClass();
            int actualResult = calculator.Add(firstNumber, secondNumber);
           
            actualResult.Should().Be(expectedResult);

        }

        [Theory]
        [InlineData(5, 5, 0)]
        [InlineData(15, 5, 10)]
        [InlineData(-5, -5, 0)]
        [InlineData(-15,-5,-10)]
        [InlineData(5, 10, -5)]
        public void Subtraction_ShouldTakeTwoIntegers_And_ReturnAnInteger(int firstNumber, int secondNumber, int expectedResult)
        {
            CalculatorClass calculator = new CalculatorClass();
            int actualResult = calculator.Subtract(firstNumber, secondNumber);
            //Assert.Equal(10, actualResult);

            actualResult.Should().Be(expectedResult);

        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(50, 0, 0)]
        [InlineData(-5, 5, -25)]
        public void Multiplication_ShouldTakeTwoIntegers_And_ReturnAnInteger(int firstNumber, int secondNumber, int expectedResult)
        {
            CalculatorClass calculator = new CalculatorClass();
            int actualResult = calculator.Multiply(firstNumber, secondNumber);
            //Assert.Equal(10, actualResult);

            actualResult.Should().Be(expectedResult);

        }

        [Theory]
        [InlineData(5, 5, 1)]
        [InlineData(15, 5, 3)]
        [InlineData(5,0,0,Skip ="skipped this test")]
        public void Divison_ShouldTakeTwoIntegers_And_ReturnAnInteger(int firstNumber, int secondNumber, int expectedResult)
        {
            CalculatorClass calculator = new CalculatorClass();
            int actualResult = calculator.Divide(firstNumber, secondNumber);
            //Assert.Equal(10, actualResult);

            actualResult.Should().Be(expectedResult);

        }
    }
    }
