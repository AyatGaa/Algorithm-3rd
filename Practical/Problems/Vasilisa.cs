using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Problems
{
    public class Vasilisa
    {
        public static void Vasilisa_Br(int r1 ,int r2 , int c1 , int c2 , int d1 , int d2)
        {
            for(int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {                               //     d1  c1 c2  d2 
                        for (int d = 1; d <= 9; d++) //  r1=>   a  b  
                        {                           //  r2=>   c  d
                            if( a!= b && a != c && a !=d && b!= c && b != d && c!=d)
                            {
                                if(a + b == r1 && a + c == c1 &&
                                   c + d == r2 && d + b == c2 && 
                                   a + d == d1 && c + b == d2)
                                     {
                                    Console.WriteLine(a + " " + b);
                                    Console.WriteLine(c + " " + d);
                                    return ;
                                }
                                 
                            }
                        }

                    }

                }

            }
            Console.WriteLine(-1);
        }
    }
}
