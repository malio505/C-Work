//Name:Begaye, Gamaliel 
//Date:12/11/2021
//Assignment 4

using System;

namespace Assignment4
{
    class assignment4
    {
        static void Main(string[] args)
        {
            //Declare your variables here - I've given you "max", add others as needed
            int max;
            int counter;
            int line;

            //Prompt the user per the example and store that in one of your variables
            Console.Write("Enter the maximum value for your pyramid (0 to quit): ");
            max = Convert.ToInt32(Console.ReadLine());

            //Your outer "main" while loop that uses the sentinel
            while (max != 0) //This is where "max" is not equal to 0. 
                line = 1; //This is the string we use for the "outer" loop.
            {

                //Here we use nested while loops to draw the "increasing" part
                while (max <= 0) //This is where "max" is less than or equal to 0.
                    counter = 0;
                {

                    //This while loop outputs your asterisks - see the example
                    //on our Blackboard for this week for outputting sequences;
                    while (counter < line)
                    {
                        // Code to output astersisks here
                    }   Console.Write("*"); //This is where the program will input "*".
                    // See the example about outputting sequences for what should go here
                }       ++counter;


                //You may need to do something with a variable here before 
                //the next while loops
                    Console.WriteLine(); //This is where the next line is going to be written.
                    ++line;
                //Here we use nested while loops to draw the "decreasing" part
                while (max >= 0) //Th is where "max" is greater than or equal to 0.
                    --counter;
                {

                    while (line < counter)
                    {
                        // Code to output astersisks here
                    }   Console.Write('*');
                    // See the example about outputting sequences for what should go here
                }   --line; 

                //Since this is right before we loop back to our "main" while loop,
                //we need to re-prompt the user so that we can change the value of the
                //variable that we're using in our "main" while loop
                Console.Write("Enter the maximum value for your pyramid (0 to quit): ");
                max = Convert.ToInt32(Console.ReadLine());
            }

        } // end Main

    } // end class

} // end namespace
