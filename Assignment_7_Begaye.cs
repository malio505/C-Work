// Name:Begaye, Gamaliel
// Date: 1/13/2022
//Assignment: Week 7

using System;

namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use these variables
            //x, y, and speed are entered by the user
            int x, y; //These represent the desitnation of the car
            int speed; //This is how fast the car is moving

            //distance and timeOfTravel are calculated by the program
            double distance; //This is how far the destination is from thar
            double timeOfTravel = 0.0; //This is how long it will take the car 
                                       //to get to the destination.  Note that it is assigned a value of 0.0
                                       //upon declaration.  Since we will be passing it by reference later,
                                       //it has to have a value assigned, otherwise an error occurs when we
                                       //try to pass it to a method by reference.

            //Get your user input for x, y, and speed
            Console.Write("Enter the x value of destination: ");
            x=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the y value of destination: ");
            y=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the speed of the car: ");
            speed=Convert.ToInt32(Console.ReadLine()); 

            //Call your first printIt method that summarizes the user input
           
            printIt(x,y,speed); //This printIt method sends the values to the method below

            //Calculate your distance using your calcDistance method

            distance= calcDistance(x,y);  //This is my calculation that is sent to the method below

            //Calculate timeOfTravel passing by reference to your calcTime method 
            //(don't forget you'll also need to send your speed and distance)
             calcTime(speed, distance, ref timeOfTravel);

            //Call your other printIt method - this is known as overloading as the method 
            //has the same name by accepts different variables
            printIt(timeOfTravel,distance); //This is my second printIt call, instead of x, y, speed timeOfTravel and distance is used instead. 

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

        }


        //Method declarations below... Note that these are outside of Main!
        //You must fill in the RETURN TYPE and the ITEMS THAT BELONG IN THE 
        //PARENTHESES as well as the actual code inside the method

        //Your first printIt method will take the x, y, and speed values
        public static void printIt(int x, int y, int speed)
        {
            Console.WriteLine($"The car will be traveling from 0,0 to {x},{y} at a speed of {speed}." ); //I took off the "double" per your instructions provided for both calls. 

        }

        //Your overloaded printIt method will take the timeOfTravel and distance values
        public static void printIt(double timeOfTravel, double distance)
        {
            Console.WriteLine($"It will take a time of {timeOfTravel} to travel a distance of {distance}.");
        }


        //This method should return a type double that is the pythagorean distance from 
        //0, 0, to x, y.  
        public static double calcDistance(double x, double y)
        {
            //Hint: You will need to use Math.Pow and Math.Sqrt here
           return Math.Sqrt( Math.Pow(x,2) + Math.Pow(y,2));
        }

        //This method should take a pass-by-reference timeOfTravel and two other
        //values and assign a calculated valued to timeOfTravel
        public static void calcTime(double speed, double distance, ref double timeOfTravel)
        {
            timeOfTravel = distance / speed;
        }
    }
}

