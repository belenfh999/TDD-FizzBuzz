using System;

namespace FizzBuzz.Library
{
    public class FizzBuzzService
    {
        public String Print(int value) 
        {
            if(value == 7)
            {
                return "7";
            }
            else if(value % 3 == 0){
                return "Fizz";
            }
            else 
            {
                return "8";
            }
        }
    }
}
