using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Practical.Brute_Force
{
    internal class MatrixMul
    { // 

        public static void add_matrix(int[,] a, int[,] b, int[,] c, int split_index)
        {
          

            for (int i = 0; i < split_index; i++)
            {
                for (int j = 0; j < split_index; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }

        }
        public static int[,] multply_matrix(int[,] a , int[,] b )
        { 
            
            int row = a.GetLength(0);
            int col = b.GetLength(1);
            int[,] c = new int [row , col] ;
            int n = a.GetLength(0);
            if (n == 1)
            {
                c[0,0] = a[0,0]* b[0,0];
                return c;
            }
          

          
            int split_index = n / 2;

            //divide
            int[,] a00 = new int[split_index , split_index];
            int[,] a01 = new int[split_index, split_index]; 
            int[,] a10 = new int[split_index, split_index];
            int[,] a11 = new int[split_index, split_index];

            int[,] b00 = new int[split_index, split_index];
            int[,] b01 = new int[split_index, split_index];
            int[,] b10 = new int[split_index, split_index];
            int[,] b11 = new int[split_index, split_index];

            int[,] c00 = new int[split_index, split_index];
            int[,] c01 = new int[split_index, split_index];
            int[,] c10 = new int[split_index, split_index];
            int[,] c11 = new int[split_index, split_index];


            //conqure

            for (int i = 0; i < split_index; i++)
            {
                for (int j = 0; j < split_index; j++)
                {
                    a00[i, j] = a[i, j];
                    a01[i , j] = a[i, j+ split_index];
                    a10[i, j] = a[i+ split_index, j ];
                    a11[i, j] = a[i + split_index, j + split_index];

                    b00[i, j] = b[i, j];
                    b01[i, j] = b[i, j + split_index];
                    b10[i, j] = b[i + split_index, j];
                    b11[i, j] = b[i + split_index, j + split_index];

                }
            }



            add_matrix(multply_matrix(a00, b00), multply_matrix(a01, b10), c00, split_index);
            add_matrix(multply_matrix(a00, b01), multply_matrix(a01, b11), c01, split_index);
            add_matrix(multply_matrix(a10, b00), multply_matrix(a11, b10), c10, split_index);
            add_matrix(multply_matrix(a10, b01), multply_matrix(a11, b11), c11, split_index);


            //merge
            for(int i = 0; i<split_index; i++)
            {
                for (int j = 0; j < split_index; j++)
                {
                    c[i,j] = c00[i,j];
                    c[i, j + split_index] = c01[i,j];
                    c[i + split_index , j] = c10[i,j];
                    c[i + split_index, j + split_index] = c00[i, j];
                }
            }

            return c;
        }

      

    }
}
