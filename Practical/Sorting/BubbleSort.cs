using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Sorting
{
    public  class BubbleSort
    {
        public static void bubblesort(int[] arr)
        {

            for(int i = 0; i< arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] >= arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j + 1] = temp;
                    }        
                }
            }
        }
    }
}
