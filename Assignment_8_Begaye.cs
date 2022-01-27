// Name:Begaye, Gamaliel    
// Date:1/21/2022
//Assignment: Week 8 Arrays

using System;

namespace Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare your random number generator here
            Random r = new Random(243); //Command showing the random generator method. 

            //Declare your array and other variables here
            int[] x = new int[20];

            //Use a for loop to fill your array with values from 0 through 99
            for (int i = 0; i < x.Length; i++) 
            {
                x[i] = r.Next(0,99); //This will output values from 0-99. 
            }
            Console.WriteLine("The initial array: ");
            Console.WriteLine();         

            //Call printArray to display your newly created array
            printArray(x);
            Console.WriteLine();

            //Display the first element in the array         
            Console.WriteLine($"The first element of the array is: {x[0]}");

            //Display the last element of the array
            Console.WriteLine($"The last element of the array is: {x[x.Length-1]}"); //This command shows the last element per your instruction. 

            int max = 0;
            //Find the largest value in the array using a for loop:
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > max)
                {
                    max = x[i];
                }
               

            }

            //Now display that largest value
            Console.WriteLine($"The largest value of the array is: {max}");

            int min = 99;
            //Find the smallest value in the array
            for (int j = 0; j < x.Length; j++)
            {
                if (x[j] < min)
                {
                    min = x[j];
                }
            }

            //Now display the smallest value
            Console.WriteLine($"The smallest value in the array is: {min}");
           
            //Now swap the first and last values in the array and call printArray
            //to show the array with the new values
            int first = x[0];
            int last = x[x.Length-1];

            x[0] = last;
            x[x.Length-1] = first;

            Console.WriteLine();
            Console.WriteLine($"The array after swapping the first and last elements: ");
            Console.WriteLine(); 
            printArray(x);

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

        }


        //Method declarations below... Note that these are outside of Main!
        //You must fill in the RETURN TYPE and the ITEMS THAT BELONG IN THE 
        //PARENTHESES as well as the actual code inside the method

        //Your printArray method
        public static void printArray(int[] randomNumbers)
        {
            Console.WriteLine("**************"); //This will output 14 asterisks before the elements.
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                Console.WriteLine($"ELEMENT[{i}]: {randomNumbers[i]}"); //This for loop will make up a element list
            }

            Console.WriteLine();
            Console.WriteLine("**************"); //This will display 14 asterisks after the elements.
        }


    }
}

