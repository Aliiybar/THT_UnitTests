using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string FizzBuzzer(int i)
        {
            string retval = string.Empty;
            if (i % 3 == 0)
            {
                retval = "Fizz";
            }
            if (i % 5 == 0)
            {
                retval += "Buzz";
            }

            if (retval == string.Empty)
            {
                retval = i.ToString();
            }
            return  retval;
        }
    }
}
