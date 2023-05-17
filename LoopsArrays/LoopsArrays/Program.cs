using System;

class Program
{
    public static void Main(string[] args)
    {
        int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
        int temp;

        for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
        {
            for (int k = 0; k < arr.GetUpperBound(1) + 1; k++)
                Console.Write(arr[i, k] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();


        for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
        {
            for (int k = 0; k < arr.GetUpperBound(1) + 1; k++)
                Console.Write(arr[i, k] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}