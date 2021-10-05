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
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(11)]
        public void ShouldPrintNumber(int value)
        {
            Assert.Equal($"{value}", _fizzBuzz.Print(value));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(27)]
        public void ShouldPrintFizz(int value){
            Assert.Equal("Fizz", _fizzBuzz.Print(value));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        public void ShouldPrintBuzz(int value){
            Assert.Equal("Buzz", _fizzBuzz.Print(value));
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        [InlineData(600)]
        public void ShouldPrintFizzBuzz(int value){
            Assert.Equal("FizzBuzz", _fizzBuzz.Print(value));
        }
    }
}
