using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int Sum = 0;

            Console.WriteLine("Enter a series of single digit numbers");
            a = Convert.ToInt32(Console.ReadLine());

            while (a > 0 )
            {
                Sum += (a % 10);
                    a /= 10;

                Console.WriteLine("Sum of all numbes is {0}",Sum);
            }
        }
    }
}
