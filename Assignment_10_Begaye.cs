//Name:Begaye, Gamaliel
//Date: 2/2/2022

using System;

namespace assignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare you variable(s)
            string visual = "The sky above the port was the color of television, tuned to a dead channel.";
            Console.WriteLine($"Initial analysis on string: \n{visual}"); //This code ensures that the string is below the other.
            Console.WriteLine("======================");            
            Console.WriteLine($"Total characters: {visual.Length}");

            //Output your analysis calling the appropriate methods
            Console.WriteLine($"Total spaces: {countCharacterType(visual, ' ')}"); //This is the call to the countCharacterType method
            Console.WriteLine($"Total vowels: {countVowels(visual)}"); //This is the call to the countVowels method
            Console.WriteLine($"Total consonants: {countConsonants(visual)}"); //This is the call to the countConsonants method
            //Output your manipulations

            Console.Write("\n\nManipulations\n\n"); //This ensures there is the appropriate gaps between "Manipulations"
            Console.WriteLine("Space replacement...");
            Console.WriteLine("=========================================");
            Console.WriteLine(visual.Replace(' ', '^')); //This shows the ^ characters within the string
            Console.WriteLine();
            Console.WriteLine("Uppercase...");
            Console.WriteLine("=================================");
            Console.WriteLine(visual.ToUpper()); //This places the entire string in Uppercase letters
            Console.WriteLine();
            Console.WriteLine("Substrings...");
            Console.WriteLine("=================================");
           
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(visual.Substring(i * 19, 19)); //This for loop displays 19 characters within 4 lines
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }


        //Methods - fill in the return type, the parameters, and the code for each method below
        public static int countCharacterType(string text, char character)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (character == text[i])
                {
                    counter++;
                }
            } 
            return counter; 
        }

        public static int countVowels(string text)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int counter = 0;
            string lowerText = text.ToLower();

            for (int i = 0; i < lowerText.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (lowerText[i] == vowels[j])
                    {
                        counter++;
                    }
                }
            }
            return counter;

        }

        public static int countConsonants(string text)
        {
            int counter = text.Length;

            counter-=countVowels(text);

            char[] characters = new char[] { ' ', ',', '.' };
            
            for (int i = 0; i < characters.Length; i++)
            {
                counter-=countCharacterType(text, characters[i]);
            }
            return counter;
        }
    }
}
