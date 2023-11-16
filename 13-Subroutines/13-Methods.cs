using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

/*
===============================================================================
PROJECT 13: METHODS
===============================================================================
Objective:
- Understand and practice creating and calling methods in C#.

Main Tasks:
1. Create a method called "SayHello" to print the message "Hello World".
2. Create a method called "Exit" to print the message "Press any key to exit..." and wait for user input.

Questions:
1. What is a method?
2. What does the 'void' keyword mean?
3. What does it mean to 'call' a method?

Extension Tasks:
1. Try creating extra methods that do whatever you like.
2. Try calling the methods multiple times.
3. Try calling methods from within another method.

Additional Resources:
- Methods: https://www.tutorialspoint.com/csharp/csharp_methods.htm
- Methods: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_13_Methods
    {
        static void Main(string[] args)
        {
            // Call the methods here
            hello();
            bye();
            Wait();
        }

        // Write your methods here
        static void Wait()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("press any key to continue...");
            Console.ReadLine();
        }

        static void hello()
        {
            Console.WriteLine("please enter name");
            string name = Console.ReadLine();
            Console.WriteLine("hello exho");

          
        }

        static void bye()
        {
            Console.WriteLine("bye");
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/