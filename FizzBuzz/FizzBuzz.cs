using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Get(int num)
        {
            if (IsMultipleof3(num))
            {
                return "Fizz";
            }
            if (IsMultipleof5(num))
            {
                return "Buzz";
            }
            return num.ToString();
        }

        private bool IsMultipleof3(int numberToCheck)
        {
            return numberToCheck % 3 == 0;
        }

        private bool IsMultipleof5(int numberToCheck)
        {
            return numberToCheck % 5 == 0;
        }
    }
}
