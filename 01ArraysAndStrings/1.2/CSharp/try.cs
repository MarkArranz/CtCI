using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            var input = new char?[] { 'c', 'a', 'r', null };
            Console.WriteLine("Raw Input:");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();


            var result = reverse(input);
            reverseInPlace(input);

            Console.WriteLine("Reverse:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Reverse In Place:");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }

        static char?[] reverse(char?[] collection)
        {
            // A place to store the new collection
            var newCollection = new char?[collection.Length];

            // The length of the collection without 'null'
            var contentLength = collection.Length - 1;

            // Iterate over collection
            for (var i = 0; i < contentLength; i++)
            {
                var item = collection[i];

                // Put item in new collection at the last place - 1 due to index never being equal to length
                var reverseIndex = (contentLength - 1) - i;
                newCollection[reverseIndex] = item;
            }

            // Add null to the end of the new collection and return
            newCollection[contentLength] = null;
            return newCollection;
        }

        static void reverseInPlace(char?[] collection)
        {
            // start two index points; one at the begining and one at the end
            int start = 0;
            int end = collection.Length - 2;
            for (; start < end; start++, end--)
            {
                // c
                char? temp = collection[start];
                // rar
                collection[start] = collection[end];
                // rac
                collection[end] = temp;
            }
        }
    }
}