using System;

namespace ConsoleApp3.CodeExamples
{
    /**
     * Example page 16.2
     * Shows on console:
     *     Introduce un dato.
     * And safe the data on a variable named "dato".
     */
    public class Example2
    {
        // Example page to show it on console.
        public static string ExamplePage = "p. 16.2";
        
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
            // Shows on console "Introduce un dato" and then jump to the next line.
            Console.WriteLine("Introduce un dato");
            
            // Save the data on a string variable named "dato"
            string dato = Console.ReadLine();

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
                Program.MenuExamples();
                return;
            }
            // It returns to the menu method i made on Program.cs file
            // Callback to the menu method on Program.cs
            Console.Clear();
            Program.MenuExamples();
        }
    }
}