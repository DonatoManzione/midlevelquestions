using System;
using System.Collections;

namespace midlevelquestionfourteen
{
    class Program
    {
        //Question 14: How to convert a two-dimensional array to a one-dimensional array
        static void Main(string[] args)
        {
            //create two dimensional array
            int[,] myTwoDimen = new int[,] {  { 2, 5, 6 },  { 4, 3, 2 },  { 3, 6, 1 } };

            //pass to conversion function
            int[] result = ConvertToOneDimensional(myTwoDimen);

            //print results
            Print(result);

        }











        static int[] ConvertToOneDimensional(int[,] twoDimensional)
        {
            IList myList = new ArrayList();

            int size = 0;

            //add all of the int elements in the inner arrays into a list. Calculate total number of int elements
            foreach(int i in twoDimensional)
            {
                size++;
                myList.Add(i);
            }

            //create an array of as many integer elements as there were in the multidimensional array
            int[] oneDimen = new int[size];

            //add elements of the list to the new array
            for(int o = 0;o < size; o++)
            {
                oneDimen[o] = (int)myList[o];
            }
            //return array
            return oneDimen; 
        }

        //print function
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
