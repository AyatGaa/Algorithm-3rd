using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Dynamic_Programming
{
    public class Fib_DP
    {
        public static long[] fib = new long [1005];

        //memo 
        // return fib(n-1) , fib(n-2)
        // 0 1 2 3 4 5 6  7  8 9
        // 0 1 1 2 3 5 8 13 21 34
        public static long fibo(int n )
        {
            //fib[0] = 0;
           // fib[1] = 1;
           // for n =1 or n =0
            if (n <=1 )
            {
                return n;
            }
            // if it  in my memoriazation array return it
           if (fib[n] > 0)
            {
              return fib[n];
            }
           // if not we need to calculate it and save it in my memo
           else
            {
                fib[n] = fibo(n-1) + fibo(n-2);
            }

            return fib[n];
        }
       
    }
}
