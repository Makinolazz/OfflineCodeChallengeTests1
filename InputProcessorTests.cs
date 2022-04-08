using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfflineCodeChallenge;
using System;
using System.Collections.Generic;
using System.Text;

namespace OfflineCodeChallenge.Tests
{
    [TestClass()]
    public class InputProcessorTests
    {
        [TestMethod()]
        public void ProcessInput_Sums_Two_String_Inputs()
        {
            // Arrange
            var processor = new InputProcessor();

            // Act
            var actual = processor.ProcessInput("11","11");

            // Assert
            Assert.AreEqual("22", actual);
        }

        [TestMethod()]
        public void ProcessInput_Sums_Two_Int_Inputs()
        {
            // Arrange
            var processor = new InputProcessor();

            // Act
            var actual = processor.ProcessInput(11, 11);

            // Assert
            Assert.AreEqual("22", actual);
        }

        [TestMethod()]
        public void ProcessInput_Sums_Two_String_Inputs_Different_Size()
        {
            // Arrange
            var processor = new InputProcessor();

            // Act
            var actual = processor.ProcessInput("1111", "11");

            // Assert
            Assert.AreEqual("2211", actual);
        }

        [TestMethod()]
        public void ProcessInput_Sums_Two_Int_Inputs_Different_Size()
        {
            // Arrange
            var processor = new InputProcessor();

            // Act
            var actual = processor.ProcessInput(1111, 11);

            // Assert
            Assert.AreEqual("2211", actual);
        }

        [TestMethod()]
        public void ProcessInput_Sums_Two_Negative_String_Inputs()
        {
            // Arrange
            var processor = new InputProcessor();

            // Act
            var actual = processor.ProcessInput("-11", "-11");

            // Assert
            Assert.AreEqual("-2-2", actual);
        }

        [TestMethod()]
        public void ProcessInput_Sums_Two_Negative_Int_Inputs()
        {
            // Arrange
            var processor = new InputProcessor();

            // Act
            var actual = processor.ProcessInput(-11, -11);

            // Assert
            Assert.AreEqual("-2-2", actual);
        }

        [TestMethod()]
        public void ProcessInput_Sums_Two_Negative_String_Inputs_Different_Size()
        {
            // Arrange
            var processor = new InputProcessor();

            // Act
            var actual = processor.ProcessInput("-1111", "-11");

            // Assert
            Assert.AreEqual("-2-2-1-1", actual);
        }

        [TestMethod()]
        public void ProcessInput_Sums_Two_Negative_Int_Inputs_Different_Size()
        {
            // Arrange
            var processor = new InputProcessor();

            // Act
            var actual = processor.ProcessInput(-1111, -11);

            // Assert
            Assert.AreEqual("-2-2-1-1", actual);
        }

        [TestMethod()]
        public void ProcessInput_Sums_Positive_And_Negative_String_Inputs()
        {
            // Arrange
            var processor = new InputProcessor();

            // Act
            var actual = processor.ProcessInput("1111", "-11");

            // Assert
            Assert.AreEqual("0011", actual);
        }

        [TestMethod()]
        public void ProcessInput_Detects_Non_Numeric_String_Inputs_And_Returns_Message()
        {
            // Arrange
            var processor = new InputProcessor();

            // Act
            var actual = processor.ProcessInput("1ab1", "a11b");

            // Assert
            Assert.AreEqual("Invalid input data", actual);
        }

        [TestMethod()]
        public void ProcessInput_Detects_Empty_String_Inputs_And_Returns_Message()
        {
            // Arrange
            var processor = new InputProcessor();

            // Act
            var actual = processor.ProcessInput("", "");

            // Assert
            Assert.AreEqual("Empty Input", actual);
        }
    }
}