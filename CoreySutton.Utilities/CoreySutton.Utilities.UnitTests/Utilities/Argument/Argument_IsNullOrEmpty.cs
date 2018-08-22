using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreySutton.Utilities.UnitTests
{
    [TestClass]
    public class Argument_IsNullOrEmpty
    {
        [TestMethod]
        public void IsNotNullOfEmpty_IEnumerable()
        {
            // Arrange
            IEnumerable notEmpty = new[] { "one", "two", "three" };
            IEnumerable empty = new string[0];

            // Act / Assert
            Argument.IsNotNullOrEmpty(notEmpty);
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsNotNullOrEmpty(empty));
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsNotNullOrEmpty((IEnumerable)null));

            // assert  
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
        public void IsNotNullOfEmpty_IEnumerableGeneric()
        {
            // Arrange
            IEnumerable<string> notEmpty = new[] { "one", "two", "three" };
            IEnumerable<string> empty = new string[0];

            // Act / Assert
            Argument.IsNotNullOrEmpty(notEmpty);
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsNotNullOrEmpty(empty));
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsNotNullOrEmpty((IEnumerable<string>)null));

            // assert  
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
        public void IsNotNullOfEmpty_IDictionary()
        {
            // Arrange
            IDictionary notEmpty = new Dictionary<int, string>();
            notEmpty.Add(1, "one");
            notEmpty.Add(2, "two");
            notEmpty.Add(3, "three");

            IDictionary empty = new Dictionary<int, string>();

            // Act / Assert
            Argument.IsNotNullOrEmpty(notEmpty);
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsNotNullOrEmpty(empty));
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsNotNullOrEmpty((IDictionary)null));

            // assert  
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
        public void IsNotNullOfEmpty_ICollection()
        {
            // Arrange
            ICollection notEmpty = new[] { "one", "two", "three" };
            ICollection empty = new string[0];

            // Act / Assert
            Argument.IsNotNullOrEmpty(notEmpty);
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsNotNullOrEmpty(empty));
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsNotNullOrEmpty((ICollection)null));

            // assert  
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
        public void IsNotNullOfEmpty_String()
        {
            // Arrange
            string notEmpty = "one";
            string empty = string.Empty;

            // Act / Assert
            Argument.IsNotNullOrEmpty(notEmpty);
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Argument.IsNotNullOrEmpty(empty));
            var exceptionNull = Assert.ThrowsException<ArgumentNullException>(
               () => Argument.IsNotNullOrEmpty((string)null));

            // assert  
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
