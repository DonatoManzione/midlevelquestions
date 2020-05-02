using System;

namespace midlevelquestionone
{
    class Program
    {
        //Question 1: How to reverse a string with for and while loops, recursive method, and   Array.Reverse function

        public static void Main(string[] args)
        {
            string myString = "this is a string";
            Console.WriteLine(ReverseWithForLoop(myString));
            Console.WriteLine(ReverseWithWhileLoop(myString));
            Console.WriteLine(ReverseWithArrayReverse(myString));

        }

        private static string ReverseWithArrayReverse(string str)
        {
            char[] characterArray = str.ToCharArray();
            Array.Reverse(characterArray);
            string newString = "";

            for(int i = 0; i < str.Length; i++)
            {
                newString += characterArray[i];
            }
            return newString;
        }

        public static string ReverseWithForLoop(string str)
        {
            string newString = "";
            for(int i = 0; i < str.Length; i++)
            {
                newString += str[str.Length-i-1];
            }
            return newString;
        }

        public static string ReverseWithWhileLoop(string str)
        {
            string newString = "";
            int i = str.Length-1;

            while (i >=0)
            {
                newString += str[i];
                i--;
            }
            return newString;
        }





        
    }
}
