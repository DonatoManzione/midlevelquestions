using System;
using System.Collections;
using System.Collections.Generic;

namespace midlevelquestioneleven
{
    class QuestionEleven
    {

        public static void Main(string[] args)
        {
           Console.WriteLine(FindSecondLargest(new int[] { 3,3,3,4,5,3,3 }));
        }
        //Question 12. Find the second largest integer in an array using a for loop
        public static int FindSecondLargest(int[] arr)
        {


            //create a set to avoid checking variables that are duplicates
            ISet<int> uniqInts = new HashSet<int>(arr);

            //Find the largest and smallest of the two first elements
            //store them in variables
            int largest = Math.Max(arr[0], arr[1]);
            int secondLargest = Math.Min(arr[0], arr[1]);

            //Remove them from the set because you've already checked them
            uniqInts.Remove(arr[1]);
            uniqInts.Remove(arr[0]);

            //iterate through the set to find largest and second largest
            foreach (object o in uniqInts)
            {
                                if (largest < (int)o)
                {
                    //if largest is smaller than current element 
                    // make largest = current element, and secondLargest = largest 
                    secondLargest = largest;
                    largest = (int)o;
                }
                else
                {
                    //if current element is bigger than secondLargest and smaller than largest, make current element secondLargest
                    if (secondLargest < (int) o)
                    {
                        secondLargest = (int) o;
                    }
                }
            }


            return secondLargest;



        }

    }
}



