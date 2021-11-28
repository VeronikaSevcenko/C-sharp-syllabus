using System;

namespace PrintDayWord2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber == 1)
            {
                Console.WriteLine("Monday");

            } if (dayNumber == 2)
            {
                Console.WriteLine("Tuesday");

            } if (dayNumber == 3)
            {
                Console.WriteLine("Wednesday");
            }
            if (dayNumber == 4)
            {
                Console.WriteLine("Thursday");
            }
            if (dayNumber == 5)
            {
                Console.WriteLine("Friday");
            }
            if (dayNumber == 6)
            {
                Console.WriteLine("Saturday");
            }
            if (dayNumber == 7)
            {
                Console.WriteLine("Sunday");
            } 
            if ( dayNumber > 8)
            {
                Console.WriteLine("Not a valid day");
            }
        }
    }
}
