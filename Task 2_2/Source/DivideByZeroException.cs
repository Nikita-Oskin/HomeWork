using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2_2
{
    public class DivideByZeroExc
    {
        public int Div(int x, int y)
        {
            try
            {
                return x / y;
            }
            catch (DivideByZeroException exp)
            {
                Console.WriteLine(exp);
                return default;
            }
        }
    }
}
