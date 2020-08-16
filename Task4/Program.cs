using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            char C = Char.Parse(Console.ReadLine());
            string[] A = { "ad", "sdg", "55efds5", "kndkn63", "jwgb12m0", "35hf4g", "sdv55" };
            try
            {
                var res = A.SingleOrDefault(n => (n[n.Length - 1] == C));
                Console.WriteLine(res);
            }

            catch (Exception ex) { Console.WriteLine("Error"); }
        }
    }
}
