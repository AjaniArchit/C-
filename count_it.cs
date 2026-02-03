using System;

class demo
{
    static void Main()
    {
        Console.WriteLine("Enter row size:");
        int r = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter column size:");
        int c = Convert.ToInt32(Console.ReadLine());

        int[,] arr = new int[r, c];

        // Input
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write("arr[" + i + "," + j + "] = ");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nMatrix:");
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nElement Frequency:");
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                int count = 0;
                bool printed = false;

                // Check if already counted
                for (int x = 0; x < i; x++)
                {
                    for (int y = 0; y < c; y++)
                    {
                        if (arr[i, j] == arr[x, y])
                        {
                            printed = true;
                            break;
                        }
                    }
                    if (printed) break;
                }

                if (printed)
                    continue;

          
                for (int k = 0; k < r; k++)
                {
                    for (int l = 0; l < c; l++)
                    {
                        if (arr[i, j] == arr[k, l])
                        {
                            count++;
                        }
                    }
                }

                Console.WriteLine("Element " + arr[i, j] + " is " + count + " times");
            }
        }
    }
}
