using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestExampleProgramme;
using Moq;
using System.Collections.Generic;

namespace UnitTestExampleTests
{
    [TestClass]
    public class CalculatorTest
    {
        private static string filePath = System.IO.Directory.GetCurrentDirectory() + "\\numbers.txt";

        private Calculator calculator;
        [TestMethod]
        public void TestAdditionWithOnlyPositiveNumbers()
        {
            
            List<string> values = new List<string>();
            values.Add("1");
            values.Add("1");
            Mock<FileReader> fileReader = new Mock<FileReader>();
            fileReader.Setup(x => x.GetLinesFromTextFile(filePath)).Returns(values.ToArray);
            calculator = new Calculator(fileReader.Object);
            Assert.AreEqual(2, calculator.Add(filePath));
        }
    }
}
