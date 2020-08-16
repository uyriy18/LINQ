using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, -3, 5, 4, 8, -54, 4, 55, 94, -66, 48, 49, -84, 54, 8, -99 };
            var res = num.Where(n => (n < 0)).Sum();
            var res1 = num.Count(n => n < 0);
            if (res1 == 0) Console.WriteLine("0  :  0");
            else Console.WriteLine($"Sume of negative elements : {res}, Amount of negative elements : {res1}");

        }
    }
}
