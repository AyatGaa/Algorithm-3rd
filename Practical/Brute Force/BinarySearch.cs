using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Brute_Force
{
    public class BinarySearch
    { // sorteddd araay 
        public static int binary_search(int[] arr , int left , int right , int x)
        {
            Array.Sort(arr);
            if (left <= right)
            {
                int mid;
                mid = left + (right - left) / 2;
                if(x == arr[mid])
                {
                    return mid;
                }else if (x < arr[mid])
                {
                    return binary_search(arr, left, mid - 1, x);
                }else
                {
                   return binary_search(arr , mid+1 , right , x);
                }
            }
            return -1 ;
        }
    }
}
