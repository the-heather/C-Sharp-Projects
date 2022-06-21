using System;
using System.Collections.Generic;
using System.Linq;

namespace iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] greetings = { "Hello, ", "Nice to meet you, ", "Goodbye, " };  // Create a list of values
            Console.WriteLine("Please enter your name:");
            string getName = Console.ReadLine();
            //  amend user input to each item in string 
            foreach (string i in greetings)
            {
                Console.WriteLine(i + getName);
            }
            //while n is less than 5 print current number to screen 
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine(n);
                n++;
            }
            //while s is less than or equal to 5 print current number to screen
            int s = 0;
            while (s <= 5)
            {
                Console.WriteLine(s);
                s++;
            }
            // Create a list of values
            List<string> letters = new List<string>();
            letters.Add("a");
            letters.Add("b");
            letters.Add("c");
            letters.Add("d");
            Console.WriteLine("Please pick a letter A - D:");
            string getLetter = Console.ReadLine();
            //find the first instance of user input in list
            int indexL = letters.FindIndex(a => a.Contains(getLetter));
            // if user input is valid
            if (indexL != -1)
            {   //display index of element
                Console.WriteLine(getLetter + " is #" + indexL + " in the list!");
            }
            else // otherwise
            {   // display input was invalid
                Console.WriteLine(getLetter + " is not a valid letter");
            }
            // Create a list of values
            List<string> colors = new() { "red", "blue", "green", "blue" };
            Console.WriteLine("Pick one of these colors: red, blue, or green");
            string getColor = Console.ReadLine();
            //Loop over items in list 
            for (int i = 0; i < colors.Count; i++)
            {   //if color entered by user matches color in list 
                if (colors[i] == getColor)
                {   //display index value of matching element
                    Console.WriteLine("color was found at " + i);
                }
            }

            // Create a list of strings with a duplicate item
            List<string> names = new() { "Heather", "Carter", "Morgan", "Heather" };
            //backup list of strings that starts empty
            List<string> namesCopy = new List<string>();

            //iterates through the main-list of names
            foreach (string item in names)
            {
                //if the backup list contains the current item from the main list...
                if (namesCopy.Contains(item))
                {
                    //display a message saying the item has appeared: before
                    Console.WriteLine("The item " + item + " has appeared before");
                }
                //otherwise, if the backup list does NOT contain the current item from the main list...
                else
                {
                    //display a message saying it has NOT appeared- before
                    Console.WriteLine("The item " + item + " has NOT appeared before");
                }
                //take the current item from the main "names" list, and add it to the "namescopy" backup list
                namesCopy.Add(item);
            }

            Console.ReadLine();
        }
    }
}
