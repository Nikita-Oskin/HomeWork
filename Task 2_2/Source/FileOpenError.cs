using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Block2_2
{
    class FileOpenException
    {
        public void FileOpen()
        {
            try
            {
                using (StreamReader x = new StreamReader("Hello"))
                {
                    Console.WriteLine(x.ReadLine());
                }
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
