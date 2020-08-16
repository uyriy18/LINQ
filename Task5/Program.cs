using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> A = new List<string> { "ad", "sdg", "55efds5", "kndkn63", "jwgb12m0", "35hf4g", "sdv55", "5sfvf5", "snun5" , "5", "55"};
            char C = '5';
            var res = A.Count(n => (n.Length > 1) && (n[0] == C) && (n[n.Length - 1] == C));
            
                Console.WriteLine(res );
            
        }
    }
}
