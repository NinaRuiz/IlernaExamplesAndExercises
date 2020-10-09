using System;

namespace ConsoleApp3.CodeExercises
{
    public class Exercise1
    {
        // Exercise name.
        public static string ExerciseName = "Addition";

        /**
         * Solution method
         * PUT YOUR CODE INSIDE THIS METHOD
         */
        private static void Solution()
        {
            // PUT YOUR CODE HERE
            
        }
        
        /**
         * Run method
         * Write the header on the console.
         * It makes all the needed callbacks
         */
        public static void Run ()
        {
            // Shows example page on console
            Console.WriteLine("> Exercise " + ExerciseName);
            // Callback to the Example method
            Example();
            // Callback to the End method
            End();
        }
        
        /**
         * Example method
         * It shows on console the lines "Hello World!" and "Programming..."
         */
        public static void Example()
        {
            Console.WriteLine("Write a program that asks the user to say two numbers and add one number to the other.");
            Console.WriteLine("If you want a hint write 1\nIf you want more difficulty write 2\nIf you want to see the program write 0");
            var input = Console.ReadLine();
            if (input == null)
            {
                Console.Clear();
                Console.WriteLine("That's not an option.");
                Example();
                return;
            }

            var select = Int32.Parse(input);

            switch (select)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Remember that the method 'ReadLine' it saves an input into a variable.\n" +
                                      "To make any operation you can use the symbols: +, -, *, /.");
                    Example();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("What will happen if i write a letter?\n" +
                                      "What will happen if i don't write anything?\n" +
                                      "And if i want to see the subtraction, the multiplication and the division?\n" +
                                      "Make something that tells the user to write a number instead of a letter or anything.\n" +
                                      "You can also make the program to made every operation.");
                    Example();
                    break;
                case 0:
                    Console.Clear();
                    Solution();
                    Example();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("That's not an option.");
                    Example();
                    break;
            }
        }
        
        /**
         *  End method
         *  Return the user to the menu method.
         */
        public static void End()
        {
            // Jump to the next line and writ "Press enter to continue..." on the console.
            Console.WriteLine("\nPress enter to continue...");
            
            // Save the key value on to a variable named "key"
            var key = Console.ReadLine();
            
            // If key doesn't have any key inside...
            if (key == null)
            {
                // Clear all lines of the console.
                Console.Clear();
                
                // It returns to the menu method i made on Program.cs file
                // Callback to the menu method on Program.cs
                Program.MenuExamples();
                return;
            }
            
            // Clear all lines of the console.
            Console.Clear();
            
            // It returns to the menu method i made on Program.cs file
            // Callback to the menu method on Program.cs
            Program.MenuExamples();
        }
    }
}