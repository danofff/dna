using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dna
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client();
            c.GenerateDNA();
            Console.WriteLine($"a-{c.ap}% c-{c.cp}% g-{c.gp}% t-{c.ap}%");
            Console.WriteLine("It's over");
        }
    }
}
