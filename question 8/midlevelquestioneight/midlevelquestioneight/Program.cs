using System;

namespace midlevelquestioneight
{
    class Program
    {
        //question 8: left circular rotation of an array
        static void Main(string[] args)
        {
            int[] myTestArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            myTestArray = OnePositionLeftCircularRotation(myTestArray);
            Print(myTestArray);
            myTestArray = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            myTestArray = LeftCircularRotationXSpaces(myTestArray, 5);
            Print(myTestArray); 
        }

        static int[] OnePositionLeftCircularRotation(int[] arr)
        {

            int[] newArray = new int[arr.Length];

            for(int i = 1; i < arr.Length; i++)
            {
                newArray[i - 1] = arr[i];
            }
            newArray[arr.Length - 1] = arr[0];
            return newArray;
        }

        static int[] LeftCircularRotationXSpaces(int[] arr, int x)
        {
            for(int i = 0; i < x; i++)
            {
               arr= OnePositionLeftCircularRotation(arr);
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
