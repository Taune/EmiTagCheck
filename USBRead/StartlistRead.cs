using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USBRead
{
    class StartlistRead
    {

        public void ReadCsvFile ()
        {
            try
            {
                String st = System.IO.File.ReadAllText("c:\temp\brikkesjekk_fredag.csv");
                Console.WriteLine(st);
            }

            catch (Exception e)
            {
                Console.WriteLine("File could not be found");
                Console.WriteLine(e.Message);
            }
        }
    }
}
