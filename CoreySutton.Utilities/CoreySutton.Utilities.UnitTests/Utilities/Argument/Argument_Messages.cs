using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreySutton.Utilities.UnitTests
{
    [TestClass]
    public class Argument_Messages
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
                new ArgumentNullException(nameof(obj)).Message,
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
                new ArgumentNullException(Argument.DefaultArgumentName).Message,
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
    }
}
