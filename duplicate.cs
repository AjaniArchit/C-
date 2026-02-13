using System;

class count_it 
{
    static void Main()
    {
        Console.Write("enter row size: ");
        int r = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter column size: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int[,] arr = new int[r,c];

        
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write("arr[" + i + "," + j + "] : ");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        
        Console.WriteLine("\n  element matrix : ");
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n element Count:");

        
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                bool Printed = false;

                
                for (int x = 0; x <= i; x++)
                {
                    for (int y = 0; y < c; y++)
                    {
                        if (x == i && y == j)
                            break;

                        if (arr[i, j] == arr[x,y])
                        {
                            Printed = true;
                            break;
                        }
                    }
                    if (Printed)
                        break;
                }

                if (Printed)
                    continue;

                int count = 0;

                for (int k = 0; k < r; k++)
                {
                    for (int l = 0; l < c; l++)
                    {
                        if (arr[i, j] == arr[k,l])
                        {
                            count++;
                        }
                    }
                }

                Console.WriteLine("element " + arr[i, j] + " is " + count + " times.");
            }
        }
    }
}
