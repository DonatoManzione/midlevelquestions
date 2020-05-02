using System;

namespace midlevelquestionsfifteen
{
	
	
		public class Program
		{
			public static void Main(string[] args)   //main method
			{
				int[] OneDArray = new int[] { 27, 45, 78, 90, 63, 81 };
				MyArray(OneDArray, 3, 2);
			}

			public static void MyArray(int[] OneDArray, int r1, int c1)  //method
			{
				//local variable declaration and initilization - will use as index of OneDArray
				int i = 0;

				int[,] TwoDArray = new int[r1, c1];   //declaration of TwoDArray

				for (int y = 0; y < r1; y++)  //outer for loop - for row value
				{
					for (int x = 0; x < c1; x++)  //inner for loop - for column value
					{
						TwoDArray[y, x] = OneDArray[i];
						i++;
						Console.WriteLine(TwoDArray[y, x] + " ");
					}
					Console.WriteLine();
				}
			}
		}
	


}
