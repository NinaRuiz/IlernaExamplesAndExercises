using System;
using ConsoleApp3;

namespace ConsoleApp3.CodeExamples
{
    /**
     * Example of page 16.1
     * Shows on console:
     *     Hello World!
     *     Programming...
     */
    public class Example1
    {
        // Example page to show it on console.
        public static string ExamplePage = "p. 16.1";
        
        /**
         * Run method
         * Write the header on the console.
         * It makes all the needed callbacks
         */
        public static void Run ()
        {
            // Shows example page on console
            Console.WriteLine("> Example on: " + ExamplePage);
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
            // Shows on console "Hello World!" and then jump to the next line.
            Console.WriteLine("Hello World!");
            // Shows on console "Programing...", it doesn't jump to next line, if we write another 
            // thing on console, it will continue the text on the same line.
            Console.Write("Programming...");
            
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