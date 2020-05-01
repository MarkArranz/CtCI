using System;

namespace Test {
	public static class Program {
		public void Main() {

			Console.WriteLine(input);
			var result = reverse(input);
			Console.WriteLine(result);
		}

		T reverse(T collection) {
			// A place to store the new collection
			var newColletion = new T[collection.Length];

			// The length of the collection without 'null'
			var contentLength = collection.Length - 1;

			// Iterate over collection
			for (var i = 0; i < contentLength; i++) {
				var item = collection[i];

				// Put item in new collection at the last place - 1 due to index never being equal to length
				var reverseIndex = (contentLength - 1) - i;
				newCollection[reverseIndex] = item;
			}

			// Add null to the end of the new collection and return
			newCollection[contentLength] = 'null'
			return newCollection
		}

		T reverseInPlace(T collection){
			// start two index points; one at the begining and one at the end
			int start = 0;
			int end = collection.Length - 2;
			for (; start < end; start++, end--) {
				// c
				char temp = collection[start];
				// rar
				collection[start] = collection[end];
				// rac
				collection[end] = temp;
			}
		}
	}
}