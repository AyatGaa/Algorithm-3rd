using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Problems
{
    public class CutRibbon
    {
        public static int cut_ribbon_dp(int len , int a ,int b ,int c )
        {
            int[] memo = new int[len +1];
            memo[0] = 0;
                 
            for ( int i =1; i < len + 1; i++)
            {
                memo[i] = int.MinValue;
                if(i >=a)
                {
                    memo[i] = Math.Max(memo[i], memo[i - a]+ 1);
                }
              
                if (i >= b)
                {
                  memo[i] = Math.Max(memo[i], memo[i - b]+ 1);
                }
                
                if (i >= c)
                {
                    memo[i] = Math.Max(memo[i], memo[i - c]+ 1);

                }
                    
            }
            return memo[len];
        }
        
    }
}
 