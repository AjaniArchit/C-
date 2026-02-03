using System;
class array{
		static void Main(){
				int [,] arr = new int[2,2];
				arr[0,0]=5;
				arr[0,1]=10;
				arr[1,0]=15;
				arr[1,1]=20;
				Console.WriteLine("total element:"+arr.Length);
				for(int i=0; i<arr.GetLength(0); i++)
				{
					for(int j=0; j<arr.GetLength(0); j++)	
					{
							Console.WriteLine("arr"+i+","+j+"="+arr[i,j]);
					}
				}
		}
}