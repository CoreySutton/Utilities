using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreySutton.Utilities.UnitTests
{
    [TestClass]
    public class Argument_IsGreaterThanOrEqualToZero
    {
        [TestMethod]
        public void IsGreaterThanOrEqualToZero_Long()
        {
            // Arrange
            long lessThanZero = -1L;
            long greaterThanZero = 1L;
            long zero = 0L;

            // Act / Assert
            Argument.IsGreaterThanOrEqualToZero(greaterThanZero);
            Argument.IsGreaterThanOrEqualToZero(zero);
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsGreaterThanOrEqualToZero(lessThanZero));

            // Assert
            Assert.AreEqual(
                exceptionNull.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");
        }

        [TestMethod]
        public void IsGreaterThanOrEqualToZero_Decimal()
        {
            // Arrange
            decimal lessThanZero = -1.0m;
            decimal greaterThanZero = 1.0m;
            decimal zero = 0.0m;

            // Act / Assert
            Argument.IsGreaterThanOrEqualToZero(greaterThanZero);
            Argument.IsGreaterThanOrEqualToZero(zero);
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsGreaterThanOrEqualToZero(lessThanZero));

            // Assert
            Assert.AreEqual(
                exceptionNull.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");
        }

        [TestMethod]
        public void IsGreaterThanOrEqualToZero_Float()
        {
            // Arrange
            float lessThanZero = -1.0f;
            float greaterThanZero = 1.0f;
            float zero = 0.0f;

            // Act / Assert
            Argument.IsGreaterThanOrEqualToZero(greaterThanZero);
            Argument.IsGreaterThanOrEqualToZero(zero);
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsGreaterThanOrEqualToZero(lessThanZero));

            // Assert  
            Assert.AreEqual(
                exceptionNull.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");
        }

        [TestMethod]
        public void IsGreaterThanOrEqualToZero_Double()
        {
            // Arrange
            double lessThanZero = -1.0d;
            double greaterThanZero = 1.0d;
            double zero = 0.0d;

            // Act / Assert
            Argument.IsGreaterThanOrEqualToZero(greaterThanZero);
            Argument.IsGreaterThanOrEqualToZero(zero);
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsGreaterThanOrEqualToZero(lessThanZero));

            // Assert  
            Assert.AreEqual(
                exceptionNull.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");
        }

        [TestMethod]
        public void IsGreaterThanOrEqualToZero_Int()
        {
            // Arrange
            int lessThanZero = -1;
            int greaterThanZero = 1;
            int zero = 0;

            // Act / Assert
            Argument.IsGreaterThanOrEqualToZero(greaterThanZero);
            Argument.IsGreaterThanOrEqualToZero(zero);
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsGreaterThanOrEqualToZero(lessThanZero));

            // Assert
            Assert.AreEqual(
                exceptionNull.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");
        }
    }
}
