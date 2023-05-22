using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Sorting
{
    public class MergeSort
    {
        //merge sort O(n)
        public static void Merge(int[] arr , int left , int mid , int right)
        {
            int i, j, k;
            //same array and make TEmp one to sort in it and move it back main array !
            int[] Temp = new int[arr.Length+1];
               
          
            //same arraay == > i first part // j second part // k Temp array 
            i = k = left; // first elemetn == 0
            j = mid+1; 
            // merge
            while (i <= mid  && j<=right)
            {
                if (arr[i] <= arr[j])
                {
                    Temp[k] = arr[i];
                    i++;
                }
                else
                {
                    Temp[k] = arr[j];
                    j++;
                }
                k++; // movve to new place to save next element
            }

            //check if one array hvae more elemtn than other
            while(i <= mid)
            {
                Temp[k] = arr[i];
                i++;
                k++;
            }
            while ( j <= right)
            {
                Temp[k] = arr[j];
                j++;
                k++;
            }
            //move temp array elemtn to main array !
            for (int x = left; x <= right; x++)
            {
                arr[x] = Temp[x];
            }
        }

        //merge sort recursive
        public static void merge_sort(int [] arr ,int left  , int right)
        {

            if (left < right)
            {
                int mid;
                mid= left + (right - left) / 2;
                merge_sort(arr, left, mid);
                merge_sort(arr , mid+1 , right );

           
                Merge(arr , left , mid , right );
            }

       
        }
    }
}
