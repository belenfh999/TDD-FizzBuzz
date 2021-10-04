using Xunit;
using FizzBuzz.Library;

namespace FizzBuzz.Tests
{
   
    public class FizzBuzzTests
    {
        private FizzBuzzService _fizzBuzz;

        public FizzBuzzTests()
        {
            _fizzBuzz = new FizzBuzzService();
        }

        [Theory]
        [InlineData(7)]
        [InlineData(8)]
        public void ShouldPrintNumber(int value)
        {
            Assert.Equal($"{value}", _fizzBuzz.Print(value));
        }

        [Fact]
        public void ShouldPrintFizz(){
            Assert.Equal("Fizz", _fizzBuzz.Print(3));
        }
    }
}
