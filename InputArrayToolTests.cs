using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfflineCodeChallenge;
using System;
using System.Collections.Generic;
using System.Text;

namespace OfflineCodeChallenge.Tests
{
    [TestClass()]
    public class InputArrayToolTests
    {
        [TestMethod()]
        public void BuildIntArray_Returns_An_Int_Array_From_String()
        {
            // Arrange
            var input = "123";

            // Act
            var actual = InputArrayTool.BuildIntArray(input);

            // Assert
            Assert.AreEqual(3, actual.Length);
        }

        [TestMethod()]
        public void SetNegativeValues_Returns_An_Int_Array_With_Negative_Values()
        {
            // Arrange
            var input = new int[] { 1 };

            // Act
            var actual = InputArrayTool.SetNegativeValues(input);

            // Assert
            Assert.AreEqual(-1, actual[0]);
        }

        [TestMethod()]
        public void SumArraysItems_Returns_The_Sums_Of_Items_In_Matching_Positions()
        {
            // Arrange
            var inputA = new int[] { 1 };
            var inputB = new int[] { 1 };

            // Act
            var actual = InputArrayTool.SumArraysItems(inputA, inputB);

            // Assert
            Assert.AreEqual(2, actual[0]);
        }
    }
}