using System;

namespace FizzBuzz.Library
{
    public class FizzBuzzService
    {
        public String Print(int value) 
        {
            if(value % 3 == 0)
            {
                return "Fizz";
            }
            else if (value % 5 == 0)
            {
                return "Buzz";
            }
            else 
            {
                return $"{value}";
            }
        }
    }
}
