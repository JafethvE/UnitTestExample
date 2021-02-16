using System.Collections.Generic;

namespace UnitTestExampleProgramme
{
    class Calculator
    {
        public static double Add(List<double> doubles)
        {
            double result = 0.0;
            foreach(double value in doubles)
            {
                result += value;
            }
            return result;
        }

        public static double Multiply(List<double> doubles)
        {
            double result = doubles[0];
            for(int i = 1; i < doubles.Count; i++)
            {
                result *= doubles[i];
            }
            return result;
        }

        public static double Subtract(List<double> doubles)
        {
            double result = doubles[0];
            for (int i = 1; i < doubles.Count; i++)
            {
                result -= doubles[i];
            }
            return result;
        }

        public static double Average(List<double> doubles)
        {
            double sum = Add(doubles);
            return sum / doubles.Count;
        }
    }
}
