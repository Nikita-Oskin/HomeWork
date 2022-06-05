using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2_1
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] city = { "Tokyo", "Amsterdam","Instanbul",
                                "Berlin", "London", "Washington"};
            string[] city0 = { "Amsterdam", "Berlin", "Instanbul",
                                "London", "Tokyo", "Washington"};
            int i = 0, count = 0;
            LinkedList<string> doublylinkedlist = new LinkedList<string>(city);

            var query = doublylinkedlist.OrderBy(s => { count++; return s; }, StringComparer.Ordinal);




            foreach (var q in query)
            {
                Console.WriteLine(q);
            }

            Console.Read();
        }
    }
}
