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

        private static void WriteTimestamp()
        {
            Console.Write($"{DateTime.Now:o}");
        }
    }
}
