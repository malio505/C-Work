// Name:Begaye, Gamaliel
// Date:2/20/2022
// Assignment:  Assignment 2 - Time-distance calculation.

using System;

public class TimeDistance
{
    //Declare your autoimplemented properties here
    public double Distance { get; set; } //These are my auto-implemented values for the 
    public double Speed { get; set; }    //TimeDistance class.
    public double Time { get; set; }
    public double Journey { get; set; } //These are my secondary names for distance 
    public double Fastness { get; set; } //and speed. 
    //Constructor that takes no arguments
    public TimeDistance()
    {
       Distance = 1; //These are the two values set to 1
        Time = 1;
    }

    //Constructor shell that should take two arguments and assign
    //those values to whatever your variables for distance and time are
    public TimeDistance( int Distance, int Speed)
    {
        
        Distance = Distance; //These are my two parameters
        Speed = Speed;
    }



    //Calculate the amount of time it will take to travel
    //the given distance at the given speed
    public void ComputeTime()
    {
        Time = Distance / Speed; //This is the calculation showing the time it takes to travel
                                 // using distance / speed. 
    }


} // end class TimeDistance

public class timeDistanceTest
{
    public static void Main(string[] args)
    {
        //Instantiate a TimeDistance object using the empty constructor
        TimeDistance timeDistance = new TimeDistance(); //This is my empty constructor to call the class.
        //Change the distance to travel and the speed using dot notation
        timeDistance.Distance = 243;
        timeDistance.Speed = 24;
        //Use the calculate method to determine the amount of time it will take to
        //go that distance based on that speed (you may declare a new variable or 
        //combine this step with the step below).
        timeDistance.ComputeTime();
        //Display your output as shown in the example
        Console.WriteLine("Providing 2 time-distance calculations for Assignment 2: ");
        Console.WriteLine();
        Console.WriteLine($"To go a distance of {timeDistance.Distance} at a speed of {timeDistance.Speed} it will take a time of {timeDistance.ComputeTime} ");
        //Instantiate a new (i.e. use a new name) TimeDistance object by passing the two 
        //variables to the constructor as directed in the assignment
        timeDistance.Journey = 257;
        timeDistance.Fastness = 75.3;
        //Use the calculate method to determine the amount of time it will take to
        //go that distance based on that speed (you may declare a new variable or 
        //combine this step with the step below).
        timeDistance.ComputeTime();
        //Display your output as shown in the example
        Console.WriteLine($"To go a distance of {timeDistance.Journey} at a speed of {timeDistance.Fastness} it will take a time of {timeDistance.ComputeTime} ");
        Console.WriteLine();

        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
    } // end Main
} // end class timeDistanceTest
