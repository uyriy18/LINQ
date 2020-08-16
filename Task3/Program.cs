using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "asdd", "kjsf12", "12kjb43", ",dvv22kl", "133lcl*", "sdjf1", "12jn12" };
            int N = 6;
            var res = str.LastOrDefault(n => (n.Length == N) && Char.IsDigit(n[0]));

            if (res != null) Console.WriteLine(res);
            else Console.WriteLine("String not found");
        }
    }
}
