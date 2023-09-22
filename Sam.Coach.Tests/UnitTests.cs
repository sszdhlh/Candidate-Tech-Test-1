using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Sam.Coach.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(new [] {4,3,5,8,5,0,0,-3}, new [] {3,5,8})]
        [InlineData(new[] { 4, 6, -3, 3, 7, 9 }, new[] { -3, 3, 7, 9 })]
        [InlineData(new[] { 9, 6, 4, 5, 2, 0 }, new[] { 4, 5 })]
        [InlineData(new[] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 }, new[] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 })]
        [InlineData(new[] { 5, 4, 3, 2, 1, 0, -1, -2, -3, -4, -5 }, new[] { 5 })]
        [InlineData(new int[] { }, new int[] { })]
        // TODO: add more scenarios to ensure finder is working properly
        public async Task Can_Find(IEnumerable<int> data, IEnumerable<int> expected)
        {
            IEnumerable<int> actual = null;

            // TODO: create the finder instance and get the actual result
            var finder = new LongestRisingSequenceFinder();
            actual = await finder.Find(data);

            actual.Should().Equal(expected);
        }
    }
}
