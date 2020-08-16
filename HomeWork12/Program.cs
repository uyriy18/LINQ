using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, -2, 2, -5, -14, 6, 7, 24, 3 , -8, 14, 25, 6};

            #region for
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i] > 0)
            //    {
            //        Console.WriteLine(num[i]);
            //        break;
            //    }
            //}
            //for (int i = num.Length - 1; i >= 0; i--)
            //{
            //    if (num[i] < 0)
            //    {
            //        Console.WriteLine(num[i]);
            //        break;
            //    }
            //}
            #endregion

            var pos = num.FirstOrDefault(n => (n > 0));
            var neg = num.LastOrDefault(n => (n < 0));
            Console.WriteLine($"{pos}\t{neg}");
                      
        }

    }
}
