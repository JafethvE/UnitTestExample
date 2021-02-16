using System;
using System.Collections.Generic;

namespace UnitTestExampleProgramme
{
    public class Calculator
    {
        private static List<double> GetValuesFromFile(string filePath)
        {
            List<double> values = new List<double>();
            string[] fileInputs = { };
            try
            {
                fileInputs = FileReader.GetLinesFromTextFile(filePath);
            }
            catch (Exception e)
            {
                throw e;
            }

            if (fileInputs.Length == 0)
            {
                Console.WriteLine("Please fill in the numbers.txt file found with this programme.");
                return null;
            }


            foreach (string fileInput in fileInputs)
            {
                try
                {
                    values.Add(Double.Parse(fileInput));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong while parsing the value {0}.\n", fileInput);
                    Console.WriteLine(e.Message);
                }
            }

            return values;
        }

        public static double Add(string filePath)
        {
            List<double> values = GetValuesFromFile(filePath);
            double result = 0.0;
            foreach(double value in values)
            {
                result += value;
            }
            return result;
        }

        public static double Multiply(string filePath)
        {
            List<double> values = GetValuesFromFile(filePath);
            double result = values[0];
            for(int i = 1; i < values.Count; i++)
            {
                result *= values[i];
            }
            return result;
        }

        public static double Subtract(string filePath)
        {
            List<double> values = GetValuesFromFile(filePath);
            double result = values[0];
            for (int i = 1; i < values.Count; i++)
            {
                result -= values[i];
            }
            return result;
        }

        public static double Average(string filePath)
        {
            List<double> values = GetValuesFromFile(filePath);
            double sum = Add(filePath);
            return sum / values.Count;
        }
    }
}
