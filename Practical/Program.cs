using Practical.Brute_Force;
using Practical.Dynamic_Programming;
using Practical.Greedy;
using Practical.Problems;
using Practical.Sorting;
using System;
//Fibonacci by Dynamic Programming
Console.WriteLine("Fibonacci DP");
Console.WriteLine(Fib_DP.fibo(8));
Console.WriteLine("==============================");


Console.WriteLine("0/1 Knapsack DP");

int n = 4;
int[] w = new int[] { 2, 1, 3, 2 };
int[] v = new int[] { 12, 10, 20, 15 };
int c = 5;

Console.WriteLine(BinaryKnapsack.binary_Knapsack(n, w, v, c, 0));

Console.WriteLine("==============================");


Console.WriteLine("MAtrix Multiplication BF");


int[,] a = new int[,] { { 1,2} ,
                        { 3,4 } };


int[,] b = new int[,] { { 1,2} ,
                        { 3, 4 } };
int[,] matrix_C = new int[a.GetLength(0), b.GetLength(1)];

int[,] matrix_res = MatrixMul.multply_matrix(a, b);

for (int i = 0; i < a.GetLongLength(0); i++)
{
    for (int j = 0; j < a.GetLongLength(0); j++)
    {
        Console.Write(matrix_res[i, j] + " ");
    }
    Console.WriteLine("");
}
Console.WriteLine("");


Console.WriteLine("==============================");
Console.WriteLine("Fraction Knapsack ");

int cap1 = 5;
Items[] items = { new Items(2, 12), new Items(1, 10), new Items(3, 20), new Items(2, 15) };
Console.WriteLine(FractionKnapsack.Fraction_KnapsackGreddy(items, cap1));

int cap2 = 50;

Items[] arr = { new Items(10, 60), new Items(20, 100), new Items(30, 120) };

Console.WriteLine(FractionKnapsack.Fraction_KnapsackGreddy(arr, cap2));


int[] arr1 = { 1, 3, 20, 4, 1 }; // 2 3  4 5 6
int len = arr1.Length;


Console.WriteLine("==============================");
Console.WriteLine(" Insertion sort");
InsertionSort.Insertion_Sort(arr1, len);
Console.WriteLine("After Insertio sortt ");
for (int i = 0; i < len; i++)
{
    Console.Write(arr1[i] + " ");
}

Console.WriteLine(" ");
Console.WriteLine("==============================");
Console.WriteLine(" Merge sort");
MergeSort.merge_sort(arr1, 0, len - 1);
Console.WriteLine("After Merge Sorting ");
for (int i = 0; i < len; i++)
{
    Console.Write(arr1[i] + " ");
}
Console.WriteLine(" ");


Console.WriteLine("==============================");
Console.WriteLine(" Bubble sort");
BubbleSort.bubblesort(arr1);
Console.WriteLine("After Bubble Sorting ");
for (int i = 0; i < len; i++)
{
    Console.Write(arr1[i] + " ");
}
Console.WriteLine(" ");


Console.WriteLine("==============================");
Console.WriteLine(" Selection sort");
SelectionSort.selection_sort(arr1);
Console.WriteLine("After Selection  Sorting ");
for (int i = 0; i < len; i++)
{

    Console.Write(arr1[i] + " ");
}
Console.WriteLine(" ");



Console.WriteLine("==============================");
Console.WriteLine(" Binary Search ");
int ind = BinarySearch.binary_search(arr1, 0, len - 1, 3);
Console.Write ( " indexx = "+ind);
Console.WriteLine(" ");


Console.WriteLine("==============================");
Console.WriteLine(" Linear Search ");
Console.WriteLine("indexx = " + LinearSearch.linear_search(arr1, len, 4));


Console.WriteLine("==============================");
Console.WriteLine("Fibonacci BR  and dp ");
Console.WriteLine(FibonacciBR.fib_BR(8));
Console.WriteLine(FibonacciBR.fib(8));

Console.WriteLine("==============================");
Console.WriteLine(" Peak finder  ");
Console.WriteLine(PeakFinder.peak_finder(arr1, len));

//take input
//int[] ints = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int a1 = ints[0];
//int b1 = ints[1];
//ints = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int a2 = ints[0];
//int b2 = ints[1];
//ints = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//int a3 = ints[0];
//int b3 = ints[1];
Console.WriteLine("==============================");
Console.WriteLine(" Art Problem  ");
Art.art(2 ,3 , 1 ,3 ,2 ,1);

Console.WriteLine("==============================");
Console.WriteLine(" Cut ribbon Problem  ");
Console.WriteLine(CutRibbon.cut_ribbon_dp(5, 5, 3, 2));

Console.WriteLine("==============================");
Console.WriteLine(" Vasilsa Problem  ");
Vasilisa.Vasilisa_Br(11 ,10,13 ,8,5 ,16);