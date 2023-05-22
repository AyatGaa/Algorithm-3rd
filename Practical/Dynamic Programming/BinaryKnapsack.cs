using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Dynamic_Programming
{
    public class BinaryKnapsack
    {
        /// <summary>
        /// weight 
        /// value  
        /// items n 
        /// comb of max vlues <= max knapsack
        ///  
        /// base case 
        /// 1- if knapsack capacity =0  OR if ittems ==  0  
        /// 
        // rows = number of items +1
        // col = ?????????????????????

        public static int[, ] memo = new int[10, 50];
        static int maxi = 0;
        public static int binary_Knapsack(int n , int[] w , int[] v, int c , int i) 
        {
       
            // base
            //num of items == to iterations
            if (n == i || c == 0)
            {
                return 0;
            }

            //if not existi in memo
            if (memo[i,c] > 0)
            {
                return memo[i,c];
            }



            // if item weight can put in knapsack
            if (w[i] <= c)
            {
                //if  i will take the item 
                var take = binary_Knapsack(n, w, v, c - w[i], i + 1) + v[i];

                // if i willnot take the itmr
                var no_take = binary_Knapsack(n, w, v, c, i + 1);

                //store max combination in maxi
                maxi = Math.Max(take, no_take);

            }
            else
            {
                var no_take = binary_Knapsack(n, w, v, w[i], i + 1);
                maxi = no_take;
            }

            memo[i, c] = maxi;

            return maxi;
        }
    }
}
