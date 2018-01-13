using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigPow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 2 numbers a and b, that defines the range[a,b]:)");
            Console.WriteLine("Enter a and press Enter:");
            long a = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter b and press Enter:");
            long b = Convert.ToInt64(Console.ReadLine());

            if (a > b) Console.WriteLine("Unacceptable range [ {0}, {1} ]", b, a);
            else
            {
                Console.WriteLine("Your range [ {0}, {1} ] is correct. See results below:", a, b);
                long[] res = SumDigPow(a, b);
                foreach (long num in res)
                {
                    Console.Write(num + ",");
                }
                Console.ReadKey();
            }
        }
        public static long[] SumDigPow(long a, long b)
        {
            long[] result = new long[] { };
            
            for (long i = a;i<=b;i++)
            {
                long digit = i;
                long sum = 0;
                
                int qty = (int)System.Math.Ceiling(System.Math.Log10(System.Math.Abs(digit)+0.5));
                
                do
                {
                    sum += (long)System.Math.Pow(digit%10, qty);
                    digit /= 10;
                    qty--;
                }
                while (qty != 0);

                if (sum == i)
                {
                    System.Array.Resize(ref result, result.Length + 1);
                    result[result.Length-1] = i;
                }   
            }

            return result;

            /*Best solution
            List<long> values = new List<long>();
            for (long x = a; x <= b; x++)
            {
                if (x.ToString().Select((c, i) => Math.Pow(Char.GetNumericValue(c), i + 1)).Sum() == x)
                values.Add(x);
            }
            return values.ToArray();
             */
        }
    }
}
