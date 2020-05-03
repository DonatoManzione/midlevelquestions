using System;

namespace midlevelquestionthree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseOrderOfWords("Let us reverse the word order in this string"));
        }

        static string ReverseOrderOfWords(string words)
        {
            string[] array = words.Split(" ");
            Array.Reverse(array);
            string result = "";
            for(int i = 0; i < array.Length; i++)
            {
                result += array[i] + " ";
            }
            return result;

        }
    }
}
