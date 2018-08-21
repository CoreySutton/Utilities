using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreySutton.Utilities.UnitTests
{
    [TestClass]
    public class Validator_IsNotNullAndHasOneItem
    {
        [TestMethod]
        public void IsNotNullAndHasOneItem_IEnumerable()
        {
            // Arrange
            IEnumerable oneItem = new string[] { "one" };
            IEnumerable twoItem = new string[] { "one", "two" };
            IEnumerable empty = new string[0];

            // Act / Assert  
            Assert.IsFalse(Validator.IsNotNullAndHasOneItem(empty));
            Assert.IsTrue(Validator.IsNotNullAndHasOneItem(oneItem));
            Assert.IsFalse(Validator.IsNotNullAndHasOneItem(twoItem));
            Assert.IsFalse(Validator.IsNotNullAndHasOneItem(null));
        }

        [TestMethod]
        public void IsNotNullAndHasOneItem_IEnumerableGeneric()
        {
            // Arrange
            IEnumerable<string> oneItem = new string[] { "one" };
            IEnumerable<string> twoItem = new string[] { "one", "two" };
            IEnumerable<string> empty = new string[0];

            // Act / Assert  
            Assert.IsFalse(Validator.IsNotNullAndHasOneItem(empty));
            Assert.IsTrue(Validator.IsNotNullAndHasOneItem(oneItem));
            Assert.IsFalse(Validator.IsNotNullAndHasOneItem(twoItem));
            Assert.IsFalse(Validator.IsNotNullAndHasOneItem(null));
        }

        [TestMethod]
        public void IsNotNullAndHasOneItem_ICollection()
        {
            // Arrange
            ICollection oneItem = new string[] { "one" };
            ICollection twoItem = new string[] { "one", "two" };
            ICollection empty = new string[0];

            // Act / Assert  
            Assert.IsFalse(Validator.IsNotNullAndHasOneItem(empty));
            Assert.IsTrue(Validator.IsNotNullAndHasOneItem(oneItem));
            Assert.IsFalse(Validator.IsNotNullAndHasOneItem(twoItem));
            Assert.IsFalse(Validator.IsNotNullAndHasOneItem(null));
        }

        [TestMethod]
        public void IsNotNullAndHasOneItem_IDictionary()
        {
            // Arrange
            IDictionary oneItem = new Dictionary<int, string>();
            oneItem.Add(1, "one");
            IDictionary twoItem = new Dictionary<int, string>();
            twoItem.Add(1, "one");
            twoItem.Add(2, "two");
            IDictionary empty = new Dictionary<int, string>();

            // Act / Assert  
            Assert.IsFalse(Validator.IsNotNullAndHasOneItem(empty));
            Assert.IsTrue(Validator.IsNotNullAndHasOneItem(oneItem));
            Assert.IsFalse(Validator.IsNotNullAndHasOneItem(twoItem));
            Assert.IsFalse(Validator.IsNotNullAndHasOneItem(null));
        }
    }
}
