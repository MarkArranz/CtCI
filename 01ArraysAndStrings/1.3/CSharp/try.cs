using System;

namespace Test {
    class Program {
        static void Main() {
            var testTrue = new string [] {"abcdef", "fedcba"};
            var testFalse = new string [] { "abcdef", "ABCDEF"};
            var testWhitespaceTrue = new string [] { "abc def", "abcdef " };
            var testWhitespaceFalse = new string [] { "abcdef  ", "abcdef " };

            var tests = new string[][] {
                testTrue,
                testFalse,
                testWhitespaceTrue,
                testWhitespaceFalse
            };

            foreach (var test in tests) {
                var testA = test[0];
                var testB = test[1];
                Console.WriteLine($"{testA} and {testB}: {isPermutation(testA, testB)}");
            }
        }

        static bool isPermutation(string strA, string strB) {
            // If the strings are not the same length...
            if (strA.Length != strB.Length) {
                // ... automatically return false.
                return false;
            }

            // NOTE A: Ineffecient.
            // // Sort both strings.
            // var sortedStrA = sortString(strA);
            // var sortedStrB = sortString(strB);

            // // If the strings are equal...
            // if (sortedStrA == sortedStrB) {
            //     // ...they are permutations of each other.
            //     return true;
            // }

            // // ... otherwise they are not.
            // return false;

            // NOTE A: Better implmentation.
            return sortString(strA) == sortString(strB);
        }

        static string sortString(string str) {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            return String.Join("", arr);
        }
    }
}
