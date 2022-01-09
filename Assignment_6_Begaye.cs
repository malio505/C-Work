// Name:Begaye, Gamaliel    
// Date:1/7/2022
// Assignment: 6.1

using System;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare two doubles to store the user input 
            double number1;
            double number2;


            //Get the user input
            Console.Write("Enter Number 1: ");//User inputs first number.
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Number 2: ");//User inputs second number. 
            number2 = Convert.ToDouble(Console.ReadLine());


            //Provide the analysis as described in the assignment here
            //DO NOT CREATE YOUR OWN METHODS!  
            Console.WriteLine();
            Console.WriteLine($"The absolute value of {number1} is {Math.Abs(number1)}.");//Absolute value methods.

            Console.WriteLine($"The absolute value of {number2} is { Math.Abs(number2)}.");

            Console.WriteLine($"The maximum of {number1} and {number2} is {Math.Max(number1, number2)}.");//Maximun and Minimum methods.

            Console.WriteLine($"The minimum of {number1} and {number2} is {Math.Min(number1, number2)}.");

            Console.WriteLine($"{number1} raised to the power of 3 is {Math.Pow(number1, 3)}.");//Each number raised to the power of 3 methods.

            Console.WriteLine($"{number2} raised to the power of 3 is {Math.Pow(number2, 3)}.");

            Console.WriteLine($"The square root of the absolute value of {number1} is {Math.Sqrt(Math.Abs(number1))}.");//The square root methods. 

            Console.WriteLine($"The square root of the absolute value of {number2} is {Math.Sqrt(Math.Abs(number2))}.");

            Console.WriteLine();

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

        }
    }
}
