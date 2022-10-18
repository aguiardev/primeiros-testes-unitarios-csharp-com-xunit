namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact(DisplayName = "Given valid numbers, when sum then should succcess.")]
        public void GivenValidNumbers_WhenSum_ThenShouldSucccess()
        {
            //arrange
            const int resultExpected = 5;
            const int firstNumber = 3;
            const int secondNumber = 2;

            //act
            var resultActual = Calculator.Sum(firstNumber, secondNumber);

            //assert
            Assert.Equal(resultExpected, resultActual);
        }

        [Theory(DisplayName = "Given invalid numbers, when sum then should fail.")]
        [InlineData(-5, 7)]
        [InlineData(10, -8)]
        [InlineData(-11, -3)]
        public void GivenInvalidNumbers_WhenSum_ThenShouldFail(int firstNumber, int secondNumber)
        {
            //arrange
            const int resultExpected = -1;

            //act
            var resultActual = Calculator.Sum(firstNumber, secondNumber);

            //assert
            Assert.Equal(resultExpected, resultActual);
        }
    }
}