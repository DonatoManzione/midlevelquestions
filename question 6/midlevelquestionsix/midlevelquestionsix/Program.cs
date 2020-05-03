using System;
using System.Collections.Generic;

namespace midlevelquestionsix
{
    class Program
    {
        //remove duplicate characters from a string
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveDuplicates("Hello World!"));
        }


        static string RemoveDuplicates(string str)
        {
            char[] charactersInString = str.ToCharArray();
            ISet<char> uniqCharacters = new HashSet<char>(charactersInString);
            string result = "";
            foreach(char c in uniqCharacters)
            {
                result += c;
            }
            return result;
        }
    }
}
