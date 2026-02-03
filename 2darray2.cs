using System;

class demo
{
    static void Main()
    {
        int[,] a = new int[2, 3];

        a[0, 0] = 10;
        a[0, 1] = 20;
        a[0, 2] = 30;
        a[1, 0] = 40;
        a[1, 1] = 50;
        a[1, 2] = 60;

        Console.WriteLine("Total number element: " + a.Length);

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(a[i, j]);
            }
        }

        Console.ReadLine();
    }
}

		