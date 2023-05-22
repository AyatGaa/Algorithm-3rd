using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Sorting
{
    public class SelectionSort
    {

        public static void selection_sort(int[] arr)
        {
            for(int i=0; i<arr.Length-1; i++)
            {
                int mini = i;
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[j] <= arr[mini])
                    {
                        mini = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[mini];
                arr[mini] = temp;
            }
        }
    }
}
