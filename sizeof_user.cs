using System;

class demo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter size of array:");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] a = new int[size];
        int sum = 0;

        // Get elements from user
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("Enter element at index " + i + ": ");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nArray elements with index:");

        // Print elements with index and calculate sum
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine("Index " + i + " = " + a[i]);
            sum = sum + a[i];
        }

        Console.WriteLine("\nSum of array elements = " + sum);

        Console.ReadLine();
    }
}
