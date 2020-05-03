using System;
using System.Collections.Generic;

namespace midlevelquestionfive
{
    class Program
    {
        
        /// How to count the occurrence of each character in a string?
        static void Main(string[] args)
        {
            Dictionary<char, int> frequencies = new Dictionary<char, int>();
            frequencies = EachCharFrequency("Hello World!");
            Print(frequencies);
        }


        static Dictionary<char, int> EachCharFrequency(string str)
        {
            Dictionary<char, int> characterFrequencies = new Dictionary<char, int>();
            foreach(char c in str)
            {
                if (characterFrequencies.ContainsKey(c))
                {
                    characterFrequencies[c]++;
                }else
                {
                    characterFrequencies.Add(c, 1);
                }
                
            }
            return characterFrequencies;
        }

        static void Print(Dictionary<char, int> dict)
        {
            foreach(KeyValuePair<char, int> kv in dict)
            {
                Console.WriteLine(kv.Key + ": " + kv.Value);
            }
        }
    }


    
}
