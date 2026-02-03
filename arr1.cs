using System;

class demo
{
    public static void Main(string[] args)
    {
        int[] a = new int[3];
        a[0] = 3;
        a[1] = 4;
        a[2] = 5;

        Console.WriteLine("size of array " + a.Length);

        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }

        Console.ReadLine();
    }
}
