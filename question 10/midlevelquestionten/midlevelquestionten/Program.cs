using System;

namespace midlevelquestionten
{
    class Program
    {
        //10. Find out if positive integer is a prime number
        static void Main(string[] args)
        {
            IsPrime(2);
            IsPrime(3);
            IsPrime(4);
            IsPrime(7);
            IsPrime(173);
            IsPrime(174);
        }



        static void IsPrime(uint positiveInteger)
        {
            if(positiveInteger == 2)
            {
                Console.WriteLine(positiveInteger + " is a prime number");
                return;
               
            }
            for(int i = 2; i < positiveInteger; i++)
            {
                if (positiveInteger % i == 0)

                {
                    Console.WriteLine(positiveInteger + " is not a prime number");
                    return;

                }
            }
            Console.WriteLine(positiveInteger + " is a prime number");

           
        }

        
    }
}
