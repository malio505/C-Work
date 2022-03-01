// Name: Begaye, Gamaliel
// Date: 2/25/2022
// Assignment:  Assignment 3
using System;

public class TimeDistance
{
    //Declare your private class variables for distance, speed, and time here -
    //remember to assign it the default values given in the assignment.
    //Also remember that these are "visible" to all methods in the class, 
    //but not to the actual object unless we "get" or "set" them.
    //private double Distance { get; set; }
        
    public double Time { get; set; }

    private double _speed; //These are my private class variables
    private double _distance;

    //Constructor that takes no arguments
    public TimeDistance()
    {

    }

    //Constructor shell that should take distance and speed arguments.  
    //You should call your setter methods and pass the given parameters 
    //to those within this constructor.  You need to fill in the parantheses.
    public TimeDistance(int distance, int speed)
    {
        _distance = distance; //This is the names that I use to call this constructor.
        _speed = speed;
    }

    //Now we declare our "getter" and "setter" for our class variables.
    //Remember, you DO NOT need a "setter" for the amount of time it will
    //take to go your distance, so you should only have five methods here.  
    //Also remember that "getters" and "setters" need to be declared as public
    public void setSpeed(double value) //Here is my list of "getters" and "setters" for the main to call.
    {
        if (value == 0)
        {
            _speed = 0.1;
        }
        else if (value < 0)
        {
            _speed = Math.Abs(value);
        }
        else if (value > 100.0)
        {
            _speed = 100.0;
        }
        else
        {
            _speed = value;
        }
    }

    public double getSpeed()
    {
        return _speed;
    }

    public void setDistance(double value)
    {
        if (value == 0)
        {
            _distance = 0.1;
        }
        else if (value < 0)
        {
            _distance = Math.Abs(value);
        }
        else if (value > 1000.0)
        {
            _distance = 1000.0;
        }
        else
        {
            _distance = value;
        }
    }
    public double getDistance()
    {
        return _distance;
    }
    //Calculate the amount of time it will take to travel
    //the given distance at the given speed
    public double computeTime()
    {
      return _distance / _speed; //This is the math that is needed to come up with the speed.
    }

} // end class TimeDistance

public class timeDistanceTest
{
    public static void Main(string[] args)
    {       
        //Make sure you output the appropriate things to the screen so your
        //output looks like the example with the exception of the values
        //generated.

        //Instantiate a TimeDistance object using the empty constructor
        TimeDistance timeDistance = new TimeDistance();
        //Set your time and distance values using the appropriate setters
        timeDistance.setDistance(-1024);
        timeDistance.setSpeed(14.2);
        //Call the computeTime method
        //timeDistance.computeTime();
        //Output data as appropriate
        Console.WriteLine("Providing 2 time-distance calculations for Assignment 3: ");
        Console.WriteLine($"\n\nFirst Distance value is {timeDistance.getDistance()}. First speed value is {timeDistance.getSpeed()}.\n");
        Console.WriteLine($"To go a distance of {timeDistance.getDistance()} at a speed of {timeDistance.getSpeed()} it will take a time of {timeDistance.computeTime()}");
        //Instantiate a second TimeDistance object by sending the appropriate speed and distance
        //values to the constructor
        TimeDistance timeDistance2 = new TimeDistance(); //This is my new .dot notation for my second set of values.

        timeDistance2.setDistance(155.7);
        timeDistance2.setSpeed(0);
        //Call computeTime
        //timeDistance.computeTime();
        //Output as appropriate
        Console.WriteLine("\n=====================================\n\n");
        Console.WriteLine($"Second distance value is {timeDistance2.getDistance()}. First speed value is {timeDistance2.getSpeed()}.\n");
        Console.WriteLine($"To go a distance of {timeDistance2.getDistance()} at a speed of {timeDistance.getSpeed()} it will take a time of {timeDistance.computeTime()}");
        Console.WriteLine("\nPress enter to continue");
        Console.ReadLine();
    } // end Main
} // end class timeDistanceTest
