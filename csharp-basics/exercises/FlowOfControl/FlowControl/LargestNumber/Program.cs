using System;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            int input1;
            int input2;
            int input3;

            Console.WriteLine("Input the 1st number: ");
             input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            input3 = int.Parse(Console.ReadLine());

            if (input1 > input2)
            {
                if (input1 > input3)
                {
                    Console.WriteLine("Number 1st is largest");
                } else
                {
                    Console.WriteLine("Number 3rd is largest");
                }
            } else if (input2 > input3)
            {
                Console.WriteLine("Number 2nd is largest");
            } else
            {
                Console.WriteLine("Number 3rd is largest");
            }

            /*
            todo - expected output:
            Input the 1st number: 25
            Input the 2nd number: 78
            Input the 3rd number: 87
             */
        }
    }
}
