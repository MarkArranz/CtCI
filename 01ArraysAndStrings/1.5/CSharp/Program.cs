using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var testArray = new string[] {
                "aabcccccaaa",
                "abcde",
                "abcccccccccccccccccccccccccccde"
            };
            foreach (var test in testArray)
            {
                Console.WriteLine(String.Join("", compress(test.ToCharArray())));
            }
        }

        static char[] compress(char[] str)
        {
            if (str.Length == 0) { return str; }

            // Calculate new string size
            var compressedStringLength = calculateCompressedLength(str);

            if (compressedStringLength > str.Length) { return str; }

            var compressedStr = new char[compressedStringLength];
            int w = 0;
            var prevChar = str[0];
            int counter = 1;
            char[] counterArray;

            for (int r = 1; r < str.Length; r++)
            {
                if (str[r] == prevChar)
                {
                    counter++;
                }
                else
                {
                    compressedStr[w] = prevChar;
                    w++;

                    counterArray = counter.ToString().ToCharArray();
                    for (var i = 0; i < counterArray.Length; i++)
                    {
                        compressedStr[w] = counterArray[i];
                        w++;
                    }

                    prevChar = str[r];
                    counter = 1;
                }
            }

            compressedStr[w] = prevChar;
            w++;

            counterArray = counter.ToString().ToCharArray();
            for (var i = 0; i < counterArray.Length; i++)
            {
                compressedStr[w] = counterArray[i];
                w++;
            }

            return compressedStr;
        }

        private static int calculateCompressedLength(char[] str)
        {
            var prevChar = str[0];
            int compressedLength = 0;
            int counter = 1;
            for (int r = 1; r < str.Length; r++)
            {
                if (str[r] == prevChar)
                {
                    counter++;
                }
                else
                {
                    prevChar = str[r];
                    compressedLength += 1 + counter.ToString().Length;
                    counter = 1;
                }
            }

            compressedLength += 1 + counter.ToString().Length;

            return compressedLength;
        }
    }
}
