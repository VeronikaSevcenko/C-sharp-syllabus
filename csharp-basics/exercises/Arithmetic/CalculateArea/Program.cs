using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Menu choice");
            // Get the user's menu choice.
            
            

        }

        public static int GetMenu()
        {
            
            int userChoice = int.Parse(Console.ReadLine());


            // Display the menu.


            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            // get input from user
            switch(userChoice)
            {
                case 1 :
                    CalculateCircleArea();
                    break;
                case 2 :
                    CalculateRectangleArea();
                    break;
                case 3 :
                    CalculateTriangleArea();
                    break;
                case 4 :
                    Console.WriteLine("Quit\n");
                    break;
                default:
                    Console.WriteLine("Enter your choice (1-4) : ");
                    break;

            }
            // validate input

            


            return userChoice;
        }

        public static void CalculateCircleArea()

        {
            int radius;
            // Get input from user
            Console.WriteLine("What is the circle's radius? ");

            //todo
            radius = int.Parse(Console.ReadLine());

            // Display output
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));

            Console.ReadLine();
        }

        public static void CalculateRectangleArea()
        {
            decimal length;
            decimal width;

            // Get input from user

            // Get length
            Console.WriteLine("Enter length? ");
            //todo
            length = decimal.Parse(Console.ReadLine());
            // Get width
            Console.WriteLine("Enter width? ");
            //todo
            width = decimal.Parse(Console.ReadLine());
            // Display output
            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfTriangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            decimal ground;
            decimal height;

            // Get input from user

            // Get the base
            Console.WriteLine("Enter length of the triangle's base? ");
            ground = decimal.Parse(Console.ReadLine());
            //todo
            //read key value

            // Get the height
            Console.WriteLine("Enter triangle's height? ");
            height = decimal.Parse(Console.ReadLine());
            //todo
            //read key value

            // Display the triangle's area.
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfRectangle(ground, height));
        }
    }
}
