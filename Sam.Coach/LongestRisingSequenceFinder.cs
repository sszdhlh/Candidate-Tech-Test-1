using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Sam.Coach.Tests")]

namespace Sam.Coach
{
    internal class LongestRisingSequenceFinder : ILongestRisingSequenceFinder
    {
        public Task<IEnumerable<int>> Find(IEnumerable<int> numbers) => Task.Run(() =>
        {
            IEnumerable<int> result = null;

            // TODO: return the longest raising sequence in the collection provided, i.e.
            // when numbers = [4, 6, -3, 3, 7, 9] then expected result is [-3, 3, 7, 9]
            // when numbers = [9, 6, 4, 5, 2, 0] then expected result is [4, 5]
            var numList = numbers.ToList();
            if (!numList.Any()) return Enumerable.Empty<int>();
            //The maximum length
            int max = 1;
            //end index
            int End = 0;

            //sequence length
            int current = 1;
            int EndIndex = 0;

            //Iterate through the list starting from the second element
            for (int i = 1; i < numList.Count; i++)
            {
                // Checks if the current element is greater than the previous element
                if (numList[i] > numList[i - 1])
                {
                    // increase the length
                    current++;
                    // increment end index
                    EndIndex = i;

                    //If the current length is greater than the maximum length, the maximum length and the current end index are assigned
                    if (current > max)
                    {
                        max = current;
                        End = EndIndex;
                    }
                }
                // interrupt, reset length
                else
                    current = 1;
            }

            var longestSequence = new List<int>();
            //Loop out data
            for (int i = End - max + 1; i <= End; i++)
            {
                longestSequence.Add(numList[i]);
            }
            result = longestSequence;

            return result;
        });
    }
}
