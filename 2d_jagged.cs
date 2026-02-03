using System;
class jagged2d
{
    static void Main()
    {
        Console.WriteLine("enter number of rows:");
        int rows = Convert.ToInt32(Console.ReadLine());


        int[][] arr = new int[rows][];

    
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine("enter number of columns for row " + i + ":");
            int cols = Convert.ToInt32(Console.ReadLine());

            arr[i] = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                Console.Write("enter value arr[" + i + "][" + j + "]: ");
                arr[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }

     
        
    }
}
