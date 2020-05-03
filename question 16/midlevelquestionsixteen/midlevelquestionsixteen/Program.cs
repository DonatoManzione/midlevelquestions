using System;

namespace midlevelquestionsixteen
{
    class Program
    {
        // How to find the angle between hour and minute hands of a clock at any given time?
        static void Main(string[] args)
        {
            Console.WriteLine(FindAngle(6,15));
            Console.WriteLine(FindAngle(10, 15));
        }

     static double FindAngle(int hourFrom12, int minutes)
        {
            double oneHourAngle = 30;//degrees per hour for hour hand

            double minuteHandAsHour = minutes / 5;//imagine the minute hand also points to the hour

            double separation = hourFrom12 - minuteHandAsHour;

            if(separation > 6)
            {
                separation = 12 - separation;
            }
            return separation * 30;
        }
    }
}
