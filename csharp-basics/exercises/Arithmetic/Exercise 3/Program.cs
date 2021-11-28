using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            int average;
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number)
            {
                sum += number;
            }
            average = sum / upperBound;

            Console.WriteLine("The sum of 1 to 100 is " + sum);

            Console.WriteLine("The average is " + average);
        }
    }
}
