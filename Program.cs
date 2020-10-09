using System;
using System.Collections.Generic;
using ConsoleApp3.CodeExamples;
using ConsoleApp3.CodeExercises;

namespace ConsoleApp3
{
    class Program
    {
        private static List<string> Examples = new List<string>();
        private static List<string> Exercises = new List<string>();
        private static int _examplesNum = 0;
        private static int _exercisesNum = 0;

        static void Main(string[] args)
        {    
            
            
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine(">Menu: ");
            Console.WriteLine("1 Examples");
            Console.WriteLine("2 Exercises"); 
            Console.WriteLine("0 Exit");
            var input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("You must choose.");
                Menu();
                return;
            }
            var select = Int32.Parse(input);
            switch (select)
            {
                case 1:
                    Console.Clear();
                    MenuExamples();
                    break;
                case 2:
                    Console.Clear();
                    MenuExercises();
                    break;
                case 0:
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("That example doesn't exist.");
                    Menu();
                    break;
            }
        }

        public static void MenuExamples()
        {
            CreateExamplesList();
            Console.WriteLine("> Menu Examples: ");
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
                MenuExamples();
                return;
            }
            
            select = Int32.Parse(input);
            
            switch (select)
            {
                case 0:
                    Menu();
                    break;
                case 1:
                    Console.Clear();
                    Example1.Run();
                    break;
                case 2:
                    Console.Clear();
                    Example2.Run();
                    break;
                case 3:
                    Console.Clear();
                    Example3.Run();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("That example doesn't exist.");
                    MenuExamples();
                    break;
            }
        }
        
        public static void MenuExercises()
        {
            CreateExercisesList();
            Console.WriteLine("> Menu Exercises: ");
            foreach (var exercise in Exercises)
            {
                Console.WriteLine(exercise);
            }
            Console.WriteLine("Write the number of the example you want to see:");

            var input = Console.ReadLine();
            var select = 0;
            if (input == null)
            {
                Console.WriteLine("You must choose.");
                MenuExercises();
                return;
            }
            
            select = Int32.Parse(input);
            
            switch (select)
            {
                case 0:
                    Menu();
                    break;
                case 1:
                    Console.Clear();
                    Exercise1.Run();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("That exercise doesn't exist.");
                    MenuExercises();
                    break;
            }
        }

        static void CreateExamplesList()
        {
            AddExample(Example1.ExamplePage);
            AddExample(Example2.ExamplePage);
            AddExample(Example3.ExamplePage);
            Examples.Add("0 Menu");
        }
        
        static void CreateExercisesList()
        {
            AddExercise(Exercise1.ExerciseName);
            Exercises.Add("0 Menu");
        }
        
        private static void AddExercise(string name)
        {
            _exercisesNum++;
            Exercises.Add(_exercisesNum + " Exercise " + name);
        }
        
        private static void AddExample(string page)
        {
            _examplesNum++;
            Examples.Add(_examplesNum + " Example " + page);
        }
    }
}