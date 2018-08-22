using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreySutton.Utilities.UnitTests
{
    [TestClass]
    public class Validator_HasOneItem
    {
        [TestMethod]
        public void HasOneItem_IEnumerable()
        {
            // Arrange
            IEnumerable oneItem = new string[] { "one" };
            IEnumerable twoItem = new string[] { "one", "two" };
            IEnumerable empty = new string[0];

            // Act / Assert  
            Assert.IsFalse(Validator.HasOneItem(empty));
            Assert.IsTrue(Validator.HasOneItem(oneItem));
            Assert.IsFalse(Validator.HasOneItem(twoItem));
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Validator.HasOneItem(null));

            // Assert  
            Assert.AreEqual(
                exceptionEmpty.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");
        }

        [TestMethod]
        public void HasOneItem_IEnumerableGeneric()
        {
            // Arrange
            IEnumerable<string> oneItem = new string[] { "one" };
            IEnumerable<string> twoItem = new string[] { "one", "two" };
            IEnumerable<string> empty = new string[0];

            // Act / Assert  
            Assert.IsFalse(Validator.HasOneItem(empty));
            Assert.IsTrue(Validator.HasOneItem(oneItem));
            Assert.IsFalse(Validator.HasOneItem(twoItem));
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Validator.HasOneItem(null));

            // Assert  
            Assert.AreEqual(
                exceptionEmpty.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");
        }

        [TestMethod]
        public void HasOneItem_ICollection()
        {
            // Arrange
            ICollection oneItem = new string[] { "one" };
            ICollection twoItem = new string[] { "one", "two" };
            ICollection empty = new string[0];

            // Act / Assert  
            Assert.IsFalse(Validator.HasOneItem(empty));
            Assert.IsTrue(Validator.HasOneItem(oneItem));
            Assert.IsFalse(Validator.HasOneItem(twoItem));
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Validator.HasOneItem(null));

            // Assert  
            Assert.AreEqual(
                exceptionEmpty.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");
        }

        [TestMethod]
        public void HasOneItem_IDictionary()
        {
            // Arrange
            IDictionary oneItem = new Dictionary<int, string>();
            oneItem.Add(1, "one");
            IDictionary twoItem = new Dictionary<int, string>();
            twoItem.Add(1, "one");
            twoItem.Add(2, "two");
            IDictionary empty = new Dictionary<int, string>();

            // Act / Assert  
            Assert.IsFalse(Validator.HasOneItem(empty));
            Assert.IsTrue(Validator.HasOneItem(oneItem));
            Assert.IsFalse(Validator.HasOneItem(twoItem));
            var exceptionEmpty = Assert.ThrowsException<ArgumentNullException>(
                () => Validator.HasOneItem(null));

            // Assert  
            Assert.AreEqual(
                exceptionEmpty.Message,
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
                "Incorrect exception message");
        }
    }
}
