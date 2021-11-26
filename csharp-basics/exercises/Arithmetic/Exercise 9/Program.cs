using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            float weight, height, BMI;
            
            Console.WriteLine("Please,write your weight");
            weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Please, write your height");
            height = float.Parse(Console.ReadLine());

            BMI = weight / (height * height);

            if (BMI < 18.5)
            {
                Console.WriteLine("Your BMI category is : Starvation");
            }
            else if (BMI > 25)
            {
                Console.WriteLine("Your BMI category is : Overweight");
            }
            Console.ReadLine();





            

        }
    }
}
