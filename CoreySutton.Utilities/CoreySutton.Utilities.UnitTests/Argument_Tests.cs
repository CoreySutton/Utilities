using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreySutton.Utilities.UnitTests
{
    [TestClass]
    public class Argument_Tests
    {
        [TestMethod]
        public void NotNull_CustomMessage_ThrowsArgumentNullException()
        {
            // arrange
            object obj = null;

            // act  
            ArgumentNullException exception = Assert.ThrowsException<ArgumentNullException>(() => Argument.IsNotNull(obj, nameof(obj)));

            // assert  
            Assert.AreEqual(
                exception.Message,
                GetArgumentNullExceptionMessage(nameof(obj)),
                "Incorrect exception message");
        }

        [TestMethod]
        public void NotNull_DefaultMessage_ThrowsArgumentNullException()
        {
            // arrange
            object obj = null;

            // act  
            ArgumentNullException exception = Assert.ThrowsException<ArgumentNullException>(() => Argument.IsNotNull(obj));

            // assert  
            Assert.AreEqual(
                exception.Message,
                GetArgumentNullExceptionMessage(Argument.DefaultArgumentName),
                "Incorrect exception message");
        }

        [TestMethod]
        public void NotNull_DefaultMessage()
        {
            // arrange
            object obj = new object();

            // act
            Argument.IsNotNull(obj);
        }

        private string GetArgumentNullExceptionMessage(string argumentName)
        {
            return $"Value cannot be null.\r\nParameter name: {argumentName}";
        }
    }
}
