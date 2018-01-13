using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountBits(10000));
            Console.ReadKey();

        }
        public static int CountBits(int n)
        {
            int a = 0;
            while (n / 2 >= 1)
            {
                if ((n % 2) == 1)
                {
                    a++;
                }
                n = n / 2;
                if(n == 1)
                {
                    a++;
                }
            }
            
            return a;
        }
    }
}
