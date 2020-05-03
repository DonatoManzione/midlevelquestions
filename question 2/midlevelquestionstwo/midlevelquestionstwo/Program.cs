using System;

namespace midlevelquestionstwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("Hello World!"));
            Console.WriteLine(IsPalindrome("hellolleh"));
        }


        static bool IsPalindrome(string str)
        {
            int halfLength = str.Length / 2;
            for(int i = 0; i < halfLength; i++)
            {
                if (str[i] == str[str.Length - i - 1])
                {
                    continue;
                }else
                {
                    return false;
                }
            }
            return true;

        }
    }
}
