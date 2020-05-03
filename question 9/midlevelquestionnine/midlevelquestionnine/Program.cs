using System;

namespace midlevelquestionnine
{
    class Program
    {
        //Right circular rotation of an array
        static void Main(string[] args)
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            testArray = RightCircularRotationByOneSpace(testArray);
            Print(testArray);
            testArray = RightCircularRotationByXSpaces(testArray, 4);
            Print(testArray);
        }

        static int[] RightCircularRotationByOneSpace(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for(int i = 0; i < arr.Length-1; i++)
            {
                newArr[i + 1] = arr[i];
            }
            newArr[0] = arr[arr.Length - 1];
            return newArr;
        }

        static int[] RightCircularRotationByXSpaces(int[] arr, int x)
        {
            for(int i = 0; i < x; i++)
            {
                arr = RightCircularRotationByOneSpace(arr);
            }
            return arr;
        }

        static void Print(int[] arr)
        {
            Console.Write("{ ");
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("}");
        }
    }
}
