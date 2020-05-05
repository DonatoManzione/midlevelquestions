using System;

namespace midlevelquestiontwenty
{
    class Program
    {
        static int x = 9;
        static int y = 8;
        //Q20. How to swap two and three numbers?
        static void Main(string[] args)
        {
            Console.WriteLine("Variable x holds " + x + " and variable y holds " + y);
            Swap();
            Console.WriteLine("Variable x holds " + x + " and variable y holds " + y);
        }

        static void Swap()
        {
            int temp = y;
            y = x;
            x = temp;
        }
    }
}
