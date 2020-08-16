using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, -3, 5, 4, 8, -54, 4, 55, 95, -66, 48, 49, -84, 54, 8, -99, 100, 5};
            var res = num.Where(n => (n > 0) && (n / 10 > 0) && (n / 10 < 10)).Average();
            var res1 = num.Count(n => (n > 0) && (n / 10 > 0) && (n / 10 < 10));
            if (res == 0.0) Console.WriteLine("0.0");
            else if (res1 == 0) Console.WriteLine("0");
            else Console.WriteLine(res + " " + res1);
        }
    }
}
