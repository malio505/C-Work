// Name:Begaye, Gamaliel        
// Date:12/3/2021

using System;

public class Assignment1
{
    public static void Main(string[] args)
    {
        //Declare you integer variables here
        int number1;
        int number2;
        int sum;
        int even;
        int odd;

        //Prompt for input and read first number
        Console.Write("Enter first number: "); //User inputs first number
        number1 = Convert.ToInt32(Console.ReadLine()); //Program reads the first number

        //Prompt for input and read second number
        Console.Write("Enter second number: "); //User inputs second number
        number2 = Convert.ToInt32(Console.ReadLine()); //Program reads the second number

        //Output your addition and multiplication results as shown in the example here
        sum = number1 + number2; //adding two numbers
        sum = number1 * number2; //multiplying two numbers

        //Use 4 if statements to determine if your numbers are odd or even and display
        //the results accordingly
        if (number1 == odd)
            odd = number1;
        if (number1 != even)
            even = number1;
        if (number2 == odd)
            odd = number2;
        if (number2 != even)
            even = number2;
        sum = number1 % number2; //finding if a number has a remainder

        //Pause the screen - get used to seeing this as it is in pretty much each assignment
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();


    } // end Main
} // end class Assignment1



