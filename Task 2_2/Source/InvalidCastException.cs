using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2_2
{
    class InvalidCastExc
    {
        public string InvalidCastExcept()
        {
            object x = 10.23123;
            string y = null;
            try
            {
                y = (string)x;
            }
            catch (InvalidCastException exc)
            {
                Console.WriteLine(exc);
            }

            return y;
        }
    }
}

