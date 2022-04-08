using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfflineCodeChallenge;
using System;
using System.Collections.Generic;
using System.Text;

namespace OfflineCodeChallenge.Tests
{
    [TestClass()]
    public class InputValidatorTests
    {
        [TestMethod()]
        public void IsEmptyInput_Returns_True_For_Empty_Strings()
        {
            // Arrange
            var input = String.Empty;

            // Act
            var actual = InputValidator.IsEmptyInput(input);

            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void IsEmptyInput_Returns_False_For_Not_Empty_Strings()
        {
            // Arrange
            var input = "not empty";

            // Act
            var actual = InputValidator.IsEmptyInput(input);

            // Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void IsNegativeInput_Returns_True_When_String_Starts_With_Minus_Sign()
        {
            // Arrange
            var input = "-123";

            // Act
            var actual = InputValidator.IsNegativeInput(input);

            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void IsNegativeInput_Returns_False_When_String_Dont_Start_With_Minus_Sign()
        {
            // Arrange
            var input = "123";

            // Act
            var actual = InputValidator.IsNegativeInput(input);

            // Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void HasInvalidData_Returns_True_When_Negative_Value_Found_In_Int_Array()
        {
            // Arrange
            var input = new int[] { 1, 2, -1 };

            // Act
            var actual = InputValidator.HasInvalidData(input);

            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void HasInvalidData_Returns_False_When_No_Negative_Value_Found_In_Int_Array()
        {
            // Arrange
            var input = new int[] { 1, 2, 3 };

            // Act
            var actual = InputValidator.HasInvalidData(input);

            // Assert
            Assert.AreEqual(false, actual);
        }
    }
}