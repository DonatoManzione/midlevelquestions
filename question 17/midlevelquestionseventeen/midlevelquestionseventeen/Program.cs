using System;

namespace midlevelquestionseventeen
{
    class Program
    {
        //Q17. How to calculate the factorial of a number using for loop, while, do-while, and recursive functions? 
        static void Main(string[] args)
        {
            Console.WriteLine(FactorialUsingForLoop(4));
            Console.WriteLine(FactorialUsingWhileLoop(4));
            Console.WriteLine(FactorialUsingDoWhileLoop(4));
            Console.WriteLine(FactorialUsingRecursiveFunction(4));
        }

        private static uint FactorialUsingRecursiveFunction(uint num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * FactorialUsingRecursiveFunction(num - 1);
            }
        }

        private static uint FactorialUsingDoWhileLoop(uint num)
        {
            uint factorial = 1;
            if (num == 2 || num == 1)
            {
                return num;
            }
            uint i = 2;
            do
            {
                factorial *= i;
                i++;
            } while (i <= num);
            return factorial;

        }

        static uint FactorialUsingForLoop(uint num)
        {
            uint factorial = 1;
            if (num == 2 || num == 1)
            {
                return num;
            }
            for (uint i = 2; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static uint FactorialUsingWhileLoop(uint num)
        {
            uint factorial = 1;
            if (num == 2 || num == 1)
            {
                return num;
            }
            uint i = 2;
            while (i <= num)
            {
                factorial *= i;
                i++;
            }

            return factorial;
        }
    }
}
