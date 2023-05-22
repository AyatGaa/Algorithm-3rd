using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Sorting
{
    public  class InsertionSort
    {
        public static int[] Insertion_Sort(int[] arr, int len)
        {               //  j  k
            int key, j;  // 0  1  2  3  4 
                         // 2  3  4  5| 6 
            for (int i = 1; i< arr.Length; i++)
            {                  
                key = arr[i]; 
                j = i - 1; 
                // > acsendeing order
                while(j >= 0 && arr[j] > key)
                {
                    arr[j+1] = arr[j];
                    j--; // point to items before separator  
                }
                //if not grater place it with same value 
                arr[j+1] = key;

            }
            return arr;
        }
    }
}
