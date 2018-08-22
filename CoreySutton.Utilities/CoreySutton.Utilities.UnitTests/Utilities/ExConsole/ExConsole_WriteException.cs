using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreySutton.Utilities.UnitTests
{
    [TestClass]
    public class ExConsole_WriteException
    {
        [TestMethod]
        public void WriteException_DepthOne()
        {
            string exceptionMessage = "A test exception occurred";
            string path = Directory.GetCurrentDirectory();
            path = Path.GetFullPath(Path.Combine(path, @"..\..\"));

            try
            {
               throw new Exception(exceptionMessage);
            }
            catch(Exception ex)
            {
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    ExConsole.Write(ex);

                    string expected = string.Empty;
                    expected += $"ERROR: {exceptionMessage}{Environment.NewLine}";
                    expected += $"Site: {ex.TargetSite}{Environment.NewLine}";
                    expected += $"Depth: 1{Environment.NewLine}";

                    expected += $"   at {nameof(CoreySutton)}" +
                        $".{nameof(Utilities)}" +
                        $".{nameof(UnitTests)}" +
                        $".{nameof(ExConsole_WriteException)}" +
                        $".{nameof(WriteException_DepthOne)}()" +
                        $" in {path}" +
                        @"Utilities\ExConsole\" + 
                        $"{nameof(ExConsole_WriteException)}.cs:line 23";

                    Assert.AreEqual(expected, sw.ToString());
                }
            }
        }
    }
}
