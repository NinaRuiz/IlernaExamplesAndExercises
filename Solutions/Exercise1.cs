using System;

namespace ConsoleApp3.Solutions
{
    public class Exercise1
    {
        public static void SolutionEASY()
        {
            // Show "Write a number" throw the console.
            Console.WriteLine("Write a number: ");
            
            // Save the input number into a string variable named "input1"
            string input1 = Console.ReadLine();
            
            // Change the input1 type to integer and saved it into a integer variable named "num1"
            int num1 = Int32.Parse(input1);
            
            // Show "Write another number" throw the console.
            Console.WriteLine("Write another number: ");
            
            // Save the input number into a string variable named "input2"
            string input2 = Console.ReadLine();
            
            // Change the input1 type to integer and saved it into a integer variable named "num2"
            int num2 = Int32.Parse(input2);
            
            // Num1 plus Num2, save the result into a integer variable named "result"
            int result = num1 + num2;
            
            // Show the result throw the console
            Console.WriteLine("Result: " + result);
        }
        
        public static void SolutionHARD()
        {

            // Show "Write a number" throw the console.
            Console.WriteLine("Write a number: ");
            
            // Save the input number into a string variable named "input1"
            string input1 = Console.ReadLine();
            
            // If the input is null try again
            // It will do it till input1 has something in it
            while (input1 == null)
            {
                // Show "You must write something" to the console
                Console.WriteLine("You must write something.");
                
                // Save the input number into the variable "input1"
                input1 = Console.ReadLine();
            }
            
            // Declare num1
            int num1;
            
            // Verify input is a number
            bool isNumber1 = int.TryParse(input1, out num1);
    
            // While isNumber won't be true, try again
            while (!isNumber1)
            {
                input1 = Console.ReadLine();
                isNumber1 = int.TryParse(input1, out num1);
            }
            
            // Show "Write another number" throw the console.
            Console.WriteLine("Write another number: ");
            
            // Save the input number into a string variable named "input2"
            string input2 = Console.ReadLine();
            
            // If the input is null try again
            // It will do it till input1 has something in it
            while (input2 == null)
            {
                // Show "You must write something" to the console
                Console.WriteLine("You must write something.");
                
                // Save the input number into the variable "input1"
                input2 = Console.ReadLine();
            }
            
            // Declare num1
            int num2;
            
            // Verify input is a number
            bool isNumber2 = int.TryParse(input1, out num2);
    
            // While isNumber won't be true, try again
            while (!isNumber2)
            {
                input1 = Console.ReadLine();
                isNumber2 = int.TryParse(input1, out num1);
            }

            // Save the result into a integer variable named "result"
            int resultSum = num1 + num2;
            int resultRest = num1 - num2;
            int resultMult = num1 * num2;
            int resultDiv = num1 / num2;

            // Show the result throw the console
            Console.WriteLine("Result Addition: " + resultSum);
            Console.WriteLine("Result Subtraction: " + resultRest);
            Console.WriteLine("Result Multiplication: " + resultMult);
            Console.WriteLine("Result Difference: " + resultDiv);
        }
    }
}