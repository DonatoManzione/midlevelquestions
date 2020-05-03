using System;

namespace midlevelquestionseven
{
    class Program
    {
        //Question seven: how many substrings in a given string
        static void Main(string[] args)
        {
            Console.WriteLine(HowManySubstrings("Hello World!"));
        }

        static int HowManySubstrings(string str)
        {
            int numberOfSubStrings = 0;
            for(int i = 1; i <= str.Length; i++)
            {
                numberOfSubStrings += i;
            }
            return numberOfSubStrings;
        }
    }
}
