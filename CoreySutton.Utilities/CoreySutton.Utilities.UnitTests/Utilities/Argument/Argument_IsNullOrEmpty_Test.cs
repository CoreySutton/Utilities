using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreySutton.Utilities.UnitTests
{
    [TestClass]
    public class Argument_IsNullOrEmpty_Test : Argument_TestBase
    {
        [TestMethod]
        public void IsNotNullOfEmpty_IEnumerable()
        {
            // Arrange
            IEnumerable notEmpty = new string[] { "one", "two", "three" };
            IEnumerable empty = new string[0];
            IEnumerable nullEnumerable = null;

            // Act / Assert
            Argument.IsNotNullOrEmpty(notEmpty);
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsNotNullOrEmpty(empty));
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsNotNullOrEmpty(nullEnumerable));

            // assert  
            Assert.AreEqual(
                exceptionEmpty.Message,
                GetArgumentNullExceptionMessage(Argument.DefaultArgumentName),
                "Incorrect exception message");
            Assert.AreEqual(
                exceptionNull.Message,
                GetArgumentNullExceptionMessage(Argument.DefaultArgumentName),
                "Incorrect exception message");
        }

        [TestMethod]
        public void IsNotNullOfEmpty_IEnumerableGeneric()
        {
            // Arrange
            IEnumerable<string> notEmpty = new string[] { "one", "two", "three" };
            IEnumerable<string> empty = new string[0];
            IEnumerable<string> nullEnumerable = null;

            // Act / Assert
            Argument.IsNotNullOrEmpty(notEmpty);
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsNotNullOrEmpty(empty));
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsNotNullOrEmpty(nullEnumerable));

            // assert  
            Assert.AreEqual(
                exceptionEmpty.Message,
                GetArgumentNullExceptionMessage(Argument.DefaultArgumentName),
                "Incorrect exception message");
            Assert.AreEqual(
                exceptionNull.Message,
                GetArgumentNullExceptionMessage(Argument.DefaultArgumentName),
                "Incorrect exception message");
        }

        [TestMethod]
        public void IsNotNullOfEmpty_IDictionary()
        {
            // Arrange
            IDictionary notEmpty = new Dictionary<int, string>();
            notEmpty.Add(1, "one");
            notEmpty.Add(2, "two");
            notEmpty.Add(3, "three");

            IDictionary empty = new Dictionary<int, string>();
            IDictionary nullDictionary = null;

            // Act / Assert
            Argument.IsNotNullOrEmpty(notEmpty);
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsNotNullOrEmpty(empty));
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsNotNullOrEmpty(nullDictionary));

            // assert  
            Assert.AreEqual(
                exceptionEmpty.Message,
                GetArgumentNullExceptionMessage(Argument.DefaultArgumentName),
                "Incorrect exception message");
            Assert.AreEqual(
                exceptionNull.Message,
                GetArgumentNullExceptionMessage(Argument.DefaultArgumentName),
                "Incorrect exception message");
        }

        [TestMethod]
        public void IsNotNullOfEmpty_ICollection()
        {
            // Arrange
            ICollection notEmpty = new string[] { "one", "two", "three" };
            ICollection empty = new string[0];
            ICollection nullCollection = null;

            // Act / Assert
            Argument.IsNotNullOrEmpty(notEmpty);
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsNotNullOrEmpty(empty));
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsNotNullOrEmpty(nullCollection));

            // assert  
            Assert.AreEqual(
                exceptionEmpty.Message,
                GetArgumentNullExceptionMessage(Argument.DefaultArgumentName),
                "Incorrect exception message");
            Assert.AreEqual(
                exceptionNull.Message,
                GetArgumentNullExceptionMessage(Argument.DefaultArgumentName),
                "Incorrect exception message");
        }

        [TestMethod]
        public void IsNotNullOfEmpty_String()
        {
            // Arrange
            string notEmpty = "one";
            string empty = string.Empty;
            string nullString = null;

            // Act / Assert
            Argument.IsNotNullOrEmpty(notEmpty);
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsNotNullOrEmpty(empty));
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
               () => Argument.IsNotNullOrEmpty(nullString));

            // assert  
            Assert.AreEqual(
                exceptionEmpty.Message,
                GetArgumentNullExceptionMessage(Argument.DefaultArgumentName),
                "Incorrect exception message");
            Assert.AreEqual(
                exceptionNull.Message,
                GetArgumentNullExceptionMessage(Argument.DefaultArgumentName),
                "Incorrect exception message");
        }
    }
}
