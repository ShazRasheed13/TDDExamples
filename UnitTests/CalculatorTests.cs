using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples;

namespace UnitTests
{
    public class CalculatorTests
    {
        private Calculator Calculator = new();
        [Fact]
        public void ReturnsZeroForEmptyString()
        {
            var result = Calculator.Add("");
            Assert.Equal(0, result);
        }

        [Fact]
        public void ReturnsNumberForSingleNumber()
        {
            var result = Calculator.Add("5");
            Assert.Equal(5, result);
        }

        [Fact]
        public void SumsTwoNumbersSeparatedByComma()
        {
            var result = Calculator.Add("3,7");
            Assert.Equal(10, result);
        }

        [Fact]
        public void SumsMultipleNumbersSeparatedByComma()
        {
            var result = Calculator.Add("1,2,3,4,5");
            Assert.Equal(15, result);
        }

        [Fact]
        public void ThrowsExceptionForInvalidInput()
        {
            Assert.Throws<FormatException>(() => Calculator.Add("1,,2"));
            Assert.Throws<FormatException>(() => Calculator.Add("abcd"));
        }
    }
}
