using System;

namespace midlevelquestionnineteen
{
    class Program
    {
        //Q19. How to find prime numbers between 1 to 100 using for and while loop?
        static void Main(string[] args)
        {
            Console.Write("2, 3, 5, 7, ");
            for(uint i = 11; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + ", ");
                }
            }
        }


        static bool IsPrime(uint num)
        {
            for(uint i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }


        
    }
}
