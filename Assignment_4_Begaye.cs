//Name:Begaye, Gamaliel 
//Date:12/11/2021
//Assignment 4

using System;

namespace Assignment4
{
    class Assignment4
    {
        static void Main(string[] args)
        {
            //Declare your variables here - I've given you "max", add others as needed
            int max;
            int counter = 0;
            int line;

            //Prompt the user per the example and store that in one of your variables
            Console.Write("Enter the maximum value for your pyramid (0 to quit): ");
            max = Convert.ToInt32(Console.ReadLine());
           
            //Your outer "main" while loop that uses the sentinel
            while (max != 0) //This is where we state how big the pyramid is going to be.
            {
                line = 1;
                //Here we use nested while loops to draw the "increasing" part
                while (line <= max) //This is where the pyramid is going to build.
                {
                    counter = 0;
                    //This while loop outputs your asterisks - see the example
                    //on our Blackboard for this week for outputting sequences;
                    while (counter < line)
                    {
                        // Code to output astersisks here
                        Console.Write("*"); //This is what the pyramid is going to be made out of. 
                        // See the example about outputting sequences for what should go here
                        counter++; //This increases the pyramid. 

                    }
                    //You may need to do something with a variable here before 
                    //the next while loops
                    Console.WriteLine(); //This also has to do with increasing the pyramid. 
                    line++;
                }
                //Here we use nested while loops to draw the "decreasing" part
                while (line != 0)
                {
                    counter = line;

                    while (counter > 0)
                    {
                        // Code to output astersisks here
                        Console.Write("*"); //This is the symbol for decreasing the pyramid

                        counter--;
                    }
                    // See the example about outputting sequences for what should go here
                    Console.WriteLine(); //This has to do with decreasing the pyramid. 
                    line--;
                }
                //Since this is right before we loop back to our "main" while loop,
                //we need to re-prompt the user so that we can change the value of the
                //variable that we're using in our "main" while loop
                Console.Write("Enter the maximum value for your pyramid (0 to quit): "); //This is displayed at the end of the pyramid to prompt the user if they want to create another pyramid or leave app.
                max = Convert.ToInt32(Console.ReadLine());
            }

        } // end Main

    } // end class

} // end namespace
