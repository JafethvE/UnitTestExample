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
        public void TestDefaultConstructor()
        {
            calculator = new Calculator();
            Assert.IsNotNull(calculator.fileReader);
        }

        [TestMethod]
        public void TestOverloadedConstructor()
        {
            FileReader fileReader = new FileReader();
            calculator = new Calculator(fileReader);
            Assert.AreEqual(fileReader, calculator.fileReader);
        }

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

        [TestMethod]
        public void TestAdditionWithPositiveAndNegativeNumbers()
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
        public void TestAdditionWithOnlyNegativeNumbers()
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
        public void TestSubtractionWithOnlyPositiveNumbers()
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
        public void TestSubtractionWithPositiveAndNegativeNumbers()
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
        public void TestSubtractionWithOnlyNegativeNumbers()
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
        public void TestMultiplicationWithOnlyPositiveNumbers()
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
        public void TestMultiplicationWithPositiveAndNegativeNumbers()
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
        public void TestMultiplicationWithOnlyNegativeNumbers()
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
        public void TestAverageWithOnlyPositiveNumbers()
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
        public void TestAverageWithPositiveAndNegativeNumbers()
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
        public void TestAverageWithOnlyNegativeNumbers()
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
    }
}
