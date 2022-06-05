using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2_2
{
    class KeyNotFoundExcept
    {
        public void KeyNotFoundExc()
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            dict.Add("4.3", 4.3);
            dict.Add("8.5", 8.5);
            try
            {
                Console.WriteLine(dict["200"]);
            }
            catch (KeyNotFoundException exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}
