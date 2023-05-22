using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Greedy
{
    //Class of items
    public class Items
    {
        public int Weight { set; get; }
        public int Value { set; get; }

        // to get the values and weights of item
        public Items(int weight, int value)
        {
            this.Weight = weight;
            this.Value = value;
        }
    }

    public class FractionKnapsack
    {
        // find max vlaue
        public static double Fraction_KnapsackGreddy(Items[] items, int Capacity)
        {
            // compare ration of x (vlaue/weight) to y (value/weight) "sort Asending " 1=>10
            Array.Sort(items, (x, y) => ((double)y.Value / (double)y.Weight).CompareTo((double)x.Value / (double)x.Weight));

            double Total_Value = 0;
            int Remaininig_Capacity = Capacity;

            //add items with heigest ration
            foreach (Items item in items)
            {
                
                //if item can add as whole in knapsack ! add it easliy
                if (item.Weight <= Remaininig_Capacity)
                {
                    Total_Value += item.Value;
                    Remaininig_Capacity -= item.Weight;

                }
                else
                {
                    if (Remaininig_Capacity == 0) break;
                    // if we cant add it as whole ==> clac fracto to it
                    // fraction =[ reamin capacity / weight ]of that item!

                    double Fraction = (double)Remaininig_Capacity / (double)item.Weight;

                    Total_Value += Fraction * (double)item.Value;
                    break;
                }
            }

            return Total_Value;
        }

    }
}
