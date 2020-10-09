using System;

namespace ConsoleApp3.CodeExamples
{
    /**
     * Example page 17
     * It saves different types of variables.
     *
     * I show the variables on console so it shows something.
     */
    public class Example3
    {
        // Example page to show it on console.
        public static string ExamplePage = "p. 17";
        
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
            // Create a integer variable named "numero"
            int numero;
            
            // Set number 10 to the variable "numero"
            numero = 10;
            
            // Create a character variable named "letra" and set char 'a' to the variable.
            char letra = 'a';
            
            // Create a string cariable named "cadena" and set string "Esta es una cadena" to the variable.
            string cadena = "Esta es una cadena";
            
            // Show all variables on console
            Console.WriteLine("Int: " + numero);
            Console.WriteLine("Char: " + letra);
            Console.WriteLine("String: " + cadena);
            
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