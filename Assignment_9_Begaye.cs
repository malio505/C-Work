// Name:Begaye, Gamaliel
// Date:1/27/2022

using System;

namespace Assignment9
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create your array already full of data, i.e. initialize it as your declare it
            int[] array1 = { 3, 11, 20, 27, 39, 49, 59, 63, 72, 78, 87, 89, 93, 94, 98, 99, 102, 99, 95, 95 };

            //Create a second array of doubles to hold the smoothed values from the original array
            double[] array2 = new double[20]; //This is my empty array of doubles
            //Print the original array using a printArray method
            printArray(array1);
            //Call your smoothArray method by passing your two arrays to it
          

            //Print your smoothed array
            smoothArray(array1,ref array2); //This is calling both my smoothArray method and also the array2 
            printArray(array2);             //method. 
            Console.WriteLine();

            Console.WriteLine("\nPress Enter to continue.");
            Console.ReadLine();



        }

        //Methods: you'll need to figure out the return type of the methods and fill in the 
        //items in the parentheses as well as writing the code for the methods
        static void printArray(int[] array)
        {
            Console.WriteLine("Original Data: ");
            Console.WriteLine("==============");
            string output = "";

            for (int i = 0; i < array.Length; i++)
            {
                output += array[i].ToString() + "\t"; //This is showing my array1 Method. 

                //Console.WriteLine(Console.ReadLine());
            }

            Console.WriteLine(output);
        }

        //Here's the overloaded printArray - you'll pass a different type of parameter
        static void printArray(double[] array)
        {
            Console.WriteLine("Smoothed Data: ");
            Console.WriteLine("==============");
            string output = "";

            for (int i = 0; i < array.Length; i++) //This calls my array2 method
            {                                      
                output += array[i].ToString() + "\t";

                //Console.WriteLine(Console.ReadLine());
            }

            Console.WriteLine(output);
        }

        static void smoothArray(int[] array1, ref double[] array2)
        {
            for (int i = 1; i < array1.Length; i++)
            {
                array2[i-1] = (array1[i-1] + array1[i]) / 2.0; //This is my best attempt for the psudocode
                                                               //block of code
            }                                                  

        }

        //static double[] SmoothArray2(int[] integerArray)
        //{

        //}

    }
}
