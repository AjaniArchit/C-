using System;
class jagged3d
{
		static void Main()
		{
				Console.Write("enter number of dimensional");
				int dim = Convert.ToInt32(Console.ReadLine());
				
				int [][][] arr = new int[dim][][];
				for(int i=0; i<dim; i++)
				{
					Console.Write("enter number of rows for dim {i}");
					//int rows = Console.Write("enter number of rows for dim {i}");
					int rows=Convert.ToInt32(Console.ReadLine());
					arr[i]= new int [rows][];
					
					for(int j=0; j<rows; j++)
					{
						Console.Write("enter number of column for dim {i}, rows{i}");	
						
						int cols = Convert.ToInt32(Console.ReadLine());
						
						arr[i][j]= new int [cols];
						for(int k=0; k<cols; k++)
						{
								Console.Write("enter element [i][j][k]:");
								arr[i][j][k]= Convert.ToInt32(Console.ReadLine());
						}
					}
					
				}
				Console.WriteLine("\n 3d jagged aray element:");
				for(int i=0; i<dim; i++)
				{
				Console.WriteLine("dim {[i]}:");
				
					for(int j=0; j<arr[i].Length; j++)
					{
							for(int k=0; k<arr[i][j].Length; k++)
							{
									Console.Write(arr[i][j][k]+ "");
							}
							Console.WriteLine();
					}
				}
		}
}