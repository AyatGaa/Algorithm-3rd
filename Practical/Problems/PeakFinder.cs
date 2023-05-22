using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Problems
{
    public class PeakFinder
    {
        //handle 3 case 
        //1-elment at start of array
        //2- element at end of array
        //3-element in middle
        //4- if one element return that element
        public static int peak_finder(int[] arr , int len)
        {
            // case of oe elemetm
            if(len ==1) return arr[0];

            //start  of array
            if (arr[0] >= arr[1])
            {
                return arr[0];
            }
            //end of arr
            if (arr[len-1] >= arr[len-2])
            {
                return arr[len-1];
            }
            //mid
            for(int i = 1; i< len-1; i++) 
            {
                if (arr[i] >= arr[i-1] && arr[i] >= arr[i + 1])
                {
                    return arr[i];
                }
            }
            return -1;
        }
    }
}
