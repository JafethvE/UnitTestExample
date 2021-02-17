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
        public void DefaultConstructorShouldInitialiseWithFileReader()
        {
            calculator = new Calculator();
            Assert.IsNotNull(calculator.fileReader);
        }

        [TestMethod]
        public void OverloadedConstructorShouldInitialiseWithCorrectFileReader()
        {
            FileReader fileReader = new FileReader();
            calculator = new Calculator(fileReader);
            Assert.AreEqual(fileReader, calculator.fileReader);
        }

        [TestMethod]
        public void AdditionWithOnlyPositiveNumbersShouldReturn()
        {
            
            List<string> values = new List<string>();
            values.Add("1");
            values.Add("1");
            Mock<FileReader> fileReader = new Mock<FileReader>();
            fileReader.Setup(x => x.GetLinesFromTextFile(filePath)).Returns(values.ToArray);
            calculator = new Calculator(fileReader.Object);
            Assert.AreEqual(2, calculator.Add(filePath));
        }

        [TestMethod]
        public void AdditionWithPositiveAndNegativeNumbersShouldReturn()
        {
            List<string> values = new List<string>();
            values.Add("1");
            values.Add("-1");
            Mock<FileReader> fileReader = new Mock<FileReader>();
            fileReader.Setup(x => x.GetLinesFromTextFile(filePath)).Returns(values.ToArray);
            calculator = new Calculator(fileReader.Object);
            Assert.AreEqual(0, calculator.Add(filePath));
        }

        [TestMethod]
        public void AdditionWithOnlyNegativeNumbersShouldReturn()
        {
            List<string> values = new List<string>();
            values.Add("-1");
            values.Add("-1");
            Mock<FileReader> fileReader = new Mock<FileReader>();
            fileReader.Setup(x => x.GetLinesFromTextFile(filePath)).Returns(values.ToArray);
            calculator = new Calculator(fileReader.Object);
            Assert.AreEqual(-2, calculator.Add(filePath));
        }

        [TestMethod]
        public void SubtractionWithOnlyPositiveNumbersShouldReturn()
        {

            List<string> values = new List<string>();
            values.Add("1");
            values.Add("1");
            Mock<FileReader> fileReader = new Mock<FileReader>();
            fileReader.Setup(x => x.GetLinesFromTextFile(filePath)).Returns(values.ToArray);
            calculator = new Calculator(fileReader.Object);
            Assert.AreEqual(0, calculator.Subtract(filePath));
        }

        [TestMethod]
        public void SubtractionWithPositiveAndNegativeNumbersShouldReturn()
        {
            List<string> values = new List<string>();
            values.Add("1");
            values.Add("-1");
            Mock<FileReader> fileReader = new Mock<FileReader>();
            fileReader.Setup(x => x.GetLinesFromTextFile(filePath)).Returns(values.ToArray);
            calculator = new Calculator(fileReader.Object);
            Assert.AreEqual(2, calculator.Subtract(filePath));
        }

        [TestMethod]
        public void SubtractionWithOnlyNegativeNumbersShouldReturn()
        {
            List<string> values = new List<string>();
            values.Add("-1");
            values.Add("-1");
            Mock<FileReader> fileReader = new Mock<FileReader>();
            fileReader.Setup(x => x.GetLinesFromTextFile(filePath)).Returns(values.ToArray);
            calculator = new Calculator(fileReader.Object);
            Assert.AreEqual(0, calculator.Subtract(filePath));
        }

        [TestMethod]
        public void MultiplicationWithOnlyPositiveNumbersShouldReturn()
        {

            List<string> values = new List<string>();
            values.Add("2");
            values.Add("2");
            Mock<FileReader> fileReader = new Mock<FileReader>();
            fileReader.Setup(x => x.GetLinesFromTextFile(filePath)).Returns(values.ToArray);
            calculator = new Calculator(fileReader.Object);
            Assert.AreEqual(4, calculator.Multiply(filePath));
        }

        [TestMethod]
        public void MultiplicationWithPositiveAndNegativeNumbersShouldReturn()
        {
            List<string> values = new List<string>();
            values.Add("2");
            values.Add("-2");
            Mock<FileReader> fileReader = new Mock<FileReader>();
            fileReader.Setup(x => x.GetLinesFromTextFile(filePath)).Returns(values.ToArray);
            calculator = new Calculator(fileReader.Object);
            Assert.AreEqual(-4, calculator.Multiply(filePath));
        }

        [TestMethod]
        public void MultiplicationWithOnlyNegativeNumbersShouldReturn()
        {
            List<string> values = new List<string>();
            values.Add("-2");
            values.Add("-2");
            Mock<FileReader> fileReader = new Mock<FileReader>();
            fileReader.Setup(x => x.GetLinesFromTextFile(filePath)).Returns(values.ToArray);
            calculator = new Calculator(fileReader.Object);
            Assert.AreEqual(4, calculator.Multiply(filePath));
        }

        [TestMethod]
        public void AverageWithOnlyPositiveNumbersShouldReturn()
        {
            List<string> values = new List<string>();
            values.Add("1");
            values.Add("2");
            values.Add("3");
            values.Add("4");
            values.Add("5");
            Mock<FileReader> fileReader = new Mock<FileReader>();
            fileReader.Setup(x => x.GetLinesFromTextFile(filePath)).Returns(values.ToArray);
            calculator = new Calculator(fileReader.Object);
            Assert.AreEqual(3, calculator.Average(filePath));
        }

        [TestMethod]
        public void AverageWithPositiveAndNegativeNumbersShouldReturn()
        {
            List<string> values = new List<string>();
            values.Add("1");
            values.Add("2");
            values.Add("3");
            values.Add("4");
            values.Add("-5");
            Mock<FileReader> fileReader = new Mock<FileReader>();
            fileReader.Setup(x => x.GetLinesFromTextFile(filePath)).Returns(values.ToArray);
            calculator = new Calculator(fileReader.Object);
            Assert.AreEqual(1, calculator.Average(filePath));
        }

        [TestMethod]
        public void AverageWithOnlyNegativeNumbersShouldReturn()
        {
            List<string> values = new List<string>();
            values.Add("-1");
            values.Add("-2");
            values.Add("-3");
            values.Add("-4");
            values.Add("-5");
            Mock<FileReader> fileReader = new Mock<FileReader>();
            fileReader.Setup(x => x.GetLinesFromTextFile(filePath)).Returns(values.ToArray);
            calculator = new Calculator(fileReader.Object);
            Assert.AreEqual(-3, calculator.Average(filePath));
        }

        [TestMethod]
        public void OperationWithZeroValuesShouldReturnZero()
        {
            List<string> values = new List<string>();
            Mock<FileReader> fileReader = new Mock<FileReader>();
            fileReader.Setup(x => x.GetLinesFromTextFile(filePath)).Returns(values.ToArray);
            calculator = new Calculator(fileReader.Object);
            Assert.AreEqual(0, calculator.Add(filePath));
            Assert.AreEqual(0, calculator.Subtract(filePath));
            Assert.AreEqual(0, calculator.Multiply(filePath));
            Assert.AreEqual(0, calculator.Average(filePath));
        }
    }
}
