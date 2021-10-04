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

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        public void ShouldPrintFizz(int value){
            Assert.Equal("Fizz", _fizzBuzz.Print(value));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldPrintBuzz(int value){
            Assert.Equal("Buzz", _fizzBuzz.Print(value));
        }
    }
}
