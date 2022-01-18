using System;
using System.Globalization;
using System.IO;
using System.Text;

#pragma warning disable CA1062 // Validate arguments of public methods

namespace WorkingWithStreams
{
    public static class WritingToStream
    {
        public static void ReadAndWriteIntegers(StreamReader streamReader, StreamWriter outputWriter)
        {
            int digit;
            while ((digit = streamReader.Read()) != -1)
            {
                outputWriter.Write(digit);
            }
        }

        public static void ReadAndWriteChars(StreamReader streamReader, StreamWriter outputWriter)
        {
            int symb;
            while ((symb = streamReader.Read()) != -1)
            {
                outputWriter.Write((char)symb);
            }

            outputWriter.Flush();
        }

        public static void TransformBytesToHex(StreamReader contentReader, StreamWriter outputWriter)
        {
            while (contentReader.Peek() != -1)
            {
                outputWriter.Write(contentReader.Read().ToString("X2", CultureInfo.InvariantCulture));
            }
        }

        public static void WriteLinesWithNumbers(StreamReader contentReader, StreamWriter outputWriter)
        {
            string digit;
            int lineNumber = 1;

            while ((digit = contentReader.ReadLine()) != null)
            {
                outputWriter.WriteLine(lineNumber.ToString("D3", CultureInfo.InvariantCulture) + " " + digit);
                lineNumber++;
            }

            outputWriter.Flush();
        }

        public static void RemoveWordsFromContentAndWrite(StreamReader contentReader, StreamReader wordsReader, StreamWriter outputWriter)
        {
            StringBuilder output = new StringBuilder();
            output.Append(contentReader.ReadToEnd());

            string word;
            while ((word = wordsReader.ReadLine()) != null)
            {
                output.Replace(word, string.Empty);
            }

            outputWriter.Write(output);
        }
    }
}
