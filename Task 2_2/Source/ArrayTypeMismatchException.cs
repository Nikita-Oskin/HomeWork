using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Block2_2
{
    class ArrayTypeMismatchExc
    {
        public void ArrTypeMismhError()
        {
            string[] char_ = { "helo", "hello", "helllo" };
            object[] c = char_;
            try
            {
                c[1] = 50; 
                Console.WriteLine(c[1]);
            }
            catch (ArrayTypeMismatchException exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}
