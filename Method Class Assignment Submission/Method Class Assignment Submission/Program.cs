using System;

namespace Method_Class_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathOperations mathOp = new MathOperations();

            //Math operation on num1
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number * 5 equal: " + num1 * 5);

            //Call the method in the class, passing in two numbers
            mathOp.Numbers(5, 15);

            DisplayInfo(number: 30);

            Console.ReadLine();
        }
        static void DisplayInfo(int number)
        {
            Console.WriteLine($"Number: {number}");
        }
    }
}