﻿using System;
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
            int choice;

            do
            {
                choice = GetMenu();

                if (choice == 1)
                {
                    CalculateCircleArea();
                }
                else if (choice == 2)
                {
                    CalculateRectangleArea();
                }
                else if (choice == 3)
                {
                    CalculateTriangleArea();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thanks,have nice day!");
                }
            } while (choice != 4);
        


            // Get the user's menu choice.



        }

        public static int GetMenu()
        {
            
            int userChoice;


            // Display the menu.


            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            // get input from user
            userChoice = int.Parse(Console.ReadLine());
            // validate input
            while (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("Please enter a valid range: 1, 2, 3, or 4: ");
                userChoice = int.Parse(Console.ReadLine());
            }
            


            return userChoice;
        }

        public static void CalculateCircleArea()

        {
            double radius;
            // Get input from user
            Console.WriteLine("What is the circle's radius? ");

            //todo
            radius = double.Parse(Console.ReadLine());

            // Display output
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle((double)radius));

        }

        public static void CalculateRectangleArea()
        {
            double length;
            double width;

            // Get input from user

            // Get length
            Console.WriteLine("Enter length? ");
            //todo
            length = double.Parse(Console.ReadLine());
            // Get width
            Console.WriteLine("Enter width? ");
            //todo
            width = double.Parse(Console.ReadLine());
            // Display output
            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfTriangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            double ground;
            double height;

            // Get input from user

            // Get the base
            Console.WriteLine("Enter length of the triangle's base? ");
            ground = double.Parse(Console.ReadLine());
            //todo
            //read key value

            // Get the height
            Console.WriteLine("Enter triangle's height? ");
            height = double.Parse(Console.ReadLine());
            //todo
            //read key value

            // Display the triangle's area.
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfRectangle(ground, height));
        }
    }
}
