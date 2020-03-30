using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsah_a_obvod_ctverce
{
    class Program
    {
        static void Main(string[] args)
        {
            Ctverec ctverec = new Ctverec(5);
            Console.WriteLine(ctverec.Obvod());
            Console.WriteLine(ctverec.Obsah());

            Console.ReadKey();
        }
    }
}
