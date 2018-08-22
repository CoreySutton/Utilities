using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreySutton.Utilities.UnitTests
{
    [TestClass]
    public class Validator_IsNullOrEmpty
    {
        [TestMethod]
        public void IsNullOrEmpty_IEnumerable()
        {
            // Arrange
            IEnumerable notEmpty = new string[] { "one" };
            IEnumerable empty = new string[0];

            // Act / Assert  
            Assert.IsFalse(Validator.IsNullOrEmpty(notEmpty), "Expected true");
            Assert.IsTrue(Validator.IsNullOrEmpty(null), "Expected false");
            Assert.IsTrue(Validator.IsNullOrEmpty(empty), "Expected false");
        }

        [TestMethod]
        public void IsNullOrEmpty_IEnumerableGeneric()
        {
            // Arrange
            IEnumerable<string> notEmpty = new string[] { "one" };
            IEnumerable<string> empty = new string[0];

            // Act / Assert  
            Assert.IsFalse(Validator.IsNullOrEmpty(notEmpty), "Expected true");
            Assert.IsTrue(Validator.IsNullOrEmpty(null), "Expected false");
            Assert.IsTrue(Validator.IsNullOrEmpty(empty), "Expected false");
        }

        [TestMethod]
        public void IsNullOrEmpty_ICollection()
        {
            // Arrange
            ICollection notEmpty = new string[] { "one" };
            ICollection empty = new string[0];

            // Act / Assert  
            Assert.IsFalse(Validator.IsNullOrEmpty(notEmpty), "Expected true");
            Assert.IsTrue(Validator.IsNullOrEmpty(null), "Expected false");
            Assert.IsTrue(Validator.IsNullOrEmpty(empty), "Expected false");
        }

        [TestMethod]
        public void IsNullOrEmpty_IDictionary()
        {
            // Arrange
            IDictionary notEmpty = new Dictionary<int, string> { { 1, "one" } };
            IDictionary empty = new Dictionary<int, string>();

            // Act / Assert  
            Assert.IsFalse(Validator.IsNullOrEmpty(notEmpty), "Expected true");
            Assert.IsTrue(Validator.IsNullOrEmpty(null), "Expected false");
            Assert.IsTrue(Validator.IsNullOrEmpty(empty), "Expected false");
        }
    }
}
