using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.WriteLine("Please, enter a number and program detect if its Prime:");
            while (s != 100)
            {
                if (IsPrime(s))
                {
                    Console.WriteLine("Your number {0} is Prime!", s);
                }
                else
                {
                    // Console.WriteLine("Your number {0} is complex!", s);
                }
                s++;
            }
            Console.ReadKey();


        }
        static bool IsPrime(int n)
        {
            bool result = false;

            if (n % 2 != 0 && n > 3)
            {
                int k = System.Convert.ToInt32(System.Math.Sqrt(n)) + 1;

                for (int i = 3; i <= k; i++)
                {
                    if (i % 2 != 0)
                    {
                        if (n % i != 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else if (n == 2 || n == 3) return true;
            return result;
        }
    }
}
