using System;
using System.Collections.Generic;
using ConsoleApp3;
using ConsoleApp3.CodeExamples;

namespace ConsoleApp3
{
    class Program
    {
        private static List<string> Examples = new List<string>();
        private static int _examplesNum = 0;

        static void Main(string[] args)
        {    
            CreateExamplesList();
            Menu();
        }    

        public static void Menu()
        {
            Console.WriteLine("> Menu: ");
            foreach (var example in Examples)
            {
                Console.WriteLine(example);
            }
            Console.WriteLine("Write the number of the example you want to see:");

            var input = Console.ReadLine();
            var select = 0;
            if (input == null)
            {
                Console.WriteLine("You must choose.");
                Menu();
                return;
            }
            
            select = Int32.Parse(input);
            
            switch (select)
            {
                case 0:
                    break;
                case 1:
                    Console.Clear();
                    Example1.Run();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("That example doesn't exist.");
                    Menu();
                    break;
            }
        }

        static void CreateExamplesList()
        {
            AddExample(Example1.ExamplePage);
            Examples.Add("0 Exit");
        }

        private static void AddExample(string page)
        {
            _examplesNum++;
            Examples.Add(_examplesNum + " Example " + page);
        }
    }
}