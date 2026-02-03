using System;

class demo
{
    static void Main()
    {
        dynamic a = 20;

        a = 12.5;
        Console.WriteLine("double: " + a);

        a = 'p';
        Console.WriteLine("char: " + a);

        a = "hii";  
        Console.WriteLine("string: " + a);

        Console.ReadLine();
    }
}
