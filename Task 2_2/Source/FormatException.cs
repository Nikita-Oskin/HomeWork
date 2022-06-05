using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2_2
{
    class FormatExc
    {
        public void StrToDouble()
        {
            string x = "Welcome";
            try
            {
                Console.WriteLine(double.Parse(x));
            }
            catch (FormatException exp)
            {
                Console.WriteLine(exp);
               
            }
        }
    }
}
