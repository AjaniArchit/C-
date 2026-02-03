using System;
class demo
{
	 static void Main()
	 {
		int[,] a= new int[2,3];
		a[0,0]=10;
		a[0,1]=20;
		a[0,2]=30;
		a[1,0]=40;
		a[1,1]=50;
		a[1,2]=60;
		Console.WriteLine("with massege" + a[0,0]+ " "+a[0,1]+ " "+a[0,2]+ " "+a[1,0]+ " "+a[1,1]+ " "+a[1,2]);
		Console.ReadLine();
	 }
}