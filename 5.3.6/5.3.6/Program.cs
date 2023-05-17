using System;
class Program
{
    static void Main(string[] args)
    {
        var arr = new int[] { 1, 2, 3 };
        var data = 5;
        BigDataOperation(arr, in data);

        Console.WriteLine(arr[0]);

        Console.ReadKey();
    }

    static void BigDataOperation(int[] array, in int data)
    {
        data = 4;
        array[0] = data;
    }
}