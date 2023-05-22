using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Problems
{
    public  class Art
    {

        public static int max (int a, int b)
        {
            return Math.Max(a,b);
        }

        public static void art(int a1, int b1, int a2, int b2, int a3, int b3)
        {
            a1++;
            b1++;
            if ((max(a2, a3) < a1 && b2 +b3 < b1) ||
               ( max(b2, b3) < a1 && a2 +a3 < b1) ||
               ( max(a2, b3) < a1 && b2 + a3 < b1 )||
               ( max(b2, a3) < a1 && a2 + b3 < b1 )||
               ( max(a2, a3) < b1 && b2 + b3 < a1 )||
               ( max(b2, b3) < b1 && a2 + a3 < a1 )||
               ( max(a2, b3) < b1 && b2 + a3 < a1 )||
                (max(b2, a3) < b1 && a2 + b3 < a1) 
                )
            {

                 Console.WriteLine("YES");
            }           
            else
            {
                Console.WriteLine("NO");
            }

        } 
    }

}
//namespace _3amaly
//{

//    internal class Gerald_Is_Into_Art
//    {
//        static int max(int a, int b)
//        {
//            return Math.Max(a, b);
//        }

//        public static void art(int a1, int b1, int a2, int b2, int a3, int b3)
//        {
//            a1++;
//            b1++;
//            if (
//               (max(a2, a3) < a1 && b2 + b3 < b1) ||
//               (max(b2, b3) < a1 && a2 + a3 < b1) ||
//               (max(a2, b3) < a1 && b2 + a3 < b1) ||
//               (max(b2, a3) < a1 && a2 + b3 < b1) ||
//               (max(a2, a3) < b1 && b2 + b3 < a1) ||
//               (max(b2, b3) < b1 && a2 + a3 < a1) ||
//               (max(a2, b3) < b1 && b2 + a3 < a1) ||
//               (max(b2, a3) < b1 && a2 + b3 < a1))
//            {
//                Console.WriteLine("YES");
//            }
//            else
//            {
//                Console.WriteLine("NO");
//            }
//        }
//    }
//}