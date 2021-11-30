using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            int average;
            
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number) // for (var i = 1; i <= 100; ++i)
            {
                sum += number;
                
            }
            average = sum / 2;
            Console.WriteLine("The Sum is : " + sum);
            Console.WriteLine("The Average is : " + average);
        }
    }
}
