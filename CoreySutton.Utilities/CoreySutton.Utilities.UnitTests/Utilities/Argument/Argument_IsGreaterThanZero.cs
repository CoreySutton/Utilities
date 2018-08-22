using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreySutton.Utilities.UnitTests
{
    [TestClass]
    public class Argument_IsGreaterThanZero
    {
        [TestMethod]
        public void IsGreaterThanZero_Long()
        {
            // Arrange
            long lessThanZero = -1L;
            long greaterThanZero = 1L;
            long zero = 0L;

            // Act / Assert
            Argument.IsGreaterThanZero(greaterThanZero);
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsGreaterThanZero(zero));
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsGreaterThanZero(lessThanZero));

            // Assert  
            Assert.AreEqual(
                exceptionEmpty.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");

            Assert.AreEqual(
                exceptionNull.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");
        }

        [TestMethod]
        public void IsGreaterThanZero_Decimal()
        {
            // Arrange
            decimal lessThanZero = -1.0m;
            decimal greaterThanZero = 1.0m;
            decimal zero = 0.0m;

            // Act / Assert
            Argument.IsGreaterThanZero(greaterThanZero);
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsGreaterThanZero(zero));
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsGreaterThanZero(lessThanZero));

            // Assert  
            Assert.AreEqual(
                exceptionEmpty.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");

            Assert.AreEqual(
                exceptionNull.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");
        }

        [TestMethod]
        public void IsGreaterThanZero_Float()
        {
            // Arrange
            float lessThanZero = -1.0f;
            float greaterThanZero = 1.0f;
            float zero = 0.0f;

            // Act / Assert
            Argument.IsGreaterThanZero(greaterThanZero);
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsGreaterThanZero(zero));
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsGreaterThanZero(lessThanZero));

            // Assert  
            Assert.AreEqual(
                exceptionEmpty.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");

            Assert.AreEqual(
                exceptionNull.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");
        }

        [TestMethod]
        public void IsGreaterThanZero_Double()
        {
            // Arrange
            double lessThanZero = -1.0d;
            double greaterThanZero = 1.0d;
            double zero = 0.0d;

            // Act / Assert
            Argument.IsGreaterThanZero(greaterThanZero);
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsGreaterThanZero(zero));
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsGreaterThanZero(lessThanZero));

            // Assert  
            Assert.AreEqual(
                exceptionEmpty.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");

            Assert.AreEqual(
                exceptionNull.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");
        }

        [TestMethod]
        public void IsGreaterThanZero_Int()
        {
            // Arrange
            int lessThanZero = -1;
            int greaterThanZero = 1;
            int zero = 0;

            // Act / Assert
            Argument.IsGreaterThanZero(greaterThanZero);
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsGreaterThanZero(zero));
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsGreaterThanZero(lessThanZero));

            // Assert  
            Assert.AreEqual(
                exceptionEmpty.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");

            Assert.AreEqual(
                exceptionNull.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");
        }
    }
}
