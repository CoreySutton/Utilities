using System;
using System.Collections;
using System.Linq;

namespace CoreySutton.Utilities
{
    /// <summary>
    /// Wrapper for SystemConsole
    /// </summary>
    public static class ExConsole
    {
        private static ConsoleColor _defaultColor = ConsoleColor.Gray;

        public static void Write(string message, bool timestamp = false)
        {
            if (timestamp) WriteTimestamp();
            Console.Write(message);
        }

        public static void WriteLine(string message, bool timestamp = false)
        {
            if (timestamp) WriteTimestamp();
            Console.WriteLine(message);
        }

        public static void WriteLineToRight(string value)
        {
            if (string.IsNullOrEmpty(value)) return;

            int valueLength = value.Length;

            Console.CursorLeft = Console.BufferWidth - valueLength - 1;
            Console.WriteLine(value);
        }

        public static void WriteColor(
            string value, 
            ConsoleColor color, 
            bool timestamp = false)
        {
            if (string.IsNullOrEmpty(value)) return;

            Console.ForegroundColor = color;
            if (timestamp) WriteTimestamp();
            Console.Write(value);
            Console.ForegroundColor = _defaultColor;
        }

        public static void WriteLineColor(
            string value, 
            ConsoleColor color, 
            bool timestamp = false)
        {
            if (string.IsNullOrEmpty(value)) return;

            Console.ForegroundColor = color;
            if (timestamp) WriteTimestamp();
            Console.WriteLine(value);
            Console.ForegroundColor = _defaultColor;
        }

        public static void Write(Exception ex)
        {
            Argument.IsNotNull(ex);

            WriteException(ex, 1);
        }

        private static void WriteException(Exception ex, int depth)
        {
            if (depth > 1) Console.WriteLine();

            Console.WriteLine($"ERROR: {ex.Message}");
            Console.WriteLine($"Site: {ex.TargetSite}");
            Console.WriteLine($"Depth: {depth}");
            WriteColor(ex.StackTrace, ConsoleColor.DarkGray);

            if (ex.Data.Count > 0)
            {
                WriteColor("\tExtra details:", ConsoleColor.DarkGray);
                foreach (DictionaryEntry de in ex.Data)
                {
                    WriteColor(
                        $"\tKey: '{de.Key.ToString()}'\t\tValue: '{de.Value}'",
                        ConsoleColor.DarkGray);
                }
            }

            WriteColor(ex.StackTrace, ConsoleColor.DarkGray);

            if (ex.InnerException != null) WriteException(ex, depth++);
        }

        private static void WriteTimestamp()
        {
            Console.Write($"{DateTime.Now:o}");
        }
    }
}
