using System;

class demo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter size of array:");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] a = new int[size];

        // Taking elements from user
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("Enter element " + (i + 1) + ": ");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Array elements are:");

        // Printing elements
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }

        Console.ReadLine();
    }
}
