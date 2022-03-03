//Name Begaye, Gamaliel
//Date 2/28/2022
//Assignment Description Assignment 12


using System;


namespace assignment12
{

	class MyDrone
	{
		// Declare your private class variables here according to the directions
		private string _color; //These are my private variable names for my program.
		private double _rotors;
		private double _velocity;
		private double _xposition;
		private double _yposition;
		

		// Two Constructors for the MyDrone class
		public MyDrone()
		{
			//This will not be used for this assignment.
		}


		public MyDrone(double rotors, double velocity, double xposition, double yposition, string color)
		{
			_rotors = rotors;
			_velocity = velocity;
			_xposition = xposition;
			_yposition = yposition;	
			_color = color;
		}

		// "Getters" for the class variables - fill these in below
		public double getRotors() //These are all "getters" to call from main.
        {
			return _rotors;
        }

		public double getVelocity()
        {
			return _velocity;
        }

		public double getXposition()
        {
			return _xposition;
        }

		public double getYposition()
        {
			return _yposition;
        }

		public string getColor()
        {
			return _color;
        }

		//Main calculation method
		public double getTimeToHome()
		{
			double distancetoHome = Math.Sqrt((_xposition*_xposition)+(_yposition*_yposition)); //This is the Pythagorean Theorem formula to calculate distance to home.

			return distancetoHome / _velocity; //This is going to return the results to the console.
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			MyDrone drone1 = new MyDrone(8,12,33.75,47.82,"red"); //This is my first .dot notation call using the values per instructions.
			Console.WriteLine("Drone 1 \n-------");
			Console.WriteLine($"Color: {drone1.getColor()}");
			Console.WriteLine($"Rotors: {drone1.getRotors()}");
			Console.WriteLine($"Velocity: {drone1.getVelocity()}");
			Console.WriteLine($"Transit from {drone1.getXposition()},{drone1.getYposition()} to home will take {drone1.getTimeToHome()} seconds.\n");

			MyDrone drone2 = new MyDrone(3, 5, 64, 41, "green"); //This is my second .dot notation call using the values per instructions.
			Console.WriteLine("Drone 2\n-------");
			Console.WriteLine($"Color: {drone2.getColor()}");
			Console.WriteLine($"Rotors: {drone2.getRotors()}");
			Console.WriteLine($"Velocity: {drone2.getVelocity()}");
			Console.WriteLine($"Transit from {drone2.getXposition()},{drone2.getYposition()} to home will take {drone2.getTimeToHome()} seconds.");
			Console.WriteLine("Press enter to continue...");
			Console.ReadKey();

		}
	}
}
