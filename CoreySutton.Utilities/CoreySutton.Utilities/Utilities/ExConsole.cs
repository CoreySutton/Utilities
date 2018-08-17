using System;

namespace CoreySutton.Utilities
{
    /// <summary>
    /// Wrapper for SystemConsole
    /// </summary>
    public static class ExConsole
    {
        private static ConsoleColor _defaultColor = ConsoleColor.Gray;

        public static void Write(string message)
        {
            Console.Write(message);
        }

        public static void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public static void WriteLineToRight(string value)
        {
            if (string.IsNullOrEmpty(value)) return;

            int valueLength = value.Length;

            Console.CursorLeft = Console.BufferWidth - valueLength - 1;
            Console.WriteLine(value);
        }

        public static void WriteColor(string value, ConsoleColor color)
        {
            if (string.IsNullOrEmpty(value)) return;

            Console.ForegroundColor = color;
            Console.Write(value);
            Console.ForegroundColor = _defaultColor;
        }

        public static void WriteLineColor(string value, ConsoleColor color)
        {
            if (string.IsNullOrEmpty(value)) return;

            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ForegroundColor = _defaultColor;
        }
    }
}
