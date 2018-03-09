using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dna
{
    class Client
    {
        public string DNA { get; set; }

        private static char[] amino = new char[] { 'a', 'g', 'c', 't' };

        public double ap { get; set; }
        public double gp { get; set; }
        public double cp { get; set; }
        public double tp { get; set; }
        public void GenerateDNA()
        {
            StringBuilder dna = new StringBuilder();
            Random rnd = new Random();
            for (int i = 0; i < 10000000; i++)
            {
                dna.Append(amino[rnd.Next(0, 4)]);               
            }

            DNA = dna.ToString();
            ap = DNA.ToCharArray().Where(i => i == 'a').Count()*100/10000000;
            gp = DNA.ToCharArray().Where(i => i == 'g').Count()*100/10000000;
            cp = DNA.ToCharArray().Where(i => i == 'c').Count()*100/10000000;
            tp = DNA.ToCharArray().Where(i => i == 't').Count()*100/10000000;
        }
    }
}         
 
