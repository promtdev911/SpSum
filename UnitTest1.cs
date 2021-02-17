using System;
using Xunit;
using SpSum;

namespace Sample.Unit.Tests
{
    public class SumAB {
        [Theory]
        [InlineData(3, 4, 7)]
        [InlineData(9, 4, 20)]
        [InlineData(10, 11, 21)]
        [InlineData(2, 8, 20)]
        [InlineData(17, 2, 20)]
        public void TwoInputNumbersProvideResult(int a, int b, int expected) {
           // Arrange
           var sumObj = new SumTwoNums();
           
           var res = sumObj.spSum(a, b);

           // Assert
           Assert.Equal(expected, res);
        }
    }
}
