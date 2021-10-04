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
    }
}
