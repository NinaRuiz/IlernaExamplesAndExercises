using System;

namespace ConsoleApp3.CodeExamples
{
    public class Example2
    {
        // Example page to show it on console.
        public static string ExamplePage = "p. 16";

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
            Console.WriteLine("\nPress a enter to continue...");
            var key = Console.ReadLine();
            if (key == null)
            {
                Console.Clear();
                Program.Menu();
                return;
            }
            // It returns to the menu method i made on Program.cs file
            // Callback to the menu method on Program.cs
            Console.Clear();
            Program.Menu();
        }
    }
}