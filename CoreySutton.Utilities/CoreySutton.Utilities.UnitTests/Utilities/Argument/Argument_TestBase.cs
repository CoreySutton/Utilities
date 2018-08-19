using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreySutton.Utilities.UnitTests
{
    [TestClass]
    public class Argument_TestBase
    {
        protected string GetArgumentNullExceptionMessage(string argumentName)
        {
            return $"Value cannot be null.\r\nParameter name: {argumentName}";
        }
    }
}
