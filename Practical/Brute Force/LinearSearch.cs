using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Brute_Force
{
    public class LinearSearch
    {
        public static int linear_search(int[] arr , int len , int x)
        {
            for(int i=0 ; i<len; i++)
            {
                if (arr[i]==x) return i;
            }
            return -1;
        }
    }
}
