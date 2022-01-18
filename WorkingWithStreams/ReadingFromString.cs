using System;
using System.IO;

#pragma warning disable CA1062

namespace WorkingWithStreams
{
    public static class ReadingFromString
    {
        public static string ReadAllStreamContent(StringReader stringReader)
        {
            return stringReader.ReadToEnd();
        }

        public static string ReadCurrentLine(StringReader stringReader)
        {
            return stringReader.ReadLine();
        }

        public static bool ReadNextCharacter(StringReader stringReader, out char currentChar)
        {
            int nextSymb = stringReader.Read();
            if (nextSymb == -1)
            {
                currentChar = ' ';
                return false;
            }

            currentChar = Convert.ToChar(nextSymb);
            return true;
        }

        public static bool PeekNextCharacter(StringReader stringReader, out char currentChar)
        {
            if (stringReader.Peek() == -1)
            {
                currentChar = ' ';
                return false;
            }

            currentChar = Convert.ToChar(stringReader.Peek());
            return true;
        }

        public static char[] ReadCharactersToBuffer(StringReader stringReader, int count)
        {
            char[] buffer = new char[count];
            stringReader.Read(buffer, 0, count);
            return buffer;
        }
    }
}
