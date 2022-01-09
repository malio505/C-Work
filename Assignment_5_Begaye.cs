//Name:Gamaliel Begaye
//Date:12/16/2021
//Assignment 5

using System;

namespace Assignment5
{
    class assignment5
    {
        static void Main(string[] args)
        {
            //Declare your variables here 
            int odd = 0;
            int even = 0;
            int input = -1;
            int max = 0;



            //Prompt the user for their choice of actions
            //Console.Write("Enter 1 to display odds, 2 to display evens, or 0 to quit: ");
            //int input = Convert.ToInt32(Console.ReadLine()); //Program reads user input.

            //Console.Write("Enter the maximum possible value you wish to see: ");
            //int max = Convert.ToInt32(Console.ReadLine());



            //Your while loop to execute based on the user's choice of actions
            while (input != 0)
            {

                Console.Write("Enter 1 to display odds, 2 to display evens, or 0 to quit: ");
                input = Convert.ToInt32(Console.ReadLine());

                if (input == 0)
                {
                    break;
                }

                int start = 0;
              
                //Your switch statement to output the correct sequence of numbers
                switch (input)
                {
                    //Inside your switch statement, you have two "cases" to consider
                    //based on the user's choice plus a "default" case that handles 
                    //when the user does not choose a valid option
                    //
                    //Inside each of the two cases, you will need to ask the user for the maximum
                    //number they wish to see.  You will also need to use an appropriately configured
                    //for loop (section 6.3 on page 195) to output the numbers as described in the 
                    //assignment and shown in the example

                    case 0:

                        break;

                    //This should help with your first case statement, you'll need to add the others
                    case 1:
                        start = 1;


                        //Do the reuquired things here with your for loop
                        break;

                    //Fill in the remaining cases below, this includes the "default" case
                    case 2:
                        start = 0;

                        break;

                    default:
                        Console.WriteLine("Please enter a value from 0 to 2!: ");
                        Console.WriteLine();
                        break; 
                }
                //for (int i = 0; i< 4; i++)
                //{

                //}
                if (input >= 0 && input <= 2)
                {
                    Console.Write("Enter the maximum possible value you wish to see: ");
                    max = Convert.ToInt32(Console.ReadLine());
                    int column = 0;
                    int columnCount = 4;

                    while (start <= max)
                    {
                        Console.Write(start + "\t");
                        if (column == columnCount)
                        {
                            Console.Write("\n");
                            column = 0;
                        }
                        column++;
                        start += 2;
                    }
                    Console.WriteLine();
                }
              
                //Re-prompt the user for their choice since this is a sentinel loop
                
               

                //int input = Convert.ToInt32(Console.ReadLine()); //Program reads user input. 

            }

            Console.WriteLine("\n\nProgram complete.  Press Enter to continue.");
            Console.ReadLine();

        } // end Main

    } // end class

} // end namespace
