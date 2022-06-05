using System;
using System.Collections.Generic;
using System.Text;

namespace Block2_2
{
    class ArgumentOutOfRange
    {
        public void ArgumentOutOfRangeExc()
        {
            List<char> x = new List<char>();
            try
            {
                Console.WriteLine(x[0]);
            }
            catch (ArgumentOutOfRangeException except)
            {
                Console.WriteLine(except);
            }
        }
    }
}
