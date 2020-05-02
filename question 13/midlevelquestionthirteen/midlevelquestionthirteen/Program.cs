using System;

namespace midlevelquestionthirteen
{
    class Program
    {
        //Question 13: How to find the third largest integer in an array using only one loop
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 4, 3, 7, 5, 4, 8, 9 };
            //should print 7
            Console.WriteLine(FindThirdLargest(array));

        }

        static int FindThirdLargest(int[] arr)
        {
            int largest = Math.Max(arr[0], arr[1]);
            int secondLargest = Math.Min(arr[0], arr[1]);
            int thirdLargest;
            if (largest < arr[2])
            {
                thirdLargest = secondLargest;
                secondLargest = largest;
                largest = arr[2];
            }
            else if (secondLargest < arr[2])
            {
                thirdLargest = secondLargest;
                secondLargest = arr[2];
            }
            else
            {
                thirdLargest = arr[2];
            }


            for(int i = 3; i < arr.Length; i++)
            {
                if (largest < arr[i])
                {
                    thirdLargest = secondLargest;
                    secondLargest = largest;
                    largest = arr[i];
                }
                else if (secondLargest < arr[i])
                {
                    thirdLargest = secondLargest;
                    secondLargest = arr[i];
                }else if(thirdLargest < arr[i])
                {
                    thirdLargest = arr[i];
                }
            }

            return thirdLargest;
        }
    }
}
