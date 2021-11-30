using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double basePay = 0;
            double minBasePay = 8.0;
            int hoursWorked = 0;
            int maxHour = 60;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Employee Number" + i);

                Console.WriteLine("Enter Base Pay");
                basePay = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Hours Worked");
                hoursWorked = int.Parse(Console.ReadLine());

                double totalSalary = 0;
                if ((basePay < minBasePay) || (hoursWorked > maxHour))
                {
                    Console.WriteLine("Error");
                }
                else if (hoursWorked > 40)
                {
                    totalSalary = basePay * 40 + 1.5 * basePay * (hoursWorked - 40);
                }
                else
                {
                    totalSalary = basePay * hoursWorked;
                }
                Console.WriteLine($"Total salary is : " + totalSalary + "$");

                Console.ReadKey();

            }
        }
        
        
            
        






    }
}
