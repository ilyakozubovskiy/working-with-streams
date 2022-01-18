using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

#pragma warning disable CA1062

namespace WorkingWithStreams
{
    public static class ReadingFromStream
    {
        public static string ReadAllStreamContent(StreamReader streamReader)
        {
            return streamReader.ReadToEnd();
        }

        public static string[] ReadLineByLine(StreamReader streamReader)
        {
            string line;
            List<string> strings = new List<string>();

            while ((line = streamReader.ReadLine()) != null)
            {
                strings.Add(line);
            }

            return strings.ToArray();
        }

        public static StringBuilder ReadOnlyLettersAndNumbers(StreamReader streamReader)
        {
            int digit;
            StringBuilder lettersAndNumbers = new StringBuilder();

            while ((digit = streamReader.Peek()) != -1 && char.IsLetterOrDigit((char)digit))
            {
                lettersAndNumbers.Append((char)digit);
                streamReader.Read();
            }

            return lettersAndNumbers;
        }

        public static char[][] ReadAsCharArrays(StreamReader streamReader, int arraySize)
        {
            List<char[]> arrays = new List<char[]>();

            while (streamReader.Peek() != -1)
            {
                char[] array = new char[arraySize];
                int number = streamReader.Read(array, 0, arraySize);

                Array.Resize(ref array, number);
                arrays.Add(array);
            }

            return arrays.ToArray();
        }
    }
}
