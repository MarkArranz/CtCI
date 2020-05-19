using System;

namespace Test {
    class Program {
        static void Main() {
            // var test = new char?[] { 'M', 'r', ' ', 'J', 'o', 'h', 'n', ' ', 'S', 'm', 'i', 't', 'h', null, null, null, null };
            var testString = "Twinkle Little Star";
            var test = testString.ToCharArray();
            Console.WriteLine(String.Join(null, test));

            var testNew = replaceSpaceNew(test);
            Console.WriteLine(String.Join(null, testNew));
        }

        static char?[] replaceSpaceNew(char[] arr) {
            var spaceCounter = 0;
            for (var i = 0; i < arr.Length; i++) {
                if (arr[i] == ' ') {
                    spaceCounter++;
                }
            }

            var newLength = arr.Length + (spaceCounter * 2);

            var newArr = new char?[newLength];
            // Maintain two indexes: one to read, one to write
            for (int w = 0, r = 0; w < newArr.Length; w++, r++) {
                if (arr[r] == ' ') {
                    newArr[w] = '%';
                    newArr[w+1] = '2';
                    newArr[w+2] = '0';
                    w += 2;
                } else {
                    newArr[w] = arr[r];
                }
            }
            return newArr;
        }

        static void replaceSpaceInPlace(char?[] arr) {
            // Assuming null is at the end.
            // Iterate through char[] until you hit null
            // i-1 is the index you need to set as the "read" index.
            var r = 0;
            for (var i = 0; i < arr.Length; i++) {
                if (arr[i] == null)
                {
                    r = i - 1;
                    break;
                }
            }

            // Maintain two indexes: one to read, one to write
            for (var w = arr.Length - 1; w > r; w--, r--) {
                if (arr[r] == ' ') {
                    arr[w] = '0';
                    arr[w-1] = '2';
                    arr[w-2] = '%';
                    w -= 2;
                } else {
                    arr[w] = arr[r];
                }
            }
        }
    }
}