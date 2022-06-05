using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2_2
{
    class IndexOutOfRange
    {
        public void IndexOut_Range()
        {
            int[] x = new int[10];
            try
            {
                for (int i = 0; i < 15; i++)
                {
                    x[i] += 7;

                }
            }
            catch (IndexOutOfRangeException except)
            {
                Console.WriteLine(except);
            }
        }
    }  
}
