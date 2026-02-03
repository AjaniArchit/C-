using System;

class demo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a double value:");
        double num = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("You entered: " + num);

        Console.ReadLine();
    }
}
