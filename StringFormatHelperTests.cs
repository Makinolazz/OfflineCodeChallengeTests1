using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfflineCodeChallenge;
using System;
using System.Collections.Generic;
using System.Text;

namespace OfflineCodeChallenge.Tests
{
    [TestClass()]
    public class StringFormatHelperTests
    {
        [TestMethod()]
        public void RemoveMinusSign_And_Returns_String()
        {
            // Arrange
            var input = "-1";

            // Act
            var actual = StringFormatHelper.RemoveMinusSign(input);

            // Assert
            Assert.AreEqual("1", actual);
        }
    }
}