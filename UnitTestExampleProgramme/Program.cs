using System;

namespace UnitTestExampleProgramme
{
    class Program
    {
        private Calculator calculator = new Calculator();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            Operation operation;

            string filePath = System.IO.Directory.GetCurrentDirectory() + "\\numbers.txt";

            try
            {
                FileReader.CreateEmptyFile(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong while creating the numbers.txt file.");
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine("Welcome to our little calculator. Make sure to have filled in the numbers.text file that comes with this piece of software.");
            Console.WriteLine("Please choose from the following operations:");
            Console.WriteLine("Addition");
            Console.WriteLine("Subtraction");
            Console.WriteLine("Multiplication");
            Console.WriteLine("Average\n");

            string input = Console.ReadLine();

            try
            {
                operation = (Operation)Enum.Parse(typeof(Operation), input, true);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("{0} is not a valid operation, please choose a valid operation.", input);
                return;
            }

            switch (operation)
            {
                case Operation.Addition:
                    Console.WriteLine("The sum of the numbers you gave in the text file is {0}", calculator.Add(filePath));
                    break;
                case Operation.Subtraction:
                    Console.WriteLine("The result of the subtraction of the numbers in the text file is {0}", calculator.Subtract(filePath));
                    break;
                case Operation.Multiplication:
                    Console.WriteLine("The result of the multiplication of the numbers in the text file is {0}", calculator.Multiply(filePath));
                    break;
                case Operation.Average:
                    Console.WriteLine("The average of the numbers you gave in the text file is {0}", calculator.Average(filePath));
                    break;
            }

            try
            {
                FileReader.DeleteFile(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong while deleting the numbers.txt file.");
                Console.WriteLine(e.Message);
            }
        }
    }
}