using System;

namespace midlevelquestioneleven
{
    class Program
    {
        //Question 11: find the sum of digits of a positive integer
        //First, we create a method called FindSumDigits that takes in an uint as an argument
        //FindSumDigits converts the integer to a string, and then to a char array
        //Convert each digit character in the array into the unsigned integer (0-9) it represents and add to sum.
        //Return sum


        static void Main(string[] args)
        {

            //try with 18. Should return 9
            Console.WriteLine(FindSumDigits(18));

            //try with 55755. Should return 27
            Console.WriteLine(FindSumDigits(55755));

        }

        public static uint FindSumDigits(uint positiveInteger)
        {
            //Initialize sum variable
            uint sum = 0;

            //convert to string and remove white leading spaces
            string numberAsString = positiveInteger.ToString();


            //create a char array from the string
            char[] numberAsArrStr = numberAsString.ToCharArray();

            for (int i = 0; i < numberAsArrStr.Length; i++)
            {

                //convert each digit string into an unsigned integer
                uint myDigit = uint.Parse(numberAsArrStr[i].ToString());

                //add to the sum
                sum += myDigit;

            }

            return sum;


        }
    }
}
