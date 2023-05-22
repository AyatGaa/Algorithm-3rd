using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Brute_Force
{
    public class FibonacciBR
    {
        public static int fib_BR(int n)
        {
            int[] fibo = new int[n+5];
            fibo[0] = 0;
            fibo[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fibo[i] = fibo[i-1] + fibo[i-2];
            }
            return fibo[n];
        }
         // or 
       public static int fib(int n)
        {
            if (n <= 1)
                return n;
            else 
                return fib(n-1) +fib(n-2);
        }
    }
}
