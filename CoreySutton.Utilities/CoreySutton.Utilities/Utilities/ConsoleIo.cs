using System;
using System.Security;

namespace CoreySutton.Utilities
{
    public static class ConsoleIo
    {
        public static bool GetYesNo(string promptMsg, string emptyInputErrMsg, string notYesNoErrMsg)
        {
            while (true)
            {
                Console.Write(promptMsg);

                string inputLine = Console.ReadLine();
                inputLine = inputLine?.ToLower();

                if (string.IsNullOrEmpty(inputLine))
                {
                    Console.WriteLine(emptyInputErrMsg);
                }
                else if (inputLine == "yes" || inputLine == "y")
                {
                    return true;
                }
                else if (inputLine == "no" || inputLine == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine(notYesNoErrMsg);
                }
            }
        }

        public static SecureString GetSecureString(string promptMsg)
        {
            var pwd = new SecureString();
            //string pass = string.Empty;
            Console.Write(promptMsg);
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Backspace Should Not Work
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    //pass += key.KeyChar;
                    pwd.AppendChar(key.KeyChar);
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && pwd.Length > 0)
                    {
                        //pass = pass.Substring(0, pass.Length - 1);
                        pwd.RemoveAt(pwd.Length - 1);
                        Console.Write("\b \b");
                    }
                }
            }
            // Stops Receiving Keys Once Enter is Pressed
            while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();
            return pwd;
        }
    }
}
