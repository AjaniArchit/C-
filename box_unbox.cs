using System;

class demo
{
    public static void Main(string[] args)
    {
        // TYPE CASTING
        int a = 10;
        double b = a;          // Implicit casting
        Console.WriteLine("Implicit Casting (int to double): " + b);

        double x = 12.75;
        int y = (int)x;        // Explicit casting
        Console.WriteLine("Explicit Casting (double to int): " + y);

        // BOXING
        int num = 50;
        object obj = num;      // Boxing
        Console.WriteLine("Boxing value: " + obj);

        // UNBOXING
        int result = (int)obj; // Unboxing
        Console.WriteLine("Unboxing value: " + result);

        Console.ReadLine();
    }
}
