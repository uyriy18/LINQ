using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 11, 25, -56, 14, -565, 96, -84, -56, 64, 152, 99 };
            int d = 5;
            var res = num.FirstOrDefault(n => (n > 0) && (n % 10 == d));
            Console.WriteLine(res);
        }
    }
}
