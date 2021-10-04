using Xunit;
using FizzBuzz.Library;

namespace FizzBuzz.Tests
{
   
    public class FizzBuzzTests
    {
        [Fact]
        public void ShouldPrintNumber()
        {
            FizzBuzzService fizzBuzz = new FizzBuzzService();
            Assert.Equal("7", fizzBuzz.Print(7));
        }

        [Fact]
        public void ShouldPrintNumber2()
        {
            FizzBuzzService fizzBuzz = new FizzBuzzService();
            Assert.Equal("8", fizzBuzz.Print(8));
        }
    }
}
