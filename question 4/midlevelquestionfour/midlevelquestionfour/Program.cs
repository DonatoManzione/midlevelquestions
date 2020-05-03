using System;

namespace midlevelquestionfour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseEachWord("Hello World!"));
        }


        public static string ReverseEachWord(string str)
        {
            string[] arrayOfWords = str.Split(" ");
            for (int i = 0; i < arrayOfWords.Length; i++)
            {
                arrayOfWords[i] = ReverseWord(arrayOfWords[i]);
            }
            string result = "";
            foreach(string word in arrayOfWords)
            {
                result += word + " ";
            }
            return result;

        }

        public static string ReverseWord(string word)
        {

            string newWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                newWord += word[word.Length - i - 1];
            }
            return newWord;
        }
    }
}
