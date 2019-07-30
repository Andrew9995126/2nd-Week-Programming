using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_Week_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1+num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.ReadLine();

            
        }
    }
}
