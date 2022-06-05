using System;
using System.Collections.Generic;
using System.Text;

namespace Block2_2
{
    class StackoverFlowExc
    {
        public void OverFlowError()
        {
            int x = 990000000;
            checked
            {
                try
                {

                    int sqrt = x * x;
                    Console.WriteLine("{0} ^ 2 = {1}", x, sqrt);
                }
                catch (OverflowException except)
                {
                    Console.WriteLine(except);

                }
            }

        }
    } 
}

